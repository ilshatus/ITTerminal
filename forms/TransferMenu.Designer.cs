namespace ITTerminal
{
    partial class TransferMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Header = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.DeadlineDate = new System.Windows.Forms.MonthCalendar();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FirstCardPanel = new System.Windows.Forms.Panel();
            this.waititngFirstCardLabelRus = new System.Windows.Forms.Label();
            this.waititngFirstCardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.SecondCardPanel = new System.Windows.Forms.Panel();
            this.waititngSecondCardLabelRus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waititngSecondCardLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.FirstCardPanel.SuspendLayout();
            this.SecondCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Location = new System.Drawing.Point(16, 22);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(705, 29);
            this.Header.TabIndex = 6;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.headerLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.headerLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(53, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(595, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Transfer equipment / Передать оборудования";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.Controls.Add(this.MessageLabel);
            this.GeneralPanel.Controls.Add(this.DateBox);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.FirstCardPanel);
            this.GeneralPanel.Controls.Add(this.SecondCardPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 77);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(713, 375);
            this.GeneralPanel.TabIndex = 0;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AllowDrop = true;
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Location = new System.Drawing.Point(301, 140);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(95, 54);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "label3";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageLabel.UseCompatibleTextRendering = true;
            this.MessageLabel.Visible = false;
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.DeadlineDate);
            this.DateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.ForeColor = System.Drawing.Color.White;
            this.DateBox.Location = new System.Drawing.Point(20, 168);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(189, 192);
            this.DateBox.TabIndex = 14;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Deadline date / Срок сдачи";
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeadlineDate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeadlineDate.Location = new System.Drawing.Point(13, 18);
            this.DeadlineDate.MaxSelectionCount = 1;
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.TabIndex = 0;
            this.DeadlineDate.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(608, 333);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Text = "Submit\r\nПодтвердить";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(499, 333);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Back to Menu\r\nВернуться в меню";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FirstCardPanel
            // 
            this.FirstCardPanel.AutoScroll = true;
            this.FirstCardPanel.BackColor = System.Drawing.Color.OldLace;
            this.FirstCardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.FirstCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FirstCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstCardPanel.Controls.Add(this.waititngFirstCardLabelRus);
            this.FirstCardPanel.Controls.Add(this.waititngFirstCardLabel);
            this.FirstCardPanel.Controls.Add(this.label1);
            this.FirstCardPanel.Controls.Add(this.EquipmentList);
            this.FirstCardPanel.Location = new System.Drawing.Point(20, 17);
            this.FirstCardPanel.Name = "FirstCardPanel";
            this.FirstCardPanel.Size = new System.Drawing.Size(229, 133);
            this.FirstCardPanel.TabIndex = 10;
            // 
            // waititngFirstCardLabelRus
            // 
            this.waititngFirstCardLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waititngFirstCardLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waititngFirstCardLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngFirstCardLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngFirstCardLabelRus.Location = new System.Drawing.Point(0, 92);
            this.waititngFirstCardLabelRus.Name = "waititngFirstCardLabelRus";
            this.waititngFirstCardLabelRus.Size = new System.Drawing.Size(210, 58);
            this.waititngFirstCardLabelRus.TabIndex = 8;
            this.waititngFirstCardLabelRus.Text = "Ожидание карты старого пользователя";
            this.waititngFirstCardLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waititngFirstCardLabel
            // 
            this.waititngFirstCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.waititngFirstCardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waititngFirstCardLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngFirstCardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngFirstCardLabel.Location = new System.Drawing.Point(0, 50);
            this.waititngFirstCardLabel.Name = "waititngFirstCardLabel";
            this.waititngFirstCardLabel.Size = new System.Drawing.Size(210, 42);
            this.waititngFirstCardLabel.TabIndex = 7;
            this.waititngFirstCardLabel.Text = "Waiting for an old user\'s card";
            this.waititngFirstCardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // EquipmentList
            // 
            this.EquipmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EquipmentList.BackColor = System.Drawing.Color.White;
            this.EquipmentList.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EquipmentList.FormattingEnabled = true;
            this.EquipmentList.ItemHeight = 24;
            this.EquipmentList.Location = new System.Drawing.Point(3, 53);
            this.EquipmentList.Name = "EquipmentList";
            this.EquipmentList.Size = new System.Drawing.Size(204, 52);
            this.EquipmentList.TabIndex = 1;
            this.EquipmentList.Visible = false;
            // 
            // SecondCardPanel
            // 
            this.SecondCardPanel.BackColor = System.Drawing.Color.OldLace;
            this.SecondCardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.SecondCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SecondCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondCardPanel.Controls.Add(this.waititngSecondCardLabelRus);
            this.SecondCardPanel.Controls.Add(this.label2);
            this.SecondCardPanel.Controls.Add(this.waititngSecondCardLabel);
            this.SecondCardPanel.Enabled = false;
            this.SecondCardPanel.Location = new System.Drawing.Point(320, 17);
            this.SecondCardPanel.Name = "SecondCardPanel";
            this.SecondCardPanel.Size = new System.Drawing.Size(224, 133);
            this.SecondCardPanel.TabIndex = 9;
            // 
            // waititngSecondCardLabelRus
            // 
            this.waititngSecondCardLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waititngSecondCardLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waititngSecondCardLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngSecondCardLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngSecondCardLabelRus.Location = new System.Drawing.Point(0, 73);
            this.waititngSecondCardLabelRus.Name = "waititngSecondCardLabelRus";
            this.waititngSecondCardLabelRus.Size = new System.Drawing.Size(222, 58);
            this.waititngSecondCardLabelRus.TabIndex = 9;
            this.waititngSecondCardLabelRus.Text = "Ожидание карты нового пользователя";
            this.waititngSecondCardLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 89);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // waititngSecondCardLabel
            // 
            this.waititngSecondCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.waititngSecondCardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waititngSecondCardLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngSecondCardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngSecondCardLabel.Location = new System.Drawing.Point(0, 0);
            this.waititngSecondCardLabel.Name = "waititngSecondCardLabel";
            this.waititngSecondCardLabel.Size = new System.Drawing.Size(222, 42);
            this.waititngSecondCardLabel.TabIndex = 7;
            this.waititngSecondCardLabel.Text = "Waiting for a new user\'s card";
            this.waititngSecondCardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TransferMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 464);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TransferMenu";
            this.Text = "TransferMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransferMenu_Load);
            this.Header.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.DateBox.ResumeLayout(false);
            this.FirstCardPanel.ResumeLayout(false);
            this.SecondCardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel FirstCardPanel;
        private System.Windows.Forms.Panel SecondCardPanel;
        private System.Windows.Forms.ListBox EquipmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label waititngSecondCardLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label waititngFirstCardLabel;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.MonthCalendar DeadlineDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label waititngSecondCardLabelRus;
        private System.Windows.Forms.Label waititngFirstCardLabelRus;
    }
}