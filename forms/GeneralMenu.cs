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
            //////////////////////////////
            Get.BackColor = Color.FromArgb(150, 0, 0, 0);
            Get.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            Get.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);

            Return.BackColor = Color.FromArgb(150, 0, 0, 0);
            Return.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            Return.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);

            Transfer.BackColor = Color.FromArgb(150, 0, 0, 0);
            Transfer.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            Transfer.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);

            Exchange.BackColor = Color.FromArgb(150, 0, 0, 0);
            Exchange.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            Exchange.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);

            Lost.BackColor = Color.FromArgb(150, 0, 0, 0);
            Lost.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            Lost.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);

            GetBypassSheet.BackColor = Color.FromArgb(150, 0, 0, 0);
            GetBypassSheet.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0, 0);
            GetBypassSheet.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 0, 0, 0);
            ///////////////////////////////
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
            int ind = 5;
            int height = (GeneralPanel.Height - 2 * ind - 2) / 3;
            int width = (GeneralPanel.Width - ind - 2) / 2;

            Get.Size = new Size(width, height);
            Get.MaximumSize = new Size(width, height);

            Return.Size = new Size(width, height);
            Return.MaximumSize  = new Size(width, height);

            Transfer.Size = new Size(width, height);
            Transfer.MaximumSize = new Size(width, height);

            Exchange.Size = new Size(width, height);
            Exchange.MaximumSize = new Size(width, height);

            Lost.Size = new Size(width, height);
            Lost.MaximumSize = new Size(width, height);

            GetBypassSheet.Size = new Size(width, height);
            GetBypassSheet.MaximumSize = new Size(width, height);

            Get.Location = new Point(1, 1);
            Return.Location = new Point(width + 1 + ind, 1);
            Transfer.Location = new Point(1, height + ind + 1);
            Exchange.Location = new Point(width + 1 + ind, height + ind + 1);
            Lost.Location = new Point(1, 2 * height + 1 + 2 * ind);
            GetBypassSheet.Location = new Point(width + 1 + ind, 2 * height + 1 + 2 * ind);
        }

    }
}
