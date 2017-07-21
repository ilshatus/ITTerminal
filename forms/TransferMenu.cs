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
        private CardReader cardReader;

        public TransferMenu()
        {
            InitializeComponent();
            ////////////////////////
            FirstCardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            SecondCardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            ////////////////////////
            CloseButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            SubmitButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            SubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            ///////////////////////
        }

        private void TransferMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            cardReader = new CardReader();
            cardReader.Read(CardId);
        }

        public override void CardId(string id)
        {
            Action a = () =>
            {
                if (firstUser == null)
                {
                    cardReader.Read(CardId);
                    firstUser = CardManager.getUser(id);
                    if (firstUser == null) return;
                    equipments = Connector1C.getListOfEquipment(firstUser);
                    waititngFirstCardLabel.Visible = false;
                    FirstCardPanel.BackgroundImage = Properties.Resources.tick;
                    FirstCardPanel.BackgroundImageLayout = ImageLayout.Zoom;
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
                    SecondCardPanel.Enabled = true;
                }
                else
                {
                    secondUser = CardManager.getUser(id);
                    if (secondUser == null || firstUser.Id == secondUser.Id)
                    {
                        cardReader.Read(CardId);
                        return;
                    }
                    waititngSecondCardLabel.Visible = false;
                    SecondCardPanel.BackgroundImage = Properties.Resources.tick;
                    SecondCardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                    label2.Visible = true;
                    label2.Text = "New user: " + secondUser.Name;
                    if (DeadlineDate.SelectionStart > DateTime.Today && EquipmentList.SelectedIndex != -1)
                        SubmitButton.Enabled = true;
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

            headerLabel.Location = new Point(widthI, headerLabel.Location.Y);

            FirstCardPanel.Location = new Point(widthI, heightI);
            FirstCardPanel.Size = new Size(width, height);

            SecondCardPanel.Location = new Point(3 * widthI + width, heightI);
            SecondCardPanel.Size = new Size(width, height);

            DateBox.Location = new Point(widthI, 2 * heightI + height);
            DateBox.Size = new Size(DeadlineDate.Width + 25, DeadlineDate.Height + 25);

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
            if (firstUser != null && secondUser != null && EquipmentList.SelectedIndex != -1 && DeadlineDate.SelectionStart > DateTime.Today)
            {
                PrintSheet.PrintTransferSheet(firstUser, secondUser, equipments[EquipmentList.SelectedIndex], DeadlineDate.SelectionStart.ToShortDateString());
                Connector1C.returnEquipment(equipments[EquipmentList.SelectedIndex]);
                Connector1C.getEquipment(secondUser, equipments[EquipmentList.SelectedIndex]);
                cardReader.CloseConnection();
                this.Close();
            }
        }

        private void EquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondUser != null && DeadlineDate.SelectionStart > DateTime.Today)
                SubmitButton.Enabled = true;
        }

        private void DeadlineDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (secondUser != null && DeadlineDate.SelectionStart > DateTime.Today && EquipmentList.SelectedIndex != -1)
                SubmitButton.Enabled = true;
            else
                SubmitButton.Enabled = false;
        }
    }
}
