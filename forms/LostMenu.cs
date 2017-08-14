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
    partial class LostMenu : TerminalForm
    {
        private User user;
        private Equipment[] equipments;
        private CardReader cardReader;

        public LostMenu()
        {
            InitializeComponent();
            ////////////////////////
            CardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            ////////////////////////
            CloseButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            SubmitButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            SubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            ///////////////////////
        }

        private void LostMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            cardReader = new CardReader();
            cardReader.Read(CardId);
        }

        public override void CardId(string id)
        {
            Action a = () =>
            {
                user = CardManager.getUser(id);
                if (user == null)
                {
                    cardReader.Read(CardId);
                    showMessage("User is not found / Пользователь не найден");
                    return;
                }
                equipments = Connector1C.getListOfEquipment(user);
                waititngCardLabel.Visible = false;
                waititngCardLabelRus.Visible = false;
                CardPanel.BackgroundImage = Properties.Resources.tick;
                CardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Visible = true;
                label1.Text = user.Name + ", choose equipment that you lost (выберите утерянное оборудование):";
                EquipmentList.Visible = true;
                if (equipments != null)
                {
                    for (int i = 0; i < equipments.Count(); i++)
                    {
                        EquipmentList.Items.Add(equipments[i].Name);
                    }
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
            //Elements
            int width = GeneralPanel.Width * 40 / 100;
            int height = GeneralPanel.Height * 40 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;

            MessageLabel.Location = new Point(widthI * 6, heightI * 6);
            MessageLabel.Size = new Size(width, height);

            width = GeneralPanel.Width * 60 / 100;
            height = GeneralPanel.Height * 70 / 100;

            headerLabel.Location = new Point(widthI, headerLabel.Location.Y);

            CardPanel.Location = new Point(4 * widthI, heightI);
            CardPanel.Size = new Size(width, height);
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
            if (user == null)
            {
                showMessage("User is not found / Пользователь не найден");
            }
            else if (EquipmentList.SelectedIndex == -1)
            {
                showMessage("Lost equipment is not selected / Утерянное оборудование не выбрано");
            }
            else
            {
                PrintSheet.PrintLostSheet(user, equipments[EquipmentList.SelectedIndex]);
                Connector1C.lostEquipment(equipments[EquipmentList.SelectedIndex]);
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
