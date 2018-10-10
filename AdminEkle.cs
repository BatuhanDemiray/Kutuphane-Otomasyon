using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;

namespace KütüphaneTakipProgramı
{
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }

        private void btnAdminKayit_Click(object sender, EventArgs e)
        {
            baglanti con = new baglanti();
            if (resimYol == null)
            {
                MessageBox.Show("Lütfen Bir Fotoğraf Seçiniz");
            }
            FileStream fs = new FileStream(resimYol, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            con.adminEkle(txtKadi.Text, txtParola.Text, txtAd.Text, txtSoyad.Text, resim);
            txtKadi.Clear();
            txtParola.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            picBoxResim.Hide();  
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        string resimYol;
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "JPG |*.jpg | PNG |*.png";
            foto.Title = "Bir Fotoğraf Seçin";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                picBoxResim.Image = Image.FromFile(foto.FileName);
                resimYol = foto.FileName.ToString();
            }
        }
    }
}