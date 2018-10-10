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
    public partial class KullaniciListe : Form
    {
        public KullaniciListe()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=KUTUPHANE;Trusted_Connection=True;");
        DataTable tbl = new DataTable();

        private void KullaniciListe_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kullanici", con);
            adp.Fill(tbl);
            dGridListe.DataSource = tbl;
        }

        private void dGridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti con = new baglanti();
            con.emanetVerme(lblISBN.Text, Convert.ToInt32(dGridListe.Rows[e.RowIndex].Cells[0].Value),DateTime.Now);
            this.Hide();
        }
    }
}
