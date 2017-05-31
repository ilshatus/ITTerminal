using System;
using System.Configuration;
using System.IO.Ports;

namespace WpfApplication1
{
    class CardReader
    {
        const string COM_PORT = "COM4";
        private string nfc_code;
        public delegate void NfcReadCallback(string code);
        private NfcReadCallback callback;
        private SerialPort serialPort;

        public CardReader()
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

        public void CloseConnection()
        {
            serialPort.Close();
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
