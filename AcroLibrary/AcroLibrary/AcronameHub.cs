using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Acroname.BrainStem2CLI;

namespace AcroLibrary
{
    public class AcronameHub
    {

        public bool isConnected;
        public string connectionError = "";

        USBHub3p stem = new USBHub3p();
        UInt32 serial_number = 0;

        public AcronameHub()
        {
            //TODO:
            //Uncomment the specific device you are attempting to connect too.

            //USBStem stem = new USBStem();
            //EtherStem stem = new EtherStem();
            //MTMUSBStem stem = new MTMUSBStem();
            //MTMEtherStem stem = new MTMEtherStem();
            //MTMIOSerial stem = new MTMIOSerial();
            //MTMPM1 stem = new MTMPM1();
            //MTMRelay stem = new MTMRelay();
            //MTMDAQ1 stem = new MTMDAQ1();
            //MTMDAQ2 stem = new MTMDAQ2();
            //USBHub2x4 stem = new USBHub2x4();
            //USBHub3p stem = new USBHub3p();
            //USBCSwitch  stem = new USBCSwitch();

            //When no serial number is provided discoverAndConnect will attempt to
            //connect to the first module it finds.  If multiple BrainStem devices
            //are connected to your machine it is unknown which device will be
            //discovered first.
            //Under the hood this function uses findFirstModule()

            /*
            err = stem.module.discoverAndConnect(m_linkType.USB);
            if (err != aErr.aErrNone)
            {
                connectionError = $"0x00: Unable to find BrainStem Module: {stem.ToString()}, Error: {err}";
                return;
            }
            else
            {
                isConnected = true;
                stem.system.getSerialNumber(ref serial_number);
            }
            stem.module.disconnect();
            */

            // Put the serial number of your device here.

            //discoverAndConnect has an overload which accepts a Serial Number.
            //The example immediately above will attempt to fetch the serial number
            //and attempt to use it in this example. Feel free to drop in the
            //serial number of your device.
            //Under the hood this function uses a combination of sDiscover() and
            //connectFromSpec().

            //Console.WriteLine("Example: discoverAndConnect(USB, Serial_Number);");

            /*
            err = stem.module.discoverAndConnect(m_linkType.USB, user_serial_number);
            if (err != aErr.aErrNone)
            {
                connectionError = $"0x01: Unable to find BrainStem Module: {stem.ToString()}, Serial Number: {user_serial_number}, Error: {err}";
                isConnected = false;
            }
            else
            {
                isConnected = true;
            }
            */
        }

        public bool ConnectToFirst(out aErr err)
        {
            err = aErr.aErrNone;

            err = stem.module.discoverAndConnect(m_linkType.USB);
            if (err != aErr.aErrNone)
            {
                connectionError = $"0x00: Unable to find BrainStem Module: {stem}, Error: {err}";
                return false;
            }
            else
            {
                isConnected = true;
                stem.system.getSerialNumber(ref serial_number);
            }

            return true;
        }

        public bool ConnectToSerialNumber(out aErr err)
        {
            err = stem.module.discoverAndConnect(m_linkType.USB, serial_number);
            if (err != aErr.aErrNone)
            {
                connectionError = $"0x01: Unable to find BrainStem Module: {stem.ToString()}, Serial Number: {serial_number}, Error: {err}";
                isConnected = false;
                return false;
            }
            else
            {
                isConnected = true;
                return true;
            }
        }

        public bool Connect()
        {
            aErr err;
            if (serial_number == 0)
               return ConnectToFirst(out err);
            else
               return  ConnectToSerialNumber(out err);
        }

        public void Disconnect()
        {
            stem.module.disconnect();
        }
    
        public void DisablePort(byte port)
        {
            stem.usb.setPortDisable(port);
        }

        public void EnablePort(byte port)
        {
            stem.usb.setPortEnable(port);
        }
    }

}

