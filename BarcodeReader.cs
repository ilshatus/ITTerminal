using System;
using System.Text;
using System.Windows.Forms;

namespace ITTerminal
{
    public class BarcodeReader
    {
        Action<string> barCodeCallback;
        StringBuilder mScanData = new StringBuilder();        
        PreviewKeyDownEventHandler handler;
        Form formWindow;
        public BarcodeReader(System.Windows.Forms.Form window)
        {
            formWindow = window;
        }

        public void Read(Action<string> callback)
        {
            barCodeCallback = callback;
            handler = new PreviewKeyDownEventHandler(MainWindow_PreviewKeyDown);
            formWindow.PreviewKeyDown += handler;
        }

        void MainWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {    
          if (e.KeyCode == Keys.Enter)
            {
                barCodeCallback(mScanData.ToString());
                mScanData.Clear();
                formWindow.PreviewKeyDown -= handler;
            }
            else
            {
                char xChar = (char)e.KeyValue;
                mScanData.Append(xChar);
            }
        }
    }
}
