namespace KütüphaneTakipProgramı
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKitapListe = new System.Windows.Forms.Button();
            this.btnKitapEmanet = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapTeslim = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.ImageKey = "bookadd.png";
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(72, 66);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(111, 49);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "       Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bookadd.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "list.png");
            this.ımageList1.Images.SetKeyName(3, "tik.png");
            this.ımageList1.Images.SetKeyName(4, "handshake.png");
            this.ımageList1.Images.SetKeyName(5, "logout.png");
            // 
            // btnKitapListe
            // 
            this.btnKitapListe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnKitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapListe.ImageKey = "list.png";
            this.btnKitapListe.ImageList = this.ımageList1;
            this.btnKitapListe.Location = new System.Drawing.Point(26, 204);
            this.btnKitapListe.Name = "btnKitapListe";
            this.btnKitapListe.Size = new System.Drawing.Size(111, 49);
            this.btnKitapListe.TabIndex = 2;
            this.btnKitapListe.Text = "        Kitap Listesi";
            this.btnKitapListe.UseVisualStyleBackColor = false;
            this.btnKitapListe.Click += new System.EventHandler(this.btnKitapListe_Click);
            // 
            // btnKitapEmanet
            // 
            this.btnKitapEmanet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnKitapEmanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapEmanet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEmanet.ImageKey = "handshake.png";
            this.btnKitapEmanet.ImageList = this.ımageList1;
            this.btnKitapEmanet.Location = new System.Drawing.Point(39, 365);
            this.btnKitapEmanet.Name = "btnKitapEmanet";
            this.btnKitapEmanet.Size = new System.Drawing.Size(111, 49);
            this.btnKitapEmanet.TabIndex = 3;
            this.btnKitapEmanet.Text = "           Kitap Emanet";
            this.btnKitapEmanet.UseVisualStyleBackColor = false;
            this.btnKitapEmanet.Click += new System.EventHandler(this.btnKitapEmanet_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnKitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapSil.ImageKey = "delete.png";
            this.btnKitapSil.ImageList = this.ımageList1;
            this.btnKitapSil.Location = new System.Drawing.Point(523, 87);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(111, 49);
            this.btnKitapSil.TabIndex = 4;
            this.btnKitapSil.Text = "       Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = false;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapTeslim
            // 
            this.btnKitapTeslim.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnKitapTeslim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapTeslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapTeslim.ImageKey = "tik.png";
            this.btnKitapTeslim.ImageList = this.ımageList1;
            this.btnKitapTeslim.Location = new System.Drawing.Point(562, 214);
            this.btnKitapTeslim.Name = "btnKitapTeslim";
            this.btnKitapTeslim.Size = new System.Drawing.Size(111, 49);
            this.btnKitapTeslim.TabIndex = 5;
            this.btnKitapTeslim.Text = "         Kitap Teslim";
            this.btnKitapTeslim.UseVisualStyleBackColor = false;
            this.btnKitapTeslim.Click += new System.EventHandler(this.btnKitapTeslim_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "logout.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(562, 378);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(111, 49);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "          Oturum Kapat";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(708, 479);
            this.Controls.Add(this.btnKitapTeslim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKitapEmanet);
            this.Controls.Add(this.btnKitapListe);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Takip Programı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapListe;
        private System.Windows.Forms.Button btnKitapEmanet;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapTeslim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}