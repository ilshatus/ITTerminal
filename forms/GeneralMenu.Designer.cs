namespace ITTerminal
{
    partial class GeneralMenu
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
            this.Get = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.GetBypassSheet = new System.Windows.Forms.Button();
            this.Lost = new System.Windows.Forms.Button();
            this.Exchange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.AutoSize = true;
            this.Get.Location = new System.Drawing.Point(15, 13);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(261, 161);
            this.Get.TabIndex = 0;
            this.Get.Text = "Get Equipment";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.GET_Click);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Location = new System.Drawing.Point(282, 13);
            this.Return.Name = "Return";
            this.Return.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return.Size = new System.Drawing.Size(263, 161);
            this.Return.TabIndex = 1;
            this.Return.Text = "Return Equipment";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.Location = new System.Drawing.Point(551, 13);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(235, 161);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Transfer Equipment";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // GetBypassSheet
            // 
            this.GetBypassSheet.AutoSize = true;
            this.GetBypassSheet.Location = new System.Drawing.Point(551, 191);
            this.GetBypassSheet.Name = "GetBypassSheet";
            this.GetBypassSheet.Size = new System.Drawing.Size(235, 155);
            this.GetBypassSheet.TabIndex = 5;
            this.GetBypassSheet.Text = "Get Bypass Sheet";
            this.GetBypassSheet.UseVisualStyleBackColor = true;
            this.GetBypassSheet.Click += new System.EventHandler(this.GetBypassSheet_Click);
            // 
            // Lost
            // 
            this.Lost.AutoSize = true;
            this.Lost.Location = new System.Drawing.Point(282, 191);
            this.Lost.Name = "Lost";
            this.Lost.Size = new System.Drawing.Size(263, 155);
            this.Lost.TabIndex = 4;
            this.Lost.Text = "Lost Equipment";
            this.Lost.UseVisualStyleBackColor = true;
            this.Lost.Click += new System.EventHandler(this.Lost_Click);
            // 
            // Exchange
            // 
            this.Exchange.AutoSize = true;
            this.Exchange.Location = new System.Drawing.Point(15, 191);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(261, 155);
            this.Exchange.TabIndex = 3;
            this.Exchange.Text = "Exchange Equipment";
            this.Exchange.UseVisualStyleBackColor = true;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Get);
            this.panel1.Controls.Add(this.GetBypassSheet);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.Lost);
            this.panel1.Controls.Add(this.Transfer);
            this.panel1.Controls.Add(this.Exchange);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 362);
            this.panel1.TabIndex = 6;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // GeneralMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(827, 386);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button GetBypassSheet;
        private System.Windows.Forms.Button Lost;
        private System.Windows.Forms.Button Exchange;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Panel panel1;
    }
}