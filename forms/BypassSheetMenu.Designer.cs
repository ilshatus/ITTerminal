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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.EquipmentList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
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
            this.GeneralPanel.Controls.Add(this.CloseButton);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(689, 373);
            this.GeneralPanel.TabIndex = 6;
            this.GeneralPanel.Resize += new System.EventHandler(this.GeneralPanel_Resize);
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.OldLace;
            this.CardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CardPanel.Controls.Add(this.EquipmentList);
            this.CardPanel.Controls.Add(this.label1);
            this.CardPanel.Location = new System.Drawing.Point(156, 26);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(397, 233);
            this.CardPanel.TabIndex = 4;
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
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(583, 334);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Back to Menu";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BypassSheetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 397);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BypassSheetMenu";
            this.ShowIcon = false;
            this.Text = "BypassSheetMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BypassSheetMenu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EquipmentList;
    }
}