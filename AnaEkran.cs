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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle ktpekle = new KitapEkle();
            ktpekle.Show();
            this.Hide();
        }

        private void btnKitapListe_Click(object sender, EventArgs e)
        {
            KitapListe ktplis = new KitapListe();
            ktplis.Show();
            this.Hide();
        }

        private void btnKitapEmanet_Click(object sender, EventArgs e)
        {
            KitapEmanet ktpemanet = new KitapEmanet();
            ktpemanet.Show();
            this.Hide();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            KitapSil ktpsil = new KitapSil();
            ktpsil.Show();
            this.Hide();
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            KitapTeslim ktpteslim = new KitapTeslim();
            ktpteslim.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
    }
}
