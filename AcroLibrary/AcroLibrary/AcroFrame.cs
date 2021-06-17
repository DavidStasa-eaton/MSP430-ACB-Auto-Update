using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroLibrary
{
    public partial class AcroFrame : UserControl
    {
        public AcronameHub acHub;


        public byte acbPort
        {
            get { return byte.Parse(portBox.Text); }
            set { portBox.SelectedItem = value; }
        }

        public bool isConnected
        {
            get
            {
                if (acHub == null)
                    return false;
                else
                {
                    return acHub.isConnected;
                }
            }
        }



        public AcroFrame()
        {
            InitializeComponent();


            portBox.SelectedIndex = 0;
            
            try
            {
                acHub = new AcronameHub();
            }
            catch (Exception e)
            {
                acHub = null;
                debugLabel.Text = e.Message;
            }
            

            //Console.WriteLine(acHub.isConnected);
            //Console.WriteLine(acHub.connectionError);
            AcroButton.acHub = acHub;
        }

        public void FormatConnected()
        {
            connectButton.Text = "Disconnect";
            connectButton.BackColor = Color.LightGreen;
        }

        public void FormatDisconnected()
        {
            connectButton.Text = "Connect";
            connectButton.BackColor = SystemColors.Control;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
