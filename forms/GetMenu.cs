﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace ITTerminal
{
    partial class GetMenu : TerminalForm
    {
        private User user;
        private Equipment equipment;
        private CardReader cardReader;
        private BarcodeReader barcodeReader;

        public GetMenu()
        {
            InitializeComponent();
            ////////////////////////
            CardPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            EquipmentPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            //MessageLabel.BackColor = Color.FromArgb(50, 0, 0, 0);
            ////////////////////////
            CloseButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            SubmitButton.BackColor = Color.FromArgb(130, 255, 255, 255);
            SubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 255, 255, 255);
            ///////////////////////
        }

        private void GetMenu_Load(object sender, EventArgs e)
        {
            GeneralPanel_Resize(null, null);
            cardReader = new CardReader();
            cardReader.Read(CardId);
            barcodeReader = new BarcodeReader(this);
            barcodeReader.Read(EquipmentId);
        }

        public override void CardId(string id)
        {
            Action a = () =>
            {
                if (user == null)
                {
                    user = CardManager.getUser(id);
                    if (user == null)
                    {
                        cardReader.Read(CardId);
                        showMessage("User is not found / Пользователь не найден");
                        return;
                    }
                    waititngCardLabel.Visible = false;
                    waititngCardLabelRus.Visible = false;
                    CardPanel.BackgroundImage = Properties.Resources.tick;
                    CardPanel.BackgroundImageLayout = ImageLayout.Zoom;
                    label1.Visible = true;
                    label1.Text = "User (Пользователь): " + user.Name;
                }
            };
            BeginInvoke(a);
        }

        public override void EquipmentId(string id)
        {
            if (equipment == null)
            {
                equipment = Connector1C.getEquipmentByID(id);
                if (equipment != null)
                {
                    waitingEquipmentLabel.Visible = false;
                    waitingEquipmentLabelRus.Visible = false;
                    EquipmentPanel.BackgroundImage = Properties.Resources.tick;
                    label2.Visible = true;
                    label2.Text = "Equipment (Оборудование): " + equipment.Name;
                }
                else
                {
                    barcodeReader.Read(EquipmentId);
                    showMessage("Equipment is not found / Оборудование не найдено");
                }
            }
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

            headerLabel.Location = new Point(widthI, headerLabel.Location.Y);

            CardPanel.Location = new Point(widthI, heightI);
            CardPanel.Size = new Size(width, height);
            CardPanel.MaximumSize = new Size(width, height);

            EquipmentPanel.Location = new Point(3 * widthI + width, heightI);
            EquipmentPanel.Size = new Size(width, height);
            EquipmentPanel.MaximumSize = new Size(width, height);

            DateBox.Location = new Point(widthI, 2 * heightI + height);
            DateBox.Size = new Size(DeadlineDate.Width + 25, DeadlineDate.Height + 25);

            int buttonWidth = GeneralPanel.Width * 15 / 100;
            int buttonHeight = GeneralPanel.Height * 10 / 100;

            SubmitButton.Location = new Point(GeneralPanel.Width - buttonWidth - widthI, GeneralPanel.Height - buttonHeight - heightI);
            SubmitButton.Size = new Size(buttonWidth, buttonHeight);

            CloseButton.Location = new Point(SubmitButton.Location.X - buttonWidth - widthI / 2, SubmitButton.Location.Y);
            CloseButton.Size = new Size(buttonWidth, buttonHeight);
            ////////////////
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
            else if (equipment == null)
            {
                showMessage("Equipment is not found / Оборудование не найдено");
            }
            else if (DeadlineDate.SelectionStart <= DateTime.Today)
            {
                showMessage("Chosen date is unavailable / Выбранная дата недоступна");
            }
            else
            {
                PrintSheet.PrintGetSheet(user, equipment, DeadlineDate.SelectionStart.ToShortDateString());
                Connector1C.getEquipment(user, equipment);
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
