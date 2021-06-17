using AcroLibrary;
using Acroname.BrainStem2CLI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP430_UpdaterV2._0
{
    public partial class Form1 : Form
    {
        AcronameHub stem = new AcronameHub();
        public Form1()
        {
            InitializeComponent();
            MCU2Swap.Visible = false;
            MCU2Prog.Visible = false;

        }
        public string MCU1file = "ETU_MCU1";
        public string MCU2Flashfile = "ETU_MCU2_Flash";
        public string MCU2file = "ETU_MCU2";
        private void MCU1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetFile(MCU1file);
        }

        private void MCU2_Flash_Click(object sender, EventArgs e)
        {
            textBox2.Text = GetFile(MCU2Flashfile);
        }

        private void MCU2_Click(object sender, EventArgs e)
        {
            textBox3.Text = GetFile(MCU2file);
        }
        public string outFile;

        public string GetFile(string MCU)
        {
             string File;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
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
                FileInfo[] files = dir.GetFiles("ETU*", SearchOption.TopDirectoryOnly);
                string MCU1file;
                string MCU2flashfile;
                string MCU2file;
                foreach (var item in files)
                {
                    if (item.FullName.Contains("ETU_MCU1"))
                    {
                        MCU1file = item.FullName;
                        textBox1.Text = MCU1file;
                    }
                    else if (item.FullName.Contains("ETU_MCU2"))
                    {
                       if (item.FullName.Contains("Flash"))
                        {
                            MCU2flashfile = item.FullName;
                            textBox2.Text = MCU2flashfile;
                        }
                       else
                        {
                            MCU2file = item.FullName;
                            textBox3.Text = MCU2file;
                        }
                   
                    }
                    else
                    {
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        textBox3.Text = " ";
                    }
                    
                }
            }
            
            else
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
            }
        
        }

        public async Task<string> MCU1_Text()
        {
            return "Programmed MCU1";
        }
        public async Task<string> MCU2FlashingAlert_Text()
        {
            return "Please wait, flashing MCU2";
        }
        public async Task<string> MCU2Flash_Text()
        {
            return "Flashed MCU2";
        }
        public async Task<string> MCU2_Text()
        {
            return "Programmed MCU2";
        }
        public async Task<int> Updater(string MC)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "MSP430Flasher.exe";
            startInfo.Arguments = "-w " + MC + " -v -z [VCC]";
            process.StartInfo = startInfo;
            process.StartInfo.CreateNoWindow = true;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }
        public async void TwoWayUpdate_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Starting Update";
            textBox5.Text = " ";
            textBox6.Text = " ";
            aErr err; //pass vairable and can get it back 
            if (stem.ConnectToFirst(out err))
            {
                stem.EnablePort(0);
                stem.DisablePort(6);
                stem.EnablePort(4);
                int return1;
                return1 = await Updater(textBox1.Text);

                if (return1 == 0)
                {
                    textBox4.Text = await MCU1_Text();
                    stem.DisablePort(0);
                    stem.DisablePort(4);
                    Thread.Sleep(2000);
                    stem.EnablePort(0);
                    stem.EnablePort(6);
                    Thread.Sleep(2000);
                    textBox5.Text = await MCU2FlashingAlert_Text();
                    int return2 = await Updater(textBox2.Text);
                    if (return2 == 0)
                    {
                        Thread.Sleep(30000);
                        stem.DisablePort(0);
                        Thread.Sleep(2000);
                        stem.EnablePort(0);
                        Thread.Sleep(2000);
                        textBox5.Text = await MCU2Flash_Text();

                        int return3 = await Updater(textBox3.Text);

                        if (return3 == 0)
                        {
                            textBox6.Text = "Programmed MCU2";
                        }
                        else
                        {
                            textBox6.Text = "Could not program MCU2.";
                        }
                    }
                    else
                    {
                        textBox5.Text = "Could not Flash MCU2.";
                    }
                }
                else
                {
                    textBox4.Text = "Could not program MCU1.";
                }

            }
            else
            {
                textBox4.Text = "Error Connecting to Acroname.";
            }
        }

        public async void OneWayUpdate_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Starting Update";
            textBox5.Text = " ";
            textBox6.Text = " ";
            int return1;
            return1 = await Updater(textBox1.Text);

            if (return1 == 0)
            {
                textBox4.Text = await MCU1_Text();
                MCU2Swap.Visible = true;
            }
            else
            {
                textBox4.Text = "Could not program MCU1.";
            }

        }

        public async void MCU2Swap_Click(object sender, EventArgs e)
        {
            MCU2Swap.Visible = false;
            textBox5.Text = await MCU2FlashingAlert_Text();

            int return2 = await Updater(textBox2.Text);
            if (return2 == 0)
            {
                textBox5.Text = await MCU2Flash_Text();

                MCU2Prog.Visible = true;

            }
            else
            {
                textBox5.Text = "Could not Flash MCU2.";
            }
        }

        public async void MCU2Prog_Click(object sender, EventArgs e)
        {
            int return3 = await Updater(textBox3.Text);
            if (return3 == 0)
            {
                MCU2Prog.Visible = false;
                textBox6.Text = await MCU2_Text();

            }
            else
            {
                textBox6.Text = "Could not program MCU2.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Firmwarefolder_Click(object sender, EventArgs e)
        {
            GetFolder();
        }
    }
}
