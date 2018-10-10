namespace KütüphaneTakipProgramı
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.btnKullaniciİptal = new System.Windows.Forms.Button();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(142, 58);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola : ";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Location = new System.Drawing.Point(142, 95);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.PasswordChar = '*';
            this.txtKullaniciParola.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciParola.TabIndex = 5;
            // 
            // btnKullaniciİptal
            // 
            this.btnKullaniciİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciİptal.Image")));
            this.btnKullaniciİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciİptal.Location = new System.Drawing.Point(173, 149);
            this.btnKullaniciİptal.Name = "btnKullaniciİptal";
            this.btnKullaniciİptal.Size = new System.Drawing.Size(73, 27);
            this.btnKullaniciİptal.TabIndex = 7;
            this.btnKullaniciİptal.Text = "  İptal";
            this.btnKullaniciİptal.UseVisualStyleBackColor = true;
            this.btnKullaniciİptal.Click += new System.EventHandler(this.btnKullaniciİptal_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGiris.Image")));
            this.btnKullaniciGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(76, 149);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(73, 27);
            this.btnKullaniciGiris.TabIndex = 6;
            this.btnKullaniciGiris.Text = "Giriş Yap";
            this.btnKullaniciGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(313, 209);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciParola);
            this.Controls.Add(this.btnKullaniciİptal);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.Button btnKullaniciİptal;
        private System.Windows.Forms.Button btnKullaniciGiris;
    }
}