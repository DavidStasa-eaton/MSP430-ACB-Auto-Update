using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;

using AcronameCommonControls;
using StasaLibrary;

namespace MSP430_UpdaterV2._0
{
    public delegate void AsyncLog(DisplayText dt);

    /*Created by: Alyssa Brown 
     *Date: June 2021
     *This Program is used to update the MSP430 Microprocessors on the ACB boards.
     *There are two ways to program the boards, with one programmer (manual switch) or with 
     *two programmers (automatic switch). Both methods utilize TI's MSP Flasher command line 
     *program to update the MCs. This is found within the program folder. The two programmer 
     *version requires an Acroname USB Hub and utilizes the AcroLibrary to function. 
     *
     *NOTE: This program only works with the 2x4 USB Hub Acroname.
     */
    public partial class MainForm : Form
    {
        AcronameHub acHub;
        Stopwatch sw = new Stopwatch();
        string postMCstring = " -v -z [VCC]"; // includes the verify step. User can disable and this string will change.

        //File names for Firmware
        public string MCU1file = "ETU_MCU1";
        public string MCU2Flashfile = "ETU_MCU2_Flash";
        public string MCU2file = "ETU_MCU2";

        public AsyncLog asyncLogDel;


        public string outFile;
        public MainForm()
        {
            InitializeComponent();
            //MCU1 Swap Buttons

            asyncLogDel = logRTB.AppendText;
            AcronameHub.DisplayDel = logRTB.AppendText;
            acHub = new AcronameHub();
            acroControl.acHub = acHub;
            
        }

        public void HandleEndOfProcess(bool wasSuccessful, Button activeButton, string bText, EventHandler e)
        {

            EnableButtons(activeButton, bText, e);

            sw.Stop();
            if (wasSuccessful)
                logRTB.AppendText(new DisplayText($"Updating completed succesfully: Process Time: {sw.Elapsed.TotalSeconds}", true, Color.Green));
            else
                logRTB.AppendText(new DisplayText($"Update process failed: Process Time: {sw.Elapsed.TotalSeconds}", true, Color.Red));
        }

        #region Update Functions
        public async Task<int> Updater(string argString, int timeoutSeconds = 300)
        {
            /*Calls TI's Flasher program in order to program MC's. Command Line Process.*/

            bool doRedirectOutput = redirectOutputCheckbox.Checked;
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "MSP430Flasher.exe",
                    CreateNoWindow = doRedirectOutput,
                    UseShellExecute = !doRedirectOutput,
                    RedirectStandardError = doRedirectOutput,
                    RedirectStandardInput = doRedirectOutput,
                    RedirectStandardOutput = doRedirectOutput,
                    WindowStyle = ProcessWindowStyle.Normal,
                    Arguments = argString,
                }
            };
            logRTB?.Invoke(asyncLogDel, new DisplayText($"Executing: {argString}", Color.Blue));

