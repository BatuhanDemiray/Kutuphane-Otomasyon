namespace KütüphaneTakipProgramı
{
    partial class KullaniciListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListe));
            this.dGridListe = new System.Windows.Forms.DataGridView();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridListe
            // 
            this.dGridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGridListe.Location = new System.Drawing.Point(0, 78);
            this.dGridListe.Name = "dGridListe";
            this.dGridListe.Size = new System.Drawing.Size(445, 178);
            this.dGridListe.TabIndex = 0;
            this.dGridListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridListe_CellDoubleClick);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.SystemColors.Info;
            this.lblISBN.Location = new System.Drawing.Point(217, 35);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(162, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN :";
            // 
            // KullaniciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(445, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.dGridListe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Liste";
            this.Load += new System.EventHandler(this.KullaniciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridListe;
        public System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
    }
}