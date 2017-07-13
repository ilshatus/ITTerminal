namespace ITTerminal
{
    partial class GetMenu
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EquipmentPanel = new System.Windows.Forms.Panel();
            this.waitingEquipmentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.DeadlineDate = new System.Windows.Forms.MonthCalendar();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.waititngCardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.EquipmentPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Enabled = false;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(581, 329);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.TabStop = false;
            this.SubmitButton.Text = "Submit";
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
            this.CloseButton.Location = new System.Drawing.Point(472, 329);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "Back to Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EquipmentPanel
            // 
            this.EquipmentPanel.BackColor = System.Drawing.Color.White;
            this.EquipmentPanel.BackgroundImage = global::ITTerminal.Properties.Resources.barcode_image;
            this.EquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquipmentPanel.Controls.Add(this.waitingEquipmentLabel);
            this.EquipmentPanel.Controls.Add(this.label2);
            this.EquipmentPanel.Location = new System.Drawing.Point(340, 21);
            this.EquipmentPanel.Name = "EquipmentPanel";
            this.EquipmentPanel.Size = new System.Drawing.Size(224, 133);
            this.EquipmentPanel.TabIndex = 3;
            // 
            // waitingEquipmentLabel
            // 
            this.waitingEquipmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitingEquipmentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitingEquipmentLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitingEquipmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.waitingEquipmentLabel.Location = new System.Drawing.Point(0, 0);
            this.waitingEquipmentLabel.Name = "waitingEquipmentLabel";
            this.waitingEquipmentLabel.Size = new System.Drawing.Size(222, 42);
            this.waitingEquipmentLabel.TabIndex = 7;
            this.waitingEquipmentLabel.Text = "Waiting for an equipment";
            this.waitingEquipmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 131);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneralPanel.Controls.Add(this.DateBox);
            this.GeneralPanel.Controls.Add(this.CardPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.EquipmentPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 36);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(709, 397);
            this.GeneralPanel.TabIndex = 5;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.DeadlineDate);
            this.DateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.ForeColor = System.Drawing.Color.White;
            this.DateBox.Location = new System.Drawing.Point(40, 173);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(189, 192);
            this.DateBox.TabIndex = 0;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Deadline date";
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeadlineDate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineDate.ForeColor = System.Drawing.SystemColors.Window;
            this.DeadlineDate.Location = new System.Drawing.Point(13, 18);
            this.DeadlineDate.MaxSelectionCount = 1;
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.TabIndex = 0;
            this.DeadlineDate.TabStop = false;
            this.DeadlineDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DeadlineDate_DateChanged);
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.White;
            this.CardPanel.BackgroundImage = global::ITTerminal.Properties.Resources.nfc_image;
            this.CardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.waititngCardLabel);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Location = new System.Drawing.Point(40, 21);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(227, 133);
            this.CardPanel.TabIndex = 4;
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
            this.waititngCardLabel.Text = "Waiting for a card";
            this.waititngCardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 131);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Location = new System.Drawing.Point(12, 1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(705, 29);
            this.Header.TabIndex = 5;
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
            this.headerLabel.Size = new System.Drawing.Size(202, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Get equipment";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 448);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.GeneralPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GetMenu";
            this.Text = "GetMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GetMenu_Load);
            this.EquipmentPanel.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.DateBox.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel EquipmentPanel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label waititngCardLabel;
        private System.Windows.Forms.Label waitingEquipmentLabel;
        private System.Windows.Forms.MonthCalendar DeadlineDate;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
    }
}