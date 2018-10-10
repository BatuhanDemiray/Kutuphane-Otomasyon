using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipProgramı
{
    public partial class KitapEmanet : Form
    {
        public KitapEmanet()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=KUTUPHANE;Trusted_Connection=True;");
        DataTable tbl = new DataTable();

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            if (txtAra.Text!=string.Empty)
            {
                KullaniciListe kul = new KullaniciListe();
                kul.lblISBN.Text = txtAra.Text;
                kul.ShowDialog();
                txtAra.Clear();
            }else
            {
                MessageBox.Show("Lütfen bir ISBN giriniz");
            }
        }

        private void KitapEmanet_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spKitapListe", con);
            adp.Fill(tbl);
            dGridListe.DataSource = tbl;
        }

        private void dGridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAra.Text = dGridListe.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
