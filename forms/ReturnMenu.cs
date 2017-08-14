using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace ITTerminal
{
    partial class ReturnMenu : TerminalForm
    {
        private User user;
        private Equipment equipment;
        private User admin;
        private CardReader cardReader;
        private BarcodeReader barcodeReader;
        private static string status = ConfigurationManager.ConnectionStrings["status"].ConnectionString;


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
                showMessage("Equipment is not found / Оборудование не найдено");
                return;
            }
            waitingEquipmentLabel.Visible = false;
            waitingEquipmentLabelRus.Visible = false;
            EquipmentPanel.BackgroundImage = Properties.Resources.tick;
            user = Connector1C.equipmentPlace(id);
            label1.Visible = true;
            label1.Text = "User (Пользователь): " + user.Name + "\nEquipment (Оборудование): " + equipment.Name;
        }

        public override void CardId(string id)
        {
            Action a = () =>
            {
                if (admin == null)
                {
                    admin = CardManager.getUser(id);
                    if (admin == null || admin.Position != status)
                    {
                        admin = null;
                        cardReader.Read(CardId);
                        showMessage("Admin is not found / Администратор не найден");
                        return;
                    }
                    waititngCardLabel.Visible = false;
                    waititngCardLabelRus.Visible = false;
                    AdminCardPanel.BackgroundImage = Properties.Resources.tick;
                    AdminCardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                    label2.Visible = true;
                    label2.Text = "Admin (Администратор): " + admin.Name;
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

            MessageLabel.Location = new Point(widthI * 6, heightI * 6);
            MessageLabel.Size = new Size(width, height);

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
            if (equipment == null)
            {
                showMessage("Equipment is not found / Оборудование не найдено");
            }
            else if (admin == null)
            {
                showMessage("Admin is not found / Администратор не найден");
            }
            else {
                PrintSheet.PrintReturnSheet(new User(user.Name, ""), equipment);
                Connector1C.transferEquipment(user, admin, equipment);
                cardReader.CloseConnection();
                this.Close();
            }
        }

        private void showMessage(string msg)
        {
            MessageLabel.Text = msg;
            MessageLabel.Visible = true;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MessageLabel.Visible = false;
            timer.Enabled = false;
        }
    }
}
