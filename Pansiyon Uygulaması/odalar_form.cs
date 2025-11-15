using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması
{
    public partial class odalar_form : Form
    {
        public odalar_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");



        private void b_101_Click(object sender, EventArgs e)
        {

        }

        private void odalar_form_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select*from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                b_101.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString();
            }

            if (b_101.Text != "101")
            {
                b_101.BackColor = Color.Red;
                b_101.ForeColor = Color.White;
            }

            baglanti.Close();

            baglanti.Open();



            SqlCommand komut2 = new SqlCommand("select*from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                b_102.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString();
            }
            baglanti.Close();

            if (b_102.Text != "102")
            {
                b_102.BackColor = Color.Red;
                b_102.ForeColor = Color.White;
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("select*from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                b_103.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString();
            }

            if (b_103.Text != "103")
            {
                b_103.BackColor = Color.Red;
                b_103.ForeColor = Color.White;

            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select*from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                b_104.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString();
            }

            if (b_104.Text != "104")
            {
                b_104.BackColor = Color.Red;
                b_104.ForeColor = Color.White;

            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select*from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();



            while (oku5.Read())
            {
                b_105.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString();
            }

            if (b_105.Text != "105")
            {
                b_105.BackColor = Color.Red;
                b_105.ForeColor = Color.White;

            }

            baglanti.Close();

            baglanti.Open();


            SqlCommand komut6 = new SqlCommand("select*from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                b_106.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString();
            }

            if (b_106.Text != "106")
            {
                b_106.BackColor = Color.Red;
                b_106.ForeColor = Color.White;

            }


            baglanti.Close();

            baglanti.Open();

            SqlCommand komut7 = new SqlCommand("select*from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                b_107.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString();
            }

            if (b_107.Text != "107")
            {
                b_107.BackColor = Color.Red;
                b_107.ForeColor = Color.White;

            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut8 = new SqlCommand("select*from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                b_108.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString();
            }

            if (b_108.Text != "108")
            {
                b_108.BackColor = Color.Red;
                b_108.ForeColor = Color.White;

            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut9 = new SqlCommand("select*from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                b_109.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString();
            }

            if (b_109.Text != "109")
            {
                b_109.BackColor = Color.Red;
                b_109.ForeColor = Color.White;

            }

            baglanti.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
