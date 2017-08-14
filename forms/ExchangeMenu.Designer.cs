namespace ITTerminal
{
    partial class ExchangeMenu
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
            this.AdminCardPanel = new System.Windows.Forms.Panel();
            this.waititngCardLabelRus = new System.Windows.Forms.Label();
            this.waititngCardLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OldEquipmentPanel = new System.Windows.Forms.Panel();
            this.waitingOldEquipmentLabelRus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waitingOldEquipmentLabel = new System.Windows.Forms.Label();
            this.NewEquipmentPanel = new System.Windows.Forms.Panel();
            this.waitingNewEquipmentLabelRus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waitingNewEquipmentLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.AdminCardPanel.SuspendLayout();
            this.OldEquipmentPanel.SuspendLayout();
            this.NewEquipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(705, 29);
            this.Header.TabIndex = 12;
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
            this.headerLabel.Size = new System.Drawing.Size(612, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Exchange equipment / Обменять оборудование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralPanel.Controls.Add(this.MessageLabel);
            this.GeneralPanel.Controls.Add(this.DateBox);
            this.GeneralPanel.Controls.Add(this.AdminCardPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.OldEquipmentPanel);
            this.GeneralPanel.Controls.Add(this.NewEquipmentPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 52);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(708, 373);
            this.GeneralPanel.TabIndex = 6;
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
            this.MessageLabel.Location = new System.Drawing.Point(306, 138);
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
            this.DateBox.Location = new System.Drawing.Point(273, 168);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(189, 192);
            this.DateBox.TabIndex = 7;
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
            // AdminCardPanel
            // 
            this.AdminCardPanel.BackColor = System.Drawing.Color.White;
            this.AdminCardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.AdminCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminCardPanel.Controls.Add(this.waititngCardLabelRus);
            this.AdminCardPanel.Controls.Add(this.waititngCardLabel);
            this.AdminCardPanel.Controls.Add(this.label3);
            this.AdminCardPanel.Location = new System.Drawing.Point(40, 179);
            this.AdminCardPanel.Name = "AdminCardPanel";
            this.AdminCardPanel.Size = new System.Drawing.Size(227, 133);
            this.AdminCardPanel.TabIndex = 14;
            // 
            // waititngCardLabelRus
            // 
            this.waititngCardLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waititngCardLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waititngCardLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngCardLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngCardLabelRus.Location = new System.Drawing.Point(0, 71);
            this.waititngCardLabelRus.Name = "waititngCardLabelRus";
            this.waititngCardLabelRus.Size = new System.Drawing.Size(225, 60);
            this.waititngCardLabelRus.TabIndex = 7;
            this.waititngCardLabelRus.Text = "Ожидание карты администратора";
            this.waititngCardLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waititngCardLabel
            // 
            this.waititngCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.waititngCardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waititngCardLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngCardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngCardLabel.Location = new System.Drawing.Point(0, 0);
            this.waititngCardLabel.Name = "waititngCardLabel";
            this.waititngCardLabel.Size = new System.Drawing.Size(225, 42);
            this.waititngCardLabel.TabIndex = 6;
            this.waititngCardLabel.Text = "Waiting for an admin\'s card";
            this.waititngCardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 131);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(597, 324);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 11;
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
            this.CloseButton.Location = new System.Drawing.Point(488, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Back to Menu\r\nВернуться в меню";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OldEquipmentPanel
            // 
            this.OldEquipmentPanel.BackColor = System.Drawing.Color.OldLace;
            this.OldEquipmentPanel.BackgroundImage = global::ITTerminal.Properties.Resources.barcode_image;
            this.OldEquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OldEquipmentPanel.Controls.Add(this.waitingOldEquipmentLabelRus);
            this.OldEquipmentPanel.Controls.Add(this.label1);
            this.OldEquipmentPanel.Controls.Add(this.waitingOldEquipmentLabel);
            this.OldEquipmentPanel.Location = new System.Drawing.Point(40, 21);
            this.OldEquipmentPanel.Name = "OldEquipmentPanel";
            this.OldEquipmentPanel.Size = new System.Drawing.Size(227, 133);
            this.OldEquipmentPanel.TabIndex = 4;
            // 
            // waitingOldEquipmentLabelRus
            // 
            this.waitingOldEquipmentLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waitingOldEquipmentLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitingOldEquipmentLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingOldEquipmentLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingOldEquipmentLabelRus.Location = new System.Drawing.Point(0, 74);
            this.waitingOldEquipmentLabelRus.Name = "waitingOldEquipmentLabelRus";
            this.waitingOldEquipmentLabelRus.Size = new System.Drawing.Size(227, 59);
            this.waitingOldEquipmentLabelRus.TabIndex = 10;
            this.waitingOldEquipmentLabelRus.Text = "Ожидание старого оборудования";
            this.waitingOldEquipmentLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // waitingOldEquipmentLabel
            // 
            this.waitingOldEquipmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitingOldEquipmentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitingOldEquipmentLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingOldEquipmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingOldEquipmentLabel.Location = new System.Drawing.Point(0, 0);
            this.waitingOldEquipmentLabel.Name = "waitingOldEquipmentLabel";
            this.waitingOldEquipmentLabel.Size = new System.Drawing.Size(227, 42);
            this.waitingOldEquipmentLabel.TabIndex = 8;
            this.waitingOldEquipmentLabel.Text = "Waiting for an old equipment";
            this.waitingOldEquipmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewEquipmentPanel
            // 
            this.NewEquipmentPanel.BackColor = System.Drawing.Color.OldLace;
            this.NewEquipmentPanel.BackgroundImage = global::ITTerminal.Properties.Resources.barcode_image;
            this.NewEquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewEquipmentPanel.Controls.Add(this.waitingNewEquipmentLabelRus);
            this.NewEquipmentPanel.Controls.Add(this.label2);
            this.NewEquipmentPanel.Controls.Add(this.waitingNewEquipmentLabel);
            this.NewEquipmentPanel.Enabled = false;
            this.NewEquipmentPanel.Location = new System.Drawing.Point(340, 21);
            this.NewEquipmentPanel.Name = "NewEquipmentPanel";
            this.NewEquipmentPanel.Size = new System.Drawing.Size(224, 133);
            this.NewEquipmentPanel.TabIndex = 3;
            // 
            // waitingNewEquipmentLabelRus
            // 
            this.waitingNewEquipmentLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waitingNewEquipmentLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitingNewEquipmentLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingNewEquipmentLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingNewEquipmentLabelRus.Location = new System.Drawing.Point(0, 74);
            this.waitingNewEquipmentLabelRus.Name = "waitingNewEquipmentLabelRus";
            this.waitingNewEquipmentLabelRus.Size = new System.Drawing.Size(224, 59);
            this.waitingNewEquipmentLabelRus.TabIndex = 10;
            this.waitingNewEquipmentLabelRus.Text = "Ожидание нового оборудования";
            this.waitingNewEquipmentLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 91);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // waitingNewEquipmentLabel
            // 
            this.waitingNewEquipmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitingNewEquipmentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitingNewEquipmentLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingNewEquipmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingNewEquipmentLabel.Location = new System.Drawing.Point(0, 0);
            this.waitingNewEquipmentLabel.Name = "waitingNewEquipmentLabel";
            this.waitingNewEquipmentLabel.Size = new System.Drawing.Size(224, 42);
            this.waitingNewEquipmentLabel.TabIndex = 8;
            this.waitingNewEquipmentLabel.Text = "Waiting for a new equipment";
            this.waitingNewEquipmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ExchangeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(732, 437);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ExchangeMenu";
            this.Text = "ExchangeMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExchangeMenu_Load);
            this.Header.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.DateBox.ResumeLayout(false);
            this.AdminCardPanel.ResumeLayout(false);
            this.OldEquipmentPanel.ResumeLayout(false);
            this.NewEquipmentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel OldEquipmentPanel;
        private System.Windows.Forms.Panel NewEquipmentPanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label waitingOldEquipmentLabel;
        private System.Windows.Forms.Label waitingNewEquipmentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AdminCardPanel;
        private System.Windows.Forms.Label waititngCardLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.MonthCalendar DeadlineDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label waitingOldEquipmentLabelRus;
        private System.Windows.Forms.Label waitingNewEquipmentLabelRus;
        private System.Windows.Forms.Label waititngCardLabelRus;
    }
}