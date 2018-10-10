namespace KütüphaneTakipProgramı
{
    partial class KitapEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEmanet));
            this.label1 = new System.Windows.Forms.Label();
            this.dGridListe = new System.Windows.Forms.DataGridView();
            this.btnEmanet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // dGridListe
            // 
            this.dGridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGridListe.Location = new System.Drawing.Point(0, 120);
            this.dGridListe.Name = "dGridListe";
            this.dGridListe.Size = new System.Drawing.Size(543, 155);
            this.dGridListe.TabIndex = 2;
            this.dGridListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridListe_CellDoubleClick);
            // 
            // btnEmanet
            // 
            this.btnEmanet.BackColor = System.Drawing.SystemColors.Info;
            this.btnEmanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanet.ImageKey = "handshake.png";
            this.btnEmanet.ImageList = this.ımageList1;
            this.btnEmanet.Location = new System.Drawing.Point(82, 65);
            this.btnEmanet.Name = "btnEmanet";
            this.btnEmanet.Size = new System.Drawing.Size(118, 33);
            this.btnEmanet.TabIndex = 3;
            this.btnEmanet.Text = "         Emanet Ver";
            this.btnEmanet.UseVisualStyleBackColor = false;
            this.btnEmanet.Click += new System.EventHandler(this.btnEmanet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "home2.png");
            this.ımageList1.Images.SetKeyName(1, "handshake.png");
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(66, 31);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(162, 20);
            this.txtAra.TabIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Info;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.ImageKey = "home2.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(370, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 41);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Ana Sayfa";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 45);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // KitapEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(543, 275);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnEmanet);
            this.Controls.Add(this.dGridListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Emanet";
            this.Load += new System.EventHandler(this.KitapEmanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGridListe;
        private System.Windows.Forms.Button btnEmanet;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}