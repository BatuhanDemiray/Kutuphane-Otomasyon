using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace KütüphaneTakipProgramı
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            baglanti db = new baglanti();
            if (chkHatirla.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Kutuphane", true);
                key.SetValue("Kadi", txtAdminAdi.Text);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Kutuphane", true);
                try
                {
                    key.SetValue("Kadi", string.Empty);
                }
                catch (Exception)
                {
                    throw;
                }
            }
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
                MessageBox.Show("Oturumu ilk kez açtınız");
            }
            string kuladi = txtAdminAdi.Text.ToString();
            string parola = txtAdminParola.Text.ToString();
            bool giris = db.adminGirisKontrol(kuladi, parola);
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

        private void btnAdminİptal_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            string[] a = Registry.CurrentUser.GetSubKeyNames();
            foreach (string klasor in a)
            {
                if (klasor == "Kutuphane")
                {
                    string[] b = Registry.CurrentUser.OpenSubKey("Kutuphane", true).GetValueNames();
                    foreach (var item in b)
                    {
                        if (item != "Kadi")
                        {
                            Registry.CurrentUser.OpenSubKey("Kutuphane", true).SetValue("Kadi", string.Empty);
                        }
                        else
                        { 
                            txtAdminAdi.Text = Registry.CurrentUser.OpenSubKey("Kutuphane").GetValue("Kadi").ToString();
                        }
                    }
                }
                else
                {
                    Registry.CurrentUser.CreateSubKey("Kutuphane");
                    string[] b = Registry.CurrentUser.OpenSubKey("Kutuphane", true).GetValueNames();
                    foreach (var item in b)
                    {
                        if (item != "Kadi")
                        {
                            Registry.CurrentUser.OpenSubKey("Kutuphane", true).SetValue("Kadi", string.Empty);
                        }
                    }
                }
            }
        }



    }
}
