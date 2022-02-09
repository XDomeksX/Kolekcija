namespace Kolekcije
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
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL4 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.TXTime = new System.Windows.Forms.TextBox();
            this.TXTgod = new System.Windows.Forms.TextBox();
            this.TXTprezime = new System.Windows.Forms.TextBox();
            this.CMBrod = new System.Windows.Forms.ComboBox();
            this.BTNunesi = new System.Windows.Forms.Button();
            this.BTNispisi = new System.Windows.Forms.Button();
            this.BTNobradi = new System.Windows.Forms.Button();
            this.RCBispis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(14, 15);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(59, 13);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Podatak 1:";
            // 
            // LBL4
            // 
            this.LBL4.AutoSize = true;
            this.LBL4.Location = new System.Drawing.Point(14, 93);
            this.LBL4.Name = "LBL4";
            this.LBL4.Size = new System.Drawing.Size(59, 13);
            this.LBL4.TabIndex = 1;
            this.LBL4.Text = "Podatak 4:";
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Location = new System.Drawing.Point(14, 41);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(59, 13);
            this.LBL2.TabIndex = 2;
            this.LBL2.Text = "Podatak 2:";
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Location = new System.Drawing.Point(14, 67);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(59, 13);
            this.LBL3.TabIndex = 3;
            this.LBL3.Text = "Podatak 3:";
            // 
            // TXTime
            // 
            this.TXTime.Location = new System.Drawing.Point(79, 12);
            this.TXTime.Name = "TXTime";
            this.TXTime.Size = new System.Drawing.Size(186, 20);
            this.TXTime.TabIndex = 4;
            // 
            // TXTgod
            // 
            this.TXTgod.Location = new System.Drawing.Point(79, 64);
            this.TXTgod.Name = "TXTgod";
            this.TXTgod.Size = new System.Drawing.Size(186, 20);
            this.TXTgod.TabIndex = 6;
            // 
            // TXTprezime
            // 
            this.TXTprezime.Location = new System.Drawing.Point(79, 38);
            this.TXTprezime.Name = "TXTprezime";
            this.TXTprezime.Size = new System.Drawing.Size(186, 20);
            this.TXTprezime.TabIndex = 7;
            // 
            // CMBrod
            // 
            this.CMBrod.FormattingEnabled = true;
            this.CMBrod.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.CMBrod.Location = new System.Drawing.Point(79, 90);
            this.CMBrod.Name = "CMBrod";
            this.CMBrod.Size = new System.Drawing.Size(186, 21);
            this.CMBrod.TabIndex = 8;
            // 
            // BTNunesi
            // 
            this.BTNunesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNunesi.Location = new System.Drawing.Point(272, 12);
            this.BTNunesi.Name = "BTNunesi";
            this.BTNunesi.Size = new System.Drawing.Size(132, 99);
            this.BTNunesi.TabIndex = 9;
            this.BTNunesi.Text = "Unesi";
            this.BTNunesi.UseVisualStyleBackColor = false;
            this.BTNunesi.Click += new System.EventHandler(this.BTNunesi_Click);
            // 
            // BTNispisi
            // 
            this.BTNispisi.BackColor = System.Drawing.Color.Lime;
            this.BTNispisi.Location = new System.Drawing.Point(548, 12);
            this.BTNispisi.Name = "BTNispisi";
            this.BTNispisi.Size = new System.Drawing.Size(132, 99);
            this.BTNispisi.TabIndex = 10;
            this.BTNispisi.Text = "Ispiši";
            this.BTNispisi.UseVisualStyleBackColor = false;
            this.BTNispisi.Click += new System.EventHandler(this.BTNispisi_Click);
            // 
            // BTNobradi
            // 
            this.BTNobradi.BackColor = System.Drawing.Color.Cyan;
            this.BTNobradi.Location = new System.Drawing.Point(410, 12);
            this.BTNobradi.Name = "BTNobradi";
            this.BTNobradi.Size = new System.Drawing.Size(132, 99);
            this.BTNobradi.TabIndex = 11;
            this.BTNobradi.Text = "Obradi";
            this.BTNobradi.UseVisualStyleBackColor = false;
            this.BTNobradi.Click += new System.EventHandler(this.BTNobradi_Click);
            // 
            // RCBispis
            // 
            this.RCBispis.Location = new System.Drawing.Point(13, 120);
            this.RCBispis.Name = "RCBispis";
            this.RCBispis.Size = new System.Drawing.Size(668, 318);
            this.RCBispis.TabIndex = 12;
            this.RCBispis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.RCBispis);
            this.Controls.Add(this.BTNobradi);
            this.Controls.Add(this.BTNispisi);
            this.Controls.Add(this.BTNunesi);
            this.Controls.Add(this.CMBrod);
            this.Controls.Add(this.TXTprezime);
            this.Controls.Add(this.TXTgod);
            this.Controls.Add(this.TXTime);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL4);
            this.Controls.Add(this.LBL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL4;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.TextBox TXTgod;
        private System.Windows.Forms.TextBox TXTprezime;
        private System.Windows.Forms.ComboBox CMBrod;
        private System.Windows.Forms.Button BTNunesi;
        private System.Windows.Forms.Button BTNispisi;
        private System.Windows.Forms.Button BTNobradi;
        private System.Windows.Forms.RichTextBox RCBispis;
        private System.Windows.Forms.TextBox TXTime;
    }
}

