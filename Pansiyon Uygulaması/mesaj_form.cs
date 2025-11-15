using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    public partial class mesaj_form : Form
    {
        public mesaj_form()
        {
            InitializeComponent();
        }

        int secilenYildiz = 0;
        string connectionString = @"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;";

        private void mesaj_form_Load(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void verilergoster()
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
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = oku["Mesaj_ID"].ToString();
                            ekle.SubItems.Add(oku["Adsoyad"].ToString());
                            ekle.SubItems.Add(oku["Mesaj"].ToString());
                            ekle.SubItems.Add(oku["Yildiz"].ToString());
                            listView1.Items.Add(ekle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri gösterme hatası: " + ex.Message);
            }
        }

        private void YildizSec(int yildizSayisi)
        {
            secilenYildiz = yildizSayisi;
            b_y1.BackColor = yildizSayisi >= 1 ? Color.Gold : Color.White;
            b_y2.BackColor = yildizSayisi >= 2 ? Color.Gold : Color.White;
            b_y3.BackColor = yildizSayisi >= 3 ? Color.Gold : Color.White;
            b_y4.BackColor = yildizSayisi >= 4 ? Color.Gold : Color.White;
            b_y5.BackColor = yildizSayisi >= 5 ? Color.Gold : Color.White;
        }

        private void b_y1_Click(object sender, EventArgs e) => YildizSec(1);
        private void b_y2_Click(object sender, EventArgs e) => YildizSec(2);
        private void b_y3_Click(object sender, EventArgs e) => YildizSec(3);
        private void b_y4_Click(object sender, EventArgs e) => YildizSec(4);
        private void b_y5_Click(object sender, EventArgs e) => YildizSec(5);

        // ------------------- Kaydet -------------------
        private void b_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ad.Text) || string.IsNullOrWhiteSpace(tb_mesaj.Text))
            {
                MessageBox.Show("Lütfen ad ve mesaj alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand(
                        "INSERT INTO Mesajlar (Adsoyad, Mesaj, Yildiz) VALUES (@ad, @mesaj, @yildiz)", baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", tb_ad.Text.Trim());
                        komut.Parameters.AddWithValue("@mesaj", tb_mesaj.Text.Trim());
                        komut.Parameters.AddWithValue("@yildiz", secilenYildiz);

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Mesaj başarıyla gönderildi.");

                verilergoster();

                secilenYildiz = 0;
                b_y1.BackColor = Color.White;
                b_y2.BackColor = Color.White;
                b_y3.BackColor = Color.White;
                b_y4.BackColor = Color.White;
                b_y5.BackColor = Color.White;

                tb_ad.Clear();
                tb_mesaj.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}