            process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data?.Length > 0)
                {
                    logRTB?.Invoke(asyncLogDel, new DisplayText(e.Data, Color.LightSalmon));
                }
            };

            process.OutputDataReceived += (s, e) =>
            {
                if (e.Data?.Length > 0)
                {
                    logRTB?.Invoke(asyncLogDel, new DisplayText(e.Data, Color.SteelBlue));
                    //Console.WriteLine(e.Data);
                }
            };


            process.Start();
            if (doRedirectOutput)
            {
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }
            

            while (!process.HasExited && (DateTime.Now - process.StartTime).TotalSeconds < timeoutSeconds)
            {
                
                await Task.Delay(100);
            }

            string statusString = "";

            int lastChr = 0;
            
            bool succesfulExit = process.HasExited;
            int exitCode = 255;
            if (succesfulExit)
            {
                exitCode = process.ExitCode;
                if (exitCode == 0)
                    statusString = "Succesfully Executed: ";
                else
                    statusString = "Failed to execute: ";
            }
            else
            {
                logRTB?.Invoke(asyncLogDel, new DisplayText("Process timeout. Ensure correct MSP is selected", Color.Salmon));
            }
            process.Close();
            process.Dispose();
            logRTB?.Invoke(asyncLogDel, new DisplayText($"{statusString}: {argString}\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n", Color.BlueViolet));
            return exitCode;
        }

        public async Task<bool> PreloadMCU1()
        {
            int return1;
            string argString = "-w " + "ETU_MCU1_preload_project.txt" + postMCstring;
            return1 = await Updater(argString); //program MCU1
            //return1 = Updater(mcu1Textbox.Text); //program MCU1

            if (return1 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to program MCU1", Color.Red));
                return false; //                                                 Will stop here if MCU1 Flash fails
            }

            logRTB.AppendText(new DisplayText("MCU1 Programmed"));

            return true;
        }

        public async Task<bool> SetProcessorToMSP430F67771() // MCU1
        {
            int returnSetName;

            // Will set the process to the 677771 - Typically not needed but makes process more reliable. 
            string setNameString = $"-n {msp1_Box.Text}";
            returnSetName = await Updater(setNameString, 10); //program MCU1
            //return1 = Updater(mcu1Textbox.Text); //program MCU1

            if (returnSetName != 0)
            {
                logRTB.AppendText(new DisplayText($"Failed to set processor to {msp1_Box.Text}", Color.Red));
                return false; //                                                 Will stop here if MCU1 Flash fails
            }

            return true;
        }

        public async Task<bool> SetProcessorToMSP430F5659() // MCU2
        {
            int returnSetName;


            // Will set the process to the 677771 - Typically not needed but makes process more reliable. 
            string setNameString = $"-n {msp2_Box.Text}";
            returnSetName = await Updater(setNameString, 10); //program MCU1
            //return1 = Updater(mcu1Textbox.Text); //program MCU1

            if (returnSetName != 0)
            {
                logRTB.AppendText(new DisplayText($"Failed to set processor to {msp2_Box.Text}", Color.Red));
                return false; //                                                 Will stop here if MCU1 Flash fails
            }

            return true;
        }

        public async Task<bool> UpdateMCU1()
        {
            int return1;

            bool processSet = await SetProcessorToMSP430F67771();

            if (!processSet)
                return false;
            
            string argString = "-w " + mcu1Textbox.Text + postMCstring;
            return1 = await Updater(argString); //program MCU1
            //return1 = Updater(mcu1Textbox.Text); //program MCU1

            if (return1 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to program MCU1", Color.Red));
                return false; //                                                 Will stop here if MCU1 Flash fails
            }

            logRTB.AppendText(new DisplayText("MCU1 Programmed"));

            return true;
        }

        public async Task<bool> UpdateMCU2Flash()
        {
            
            logRTB.AppendText(new DisplayText("Flashing MCU2..."));
            string argString = "-w " + flashMcu2FileTextbox.Text + postMCstring;
            int return2 = await Updater(argString); //Flash MCU2
            //int return2 = Updater(flashMcu2FileTextbox.Text); //Flash MCU2

            if (return2 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to program MCU2", Color.Red));
                return false; //                                                 Will stop here if MCU2 Flash fails
            }

            if (threePointZeroRadioButton.Checked && timerRadio.Checked)
            {
                int count = 0;
                progressBar1.Value = 25;
                logRTB.AppendText(new DisplayText("Waiting for MCU2 to dynamically program..."));
                DateTime startTime = DateTime.Now;
                double totalTime = 25;
                try
                {
                    totalTime = double.Parse(flashWaitTimeEntry.Text);
                }
                catch
                {
                    logRTB.AppendText(new DisplayText($"Failed to convert \"{flashWaitTimeEntry.Text}\" to a number. Using 25s instead", Color.Red));
                }

                int waitTime = (int)Math.Ceiling((totalTime/52)*1000);

                while ((DateTime.Now - startTime).TotalSeconds <= totalTime)
                {
                    await Task.Delay(waitTime);
                    count += 1;
                    progressBar1.Increment(1);
                }
            }
            else 
            {
                if (twoPointZeroRadioButton.Checked)
                {
                    MessageBox.Show("Press button on ETU and the press ok.");
                    await Task.Delay(1000);
                }
                    
                MessageBox.Show("Wait for ETU to finish dynmaically programming then press ok.");
                progressBar1.Increment(52);
                /*
                int count = 0;
                progressBar1.Value = 25;
                while (count <= 25)
                {
                    await Task.Delay(1000);
                    count += 1;
                    progressBar1.Increment(2);
                }
                */
            }
            logRTB.AppendText(new DisplayText("MCU2 Dynamic Programming Completed"));
            return true;
        }

        public async Task<bool> UpdateMCU2()
        {
            string argString = "-w " + mcu2FileTextbox.Text + postMCstring;
            int return3 = await Updater(argString); //Program MCU2
            //int return3 = Updater(mcu2FileTextbox.Text); //Program MCU2

            if (return3 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to program MCU2", Color.Red));
                return false; //                                                 Will stop here if MCU2 Flash fails
            }

            logRTB.AppendText(new DisplayText("Done programming MCU2"));

            return true;
        }
        #endregion

        #region Programming Button Clicks
        public string DisableButtons(Button activeButton, EventHandler e)
        {
            string rString = activeButton.Text;
            List<Button> buttons = new List<Button>() {
                twoProgramerStartButton, OneWayUpdate, programMCU1Button, flashMCU2Button, programMCU2Button,
                eraseMCU1Button, eraseMCU2Button, eraseBothMcusButton, eraseConnectedMCUButton, preloadMCU1Button
            };
            buttons.Remove(activeButton);

            foreach (Button b in buttons)
            {
                b.Enabled = false;
            }

            activeButton.Click -= e;
            activeButton.Text = "";
            activeButton.Image = Properties.Resources.loadingGif;


            return rString;
        }

        public string EnableButtons(Button activeButton, string bText, EventHandler e)
        {
            string rString = activeButton.Text;
            List<Button> buttons = new List<Button>() {
                twoProgramerStartButton, OneWayUpdate, programMCU1Button, flashMCU2Button, programMCU2Button,
                eraseMCU1Button, eraseMCU2Button, eraseBothMcusButton, eraseConnectedMCUButton, preloadMCU1Button
            };
            buttons.Remove(activeButton);

            foreach (Button b in buttons)
            {
                b.Enabled = true;
            }

            activeButton.Click += e;
            activeButton.Text = bText;
            activeButton.Image = null;


            return rString;
        }

        private async void majorRevUpdateButton_Click(object sender, EventArgs e)
        {
            bool stepSuccesful;


            logRTB.Clear();

            EventHandler clickEvent = majorRevUpdateButton_Click;
            string bText = DisableButtons(majorRevUpdateButton, clickEvent);

            //await acroControl.RefreshConnection();

            sw.Reset();
            sw.Start();
            /*Two Programmer Auto process.*/
            logRTB.AppendText(new DisplayText("Starting update with two programmers", true));
            progressBar1.Value = 0;


            ////                                     Acroname Check
            Acroname.BrainStem2CLI.aErr err;
            if (!acHub.isConnected)
            {
                logRTB.AppendText(new DisplayText("Connection not establsihed to Acroname. Process cannot proceed", false, Color.Red));
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;  //                                                 Will stop here if no acroname
            }



            ////                                     Preload 
            await PowerAllDown();
            await EnablePorts(1, 0);
            await Task.Delay(3000);
            progressBar1.Value = 1;
            
            stepSuccesful = await SetProcessorToMSP430F67771();

            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }
            progressBar1.Value = 5;

            stepSuccesful = await PreloadMCU1();
            progressBar1.Value = 10;
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }

            //await acroControl.RefreshConnection();

            await DisablePorts(1, 0);
            await EnablePorts(2, 0);
            await Task.Delay(3000);

            ////                                      Flash MCU2
            ///
            stepSuccesful = await SetProcessorToMSP430F5659();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }
            progressBar1.Value = 15;

            stepSuccesful = await UpdateMCU2Flash();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }
            await Task.Delay(1000);

            logRTB.AppendText(new DisplayText("Done flashing MCU2"));
            ////                                      Program MCU2
            stepSuccesful = await UpdateMCU2();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }
            progressBar1.Increment(15);


            ////                                     Program MCU1
            await DisablePorts(2, 0);
            await EnablePorts(1, 0);
            await Task.Delay(3000);
            stepSuccesful = await UpdateMCU1();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, majorRevUpdateButton, bText, clickEvent);
                return;
            }

            progressBar1.Value = progressBar1.Maximum;
            HandleEndOfProcess(true, majorRevUpdateButton, bText, clickEvent);
        }
        public async void TwoWayUpdate_Click(object sender, EventArgs e)
        {
            bool stepSuccesful;
            

            logRTB.Clear();
            
            EventHandler clickEvent = TwoWayUpdate_Click;
            string bText = DisableButtons(twoProgramerStartButton, clickEvent);

            //await acroControl.RefreshConnection();

            sw.Reset();
            sw.Start();
            /*Two Programmer Auto process.*/
            logRTB.AppendText(new DisplayText("Starting update with two programmers", true));
            progressBar1.Value = 0;


            ////                                     Acroname Check
            Acroname.BrainStem2CLI.aErr err; 
            if (!acHub.isConnected)
            {
                logRTB.AppendText(new DisplayText("Connection not establsihed to Acroname. Process cannot proceed", false, Color.Red));
                HandleEndOfProcess(false, twoProgramerStartButton, bText, clickEvent);
                return;  //                                                 Will stop here if no acroname
            }




            ////                                     Program MCU1
            await PowerAllDown();
            await EnablePorts(1, 0);
            await Task.Delay(3000);
            progressBar1.Value = 10;
            stepSuccesful = await UpdateMCU1(); 
            progressBar1.Value = 20;
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, twoProgramerStartButton, bText, clickEvent);
                return;
            }

            await acroControl.RefreshConnection();

            await DisablePorts(1, 0);
            await EnablePorts(2, 0);
            await Task.Delay(3000);


            ////                                      Flash MCU2
            ///
            await SetProcessorToMSP430F5659();

            stepSuccesful = await UpdateMCU2Flash();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, twoProgramerStartButton, bText, clickEvent);
                return;
            }
            //await acroControl.RefreshConnection();

            //await DisablePorts(0);
            //await EnablePorts(0);
            await Task.Delay(3000);

            logRTB.AppendText(new DisplayText("Done flashing MCU2"));
            
            

            ////                                      Program MCU2
            stepSuccesful = await UpdateMCU2();
            if (!stepSuccesful)
            {
                HandleEndOfProcess(false, twoProgramerStartButton, bText, clickEvent);
                return;
            }
            try
            {
                await acroControl.RefreshConnection();
            }
            catch (Exception exce)
            {
                System.Diagnostics.Debug.Write($"MspUpdater_TwoWay_FinalConnectionRefresh: {exce}");
            }


            //await PowerAllDown();
            //await EnablePorts(0);
            //await Task.Delay(2000);


            progressBar1.Value = progressBar1.Maximum;
            HandleEndOfProcess(true, twoProgramerStartButton, bText, clickEvent);
        }

        private async void programMCU1Button_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = programMCU1Button_Click;
            string bText = DisableButtons(programMCU1Button, clickEvent);

            sw.Restart();
            if (acHub.isConnected && autoToggleForSingleStepCheckBox.Checked)
            {
                await acroControl.RefreshConnection();
                await CheckAndDisablePorts(2);
                await CheckAndEnablePorts(1, 0);
                await Task.Delay(3000);
            }

            ////                                     Program MCU1

            bool success = await UpdateMCU1();

            HandleEndOfProcess(success, programMCU1Button, bText, clickEvent);
        }

        private async void flashMCU2Button_Click(object sender, EventArgs e)
        {
            sw.Restart();

            EventHandler clickEvent = flashMCU2Button_Click;
            string bText = DisableButtons(flashMCU2Button, clickEvent);

            logRTB.Clear();
            if (acHub.isConnected && autoToggleForSingleStepCheckBox.Checked)
            {
                await acroControl.RefreshConnection();
                await CheckAndDisablePorts(1);
                await CheckAndEnablePorts(2, 0);
                await Task.Delay(3000);
            }

            bool prep = await SetProcessorToMSP430F5659();
            bool success = await UpdateMCU2Flash();

            HandleEndOfProcess(success, flashMCU2Button, bText, clickEvent);
        }

        private async void programMCU2Button_Click(object sender, EventArgs e)
        {
            sw.Restart();

            logRTB.Clear();
            EventHandler clickEvent = programMCU2Button_Click;
            string bText = DisableButtons(programMCU2Button, clickEvent);

            if (acHub.isConnected && autoToggleForSingleStepCheckBox.Checked)
            {
                await acroControl.RefreshConnection();
                await CheckAndDisablePorts(1);
                await CheckAndEnablePorts(2, 0);
                await Task.Delay(3000);
            }

            bool prep = await SetProcessorToMSP430F5659();
            bool success = await UpdateMCU2();

            HandleEndOfProcess(success, programMCU2Button, bText, clickEvent);
        }
        #endregion

        #region IO
        public string GetFile(string MCU)
        {
            /*Gets Individual Files from each button click*/
            string File;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt", //Only works on .txt files
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File = openFileDialog1.FileName;
                return File;
            }
            else
            {
                return " ";
            }
        }

        public void GetFolder()
        {
            /*Gets the firmware folder and automatically fills the file names
             based purely on the MCU1, MCU2, and Flash tags in filenames. Other file names
            will not work.*/
            string fullName;
            OpenFileDialog fDiag = new OpenFileDialog();

            fDiag.ValidateNames = false;
            fDiag.CheckFileExists = false;
            fDiag.CheckPathExists = true;

            fDiag.FileName = "Select Folder";

            if (fDiag.ShowDialog() == DialogResult.OK)
            {
                outFile = System.IO.Path.GetDirectoryName(fDiag.FileName);


                DirectoryInfo dir = new DirectoryInfo(outFile);
                //FileInfo[] files = dir.GetFiles("ETU*", SearchOption.TopDirectoryOnly);
                var files = dir.EnumerateFiles("*", SearchOption.TopDirectoryOnly).
                    Where(s => s.FullName.Contains("ETU") || s.FullName.Contains("MCU"));

                string MCU1file;
                string MCU2flashfile;
                string MCU2file;

                mcu1Textbox.Text = " ";
                flashMcu2FileTextbox.Text = " ";
                mcu2FileTextbox.Text = " ";

                foreach (var item in files)
                {
                    if (item.FullName.Contains("MCU1"))
                    {
                        if (!item.FullName.ToUpper().Contains("PRELOAD"))
                        {
                            MCU1file = item.FullName;
                            mcu1Textbox.Text = MCU1file;
                        }
                        
                    }
                    else if (item.FullName.Contains("MCU2"))
                    {
                        if (item.FullName.Contains("Flash"))
                        {
                            MCU2flashfile = item.FullName;
                            flashMcu2FileTextbox.Text = MCU2flashfile;
                        }
                        else
                        {
                            MCU2file = item.FullName;
                            mcu2FileTextbox.Text = MCU2file;
                        }

                    }
                }
            }

        }
        //Async tasks for UI updating


        private void MCU1_Click(object sender, EventArgs e)
        {
            mcu1Textbox.Text = GetFile(MCU1file);
        }

        private void MCU2_Flash_Click(object sender, EventArgs e)
        {
            flashMcu2FileTextbox.Text = GetFile(MCU2Flashfile);
        }

        private void MCU2_Click(object sender, EventArgs e)
        {
            mcu2FileTextbox.Text = GetFile(MCU2file);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FilenamesToSave savefilenames = new FilenamesToSave()
            {
                MCU1file = mcu1Textbox.Text,
                MCU2Flashfile = flashMcu2FileTextbox.Text,
                MCU2file = mcu2FileTextbox.Text,
                IsV3 = threePointZeroRadioButton.Checked,
                DoTogglePortsForSingleSteps = autoToggleForSingleStepCheckBox.Checked,
                procMcu1 = msp1_Box.Text,
                procMcu2 = msp2_Box.Text,
                FlashIsAutoWait = timerRadio.Checked,
                FlashWaitTime = flashWaitTimeEntry.Text
            };

            string jString = JsonConvert.SerializeObject(savefilenames);
            System.IO.File.WriteAllText("RestoreFile.txt", jString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("RestoreFile.txt"))
                return;

            FilenamesToSave restorefilenames = new FilenamesToSave();
            using (System.IO.StreamReader r = new System.IO.StreamReader("RestoreFile.txt"))
            {
                string fileText = r.ReadToEnd();
                var restoreDict = JObject.Parse(fileText); // JObject is in the Newtonsoft.Json.Linq library

                restorefilenames = restoreDict.ToObject<FilenamesToSave>();
            }

            mcu1Textbox.Text = restorefilenames.MCU1file;
            flashMcu2FileTextbox.Text = restorefilenames.MCU2Flashfile;
            mcu2FileTextbox.Text = restorefilenames.MCU2file;
            autoToggleForSingleStepCheckBox.Checked = restorefilenames.DoTogglePortsForSingleSteps;

            msp1_Box.SelectedItem = restorefilenames.procMcu1;
            msp2_Box.SelectedItem = restorefilenames.procMcu2;

            if (restorefilenames.IsV3)
                threePointZeroRadioButton.Checked = true;
            else
                twoPointZeroRadioButton.Checked = true;

            if (restorefilenames.mcu1List != null)
                UpdateComboWithList(msp1_Box, restorefilenames.mcu1List);

            if (restorefilenames.mcu2List != null)
                UpdateComboWithList(msp2_Box, restorefilenames.mcu2List);

            if (restorefilenames.FlashIsAutoWait)
                timerRadio.Checked = true;
            else
                waitForUserRadio.Checked = true;

            if (restorefilenames.FlashWaitTime.Length > 0)
                flashWaitTimeEntry.Text = restorefilenames.FlashWaitTime;

            acroControl.Connect();
        }

        private void Firmwarefolder_Click(object sender, EventArgs e)
        {
            GetFolder(); //calls get folder method
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            string fileName = @"Help.txt"; var process = new System.Diagnostics.Process(); //Opens Help file

            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };

            process.Start();
        }

        private void hardwareSetupButton_Click(object sender, EventArgs e)
        {
            HardwareSetupForm hsf = new HardwareSetupForm();
            hsf.Show();
        }
        #endregion

        #region Acronmae Functions
        private async Task PowerAllDown()
        {
            logRTB.AppendText(new DisplayText("Powering down all ports..."));
            await DisablePorts(2, 1, 0);
            await Task.Delay(1000);
            logRTB.AppendText(new DisplayText("Done powering down."));
        }

        private async Task CheckAndEnablePorts(params byte[] ports)
        {

            foreach (byte i in ports)
            {
                if (!acHub.CheckIfPortIsEnabled(i))
                {
                    await Task.Delay(100);
                    await EnablePorts(i);
                }
                    
            }
        }

        private async Task CheckAndDisablePorts(params byte[] ports)
        {

            foreach (byte i in ports)
            {
                if (acHub.CheckIfPortIsEnabled(i))
                {
                    await Task.Delay(100);
                    await DisablePorts(i);
                }
                    
            }
        }

        private async Task EnablePorts(params byte[] ports)
        {
            if (!acHub.isConnected)
            {
                logRTB.AppendText(new DisplayText("No Acroname Connection.", true, Color.Red));
            }

            bool tryAgain = true; // will be set to false if 0xFF is in array. Indcates it already retried once.
            bool s = false;
            foreach (byte i in ports)
            {
                if (i == 0xFF)
                {
                    tryAgain = false;
                    continue;
                }
                //logRTB.AppendText(new DisplayText($"Enabling port {i}"));

                s = acHub.EnablePort(i);
                if (!s)
                {
                    await acroControl.RefreshConnection();
                    break;
                }
                await Task.Delay(500);
            }


            if (!s & tryAgain)
            {
                List<byte> lPorts = new List<byte>();
                foreach (byte i in ports)
                {
                    lPorts.Add(i);
                }
                lPorts.Add(0xFF);
                await EnablePorts(lPorts.ToArray()); // try again :: potential infinite loop
            }
            else
            {
                await Task.Delay(2000);
                logRTB.AppendText(new DisplayText("Done enabling ports."));
            }

            
        }

        private async Task DisablePorts(params byte[] ports)
        {
            if (!acHub.isConnected)
            {
                logRTB.AppendText(new DisplayText("No Acroname Connection.", true, Color.Red));
            }

            bool tryAgain = true; // will be set to false if 0xFF is in array. Indcates it already retried once.
            bool s = false;
            foreach (byte i in ports)
            {
                if (i == 0xFF)
                {
                    tryAgain = false;
                    continue;
                }
                //logRTB.AppendText(new DisplayText($"Enabling port {i}"));

                s = acHub.DisablePort(i);
                if (!s)
                {
                    await acroControl.RefreshConnection();
                    break;
                }
                await Task.Delay(250);
            }

            if (!s & tryAgain)
            {
                List<byte> lPorts = new List<byte>();
                foreach (byte i in ports)
                {
                    lPorts.Add(i);
                }
                lPorts.Add(0xFF);
                await DisablePorts(lPorts.ToArray()); // try again :: potential infinite loop
            }
            else
            {
                await Task.Delay(2000);
                logRTB.AppendText(new DisplayText("Done disabling ports."));
            }
        }

        private void powerMCU1ConfigButton_Click(object sender, EventArgs e)
        {
            acHub.DisablePort(2);

            acHub.EnablePort(0);
            acHub.EnablePort(1);
        }

        private void powerMCU2ConfigButton_Click(object sender, EventArgs e)
        {
            acHub.DisablePort(1);

            acHub.EnablePort(0);
            acHub.EnablePort(2);
        }
        #endregion

        public void OneWayUpdate_Click(object sender, EventArgs e)
        {

        }

        public class FilenamesToSave
        {
            public string MCU1file { get; set; }
            public string MCU2Flashfile { get; set; }
            public string MCU2file { get; set; }
            public bool IsV3 { get; set; }
            public bool DoTogglePortsForSingleSteps { get; set; }
            public string procMcu1 { get; set; } = "MSP430F67771";
            public string procMcu2 { get; set; } = "MSP430F5659";
            public List<string> mcu1List { get; set; }
            public List<string> mcu2List { get; set; }
            public bool FlashIsAutoWait { get; set; } = true;
            public string FlashWaitTime { get; set; } = "";
        }

        private async void powerCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logRTB.AppendText(new DisplayText("Power cycling port 0", true));
            acHub.DisablePort(0);
            await Task.Delay(1000);
            acHub.EnablePort(0);
            await Task.Delay(1000);

            logRTB.AppendText(new DisplayText("Done power cycling port 0", false));
        }

        private async void refreshConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logRTB.AppendText(new DisplayText("Disconnecting and Reconnecting to Acroname", true));
            await acroControl.RefreshConnection();
        }

        private void verfiyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (verfiyCheckbox.Checked)
                postMCstring = " -v -z [VCC]";
            else
                postMCstring = " -z [VCC]";
        }

        private async Task<bool> EraseMCU1()
        {
            await DisablePorts(2);
            await EnablePorts(0, 1);

            logRTB.AppendText(new DisplayText("Attempting to erase MCU1", true));
            string argString = "-e ERASE_ALL";
            int return3 = await Updater(argString); //Program MCU2
            //int return3 = Updater(mcu2FileTextbox.Text); //Program MCU2

            if (return3 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to erase MCU1", Color.Red));
                return false;
            }

            logRTB.AppendText(new DisplayText("Done erasing MCU1"));
            return true;
        }

        private async Task<bool> EraseMCU2()
        {
            await DisablePorts(1);
            await EnablePorts(0, 2);

            logRTB.AppendText(new DisplayText("Attempting to erase MCU2", true));
            string argString = "-e ERASE_ALL";
            int return3 = await Updater(argString); //Program MCU2
            //int return3 = Updater(mcu2FileTextbox.Text); //Program MCU2

            if (return3 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to erase MCU2", Color.Red));
                return false;
            }

            logRTB.AppendText(new DisplayText("Done erasing MCU2"));
            return true;
        }

        private async void eraseMCU1Button_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = eraseMCU1Button_Click;
            string bText = DisableButtons((Button)sender, clickEvent);
            bool s = await EraseMCU1();
            HandleEndOfProcess(s, (Button)sender, bText, clickEvent);
        }

        private async void eraseMCU2Button_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = eraseMCU2Button_Click;
            string bText = DisableButtons((Button)sender, clickEvent);
            bool s = await EraseMCU2();
            HandleEndOfProcess(s, (Button)sender, bText, clickEvent);
        }

        private async void eraseConnectedMCUButton_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = eraseConnectedMCUButton_Click;
            string bText = DisableButtons((Button)sender, clickEvent);

            logRTB.AppendText(new DisplayText("Attempting to erase connected MCU", true));
            string argString = "-e ERASE_ALL";
            int return3 = await Updater(argString); //Program MCU2
            //int return3 = Updater(mcu2FileTextbox.Text); //Program MCU2

            bool s = true;
            if (return3 != 0)
            {
                logRTB.AppendText(new DisplayText("Failed to erase connected MCU", Color.Red));
                s = false;
            }

            logRTB.AppendText(new DisplayText("Done erasing connected MCU"));

            HandleEndOfProcess(s, (Button)sender, bText, clickEvent);
        }

        private async void eraseBothMcusButton_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = eraseBothMcusButton_Click;
            string bText = DisableButtons((Button)sender, clickEvent);

            bool s1 = await EraseMCU2();
            bool s2 = await EraseMCU1();

            HandleEndOfProcess(s1 && s2, (Button)sender, bText, clickEvent);
        }

        private async void preloadMCU1Button_Click(object sender, EventArgs e)
        {
            logRTB.Clear();
            EventHandler clickEvent = preloadMCU1Button_Click;
            string bText = DisableButtons((Button)sender, clickEvent);

            await DisablePorts(2);
            await EnablePorts(0, 1);

            bool s = await PreloadMCU1();

            HandleEndOfProcess(s, (Button)sender, bText, clickEvent);
        }

        private List<string> GetListFromComboBox(ComboBox cb)
        {
            List<string> rList = new List<string>();
            for (int i = 0; i < cb.Items.Count; i++)
            {
                rList.Add(cb.GetItemText(cb.Items[i]));
            }
            return rList;
        }

        private void UpdateComboWithList(ComboBox cb, List<string> valuesToAdd)
        {
            cb.Items.Clear();

            foreach (string s in valuesToAdd)
            {
                cb.Items.Add(s);
            }
        }

        private void addCurrentMspToDropDownButton_Click(object sender, EventArgs e)
        {
            List<string> msp1List = GetListFromComboBox(msp1_Box);
            List<string> msp2List = GetListFromComboBox(msp2_Box);

            if (msp1List.Contains(msp1_Box.Text))
                msp1List.Add(msp1_Box.Text);

            if (msp2List.Contains(msp2_Box.Text))
                msp2List.Add(msp2_Box.Text);

            UpdateComboWithList(msp1_Box, msp1List);
            UpdateComboWithList(msp2_Box, msp2List);
        }

        
    }
}
