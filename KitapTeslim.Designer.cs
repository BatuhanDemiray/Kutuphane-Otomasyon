namespace KütüphaneTakipProgramı
{
    partial class KitapTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapTeslim));
            this.dGridListe = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridListe
            // 
            this.dGridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGridListe.Location = new System.Drawing.Point(0, 89);
            this.dGridListe.Name = "dGridListe";
            this.dGridListe.Size = new System.Drawing.Size(744, 181);
            this.dGridListe.TabIndex = 0;
            this.dGridListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridListe_CellDoubleClick);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Info;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.ImageKey = "home2.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(312, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(111, 62);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "         Ana Sayfa";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "home2.png");
            // 
            // KitapTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(744, 270);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dGridListe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim";
            this.Load += new System.EventHandler(this.KitapTeslim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridListe;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}