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
    partial class GetMenu : TerminalForm
    {
        private User user;
        private Equipment equipment;

        public GetMenu()
        {
            InitializeComponent();
        }

        private void GetMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            //Connection with scanners
        }

        public override void CardId(string id)
        {
            if (user == null)
            {
                user = CardManager.getUser(id);
                if (user == null) return;
                label1.Visible = true;
                label1.Text = "User: " + user.Name;
            }
        }

        public override void EquipmentId(string id)
        {
            if (equipment == null)
            {
                //equipment = (1c api request by id)
                if (equipment == null)
                {
                    label2.Visible = true;
                    label2.Text = "Equipment: " + equipment.Name;
                }
            }
        }

        private void GeneralPanel_Resize(object sender, EventArgs e)
        {
            int width = GeneralPanel.Width * 40 / 100;
            int height = GeneralPanel.Height * 40 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;
            CardPanel.Location = new Point(widthI, heightI);
            CardPanel.Size = new Size(width, height);
            EquipmentPanel.Location = new Point(3 * widthI + width, heightI);
            EquipmentPanel.Size = new Size(width, height);
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
            if (user != null && equipment != null && DeadlineDate.Value > DateTime.Today)
            {
                PrintSheet.PrintGetSheet(user, equipment, DeadlineDate.Value.ToShortDateString());
                //TODO
                this.Close();
            }
            
        }
    }
}
