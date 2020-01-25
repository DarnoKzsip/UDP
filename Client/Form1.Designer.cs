namespace Client
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
            this.TB_Adres = new System.Windows.Forms.TextBox();
            this.LB_Adres = new System.Windows.Forms.Label();
            this.NUD_Port = new System.Windows.Forms.NumericUpDown();
            this.LB_Port = new System.Windows.Forms.Label();
            this.LB_Hosty = new System.Windows.Forms.ListBox();
            this.BTN_Wyslij = new System.Windows.Forms.Button();
            this.TB_Wiadomosc = new System.Windows.Forms.TextBox();
            this.LB_Wiadomosc = new System.Windows.Forms.Label();
            this.LB_Odebrane = new System.Windows.Forms.ListBox();
            this.LB_Odpowiedz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Adres
            // 
            this.TB_Adres.Location = new System.Drawing.Point(29, 32);
            this.TB_Adres.Name = "TB_Adres";
            this.TB_Adres.Size = new System.Drawing.Size(208, 20);
            this.TB_Adres.TabIndex = 0;
            this.TB_Adres.Text = "127.0.0.1";
            // 
            // LB_Adres
            // 
            this.LB_Adres.AutoSize = true;
            this.LB_Adres.Location = new System.Drawing.Point(29, 13);
            this.LB_Adres.Name = "LB_Adres";
            this.LB_Adres.Size = new System.Drawing.Size(77, 13);
            this.LB_Adres.TabIndex = 1;
            this.LB_Adres.Text = "Adres serwera:";
            // 
            // NUD_Port
            // 
            this.NUD_Port.Location = new System.Drawing.Point(327, 32);
            this.NUD_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Port.Name = "NUD_Port";
            this.NUD_Port.Size = new System.Drawing.Size(120, 20);
            this.NUD_Port.TabIndex = 2;
            this.NUD_Port.Value = new decimal(new int[] {
            3366,
            0,
            0,
            0});
            // 
            // LB_Port
            // 
            this.LB_Port.AutoSize = true;
            this.LB_Port.Location = new System.Drawing.Point(327, 12);
            this.LB_Port.Name = "LB_Port";
            this.LB_Port.Size = new System.Drawing.Size(29, 13);
            this.LB_Port.TabIndex = 3;
            this.LB_Port.Text = "Port:";
            // 
            // LB_Hosty
            // 
            this.LB_Hosty.FormattingEnabled = true;
            this.LB_Hosty.Location = new System.Drawing.Point(32, 78);
            this.LB_Hosty.Name = "LB_Hosty";
            this.LB_Hosty.Size = new System.Drawing.Size(415, 82);
            this.LB_Hosty.TabIndex = 4;
            // 
            // BTN_Wyslij
            // 
            this.BTN_Wyslij.Location = new System.Drawing.Point(172, 333);
            this.BTN_Wyslij.Name = "BTN_Wyslij";
            this.BTN_Wyslij.Size = new System.Drawing.Size(94, 30);
            this.BTN_Wyslij.TabIndex = 5;
            this.BTN_Wyslij.Text = "Wyślij";
            this.BTN_Wyslij.UseVisualStyleBackColor = true;
            this.BTN_Wyslij.Click += new System.EventHandler(this.BTN_Wyslij_Click);
            // 
            // TB_Wiadomosc
            // 
            this.TB_Wiadomosc.Location = new System.Drawing.Point(29, 286);
            this.TB_Wiadomosc.Name = "TB_Wiadomosc";
            this.TB_Wiadomosc.Size = new System.Drawing.Size(415, 20);
            this.TB_Wiadomosc.TabIndex = 6;
            // 
            // LB_Wiadomosc
            // 
            this.LB_Wiadomosc.AutoSize = true;
            this.LB_Wiadomosc.Location = new System.Drawing.Point(26, 270);
            this.LB_Wiadomosc.Name = "LB_Wiadomosc";
            this.LB_Wiadomosc.Size = new System.Drawing.Size(92, 13);
            this.LB_Wiadomosc.TabIndex = 7;
            this.LB_Wiadomosc.Text = "Wpisz wiadomość";
            // 
            // LB_Odebrane
            // 
            this.LB_Odebrane.FormattingEnabled = true;
            this.LB_Odebrane.Location = new System.Drawing.Point(32, 183);
            this.LB_Odebrane.Name = "LB_Odebrane";
            this.LB_Odebrane.Size = new System.Drawing.Size(412, 69);
            this.LB_Odebrane.TabIndex = 8;
            // 
            // LB_Odpowiedz
            // 
            this.LB_Odpowiedz.AutoSize = true;
            this.LB_Odpowiedz.Location = new System.Drawing.Point(32, 164);
            this.LB_Odpowiedz.Name = "LB_Odpowiedz";
            this.LB_Odpowiedz.Size = new System.Drawing.Size(60, 13);
            this.LB_Odpowiedz.TabIndex = 9;
            this.LB_Odpowiedz.Text = "Odpowiedz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.LB_Odpowiedz);
            this.Controls.Add(this.LB_Odebrane);
            this.Controls.Add(this.LB_Wiadomosc);
            this.Controls.Add(this.TB_Wiadomosc);
            this.Controls.Add(this.BTN_Wyslij);
            this.Controls.Add(this.LB_Hosty);
            this.Controls.Add(this.LB_Port);
            this.Controls.Add(this.NUD_Port);
            this.Controls.Add(this.LB_Adres);
            this.Controls.Add(this.TB_Adres);
            this.Name = "Form1";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Adres;
        private System.Windows.Forms.Label LB_Adres;
        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.Label LB_Port;
        private System.Windows.Forms.ListBox LB_Hosty;
        private System.Windows.Forms.Button BTN_Wyslij;
        private System.Windows.Forms.TextBox TB_Wiadomosc;
        private System.Windows.Forms.Label LB_Wiadomosc;
        private System.Windows.Forms.ListBox LB_Odebrane;
        private System.Windows.Forms.Label LB_Odpowiedz;
    }
}

