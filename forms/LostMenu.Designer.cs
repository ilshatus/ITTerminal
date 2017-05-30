namespace ITTerminal
{
    partial class LostMenu
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.CardPanel.SuspendLayout();
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
            this.GeneralPanel.Controls.Add(this.CardPanel);
            this.GeneralPanel.Controls.Add(this.SubmitButton);
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(691, 374);
            this.GeneralPanel.TabIndex = 6;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
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
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.OldLace;
            this.CardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CardPanel.Controls.Add(this.EquipmentList);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Location = new System.Drawing.Point(153, 18);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(397, 233);
            this.CardPanel.TabIndex = 5;
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
            this.EquipmentList.Location = new System.Drawing.Point(4, 35);
            this.EquipmentList.Name = "EquipmentList";
            this.EquipmentList.Size = new System.Drawing.Size(386, 172);
            this.EquipmentList.TabIndex = 6;
            this.EquipmentList.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // LostMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 398);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LostMenu";
            this.Text = "LostMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LostMenu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.ListBox EquipmentList;
        private System.Windows.Forms.Label label1;
    }
}