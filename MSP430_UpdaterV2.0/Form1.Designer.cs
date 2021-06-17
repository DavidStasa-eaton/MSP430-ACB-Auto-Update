﻿
namespace MSP430_UpdaterV2._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MCU1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MCU2_Flash = new System.Windows.Forms.Button();
            this.MCU2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TwoWayUpdate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.OneWayUpdate = new System.Windows.Forms.Button();
            this.MCU2Swap = new System.Windows.Forms.Button();
            this.MCU2Prog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Firmwarefolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MCU1
            // 
            this.MCU1.Location = new System.Drawing.Point(12, 12);
            this.MCU1.Name = "MCU1";
            this.MCU1.Size = new System.Drawing.Size(270, 35);
            this.MCU1.TabIndex = 0;
            this.MCU1.Text = "Upload MCU1";
            this.MCU1.UseVisualStyleBackColor = true;
            this.MCU1.Click += new System.EventHandler(this.MCU1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(700, 35);
            this.textBox2.TabIndex = 4;
            // 
            // MCU2_Flash
            // 
            this.MCU2_Flash.Location = new System.Drawing.Point(10, 53);
            this.MCU2_Flash.Name = "MCU2_Flash";
            this.MCU2_Flash.Size = new System.Drawing.Size(270, 35);
            this.MCU2_Flash.TabIndex = 5;
            this.MCU2_Flash.Text = "Upload MCU2 Flash";
            this.MCU2_Flash.UseVisualStyleBackColor = true;
            this.MCU2_Flash.Click += new System.EventHandler(this.MCU2_Flash_Click);
            // 
            // MCU2
            // 
            this.MCU2.Location = new System.Drawing.Point(10, 94);
            this.MCU2.Name = "MCU2";
            this.MCU2.Size = new System.Drawing.Size(270, 35);
            this.MCU2.TabIndex = 6;
            this.MCU2.Text = "Upload MCU2 ";
            this.MCU2.UseVisualStyleBackColor = true;
            this.MCU2.Click += new System.EventHandler(this.MCU2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 94);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(700, 35);
            this.textBox3.TabIndex = 7;
            // 
            // TwoWayUpdate
            // 
            this.TwoWayUpdate.Location = new System.Drawing.Point(10, 197);
            this.TwoWayUpdate.Name = "TwoWayUpdate";
            this.TwoWayUpdate.Size = new System.Drawing.Size(268, 60);
            this.TwoWayUpdate.TabIndex = 8;
            this.TwoWayUpdate.Text = "Start Two Programmer Update";
            this.TwoWayUpdate.UseVisualStyleBackColor = true;
            this.TwoWayUpdate.Click += new System.EventHandler(this.TwoWayUpdate_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(401, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(383, 26);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(401, 265);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(383, 26);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(401, 333);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(383, 26);
            this.textBox6.TabIndex = 11;
            // 
            // OneWayUpdate
            // 
            this.OneWayUpdate.Location = new System.Drawing.Point(10, 263);
            this.OneWayUpdate.Name = "OneWayUpdate";
            this.OneWayUpdate.Size = new System.Drawing.Size(268, 60);
            this.OneWayUpdate.TabIndex = 12;
            this.OneWayUpdate.Text = "Start Single Programmer Update";
            this.OneWayUpdate.UseVisualStyleBackColor = true;
            this.OneWayUpdate.Click += new System.EventHandler(this.OneWayUpdate_Click);
            // 
            // MCU2Swap
            // 
            this.MCU2Swap.AutoSize = true;
            this.MCU2Swap.Location = new System.Drawing.Point(459, 229);
            this.MCU2Swap.Name = "MCU2Swap";
            this.MCU2Swap.Size = new System.Drawing.Size(268, 30);
            this.MCU2Swap.TabIndex = 13;
            this.MCU2Swap.Text = "Swap to MCU2";
            this.MCU2Swap.UseVisualStyleBackColor = true;
            this.MCU2Swap.Click += new System.EventHandler(this.MCU2Swap_Click);
            // 
            // MCU2Prog
            // 
            this.MCU2Prog.AutoSize = true;
            this.MCU2Prog.Location = new System.Drawing.Point(459, 297);
            this.MCU2Prog.Name = "MCU2Prog";
            this.MCU2Prog.Size = new System.Drawing.Size(268, 30);
            this.MCU2Prog.TabIndex = 14;
            this.MCU2Prog.Text = "Program MCU2";
            this.MCU2Prog.UseVisualStyleBackColor = true;
            this.MCU2Prog.Click += new System.EventHandler(this.MCU2Prog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(994, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(872, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(994, 396);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(248, 26);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Board Setup";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(872, 609);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(387, 26);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "Acroname Setup";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Firmwarefolder
            // 
            this.Firmwarefolder.Location = new System.Drawing.Point(488, 140);
            this.Firmwarefolder.Name = "Firmwarefolder";
            this.Firmwarefolder.Size = new System.Drawing.Size(265, 36);
            this.Firmwarefolder.TabIndex = 19;
            this.Firmwarefolder.Text = "Upload Firmware Folder";
            this.Firmwarefolder.UseVisualStyleBackColor = true;
            this.Firmwarefolder.Click += new System.EventHandler(this.Firmwarefolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 653);
            this.Controls.Add(this.Firmwarefolder);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MCU2Prog);
            this.Controls.Add(this.MCU2Swap);
            this.Controls.Add(this.OneWayUpdate);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TwoWayUpdate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.MCU2);
            this.Controls.Add(this.MCU2_Flash);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MCU1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MSP430 Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MCU1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button MCU2_Flash;
        private System.Windows.Forms.Button MCU2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button TwoWayUpdate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button OneWayUpdate;
        private System.Windows.Forms.Button MCU2Swap;
        private System.Windows.Forms.Button MCU2Prog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Firmwarefolder;
    }
}

