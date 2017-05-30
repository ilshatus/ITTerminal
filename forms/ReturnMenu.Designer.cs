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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.EquipmentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GeneralPanel.SuspendLayout();
            this.EquipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.Controls.Add(this.EquipmentPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(722, 372);
            this.GeneralPanel.TabIndex = 0;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // EquipmentPanel
            // 
            this.EquipmentPanel.BackColor = System.Drawing.Color.OldLace;
            this.EquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EquipmentPanel.Controls.Add(this.label1);
            this.EquipmentPanel.Location = new System.Drawing.Point(241, 26);
            this.EquipmentPanel.Name = "EquipmentPanel";
            this.EquipmentPanel.Size = new System.Drawing.Size(227, 133);
            this.EquipmentPanel.TabIndex = 10;
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
            this.SubmitButton.Location = new System.Drawing.Point(563, 322);
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
            this.CloseButton.Location = new System.Drawing.Point(454, 322);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Back to Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReturnMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 396);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnMenu";
            this.Text = "ReturnMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReturnMenu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.EquipmentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel EquipmentPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
    }
}