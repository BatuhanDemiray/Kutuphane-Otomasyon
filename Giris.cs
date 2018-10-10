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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminGiris adm = new AdminGiris();
            adm.Show();
            this.Hide();
        }

        private void btnKullaniciPanel_Click(object sender, EventArgs e)
        {
            KullaniciGiris kul = new KullaniciGiris();
            kul.Show();
            this.Hide();
        }

        private void btnAdminEklePanel_Click(object sender, EventArgs e)
        {
            AdminEkle admekle = new AdminEkle();
            admekle.Show();
            this.Hide();
        }

        private void btnKulEklePanel_Click(object sender, EventArgs e)
        {
            KullaniciEkle kulekle = new KullaniciEkle();
            kulekle.Show();
            this.Hide();
        }
    }
}
