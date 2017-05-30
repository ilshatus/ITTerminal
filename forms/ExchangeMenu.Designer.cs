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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.DeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.OldEquipmentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewEquipmentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.OldEquipmentPanel.SuspendLayout();
            this.NewEquipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralPanel.Controls.Add(this.DateBox);
            this.GeneralPanel.Controls.Add(this.OldEquipmentPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.NewEquipmentPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(692, 377);
            this.GeneralPanel.TabIndex = 6;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.DeadlineDate);
            this.DateBox.Location = new System.Drawing.Point(40, 160);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(227, 56);
            this.DateBox.TabIndex = 6;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Deadline date";
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeadlineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeadlineDate.Location = new System.Drawing.Point(6, 19);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.RightToLeftLayout = true;
            this.DeadlineDate.Size = new System.Drawing.Size(215, 20);
            this.DeadlineDate.TabIndex = 1;
            // 
            // OldEquipmentPanel
            // 
            this.OldEquipmentPanel.BackColor = System.Drawing.Color.OldLace;
            this.OldEquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OldEquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OldEquipmentPanel.Controls.Add(this.label1);
            this.OldEquipmentPanel.Location = new System.Drawing.Point(40, 21);
            this.OldEquipmentPanel.Name = "OldEquipmentPanel";
            this.OldEquipmentPanel.Size = new System.Drawing.Size(227, 133);
            this.OldEquipmentPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 129);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(581, 329);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(472, 329);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Back to Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewEquipmentPanel
            // 
            this.NewEquipmentPanel.BackColor = System.Drawing.Color.OldLace;
            this.NewEquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewEquipmentPanel.Controls.Add(this.label2);
            this.NewEquipmentPanel.Location = new System.Drawing.Point(340, 21);
            this.NewEquipmentPanel.Name = "NewEquipmentPanel";
            this.NewEquipmentPanel.Size = new System.Drawing.Size(224, 133);
            this.NewEquipmentPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 129);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // ExchangeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 401);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExchangeMenu";
            this.Text = "ExchangeMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExchangeMenu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.DateBox.ResumeLayout(false);
            this.OldEquipmentPanel.ResumeLayout(false);
            this.NewEquipmentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.DateTimePicker DeadlineDate;
        private System.Windows.Forms.Panel OldEquipmentPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel NewEquipmentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}