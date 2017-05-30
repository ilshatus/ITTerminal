using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTerminal
{
    partial class GeneralMenu : Form
    {
        public GeneralMenu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            panel1_Resize(null, null);
        }

        private void GET_Click(object sender, EventArgs e)
        {
            GetMenu newForm = new GetMenu();
            newForm.Show();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            ReturnMenu newForm = new ReturnMenu();
            newForm.Show();
        }

        private void GetBypassSheet_Click(object sender, EventArgs e)
        {
            BypassSheetMenu newForm = new BypassSheetMenu();
            newForm.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            TransferMenu newForm = new TransferMenu();
            newForm.Show();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            ExchangeMenu newForm = new ExchangeMenu();
            newForm.Show();
        }

        private void Lost_Click(object sender, EventArgs e)
        {
            LostMenu newForm = new LostMenu();
            newForm.Show();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            int height = (panel1.Height - 3) / 2;
            int width = (panel1.Width - 4) / 3;
            Get.Size = new Size(width, height);
            Return.Size = new Size(width, height);
            Transfer.Size = new Size(width, height);
            Exchange.Size = new Size(width, height);
            Lost.Size = new Size(width, height);
            GetBypassSheet.Size = new Size(width, height);
            Get.Location = new Point(1, 1);
            Return.Location = new Point(width + 2, 1);
            Transfer.Location = new Point(2 * width + 3, 1);
            Exchange.Location = new Point(1, height + 2);
            Lost.Location = new Point(width + 2, height + 2);
            GetBypassSheet.Location = new Point(2 * width + 3, height + 2);
        }

        private void menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
