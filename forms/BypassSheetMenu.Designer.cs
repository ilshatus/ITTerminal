namespace ITTerminal
{
    partial class BypassSheetMenu
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.waititngCardLabelRus = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.waititngCardLabel = new System.Windows.Forms.Label();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Location = new System.Drawing.Point(17, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(705, 29);
            this.Header.TabIndex = 7;
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
            this.headerLabel.Size = new System.Drawing.Size(561, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Get bypass sheet / Получить обходной лист";
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
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.MessageLabel);
            this.GeneralPanel.Controls.Add(this.CardPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 53);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(710, 376);
            this.GeneralPanel.TabIndex = 6;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(591, 326);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Back to Menu\r\nВернуться в меню";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.OldLace;
            this.CardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.CardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.waititngCardLabelRus);
            this.CardPanel.Controls.Add(this.waititngCardLabel);
            this.CardPanel.Controls.Add(this.EquipmentList);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Location = new System.Drawing.Point(156, 26);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(397, 233);
            this.CardPanel.TabIndex = 4;
            // 
            // waititngCardLabelRus
            // 
            this.waititngCardLabelRus.BackColor = System.Drawing.Color.Transparent;
            this.waititngCardLabelRus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waititngCardLabelRus.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngCardLabelRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngCardLabelRus.Location = new System.Drawing.Point(0, 189);
            this.waititngCardLabelRus.Name = "waititngCardLabelRus";
            this.waititngCardLabelRus.Size = new System.Drawing.Size(395, 42);
            this.waititngCardLabelRus.TabIndex = 8;
            this.waititngCardLabelRus.Text = "Ожидание карты";
            this.waititngCardLabelRus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.MessageLabel.Location = new System.Drawing.Point(300, 154);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(95, 54);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "label3";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageLabel.UseCompatibleTextRendering = true;
            this.MessageLabel.Visible = false;
            // 
            // waititngCardLabel
            // 
            this.waititngCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.waititngCardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waititngCardLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waititngCardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waititngCardLabel.Location = new System.Drawing.Point(0, 51);
            this.waititngCardLabel.Name = "waititngCardLabel";
            this.waititngCardLabel.Size = new System.Drawing.Size(395, 42);
            this.waititngCardLabel.TabIndex = 7;
            this.waititngCardLabel.Text = "Waiting for a card";
            this.waititngCardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.EquipmentList.Location = new System.Drawing.Point(4, 54);
            this.EquipmentList.Name = "EquipmentList";
            this.EquipmentList.Size = new System.Drawing.Size(388, 172);
            this.EquipmentList.TabIndex = 6;
            this.EquipmentList.TabStop = false;
            this.EquipmentList.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BypassSheetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BypassSheetMenu";
            this.ShowIcon = false;
            this.Text = "BypassSheetMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BypassSheetMenu_Load);
            this.Header.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EquipmentList;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label waititngCardLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label waititngCardLabelRus;
    }
}