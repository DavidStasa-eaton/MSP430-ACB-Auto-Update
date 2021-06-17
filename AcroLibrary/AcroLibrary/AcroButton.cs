using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace AcroLibrary
{
    public class AcroButton : Label
    {
        public static AcronameHub acHub;

        ContentAlignment textAlign = ContentAlignment.MiddleCenter;
        bool autoSize = false;

        byte buttonByte;
        Color raiseColor = SystemColors.Control;
        Color pressedColor = Color.LightGreen;

        bool isPressed = false;

        [Description("Text Align"), Category("Appearance")]
        public override ContentAlignment TextAlign
        {
            get { return textAlign; }
            set
            {
                textAlign = value;
            }
        }

        [Description("Auto Size test"), Category("Layout")]
        public override bool AutoSize
        {
            get { return autoSize; }
            set
            {
                Console.WriteLine("AutoSize: " + value);
                autoSize = value;
            }
        }

        [Description("Button Index"), Category("Behavior")]
        public byte ButtonIndex
        {
            get { return buttonByte; }
            set
            {
                buttonByte = value;
                this.Text = value.ToString();
            }
        }

        [Description("Raised Color"), Category("Appearance")]
        public Color RaisedColor
        {
            get { return raiseColor; }
            set
            {
                raiseColor = value;
                this.BackColor = value;
            }
        }

        [Description("Pressed Color"), Category("Appearance")]
        public Color PressedColor
        {
            get { return pressedColor; }
            set
            {
                pressedColor = value;
            }
        }

        [Description("Is Pressed"), Category("Behavior")]
        public bool IsPressed
        {
            get { return isPressed; }
            set
            {
                isPressed = value;
                button_Click(null, null);
            }
        }

        public AcroButton()
        {
            this.FlatStyle = FlatStyle.Popup;

            this.Click += button_Click;

            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = RaisedColor;
        }

        public void Press()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = PressedColor;

            isPressed = true;
            if (acHub != null)
                acHub.EnablePort(buttonByte);
        }

        public void Raise()
        {
            this.FlatStyle = FlatStyle.Popup;
            this.BorderStyle = BorderStyle.None;
            this.BackColor = RaisedColor;

            isPressed = false;
            if (acHub != null)
                acHub.DisablePort(buttonByte);
        }

        public void button_Click(object sender, EventArgs e)
        {
            if (isPressed)
                Raise();
            else
                Press();
        }

    }
}
