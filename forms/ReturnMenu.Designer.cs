namespace ITTerminal
{
    partial class ReturnMenu
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
            this.AdminCardPanel = new System.Windows.Forms.Panel();
            this.waititngCardLabelRus = new System.Windows.Forms.Label();
            this.waititngCardLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EquipmentPanel = new System.Windows.Forms.Panel();
            this.waitingEquipmentLabelRus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waitingEquipmentLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.AdminCardPanel.SuspendLayout();
            this.EquipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Location = new System.Drawing.Point(13, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(705, 29);
            this.Header.TabIndex = 11;
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
            this.headerLabel.Size = new System.Drawing.Size(560, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Return equipment / Вернуть оборудование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.Controls.Add(this.MessageLabel);
            this.GeneralPanel.Controls.Add(this.AdminCardPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.EquipmentPanel);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 47);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(710, 370);
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
            this.MessageLabel.Location = new System.Drawing.Point(306, 143);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(95, 54);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "label3";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageLabel.UseCompatibleTextRendering = true;
            this.MessageLabel.Visible = false;
            // 
            // AdminCardPanel
            // 
            this.AdminCardPanel.BackColor = System.Drawing.Color.White;
            this.AdminCardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.AdminCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminCardPanel.Controls.Add(this.waititngCardLabelRus);
            this.AdminCardPanel.Controls.Add(this.waititngCardLabel);
            this.AdminCardPanel.Controls.Add(this.label2);
            this.AdminCardPanel.Location = new System.Drawing.Point(406, 31);
            this.AdminCardPanel.Name = "AdminCardPanel";
            this.AdminCardPanel.Size = new System.Drawing.Size(227, 133);
            this.AdminCardPanel.TabIndex = 11;
            // 
            // waititngCardLabelRus
            // 
            this.waititngCardLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waititngCardLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waititngCardLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngCardLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngCardLabelRus.Location = new System.Drawing.Point(0, 72);
            this.waititngCardLabelRus.Name = "waititngCardLabelRus";
            this.waititngCardLabelRus.Size = new System.Drawing.Size(225, 59);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 131);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(608, 324);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Text = "Submit\r\nПодтвердить";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EquipmentPanel
            // 
            this.EquipmentPanel.BackColor = System.Drawing.Color.White;
            this.EquipmentPanel.BackgroundImage = global::ITTerminal.Properties.Resources.barcode_image;
            this.EquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquipmentPanel.Controls.Add(this.waitingEquipmentLabelRus);
            this.EquipmentPanel.Controls.Add(this.label1);
            this.EquipmentPanel.Controls.Add(this.waitingEquipmentLabel);
            this.EquipmentPanel.Location = new System.Drawing.Point(78, 32);
            this.EquipmentPanel.Name = "EquipmentPanel";
            this.EquipmentPanel.Size = new System.Drawing.Size(227, 133);
            this.EquipmentPanel.TabIndex = 10;
            // 
            // waitingEquipmentLabelRus
            // 
            this.waitingEquipmentLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waitingEquipmentLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitingEquipmentLabelRus.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingEquipmentLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingEquipmentLabelRus.Location = new System.Drawing.Point(0, 89);
            this.waitingEquipmentLabelRus.Name = "waitingEquipmentLabelRus";
            this.waitingEquipmentLabelRus.Size = new System.Drawing.Size(225, 42);
            this.waitingEquipmentLabelRus.TabIndex = 10;
            this.waitingEquipmentLabelRus.Text = "Ожидание оборудования";
            this.waitingEquipmentLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 89);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // waitingEquipmentLabel
            // 
            this.waitingEquipmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitingEquipmentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitingEquipmentLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingEquipmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingEquipmentLabel.Location = new System.Drawing.Point(0, 0);
            this.waitingEquipmentLabel.Name = "waitingEquipmentLabel";
            this.waitingEquipmentLabel.Size = new System.Drawing.Size(225, 42);
            this.waitingEquipmentLabel.TabIndex = 8;
            this.waitingEquipmentLabel.Text = "Waiting for an equipment";
            this.waitingEquipmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(499, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Back to Menu\r\nВернуться в меню";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ReturnMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(734, 429);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ReturnMenu";
            this.Text = "ReturnMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReturnMenu_Load);
            this.Header.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.AdminCardPanel.ResumeLayout(false);
            this.EquipmentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel EquipmentPanel;
        private System.Windows.Forms.Label waitingEquipmentLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AdminCardPanel;
        private System.Windows.Forms.Label waititngCardLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label waitingEquipmentLabelRus;
        private System.Windows.Forms.Label waititngCardLabelRus;
    }
}