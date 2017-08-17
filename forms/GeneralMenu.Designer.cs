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
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.GeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.AutoSize = true;
            this.Get.BackColor = System.Drawing.Color.Transparent;
            this.Get.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Get.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Get.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Get.Location = new System.Drawing.Point(15, 13);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(556, 161);
            this.Get.TabIndex = 0;
            this.Get.TabStop = false;
            this.Get.Text = "Get Equipment / Получить оборудование";
            this.Get.UseVisualStyleBackColor = false;
            this.Get.Click += new System.EventHandler(this.GET_Click);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return.Location = new System.Drawing.Point(577, 13);
            this.Return.Name = "Return";
            this.Return.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return.Size = new System.Drawing.Size(586, 161);
            this.Return.TabIndex = 1;
            this.Return.TabStop = false;
            this.Return.Text = "Return Equipment / Вернуть оборудование";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transfer.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transfer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Transfer.Location = new System.Drawing.Point(15, 177);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(622, 161);
            this.Transfer.TabIndex = 2;
            this.Transfer.TabStop = false;
            this.Transfer.Text = "Transfer Equipment / Передать оборудование";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // GetBypassSheet
            // 
            this.GetBypassSheet.AutoSize = true;
            this.GetBypassSheet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GetBypassSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetBypassSheet.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetBypassSheet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetBypassSheet.Location = new System.Drawing.Point(282, 343);
            this.GetBypassSheet.Name = "GetBypassSheet";
            this.GetBypassSheet.Size = new System.Drawing.Size(591, 155);
            this.GetBypassSheet.TabIndex = 5;
            this.GetBypassSheet.TabStop = false;
            this.GetBypassSheet.Text = "Get Bypass Sheet / Получить обходной лист";
            this.GetBypassSheet.UseVisualStyleBackColor = true;
            this.GetBypassSheet.Click += new System.EventHandler(this.GetBypassSheet_Click);
            // 
            // Lost
            // 
            this.Lost.AutoSize = true;
            this.Lost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Lost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lost.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lost.Location = new System.Drawing.Point(15, 343);
            this.Lost.Name = "Lost";
            this.Lost.Size = new System.Drawing.Size(521, 155);
            this.Lost.TabIndex = 4;
            this.Lost.TabStop = false;
            this.Lost.Text = "Lost Equipment / Утеря оборудования";
            this.Lost.UseVisualStyleBackColor = true;
            this.Lost.Click += new System.EventHandler(this.Lost_Click);
            // 
            // Exchange
            // 
            this.Exchange.AutoSize = true;
            this.Exchange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exchange.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exchange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exchange.Location = new System.Drawing.Point(282, 180);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(647, 155);
            this.Exchange.TabIndex = 3;
            this.Exchange.TabStop = false;
            this.Exchange.Text = "Exchange Equipment / Обменять оборудование";
            this.Exchange.UseVisualStyleBackColor = true;
            this.Exchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPanel.Controls.Add(this.Get);
            this.GeneralPanel.Controls.Add(this.GetBypassSheet);
            this.GeneralPanel.Controls.Add(this.Return);
            this.GeneralPanel.Controls.Add(this.Lost);
            this.GeneralPanel.Controls.Add(this.Transfer);
            this.GeneralPanel.Controls.Add(this.Exchange);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(1070, 506);
            this.GeneralPanel.TabIndex = 6;
            this.GeneralPanel.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // GeneralMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 530);
            this.Controls.Add(this.GeneralPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button GetBypassSheet;
        private System.Windows.Forms.Button Lost;
        private System.Windows.Forms.Button Exchange;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Panel GeneralPanel;
    }
}