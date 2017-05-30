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
    partial class ReturnMenu : TerminalForm
    {
        private User user;
        private Equipment equipment;

        public ReturnMenu()
        {
            InitializeComponent();
        }

        private void ReturnMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            //Connection with scanners
        }

        public override void EquipmentId(string id)
        {
            //equipment = (1c api request by id)
            if (equipment == null) return;
            //user = (1c api request by id for user)
            label1.Visible = true;
            label1.Text = "User: " + user.Name + "\nEquipment: " + equipment.Name;
        }

        private void GeneralPanel_Resize(object sender, EventArgs e)
        {
            int width = GeneralPanel.Width * 40 / 100;
            int height = GeneralPanel.Height * 40 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;

            EquipmentPanel.Location = new Point(widthI * 6, heightI);
            EquipmentPanel.Size = new Size(width, height);


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
            if (user != null && equipment != null) {
                PrintSheet.PrintReturnSheet(user, equipment);
                //TODO
                this.Close();
            }
        }
    }
}
