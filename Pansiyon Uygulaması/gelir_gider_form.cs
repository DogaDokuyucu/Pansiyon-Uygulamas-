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

namespace Pansiyon_Uygulaması
{
    public partial class gelir_gider_form : Form
    {
        public gelir_gider_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void b_hesapla_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(tb_personel.Text);
            l_personel.Text = (personel * 40000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(l_toplam.Text) - (Convert.ToInt32(l_personel.Text) + Convert.ToInt32(l_gida.Text) + Convert.ToInt32(l_icecek.Text) + Convert.ToInt32(l_cerez.Text) + Convert.ToInt32(l_elek.Text) + Convert.ToInt32(l_su.Text) + Convert.ToInt32(l_int.Text));
            l_sonuc.Text = sonuc.ToString();

        }

        private void gelir_gider_form_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from Yeni_Musteri_Bilgi_Table", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                l_toplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();






            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                l_gida.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                l_icecek.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();





            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                l_cerez.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                l_elek.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                l_su.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                l_int.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
