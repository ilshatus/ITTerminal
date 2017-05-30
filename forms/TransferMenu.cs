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
    partial class TransferMenu : TerminalForm
    {
        private Equipment[] equipments;
        private User firstUser;
        private User secondUser;

        public TransferMenu()
        {
            InitializeComponent();
        }

        private void TransferMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            //Connection with scanners
        }

        public override void CardId(string id)
        {
            if (firstUser == null)
            {
                firstUser = CardManager.getUser(id);
                if (firstUser == null) return;
                //equipments = (1c api request by 'firstUser')
                label1.Visible = true;
                label1.Text = "Choose equipment of " + firstUser.Name + ":";
                EquipmentList.Visible = true;
                if (equipments != null)
                {
                    for (int i = 0; i < equipments.Count(); i++)
                    {
                        EquipmentList.Items.Add(equipments[i].Name);
                    }
                }
            }
            else
            {
                secondUser = CardManager.getUser(id);
                if (secondUser == null) return;
                label2.Visible = true;
                label2.Text = secondUser.Name;
            }
        }

        private void GeneralPanel_Resize(object sender, EventArgs e)
        {
            int width = GeneralPanel.Width * 40 / 100;
            int height = GeneralPanel.Height * 40 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;
            FirstCardPanel.Location = new Point(widthI, heightI);
            FirstCardPanel.Size = new Size(width, height);
            SecondCardPanel.Location = new Point(3 * widthI + width, heightI);
            SecondCardPanel.Size = new Size(width, height);
            DateBox.Location = new Point(widthI, 2 * heightI + height);
            DateBox.Width = width;
            int buttonWidth = GeneralPanel.Width * 15 / 100;
            int buttonHeight = GeneralPanel.Height * 10 / 100;
            SubmitButton.Location = new Point(GeneralPanel.Width - buttonWidth - widthI, GeneralPanel.Height - buttonHeight - heightI);
            SubmitButton.Size = new Size(buttonWidth, buttonHeight);
            CloseButton.Location = new Point(SubmitButton.Location.X - buttonWidth - widthI / 2, SubmitButton.Location.Y);
            CloseButton.Size = new Size(buttonWidth, buttonHeight);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (firstUser != null && secondUser != null && EquipmentList.SelectedIndex != -1 && DeadlineDate.Value > DateTime.Today)
            {
                PrintSheet.PrintTransferSheet(firstUser, secondUser, equipments[EquipmentList.SelectedIndex], DeadlineDate.Value.ToShortDateString());
                //TODO
                this.Close();
            }
        }
    }
}
