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
    public partial class sifre_form : Form
    {
        public sifre_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "UPDATE Admin_Giris SET Kullanici = @Kullanici, Sifre = @Sifre",
                baglanti);
            komut.Parameters.AddWithValue("@Kullanici", tb_ad.Text);
            komut.Parameters.AddWithValue("@Sifre", tb_sifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void tb_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
