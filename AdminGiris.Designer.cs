namespace KütüphaneTakipProgramı
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnAdminİptal = new System.Windows.Forms.Button();
            this.txtAdminAdi = new System.Windows.Forms.TextBox();
            this.txtAdminParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.Image")));
            this.btnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminGiris.Location = new System.Drawing.Point(76, 158);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(73, 27);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnAdminİptal
            // 
            this.btnAdminİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminİptal.Image")));
            this.btnAdminİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminİptal.Location = new System.Drawing.Point(173, 158);
            this.btnAdminİptal.Name = "btnAdminİptal";
            this.btnAdminİptal.Size = new System.Drawing.Size(73, 27);
            this.btnAdminİptal.TabIndex = 1;
            this.btnAdminİptal.Text = "  İptal";
            this.btnAdminİptal.UseVisualStyleBackColor = true;
            this.btnAdminİptal.Click += new System.EventHandler(this.btnAdminİptal_Click);
            // 
            // txtAdminAdi
            // 
            this.txtAdminAdi.Location = new System.Drawing.Point(142, 58);
            this.txtAdminAdi.Name = "txtAdminAdi";
            this.txtAdminAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdminAdi.TabIndex = 0;
            // 
            // txtAdminParola
            // 
            this.txtAdminParola.Location = new System.Drawing.Point(142, 95);
            this.txtAdminParola.Name = "txtAdminParola";
            this.txtAdminParola.PasswordChar = '*';
            this.txtAdminParola.Size = new System.Drawing.Size(100, 20);
            this.txtAdminParola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola : ";
            // 
            // chkHatirla
            // 
            this.chkHatirla.AutoSize = true;
            this.chkHatirla.Checked = true;
            this.chkHatirla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHatirla.ForeColor = System.Drawing.SystemColors.Info;
            this.chkHatirla.Location = new System.Drawing.Point(142, 135);
            this.chkHatirla.Name = "chkHatirla";
            this.chkHatirla.Size = new System.Drawing.Size(80, 17);
            this.chkHatirla.TabIndex = 2;
            this.chkHatirla.Text = "Beni Hatırla";
            this.chkHatirla.UseVisualStyleBackColor = true;
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(313, 209);
            this.Controls.Add(this.chkHatirla);
            this.Controls.Add(this.txtAdminAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminParola);
            this.Controls.Add(this.btnAdminİptal);
            this.Controls.Add(this.btnAdminGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.AdminGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnAdminİptal;
        private System.Windows.Forms.TextBox txtAdminAdi;
        private System.Windows.Forms.TextBox txtAdminParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHatirla;

    }
}