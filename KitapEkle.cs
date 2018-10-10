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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            baglanti con = new baglanti();
            con.kitapEkle(txtISBN.Text, txtKitapAd.Text, txtYazar.Text, txtSayfa.Text, txtTur.Text);
            txtISBN.Clear();
            txtKitapAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtTur.Clear();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
