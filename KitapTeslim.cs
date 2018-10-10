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
    public partial class KitapTeslim : Form
    {
        public KitapTeslim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=KUTUPHANE;Trusted_Connection=True;");
        DataTable tbl = new DataTable();

        private void KitapTeslim_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from vwTeslimEtmeyenGetir", con);
            adp.Fill(tbl);
            dGridListe.DataSource = tbl;
        }

        private void dGridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti bag = new baglanti();            
            DialogResult teslimal = new DialogResult();
            teslimal = MessageBox.Show("Teslim Almak İstediğinize Emin misiniz?", "Teslim Alınsın mı?", MessageBoxButtons.YesNo);
            if (teslimal == DialogResult.Yes)
            {
                try
                {
                    bag.teslimAlma(Convert.ToInt32(dGridListe.Rows[e.RowIndex].Cells[0].Value), DateTime.Now);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
                dGridListe.Update();
                dGridListe.Refresh(); 
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
