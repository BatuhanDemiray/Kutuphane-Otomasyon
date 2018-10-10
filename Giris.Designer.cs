namespace KütüphaneTakipProgramı
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnKullaniciPanel = new System.Windows.Forms.Button();
            this.btnAdminEklePanel = new System.Windows.Forms.Button();
            this.btnKulEklePanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullaniciPanel
            // 
            this.btnKullaniciPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciPanel.Image")));
            this.btnKullaniciPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciPanel.Location = new System.Drawing.Point(191, 172);
            this.btnKullaniciPanel.Name = "btnKullaniciPanel";
            this.btnKullaniciPanel.Size = new System.Drawing.Size(100, 46);
            this.btnKullaniciPanel.TabIndex = 1;
            this.btnKullaniciPanel.Text = "Kullanıcı Giriş";
            this.btnKullaniciPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciPanel.UseVisualStyleBackColor = true;
            this.btnKullaniciPanel.Click += new System.EventHandler(this.btnKullaniciPanel_Click);
            // 
            // btnAdminEklePanel
            // 
            this.btnAdminEklePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminEklePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminEklePanel.Image")));
            this.btnAdminEklePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEklePanel.Location = new System.Drawing.Point(83, 237);
            this.btnAdminEklePanel.Name = "btnAdminEklePanel";
            this.btnAdminEklePanel.Size = new System.Drawing.Size(92, 23);
            this.btnAdminEklePanel.TabIndex = 3;
            this.btnAdminEklePanel.Text = "Admin Ekle";
            this.btnAdminEklePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminEklePanel.UseVisualStyleBackColor = true;
            this.btnAdminEklePanel.Click += new System.EventHandler(this.btnAdminEklePanel_Click);
            // 
            // btnKulEklePanel
            // 
            this.btnKulEklePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKulEklePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnKulEklePanel.Image")));
            this.btnKulEklePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKulEklePanel.Location = new System.Drawing.Point(181, 237);
            this.btnKulEklePanel.Name = "btnKulEklePanel";
            this.btnKulEklePanel.Size = new System.Drawing.Size(97, 23);
            this.btnKulEklePanel.TabIndex = 4;
            this.btnKulEklePanel.Text = "Kullanıcı Ekle";
            this.btnKulEklePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKulEklePanel.UseVisualStyleBackColor = true;
            this.btnKulEklePanel.Click += new System.EventHandler(this.btnKulEklePanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hazırlayan: Batuhan Demiray";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPanel.Image")));
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.Location = new System.Drawing.Point(65, 172);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(100, 46);
            this.btnAdminPanel.TabIndex = 0;
            this.btnAdminPanel.Text = " Admin Giriş";
            this.btnAdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(366, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKulEklePanel);
            this.Controls.Add(this.btnAdminEklePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKullaniciPanel);
            this.Controls.Add(this.btnAdminPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnKullaniciPanel;
        private System.Windows.Forms.Button btnAdminEklePanel;
        private System.Windows.Forms.Button btnKulEklePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

