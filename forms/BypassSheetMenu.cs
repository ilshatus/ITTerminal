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
    partial class BypassSheetMenu : TerminalForm
    {
        private User user;
        private Equipment[] equipments;
        private CardReader cardReader;

        public BypassSheetMenu()
        {
            InitializeComponent();
            ////////////////////////
            CardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            ////////////////////////
            CloseButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            ///////////////////////
        }

        private void BypassSheetMenu_Load(object sender, EventArgs e)
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
                    return;
                }
                equipments = Connector1C.getListOfEquipment(user);
                waititngCardLabel.Visible = false;
                CardPanel.BackgroundImage = Properties.Resources.tick;
                CardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Visible = true;
                label1.Text = user.Name + ", you have following attached equipments:";
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
            int width = GeneralPanel.Width * 60 / 100;
            int height = GeneralPanel.Height * 70 / 100;
            int widthI = GeneralPanel.Width * 5 / 100;
            int heightI = GeneralPanel.Height * 5 / 100;

            headerLabel.Location = new Point(widthI, headerLabel.Location.Y);

            CardPanel.Location = new Point(4 * widthI, heightI);
            CardPanel.Size = new Size(width, height);
            int buttonWidth = GeneralPanel.Width * 15 / 100;
            int buttonHeight = GeneralPanel.Height * 10 / 100;
            CloseButton.Location = new Point(GeneralPanel.Width - buttonWidth - widthI, GeneralPanel.Height - buttonHeight - heightI);
            CloseButton.Size = new Size(buttonWidth, buttonHeight);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            cardReader.CloseConnection();
            this.Close();
        }
    }
}
