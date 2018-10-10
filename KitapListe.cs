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
using Excel = Microsoft.Office.Interop.Excel;

namespace KütüphaneTakipProgramı
{
    public partial class KitapListe : Form
    {
        public KitapListe()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=.;Database=KUTUPHANE;Trusted_Connection=True;");
        DataTable tbl = new DataTable();
        
        private void KitapListe_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spKitapListe", con);
            adp.Fill(tbl);
            dGridListe.DataSource = tbl;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable("Kitaplar");
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Kitaplar where Adi like @Adi", con);
                adp.SelectCommand.Parameters.AddWithValue("@Adi", txtAra.Text + "%");
                con.Open();
                adp.Fill(tbl);
                dGridListe.DataSource = tbl.DefaultView;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }


        Excel.Application uyg;
        Excel.Workbook ktp;
        Excel.Worksheet syf;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable("Kitaplar");
            DataRow dr;
            SqlConnection con=new SqlConnection("Server=.;Database=KUTUPHANE;Trusted_Connection=True;");
            SqlDataAdapter adp;
            uyg=new Excel.Application();
            ktp=uyg.Workbooks.Add();
            syf = (Excel.Worksheet)ktp.Worksheets.get_Item(1);
            string aktar = "select * from Kitaplar";
            adp = new SqlDataAdapter(aktar, con);
            adp.Fill(dt);
            for (int i = 1; i < dt.Columns.Count+1; i++)
            {
                for (int a = 1; a < dt.Rows.Count+1; a++)
                {
                    dr = dt.Rows[a - 1];
                    syf.Cells[a, i] = dr[i - 1].ToString();
                }
            }
            ktp.SaveAs(Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\KitapListe.xls");
            ktp.Close();
            uyg.Quit();
            MessageBox.Show("Başarıyla Masaüstüne Kaydedildi");
        }

    }
}
