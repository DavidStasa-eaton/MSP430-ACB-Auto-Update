
namespace MSP430_UpdaterV2._0
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MCU1 = new System.Windows.Forms.Button();
            this.mcu1Textbox = new System.Windows.Forms.TextBox();
            this.flashMcu2FileTextbox = new System.Windows.Forms.TextBox();
            this.MCU2_Flash = new System.Windows.Forms.Button();
            this.MCU2 = new System.Windows.Forms.Button();
            this.mcu2FileTextbox = new System.Windows.Forms.TextBox();
            this.twoProgramerStartButton = new System.Windows.Forms.Button();
            this.OneWayUpdate = new System.Windows.Forms.Button();
            this.uploadFirmwareFolderButton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.logRTB = new System.Windows.Forms.RichTextBox();
            this.acroControl = new AcronameCommonControls.AcroControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threePointZeroRadioButton = new System.Windows.Forms.RadioButton();
            this.twoPointZeroRadioButton = new System.Windows.Forms.RadioButton();
            this.hardwareSetupButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preloadMCU1Button = new System.Windows.Forms.Button();
            this.eraseBothMcusButton = new System.Windows.Forms.Button();
            this.eraseMCU2Button = new System.Windows.Forms.Button();
            this.eraseMCU1Button = new System.Windows.Forms.Button();
            this.programMCU1Button = new System.Windows.Forms.Button();
            this.flashMCU2Button = new System.Windows.Forms.Button();
            this.programMCU2Button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autoToggleForSingleStepCheckBox = new System.Windows.Forms.CheckBox();
            this.eraseConnectedMCUButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acronameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerMCU1ConfigButton = new System.Windows.Forms.Button();
            this.powerMCU2ConfigButton = new System.Windows.Forms.Button();
            this.verfiyCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.msp1_Box = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.msp2_Box = new System.Windows.Forms.ComboBox();
            this.redirectOutputCheckbox = new System.Windows.Forms.CheckBox();
            this.addCurrentMspToDropDownButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flashWaitTimeEntry = new System.Windows.Forms.TextBox();
            this.timerRadio = new System.Windows.Forms.RadioButton();
            this.waitForUserRadio = new System.Windows.Forms.RadioButton();
            this.majorRevUpdateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // MCU1
            // 
            this.MCU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCU1.Location = new System.Drawing.Point(5, 18);
            this.MCU1.Margin = new System.Windows.Forms.Padding(2);
            this.MCU1.Name = "MCU1";
            this.MCU1.Size = new System.Drawing.Size(114, 32);
            this.MCU1.TabIndex = 0;
            this.MCU1.Text = "↑ MCU1";
            this.MCU1.UseVisualStyleBackColor = true;
            this.MCU1.Click += new System.EventHandler(this.MCU1_Click);
            // 
            // mcu1Textbox
            // 
            this.mcu1Textbox.Location = new System.Drawing.Point(137, 18);
            this.mcu1Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.mcu1Textbox.Multiline = true;
            this.mcu1Textbox.Name = "mcu1Textbox";
            this.mcu1Textbox.Size = new System.Drawing.Size(400, 34);
            this.mcu1Textbox.TabIndex = 3;
            // 
            // flashMcu2FileTextbox
            // 
            this.flashMcu2FileTextbox.Location = new System.Drawing.Point(137, 54);
            this.flashMcu2FileTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.flashMcu2FileTextbox.Multiline = true;
            this.flashMcu2FileTextbox.Name = "flashMcu2FileTextbox";
            this.flashMcu2FileTextbox.Size = new System.Drawing.Size(400, 34);
            this.flashMcu2FileTextbox.TabIndex = 4;
            // 
            // MCU2_Flash
            // 
            this.MCU2_Flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCU2_Flash.Location = new System.Drawing.Point(5, 54);
            this.MCU2_Flash.Margin = new System.Windows.Forms.Padding(2);
            this.MCU2_Flash.Name = "MCU2_Flash";
            this.MCU2_Flash.Size = new System.Drawing.Size(114, 32);
            this.MCU2_Flash.TabIndex = 5;
            this.MCU2_Flash.Text = "↑ MCU2 Flash";
            this.MCU2_Flash.UseVisualStyleBackColor = true;
            this.MCU2_Flash.Click += new System.EventHandler(this.MCU2_Flash_Click);
            // 
            // MCU2
            // 
            this.MCU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCU2.Location = new System.Drawing.Point(7, 91);
            this.MCU2.Margin = new System.Windows.Forms.Padding(2);
            this.MCU2.Name = "MCU2";
            this.MCU2.Size = new System.Drawing.Size(114, 32);
            this.MCU2.TabIndex = 6;
            this.MCU2.Text = "↑ MCU2 ";
            this.MCU2.UseVisualStyleBackColor = true;
            this.MCU2.Click += new System.EventHandler(this.MCU2_Click);
            // 
            // mcu2FileTextbox
            // 
            this.mcu2FileTextbox.Location = new System.Drawing.Point(137, 91);
            this.mcu2FileTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.mcu2FileTextbox.Multiline = true;
            this.mcu2FileTextbox.Name = "mcu2FileTextbox";
            this.mcu2FileTextbox.Size = new System.Drawing.Size(400, 34);
            this.mcu2FileTextbox.TabIndex = 7;
            // 
            // twoProgramerStartButton
            // 
            this.twoProgramerStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twoProgramerStartButton.Location = new System.Drawing.Point(5, 48);
            this.twoProgramerStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.twoProgramerStartButton.Name = "twoProgramerStartButton";
            this.twoProgramerStartButton.Size = new System.Drawing.Size(111, 42);
            this.twoProgramerStartButton.TabIndex = 8;
            this.twoProgramerStartButton.Text = "Start Two Programmer Update";
            this.twoProgramerStartButton.UseVisualStyleBackColor = true;
            this.twoProgramerStartButton.Click += new System.EventHandler(this.TwoWayUpdate_Click);
            // 
            // OneWayUpdate
            // 
            this.OneWayUpdate.Location = new System.Drawing.Point(521, 47);
            this.OneWayUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.OneWayUpdate.Name = "OneWayUpdate";
            this.OneWayUpdate.Size = new System.Drawing.Size(122, 39);
            this.OneWayUpdate.TabIndex = 12;
            this.OneWayUpdate.Text = "Start Single Programmer Update";
            this.OneWayUpdate.UseVisualStyleBackColor = true;
            this.OneWayUpdate.Click += new System.EventHandler(this.OneWayUpdate_Click);
            // 
            // uploadFirmwareFolderButton
            // 
            this.uploadFirmwareFolderButton.Location = new System.Drawing.Point(541, 18);
            this.uploadFirmwareFolderButton.Margin = new System.Windows.Forms.Padding(2);
            this.uploadFirmwareFolderButton.Name = "uploadFirmwareFolderButton";
            this.uploadFirmwareFolderButton.Size = new System.Drawing.Size(102, 107);
            this.uploadFirmwareFolderButton.TabIndex = 19;
            this.uploadFirmwareFolderButton.Text = "Upload Firmware Folder";
            this.uploadFirmwareFolderButton.UseVisualStyleBackColor = true;
            this.uploadFirmwareFolderButton.Click += new System.EventHandler(this.Firmwarefolder_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.Location = new System.Drawing.Point(522, 496);
            this.Helpbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(151, 39);
            this.Helpbutton.TabIndex = 21;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 18);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(636, 25);
            this.progressBar1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Created by: Alyssa Brown and Dave Stasa 2021";
            // 
            // logRTB
            // 
            this.logRTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.logRTB.Location = new System.Drawing.Point(678, 24);
            this.logRTB.Name = "logRTB";
            this.logRTB.Size = new System.Drawing.Size(372, 534);
            this.logRTB.TabIndex = 28;
            this.logRTB.Text = "";
            // 
            // acroControl
            // 
            this.acroControl.acHub = null;
            this.acroControl.acType = AcronameCommonControls.AcroType.USBHub3p;
            this.acroControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acroControl.ButtonCount = 4;
            this.acroControl.Location = new System.Drawing.Point(12, 31);
            this.acroControl.Name = "acroControl";
            this.acroControl.Size = new System.Drawing.Size(447, 78);
            this.acroControl.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threePointZeroRadioButton);
            this.groupBox1.Controls.Add(this.twoPointZeroRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(560, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 47);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Board Version";
            // 
            // threePointZeroRadioButton
            // 
            this.threePointZeroRadioButton.AutoSize = true;
            this.threePointZeroRadioButton.Checked = true;
            this.threePointZeroRadioButton.Location = new System.Drawing.Point(60, 19);
            this.threePointZeroRadioButton.Name = "threePointZeroRadioButton";
            this.threePointZeroRadioButton.Size = new System.Drawing.Size(40, 17);
            this.threePointZeroRadioButton.TabIndex = 1;
            this.threePointZeroRadioButton.TabStop = true;
            this.threePointZeroRadioButton.Text = "3.0";
            this.threePointZeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // twoPointZeroRadioButton
            // 
            this.twoPointZeroRadioButton.AutoSize = true;
            this.twoPointZeroRadioButton.Location = new System.Drawing.Point(6, 19);
            this.twoPointZeroRadioButton.Name = "twoPointZeroRadioButton";
            this.twoPointZeroRadioButton.Size = new System.Drawing.Size(40, 17);
            this.twoPointZeroRadioButton.TabIndex = 0;
            this.twoPointZeroRadioButton.Text = "2.0";
            this.twoPointZeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardwareSetupButton
            // 
            this.hardwareSetupButton.Location = new System.Drawing.Point(522, 452);
            this.hardwareSetupButton.Name = "hardwareSetupButton";
            this.hardwareSetupButton.Size = new System.Drawing.Size(151, 39);
            this.hardwareSetupButton.TabIndex = 31;
            this.hardwareSetupButton.Text = "Hardware Setup Example";
            this.hardwareSetupButton.UseVisualStyleBackColor = true;
            this.hardwareSetupButton.Click += new System.EventHandler(this.hardwareSetupButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MCU1);
            this.groupBox2.Controls.Add(this.mcu1Textbox);
            this.groupBox2.Controls.Add(this.flashMcu2FileTextbox);
            this.groupBox2.Controls.Add(this.MCU2_Flash);
            this.groupBox2.Controls.Add(this.MCU2);
            this.groupBox2.Controls.Add(this.mcu2FileTextbox);
            this.groupBox2.Controls.Add(this.uploadFirmwareFolderButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 134);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Firmware Files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.majorRevUpdateButton);
            this.groupBox3.Controls.Add(this.preloadMCU1Button);
            this.groupBox3.Controls.Add(this.eraseBothMcusButton);
            this.groupBox3.Controls.Add(this.eraseMCU2Button);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.twoProgramerStartButton);
            this.groupBox3.Controls.Add(this.eraseMCU1Button);
            this.groupBox3.Controls.Add(this.OneWayUpdate);
            this.groupBox3.Location = new System.Drawing.Point(17, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 96);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automated Updates - Acroname Required";
            // 
            // preloadMCU1Button
            // 
            this.preloadMCU1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preloadMCU1Button.Location = new System.Drawing.Point(213, 47);
            this.preloadMCU1Button.Margin = new System.Windows.Forms.Padding(2);
            this.preloadMCU1Button.Name = "preloadMCU1Button";
            this.preloadMCU1Button.Size = new System.Drawing.Size(111, 43);
            this.preloadMCU1Button.TabIndex = 40;
            this.preloadMCU1Button.Text = "Preload MCU1";
            this.preloadMCU1Button.UseVisualStyleBackColor = true;
            this.preloadMCU1Button.Click += new System.EventHandler(this.preloadMCU1Button_Click);
            // 
            // eraseBothMcusButton
            // 
            this.eraseBothMcusButton.Location = new System.Drawing.Point(417, 48);
            this.eraseBothMcusButton.Name = "eraseBothMcusButton";
            this.eraseBothMcusButton.Size = new System.Drawing.Size(61, 42);
            this.eraseBothMcusButton.TabIndex = 39;
            this.eraseBothMcusButton.Text = "Erase Both";
            this.eraseBothMcusButton.UseVisualStyleBackColor = true;
            this.eraseBothMcusButton.Click += new System.EventHandler(this.eraseBothMcusButton_Click);
            // 
            // eraseMCU2Button
            // 
            this.eraseMCU2Button.Location = new System.Drawing.Point(329, 69);
            this.eraseMCU2Button.Name = "eraseMCU2Button";
            this.eraseMCU2Button.Size = new System.Drawing.Size(82, 21);
            this.eraseMCU2Button.TabIndex = 38;
            this.eraseMCU2Button.Text = "Erase MCU2";
            this.eraseMCU2Button.UseVisualStyleBackColor = true;
            this.eraseMCU2Button.Click += new System.EventHandler(this.eraseMCU2Button_Click);
            // 
            // eraseMCU1Button
            // 
            this.eraseMCU1Button.Location = new System.Drawing.Point(329, 47);
            this.eraseMCU1Button.Name = "eraseMCU1Button";
            this.eraseMCU1Button.Size = new System.Drawing.Size(82, 21);
            this.eraseMCU1Button.TabIndex = 37;
            this.eraseMCU1Button.Text = "Erase MCU1";
            this.eraseMCU1Button.UseVisualStyleBackColor = true;
            this.eraseMCU1Button.Click += new System.EventHandler(this.eraseMCU1Button_Click);
            // 
            // programMCU1Button
            // 
            this.programMCU1Button.Location = new System.Drawing.Point(7, 19);
            this.programMCU1Button.Name = "programMCU1Button";
            this.programMCU1Button.Size = new System.Drawing.Size(130, 29);
            this.programMCU1Button.TabIndex = 34;
            this.programMCU1Button.Text = "Program MCU1";
            this.programMCU1Button.UseVisualStyleBackColor = true;
            this.programMCU1Button.Click += new System.EventHandler(this.programMCU1Button_Click);
            // 
            // flashMCU2Button
            // 
            this.flashMCU2Button.Location = new System.Drawing.Point(7, 54);
            this.flashMCU2Button.Name = "flashMCU2Button";
            this.flashMCU2Button.Size = new System.Drawing.Size(130, 29);
            this.flashMCU2Button.TabIndex = 35;
            this.flashMCU2Button.Text = "Flash MCU2";
            this.flashMCU2Button.UseVisualStyleBackColor = true;
            this.flashMCU2Button.Click += new System.EventHandler(this.flashMCU2Button_Click);
            // 
            // programMCU2Button
            // 
            this.programMCU2Button.Location = new System.Drawing.Point(7, 89);
            this.programMCU2Button.Name = "programMCU2Button";
            this.programMCU2Button.Size = new System.Drawing.Size(130, 29);
            this.programMCU2Button.TabIndex = 36;
            this.programMCU2Button.Text = "Program MCU2";
            this.programMCU2Button.UseVisualStyleBackColor = true;
            this.programMCU2Button.Click += new System.EventHandler(this.programMCU2Button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autoToggleForSingleStepCheckBox);
            this.groupBox4.Controls.Add(this.programMCU1Button);
            this.groupBox4.Controls.Add(this.programMCU2Button);
            this.groupBox4.Controls.Add(this.eraseConnectedMCUButton);
            this.groupBox4.Controls.Add(this.flashMCU2Button);
            this.groupBox4.Location = new System.Drawing.Point(12, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 128);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Single Step Programming";
            // 
            // autoToggleForSingleStepCheckBox
            // 
            this.autoToggleForSingleStepCheckBox.AutoSize = true;
            this.autoToggleForSingleStepCheckBox.Location = new System.Drawing.Point(143, 18);
            this.autoToggleForSingleStepCheckBox.Name = "autoToggleForSingleStepCheckBox";
            this.autoToggleForSingleStepCheckBox.Size = new System.Drawing.Size(127, 30);
            this.autoToggleForSingleStepCheckBox.TabIndex = 40;
            this.autoToggleForSingleStepCheckBox.Text = "Automatically Toggle \r\nAcroname Ports";
            this.autoToggleForSingleStepCheckBox.UseVisualStyleBackColor = true;
            // 
            // eraseConnectedMCUButton
            // 
            this.eraseConnectedMCUButton.Location = new System.Drawing.Point(166, 78);
            this.eraseConnectedMCUButton.Name = "eraseConnectedMCUButton";
            this.eraseConnectedMCUButton.Size = new System.Drawing.Size(95, 40);
            this.eraseConnectedMCUButton.TabIndex = 39;
            this.eraseConnectedMCUButton.Text = "Erase Connected MCU";
            this.eraseConnectedMCUButton.UseVisualStyleBackColor = true;
            this.eraseConnectedMCUButton.Click += new System.EventHandler(this.eraseConnectedMCUButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acronameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acronameToolStripMenuItem
            // 
            this.acronameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerCycleToolStripMenuItem,
            this.refreshConnectionToolStripMenuItem});
            this.acronameToolStripMenuItem.Name = "acronameToolStripMenuItem";
            this.acronameToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acronameToolStripMenuItem.Text = "Acroname";
            // 
            // powerCycleToolStripMenuItem
            // 
            this.powerCycleToolStripMenuItem.Name = "powerCycleToolStripMenuItem";
            this.powerCycleToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.powerCycleToolStripMenuItem.Text = "Power Cycle";
            this.powerCycleToolStripMenuItem.Click += new System.EventHandler(this.powerCycleToolStripMenuItem_Click);
            // 
            // refreshConnectionToolStripMenuItem
            // 
            this.refreshConnectionToolStripMenuItem.Name = "refreshConnectionToolStripMenuItem";
            this.refreshConnectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.refreshConnectionToolStripMenuItem.Text = "Refresh Connection";
            this.refreshConnectionToolStripMenuItem.Click += new System.EventHandler(this.refreshConnectionToolStripMenuItem_Click);
            // 
            // powerMCU1ConfigButton
            // 
            this.powerMCU1ConfigButton.Location = new System.Drawing.Point(465, 31);
            this.powerMCU1ConfigButton.Name = "powerMCU1ConfigButton";
            this.powerMCU1ConfigButton.Size = new System.Drawing.Size(84, 36);
            this.powerMCU1ConfigButton.TabIndex = 39;
            this.powerMCU1ConfigButton.Text = "Power Config MCU1";
            this.powerMCU1ConfigButton.UseVisualStyleBackColor = true;
            this.powerMCU1ConfigButton.Click += new System.EventHandler(this.powerMCU1ConfigButton_Click);
            // 
            // powerMCU2ConfigButton
            // 
            this.powerMCU2ConfigButton.Location = new System.Drawing.Point(465, 73);
            this.powerMCU2ConfigButton.Name = "powerMCU2ConfigButton";
            this.powerMCU2ConfigButton.Size = new System.Drawing.Size(84, 36);
            this.powerMCU2ConfigButton.TabIndex = 40;
            this.powerMCU2ConfigButton.Text = "Power Config MCU2";
            this.powerMCU2ConfigButton.UseVisualStyleBackColor = true;
            this.powerMCU2ConfigButton.Click += new System.EventHandler(this.powerMCU2ConfigButton_Click);
            // 
            // verfiyCheckbox
            // 
            this.verfiyCheckbox.AutoSize = true;
            this.verfiyCheckbox.Checked = true;
            this.verfiyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verfiyCheckbox.Location = new System.Drawing.Point(558, 429);
            this.verfiyCheckbox.Name = "verfiyCheckbox";
            this.verfiyCheckbox.Size = new System.Drawing.Size(115, 17);
            this.verfiyCheckbox.TabIndex = 41;
            this.verfiyCheckbox.Text = "Include Verify Step";
            this.verfiyCheckbox.UseVisualStyleBackColor = true;
            this.verfiyCheckbox.CheckedChanged += new System.EventHandler(this.verfiyCheckbox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.msp1_Box);
            this.groupBox5.Location = new System.Drawing.Point(12, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 50);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MSP 1";
            // 
            // msp1_Box
            // 
            this.msp1_Box.FormattingEnabled = true;
            this.msp1_Box.Items.AddRange(new object[] {
            "MSP430F67771",
            "MSP430F67791"});
            this.msp1_Box.Location = new System.Drawing.Point(6, 19);
            this.msp1_Box.Name = "msp1_Box";
            this.msp1_Box.Size = new System.Drawing.Size(110, 21);
            this.msp1_Box.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.msp2_Box);
            this.groupBox6.Location = new System.Drawing.Point(146, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(121, 50);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MSP 2";
            // 
            // msp2_Box
            // 
            this.msp2_Box.FormattingEnabled = true;
            this.msp2_Box.Items.AddRange(new object[] {
            "MSP430F5659",
            "MSP430F5632"});
            this.msp2_Box.Location = new System.Drawing.Point(6, 19);
            this.msp2_Box.Name = "msp2_Box";
            this.msp2_Box.Size = new System.Drawing.Size(110, 21);
            this.msp2_Box.TabIndex = 0;
            // 
            // redirectOutputCheckbox
            // 
            this.redirectOutputCheckbox.AutoSize = true;
            this.redirectOutputCheckbox.Checked = true;
            this.redirectOutputCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redirectOutputCheckbox.Location = new System.Drawing.Point(310, 533);
            this.redirectOutputCheckbox.Name = "redirectOutputCheckbox";
            this.redirectOutputCheckbox.Size = new System.Drawing.Size(118, 17);
            this.redirectOutputCheckbox.TabIndex = 42;
            this.redirectOutputCheckbox.Text = "Do Redirect Output";
            this.redirectOutputCheckbox.UseVisualStyleBackColor = true;
            // 
            // addCurrentMspToDropDownButton
            // 
            this.addCurrentMspToDropDownButton.Location = new System.Drawing.Point(273, 123);
            this.addCurrentMspToDropDownButton.Name = "addCurrentMspToDropDownButton";
            this.addCurrentMspToDropDownButton.Size = new System.Drawing.Size(82, 41);
            this.addCurrentMspToDropDownButton.TabIndex = 43;
            this.addCurrentMspToDropDownButton.Text = "Add Current to Dropdown";
            this.addCurrentMspToDropDownButton.UseVisualStyleBackColor = true;
            this.addCurrentMspToDropDownButton.Click += new System.EventHandler(this.addCurrentMspToDropDownButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.flashWaitTimeEntry);
            this.groupBox7.Controls.Add(this.timerRadio);
            this.groupBox7.Controls.Add(this.waitForUserRadio);
            this.groupBox7.Location = new System.Drawing.Point(418, 119);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 46);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MCU2 Flash Behavior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "s";
            // 
            // flashWaitTimeEntry
            // 
            this.flashWaitTimeEntry.Location = new System.Drawing.Point(156, 18);
            this.flashWaitTimeEntry.Name = "flashWaitTimeEntry";
            this.flashWaitTimeEntry.Size = new System.Drawing.Size(62, 20);
            this.flashWaitTimeEntry.TabIndex = 2;
            this.flashWaitTimeEntry.Text = "25";
            // 
            // timerRadio
            // 
            this.timerRadio.AutoSize = true;
            this.timerRadio.Checked = true;
            this.timerRadio.Location = new System.Drawing.Point(99, 19);
            this.timerRadio.Name = "timerRadio";
            this.timerRadio.Size = new System.Drawing.Size(51, 17);
            this.timerRadio.TabIndex = 1;
            this.timerRadio.TabStop = true;
            this.timerRadio.Text = "Timer";
            this.timerRadio.UseVisualStyleBackColor = true;
            // 
            // waitForUserRadio
            // 
            this.waitForUserRadio.AutoSize = true;
            this.waitForUserRadio.Location = new System.Drawing.Point(6, 19);
            this.waitForUserRadio.Name = "waitForUserRadio";
            this.waitForUserRadio.Size = new System.Drawing.Size(87, 17);
            this.waitForUserRadio.TabIndex = 0;
            this.waitForUserRadio.Text = "Wait for User";
            this.waitForUserRadio.UseVisualStyleBackColor = true;
            // 
            // majorRevUpdateButton
            // 
            this.majorRevUpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.majorRevUpdateButton.Location = new System.Drawing.Point(120, 47);
            this.majorRevUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.majorRevUpdateButton.Name = "majorRevUpdateButton";
            this.majorRevUpdateButton.Size = new System.Drawing.Size(89, 43);
            this.majorRevUpdateButton.TabIndex = 41;
            this.majorRevUpdateButton.Text = "Major Rev Update";
            this.majorRevUpdateButton.UseVisualStyleBackColor = true;
            this.majorRevUpdateButton.Click += new System.EventHandler(this.majorRevUpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1050, 558);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.addCurrentMspToDropDownButton);
            this.Controls.Add(this.redirectOutputCheckbox);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.verfiyCheckbox);
            this.Controls.Add(this.powerMCU2ConfigButton);
            this.Controls.Add(this.powerMCU1ConfigButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hardwareSetupButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acroControl);
            this.Controls.Add(this.logRTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MSP430 Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MCU1;
        private System.Windows.Forms.TextBox mcu1Textbox;
        private System.Windows.Forms.TextBox flashMcu2FileTextbox;
        private System.Windows.Forms.Button MCU2_Flash;
        private System.Windows.Forms.Button MCU2;
        private System.Windows.Forms.TextBox mcu2FileTextbox;
        private System.Windows.Forms.Button twoProgramerStartButton;
        private System.Windows.Forms.Button OneWayUpdate;
        private System.Windows.Forms.Button uploadFirmwareFolderButton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logRTB;
        private AcronameCommonControls.AcroControl acroControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton threePointZeroRadioButton;
        private System.Windows.Forms.RadioButton twoPointZeroRadioButton;
        private System.Windows.Forms.Button hardwareSetupButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button programMCU1Button;
        private System.Windows.Forms.Button flashMCU2Button;
        private System.Windows.Forms.Button programMCU2Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acronameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshConnectionToolStripMenuItem;
        private System.Windows.Forms.Button powerMCU1ConfigButton;
        private System.Windows.Forms.Button powerMCU2ConfigButton;
        private System.Windows.Forms.CheckBox verfiyCheckbox;
        private System.Windows.Forms.Button eraseMCU1Button;
        private System.Windows.Forms.Button eraseMCU2Button;
        private System.Windows.Forms.Button eraseConnectedMCUButton;
        private System.Windows.Forms.Button eraseBothMcusButton;
        private System.Windows.Forms.Button preloadMCU1Button;
        private System.Windows.Forms.CheckBox autoToggleForSingleStepCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox msp1_Box;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox msp2_Box;
        private System.Windows.Forms.CheckBox redirectOutputCheckbox;
        private System.Windows.Forms.Button addCurrentMspToDropDownButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flashWaitTimeEntry;
        private System.Windows.Forms.RadioButton timerRadio;
        private System.Windows.Forms.RadioButton waitForUserRadio;
        private System.Windows.Forms.Button majorRevUpdateButton;
    }
}

