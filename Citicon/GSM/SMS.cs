using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;

namespace Citicon.GSM
{
    public class SMS
    {
        public static void SendMessage(string recipientNumber, string message)
        {
            if (!string.IsNullOrWhiteSpace(recipientNumber) && !string.IsNullOrWhiteSpace(message))
            {
                var sms = new SMS();
                var coms = sms.GetCOMs();
                var com = coms.FirstOrDefault();

                if (com != null)
                {
                    sms.Connect(com);
                    sms.Send(recipientNumber, message);
                    sms.Disconnect();
                }
            }
        }

        public SMS()
        {
            GsmPort = new SerialPort();
        }

        private SerialPort GsmPort { get; set; }
        private bool DeviceFound { get; set; }
        private bool Connected { get; set; }

        public bool Connect(COM com)
        {
            if (!Connected || GsmPort == null || !GsmPort.IsOpen)
            {
                try
                {
                    GsmPort.PortName = com.Name;
                    GsmPort.BaudRate = 9600;
                    GsmPort.Parity = Parity.None;
                    GsmPort.DataBits = 8;
                    GsmPort.StopBits = StopBits.Two;
                    GsmPort.Handshake = Handshake.RequestToSend;
                    GsmPort.DtrEnable = true;
                    GsmPort.RtsEnable = true;
                    GsmPort.NewLine = Environment.NewLine;
                    GsmPort.Open();
                    Connected = GsmPort.IsOpen;
                }
                catch (Exception)
                {
                    Connected = false;
                    throw;
                }
            }
            else
            {
                Connected = false;
            }

            return Connected;
        }

        public void Disconnect()
        {
            if (Connected || GsmPort != null || GsmPort.IsOpen)
            {
                GsmPort.Close();
                GsmPort.Dispose();
                Connected = false;
            }
        }

        public void Read()
        {
            GsmPort.WriteLine("AT+CMGF=1");
            GsmPort.WriteLine("AT+CPMS=\"SM\"");
            GsmPort.WriteLine("AT+CMGL=\"ALL\"");
            GsmPort.Write("\r");

            var response = GsmPort.ReadExisting();

            if (response.EndsWith($"{Environment.NewLine}OK{Environment.NewLine}"))
            {

            }
        }

        public void Send(string toAddress, string message)
        {
            GsmPort.WriteLine("AT+CMGF=1");
            GsmPort.WriteLine($"AT+CMGS=\"{toAddress}\"");
            GsmPort.WriteLine(message + char.ConvertFromUtf32(26));
        }

        private COM SearchCOM(string portName)
        {
            var coms = GetCOMs();

            if (coms != null)
            {
                var com = coms.FirstOrDefault(x => x.Name == portName);
                DeviceFound = com != null;
                return com;
            }
            else
            {
                DeviceFound = false;
                return null;
            }
        }

        public COM[] GetCOMs()
        {
            List<COM> coms = new List<COM>();

            var collection = GetCollection();

            foreach (var managementObject in collection)
            {
                string portName = managementObject["AttachedTo"].ToString();
                string portDescription = managementObject["Description"].ToString();

                if (portName != string.Empty)
                {
                    coms.Add(new COM()
                    {
                        Name = portName,
                        Description = portDescription
                    });
                }
            }

            return coms.ToArray();
        }

        private ManagementScope GetScope()
        {
            var options = new ConnectionOptions();
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.EnablePrivileges = true;
            var connectionString = $@"\\{Environment.MachineName}\root\cimv2";

            var scope = new ManagementScope(connectionString, options);
            scope.Connect();
            return scope;
        }

        private ObjectQuery GetQuery()
        {
            return new ObjectQuery("SELECT * FROM Win32_POTSModem");
        }

        private ManagementObjectCollection GetCollection()
        {
            var searcher = new ManagementObjectSearcher(GetScope(), GetQuery());
            return searcher.Get();
        }
    }
}
