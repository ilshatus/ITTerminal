using System;
using System.Configuration;
using System.IO.Ports;

namespace ITTerminal
{
    class CardReader
    {
        string COM_PORT = ConfigurationManager.ConnectionStrings["CardReaderCOMPort"].ConnectionString;
        private string nfc_code;
        public delegate void NfcReadCallback(string code);
        private NfcReadCallback callback;
        private SerialPort serialPort;

        public CardReader()
        {
            try
            {
                SerialPort m_mySerialPort;
                m_mySerialPort = new SerialPort(COM_PORT);

                m_mySerialPort.BaudRate = 9600;
                m_mySerialPort.Parity = Parity.None;
                m_mySerialPort.StopBits = StopBits.One;
                m_mySerialPort.DataBits = 8;
                m_mySerialPort.Handshake = Handshake.None;
                m_mySerialPort.RtsEnable = true;
                m_mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                m_mySerialPort.Open();

                serialPort = m_mySerialPort;
            }
            catch (Exception)
            {
                
            }
        }

        public void CloseConnection()
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception)
            {

            }            
        }

        public void Read(NfcReadCallback cb)
        {
            callback = cb;
        }

        private void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s = sp.ReadExisting().TrimEnd('\r', '\n');
            nfc_code += s;
            if (nfc_code.Length == 8)
            {
                callback?.Invoke(nfc_code);
                callback = null;
                nfc_code = "";
            }
        }
    }
}
