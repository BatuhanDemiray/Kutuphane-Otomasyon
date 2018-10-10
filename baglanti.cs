using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KütüphaneTakipProgramı
{
    class baglanti
    {
        string connectionString = "Server=.;Database=KUTUPHANE;Trusted_Connection=True;";
        SqlCommand komut;
        SqlConnection con;

        public void kullaniciEkle(string kadi, string parola, string isim, string soyisim, byte[] kullaniciFoto)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spKullaniciEkle";
            komut.Parameters.AddWithValue("@kadi", SqlDbType.NVarChar).Value = kadi;
            komut.Parameters.AddWithValue("@parola", SqlDbType.NVarChar).Value = parola;
            komut.Parameters.AddWithValue("@isim", SqlDbType.NVarChar).Value = isim;
            komut.Parameters.AddWithValue("@soyisim", SqlDbType.NVarChar).Value = soyisim;
            komut.Parameters.AddWithValue("@kullaniciFoto", SqlDbType.Image).Value = kullaniciFoto;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Eklendi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı Eklenemedi");
                }
                con.Close();
            }
        }
        public void adminEkle(string kadi, string parola, string isim, string soyisim, byte[] foto)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spAdminEkle";
            komut.Parameters.AddWithValue("@kadi", SqlDbType.NVarChar).Value = kadi;
            komut.Parameters.AddWithValue("@parola", SqlDbType.NVarChar).Value = parola;
            komut.Parameters.AddWithValue("@isim", SqlDbType.NVarChar).Value = isim;
            komut.Parameters.AddWithValue("@soyisim", SqlDbType.NVarChar).Value = soyisim;
            komut.Parameters.AddWithValue("@foto", SqlDbType.Image).Value = foto;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Admin Eklendi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Admin Eklenemedi");
                }
                con.Close();
            }
        }
        public bool kullaniciGirisKontrol(string kadi, string parola)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spKullaniciGiris";
            komut.Parameters.AddWithValue("@kadi", SqlDbType.NVarChar).Value = kadi;
            komut.Parameters.AddWithValue("@parola", SqlDbType.NVarChar).Value = parola;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    var a = komut.ExecuteScalar();
                    if (a != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı Giriş");
                    return false;
                }
            }
        }
        public bool adminGirisKontrol(string kadi, string parola)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spAdminGiris";
            komut.Parameters.AddWithValue("@kadi", SqlDbType.NVarChar).Value = kadi;
            komut.Parameters.AddWithValue("@parola", SqlDbType.NVarChar).Value = parola;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    var a = komut.ExecuteScalar();
                    if (a != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı Giriş");
                    return false;
                }
            }
        }
        public void kitapEkle(string ISBN, string Adi, string Yazar, string SayfaSayisi, string Turu)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spKitapEkle";
            komut.Parameters.AddWithValue("@ISBN", SqlDbType.NVarChar).Value = ISBN;
            komut.Parameters.AddWithValue("@Adi", SqlDbType.NVarChar).Value = Adi;
            komut.Parameters.AddWithValue("@Yazar", SqlDbType.NVarChar).Value = Yazar;
            komut.Parameters.AddWithValue("@SayfaSayisi", SqlDbType.NVarChar).Value = SayfaSayisi;
            komut.Parameters.AddWithValue("@Turu", SqlDbType.NVarChar).Value = Turu;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kitap Eklendi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kitap Eklenemedi");
                }
                con.Close();
            }
        }
        public void kitapCikar(string ISBN)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spKitapCikar";
            komut.Parameters.AddWithValue("@ISBN", SqlDbType.NVarChar).Value = ISBN;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
                con.Close();
            }
        }
        public void kitapListe(DataGridView dg) 
        {
            using (con = new SqlConnection(connectionString)) 
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("spKitapListe", con);
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    dg.DataSource = dt;

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }
                con.Close();
            }

            
        }
        public void kontrolGoster(DataGridView gv)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from vwTeslimEtmeyenGetir", con);
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    gv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                con.Close();
            }
        }
        public void emanetVerme(string ISBN, int KullaniciID, DateTime Verildi) 
        {
            Verildi = DateTime.Now;
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spEmanetVerme";
            komut.Parameters.AddWithValue("@ISBN", SqlDbType.NVarChar).Value = ISBN;
            komut.Parameters.AddWithValue("@KullaniciID", SqlDbType.Int).Value = KullaniciID;
            komut.Parameters.AddWithValue("@Verildi", SqlDbType.DateTime).Value = Verildi;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Emanet Verildi");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                con.Close();
            }
        }
        public void teslimAlma(int id, DateTime Alindi)
        {
            komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spTeslimAlma";
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            komut.Parameters.AddWithValue("@Alindi", SqlDbType.DateTime).Value = Alindi;
            using (con = new SqlConnection(connectionString))
            {
                komut.Connection = con;
                con.Open();
                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Teslim Alındı");
                }
                catch (Exception)
                {
                    MessageBox.Show("Teslim Alınamadı");
                }
                con.Close();
            }
        }


        internal void adminEkle()
        {
            throw new NotImplementedException();
        }
    }
}
