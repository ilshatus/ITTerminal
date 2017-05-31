using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
namespace WpfApplication1
{
    public class BarcodeReader
    {
        Action<string> barCodeCallback;
        StringBuilder mScanData = new StringBuilder();
        KeyConverter mScanKeyConverter = new KeyConverter();
        KeyEventHandler handler;
        Window formWindow;

        public BarcodeReader(Window window)
        {
            formWindow = window;
        }

        public void Read(Action<string> callback)
        {
            barCodeCallback = callback;
            handler = new KeyEventHandler(MainWindow_PreviewKeyDown);
            formWindow.PreviewKeyDown += handler;
        }

        void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {    
          if (e.Key == Key.Return)
            {
                barCodeCallback(mScanData.ToString());
                mScanData.Clear();
                formWindow.PreviewKeyDown -= handler;
            }
            else
            {
                string xChar = mScanKeyConverter.ConvertToString(e.Key);
                mScanData.Append(xChar);
            }

        }

    }
}
