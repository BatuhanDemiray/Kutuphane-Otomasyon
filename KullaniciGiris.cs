using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipProgramı
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            baglanti db = new baglanti();
            try
            {
                RegistryKey register = Registry.CurrentUser;
                register = register.OpenSubKey("", true);
                string ad = (string)register.GetValue("ad");
                int oturum_sayisi = Convert.ToInt32(register.GetValue("oturum")) + 1;
                register.SetValue("oturum", oturum_sayisi);
                MessageBox.Show("Hoşgeldin " + ad + " Programı " + oturum_sayisi + " kez açtınız");
            }
            catch (Exception)
            {
                RegistryKey register = Registry.CurrentUser;
                register = register.CreateSubKey("");
                register.SetValue("ad", "");
                register.SetValue("Oturum", 1);
                MessageBox.Show("Oturumu ilkez açtınız");
            }
            string kuladi = txtKullaniciAdi.Text.ToString();
            string parola = txtKullaniciParola.Text.ToString();
            bool giris = db.kullaniciGirisKontrol(kuladi, parola);
            if (giris == true)
            {
                AnaEkran ana = new AnaEkran();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btnKullaniciİptal_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
