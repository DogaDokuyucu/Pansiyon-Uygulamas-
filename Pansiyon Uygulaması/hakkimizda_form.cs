using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    public partial class hakkimizda_form : Form
    {
        public hakkimizda_form()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;";

        private void hakkimizda_form_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Mesaj", 150);
            listView1.Columns.Add("Yıldız", 100);

            mesajlariGoster();
            yildizOrtalamasiHesapla();
        }

        private void mesajlariGoster()
        {
            listView1.Items.Clear();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand("SELECT * FROM Mesajlar", baglanti))
                    using (SqlDataReader oku = komut.ExecuteReader())
                    {
                        while (oku.Read())
                        {
                            ListViewItem ekle = new ListViewItem(oku["Mesaj_ID"].ToString());
                            ekle.SubItems.Add(oku["Mesaj"].ToString());

                            int yildizSayisi = Convert.ToInt32(oku["Yildiz"]);
                            string yildizlar = new string('★', yildizSayisi) + new string('☆', 5 - yildizSayisi);
                            ekle.SubItems.Add(yildizlar);

                            listView1.Items.Add(ekle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesajları gösterirken hata oluştu: " + ex.Message);
            }
        }

        private void yildizOrtalamasiHesapla()
        {
            double toplam = 0;
            int sayi = 0;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand("SELECT Yildiz FROM Mesajlar", baglanti))
                    using (SqlDataReader oku = komut.ExecuteReader())
                    {
                        while (oku.Read())
                        {
                            toplam += Convert.ToInt32(oku["Yildiz"]);
                            sayi++;
                        }
                    }
                }

                double ortalama = sayi > 0 ? toplam / sayi : 0;
                int tam = (int)Math.Round(ortalama);
                string yildizlar = new string('★', tam) + new string('☆', 5 - tam);
                lblYildizOrtalamasi.Text = $"{yildizlar} ({ortalama:0.00})";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yıldız ortalaması hesaplanamadı: " + ex.Message);
            }
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                tbMesajDetay.Text = e.Item.SubItems[1].Text;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                tbMesajDetay.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lblYildizOrtalamasi_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}