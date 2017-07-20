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
        private string user;
        private Equipment equipment;
        private User admin;
        private CardReader cardReader;
        private BarcodeReader barcodeReader;

        public ReturnMenu()
        {
            InitializeComponent();
            ////////////////////////
            AdminCardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            EquipmentPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            ////////////////////////
            CloseButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            SubmitButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            SubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            ///////////////////////
        }

        private void ReturnMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            cardReader = new CardReader();
            cardReader.Read(CardId);
            barcodeReader = new BarcodeReader(this);
            barcodeReader.Read(EquipmentId);
        }

        public override void EquipmentId(string id)
        {
            equipment = Connector1C.doesSomeoneHasEquipment(id);
            if (equipment == null)
            {
                barcodeReader.Read(EquipmentId);
                return;
            }
            waitingEquipmentLabel.Visible = false;
            EquipmentPanel.BackgroundImage = Properties.Resources.tick;
            user = Connector1C.whereIsEquipment(id);
            label1.Visible = true;
            label1.Text = "User: " + user + "\nEquipment: " + equipment.Name;
            if (admin != null) SubmitButton.Enabled = true;
        }

        public override void CardId(string id)
        {
            Action a = () =>
            {
                if (admin == null)
                {
                    admin = CardManager.getUser(id);
                    if (admin == null || admin.Position != "Сотрудник")
                    {
                        cardReader.Read(CardId);
                        return;
                    }
                    waititngCardLabel.Visible = false;
                    AdminCardPanel.BackgroundImage = Properties.Resources.tick;
                    AdminCardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                    label2.Visible = true;
                    label2.Text = "Admin: " + admin.Name;
                    if (equipment != null) SubmitButton.Enabled = true;
                }
            };
            BeginInvoke(a);
        }

        private void GeneralPanel_Resize(object sender, EventArgs e)
        {
            //Panels
            GeneralPanel.Location = new Point(0, 70);
            GeneralPanel.Size = new Size(this.Size.Width, this.Size.Height - 70);
            Header.Location = new Point(0, 10);
            Header.Size = new Size(this.Size.Width, 60);
            /////////////////


            int width = GeneralPanel.Width * 40 / 100;
            int height = GeneralPanel.Height * 40 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;

            headerLabel.Location = new Point(widthI, headerLabel.Location.Y);

            EquipmentPanel.Location = new Point(widthI, heightI);
            EquipmentPanel.Size = new Size(width, height);

            AdminCardPanel.Location = new Point(3 * widthI + width, heightI);
            AdminCardPanel.Size = new Size(width, height);

            int buttonWidth = GeneralPanel.Width * 15 / 100;
            int buttonHeight = GeneralPanel.Height * 10 / 100;

            SubmitButton.Location = new Point(GeneralPanel.Width - buttonWidth - widthI, GeneralPanel.Height - buttonHeight - heightI);
            SubmitButton.Size = new Size(buttonWidth, buttonHeight);

            CloseButton.Location = new Point(SubmitButton.Location.X - buttonWidth - widthI / 2, SubmitButton.Location.Y);
            CloseButton.Size = new Size(buttonWidth, buttonHeight);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            cardReader.CloseConnection();
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (equipment != null) {
                PrintSheet.PrintReturnSheet(new User(user, ""), equipment);
                Connector1C.returnEquipment(equipment);
                Connector1C.getEquipment(admin, equipment);
                this.Close();
            }
        }
    }
}
