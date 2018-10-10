namespace KütüphaneTakipProgramı
{
    partial class KullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkle));
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKullaniciKayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxResim = new System.Windows.Forms.PictureBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.Location = new System.Drawing.Point(150, 195);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(82, 24);
            this.btnIptal.TabIndex = 19;
            this.btnIptal.Text = " İptal";
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKullaniciKayit
            // 
            this.btnKullaniciKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciKayit.Image")));
            this.btnKullaniciKayit.Location = new System.Drawing.Point(62, 195);
            this.btnKullaniciKayit.Name = "btnKullaniciKayit";
            this.btnKullaniciKayit.Size = new System.Drawing.Size(82, 24);
            this.btnKullaniciKayit.TabIndex = 18;
            this.btnKullaniciKayit.Text = "Kayıt Ekle";
            this.btnKullaniciKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciKayit.UseVisualStyleBackColor = true;
            this.btnKullaniciKayit.Click += new System.EventHandler(this.btnKullaniciKayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(42, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(59, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(150, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(104, 153);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 20);
            this.txtSoyad.TabIndex = 13;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 114);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 20);
            this.txtAd.TabIndex = 12;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(104, 74);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(141, 20);
            this.txtParola.TabIndex = 11;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(104, 37);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(141, 20);
            this.txtKadi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(31, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxResim);
            this.groupBox1.Controls.Add(this.btnResimYukle);
            this.groupBox1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 225);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // picBoxResim
            // 
            this.picBoxResim.Location = new System.Drawing.Point(265, 33);
            this.picBoxResim.Name = "picBoxResim";
            this.picBoxResim.Size = new System.Drawing.Size(119, 105);
            this.picBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxResim.TabIndex = 22;
            this.picBoxResim.TabStop = false;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResimYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimYukle.Image")));
            this.btnResimYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimYukle.Location = new System.Drawing.Point(277, 144);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(90, 28);
            this.btnResimYukle.TabIndex = 23;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKullaniciKayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKullaniciKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxResim;
        private System.Windows.Forms.Button btnResimYukle;

    }
}