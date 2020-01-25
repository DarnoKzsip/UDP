namespace Server
{
    partial class Form1
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
            this.NUD_Port = new System.Windows.Forms.NumericUpDown();
            this.LB_KomunikatyOdebrane = new System.Windows.Forms.ListBox();
            this.LAB_OdebraneKomunikaty = new System.Windows.Forms.Label();
            this.LB_Port = new System.Windows.Forms.Label();
            this.BTN_Uruchom = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // NUD_Port
            // 
            this.NUD_Port.Location = new System.Drawing.Point(217, 137);
            this.NUD_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Port.Name = "NUD_Port";
            this.NUD_Port.Size = new System.Drawing.Size(120, 20);
            this.NUD_Port.TabIndex = 0;
            this.NUD_Port.Value = new decimal(new int[] {
            3366,
            0,
            0,
            0});
            // 
            // LB_KomunikatyOdebrane
            // 
            this.LB_KomunikatyOdebrane.FormattingEnabled = true;
            this.LB_KomunikatyOdebrane.Location = new System.Drawing.Point(38, 26);
            this.LB_KomunikatyOdebrane.Name = "LB_KomunikatyOdebrane";
            this.LB_KomunikatyOdebrane.Size = new System.Drawing.Size(299, 95);
            this.LB_KomunikatyOdebrane.TabIndex = 1;
            // 
            // LAB_OdebraneKomunikaty
            // 
            this.LAB_OdebraneKomunikaty.AutoSize = true;
            this.LAB_OdebraneKomunikaty.Location = new System.Drawing.Point(38, 7);
            this.LAB_OdebraneKomunikaty.Name = "LAB_OdebraneKomunikaty";
            this.LAB_OdebraneKomunikaty.Size = new System.Drawing.Size(111, 13);
            this.LAB_OdebraneKomunikaty.TabIndex = 2;
            this.LAB_OdebraneKomunikaty.Text = "Odebrane komunikaty";
            // 
            // LB_Port
            // 
            this.LB_Port.AutoSize = true;
            this.LB_Port.Location = new System.Drawing.Point(182, 142);
            this.LB_Port.Name = "LB_Port";
            this.LB_Port.Size = new System.Drawing.Size(29, 13);
            this.LB_Port.TabIndex = 3;
            this.LB_Port.Text = "Port:";
            // 
            // BTN_Uruchom
            // 
            this.BTN_Uruchom.Location = new System.Drawing.Point(41, 137);
            this.BTN_Uruchom.Name = "BTN_Uruchom";
            this.BTN_Uruchom.Size = new System.Drawing.Size(75, 23);
            this.BTN_Uruchom.TabIndex = 4;
            this.BTN_Uruchom.Text = "Uruchom";
            this.BTN_Uruchom.UseVisualStyleBackColor = true;
            this.BTN_Uruchom.Click += new System.EventHandler(this.BTN_Uruchom_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(41, 167);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 5;
            this.BTN_Close.Text = "Zakoncz";
            this.BTN_Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 215);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Uruchom);
            this.Controls.Add(this.LB_Port);
            this.Controls.Add(this.LAB_OdebraneKomunikaty);
            this.Controls.Add(this.LB_KomunikatyOdebrane);
            this.Controls.Add(this.NUD_Port);
            this.Name = "Form1";
            this.Text = "Serwer";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.ListBox LB_KomunikatyOdebrane;
        private System.Windows.Forms.Label LAB_OdebraneKomunikaty;
        private System.Windows.Forms.Label LB_Port;
        private System.Windows.Forms.Button BTN_Uruchom;
        private System.Windows.Forms.Button BTN_Close;
    }
}

