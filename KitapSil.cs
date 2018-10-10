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
    public partial class KitapSil : Form
    {
        public KitapSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti con = new baglanti();
            con.kitapCikar(txtFiltre.Text);
            txtFiltre.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
