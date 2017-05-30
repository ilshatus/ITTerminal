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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.DeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.FirstCardPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SecondCardPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.FirstCardPanel.SuspendLayout();
            this.SecondCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.Controls.Add(this.DateBox);
            this.GeneralPanel.Controls.Add(this.FirstCardPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Controls.Add(this.SecondCardPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(672, 371);
            this.GeneralPanel.TabIndex = 0;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.DeadlineDate);
            this.DateBox.Location = new System.Drawing.Point(20, 184);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(310, 56);
            this.DateBox.TabIndex = 11;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Deadline date";
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeadlineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeadlineDate.Location = new System.Drawing.Point(20, 19);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.RightToLeftLayout = true;
            this.DeadlineDate.Size = new System.Drawing.Size(268, 20);
            this.DeadlineDate.TabIndex = 1;
            // 
            // FirstCardPanel
            // 
            this.FirstCardPanel.AutoScroll = true;
            this.FirstCardPanel.BackColor = System.Drawing.Color.OldLace;
            this.FirstCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstCardPanel.Controls.Add(this.label1);
            this.FirstCardPanel.Controls.Add(this.EquipmentList);
            this.FirstCardPanel.Location = new System.Drawing.Point(20, 17);
            this.FirstCardPanel.Name = "FirstCardPanel";
            this.FirstCardPanel.Size = new System.Drawing.Size(229, 133);
            this.FirstCardPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // EquipmentList
            // 
            this.EquipmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EquipmentList.BackColor = System.Drawing.Color.OldLace;
            this.EquipmentList.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EquipmentList.FormattingEnabled = true;
            this.EquipmentList.ItemHeight = 24;
            this.EquipmentList.Location = new System.Drawing.Point(3, 29);
            this.EquipmentList.Name = "EquipmentList";
            this.EquipmentList.Size = new System.Drawing.Size(219, 100);
            this.EquipmentList.TabIndex = 1;
            this.EquipmentList.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(561, 325);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 36);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(452, 325);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Back to Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SecondCardPanel
            // 
            this.SecondCardPanel.BackColor = System.Drawing.Color.OldLace;
            this.SecondCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondCardPanel.Controls.Add(this.label2);
            this.SecondCardPanel.Location = new System.Drawing.Point(320, 17);
            this.SecondCardPanel.Name = "SecondCardPanel";
            this.SecondCardPanel.Size = new System.Drawing.Size(224, 133);
            this.SecondCardPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 129);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // TransferMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 395);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferMenu";
            this.Text = "TransferMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransferMenu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.DateBox.ResumeLayout(false);
            this.FirstCardPanel.ResumeLayout(false);
            this.SecondCardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.DateTimePicker DeadlineDate;
        private System.Windows.Forms.Panel FirstCardPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SecondCardPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EquipmentList;
        private System.Windows.Forms.Label label1;
    }
}