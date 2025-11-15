using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    public partial class musteriler_form : Form
    {
        public musteriler_form()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;";

        private void verilergoster()
        {
            listView1.Items.Clear();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand("SELECT * FROM Yeni_Musteri_Bilgi_Table", baglanti))
                    using (SqlDataReader oku = komut.ExecuteReader())
                    {
                        while (oku.Read())
                        {
                            ListViewItem ekle = new ListViewItem(oku["Musteri_ID"].ToString());
                            ekle.SubItems.Add(oku["Ad"].ToString());
                            ekle.SubItems.Add(oku["Soyad"].ToString());
                            ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                            ekle.SubItems.Add(oku["Telefon"].ToString());
                            ekle.SubItems.Add(oku["Mail"].ToString());
                            ekle.SubItems.Add(oku["TC"].ToString());
                            ekle.SubItems.Add(oku["Oda_No"].ToString());
                            ekle.SubItems.Add(oku["Ucret"].ToString());
                            ekle.SubItems.Add(oku["Giris_Tarihi"].ToString());
                            ekle.SubItems.Add(oku["Cikis_Tarihi"].ToString());

                            listView1.Items.Add(ekle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                tb_ad.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tb_soyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cb_cin.Text = listView1.SelectedItems[0].SubItems[3].Text;
                mtb_tel.Text = listView1.SelectedItems[0].SubItems[4].Text;
                tb_mail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                tb_tc.Text = listView1.SelectedItems[0].SubItems[6].Text;
                tb_odanum.Text = listView1.SelectedItems[0].SubItems[7].Text;
                tb_ucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
                dtp_giris.Text = listView1.SelectedItems[0].SubItems[9].Text;
                dtp_cikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
            }
        }

        private void b_sil_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Önce silinecek müşteriyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();

                    if (!string.IsNullOrEmpty(tb_odanum.Text))
                    {
                        string odaTablo = "Oda" + tb_odanum.Text;
                        using (SqlCommand komutOda = new SqlCommand($"DELETE FROM {odaTablo}", baglanti))
                        {
                            komutOda.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand komut = new SqlCommand("DELETE FROM Yeni_Musteri_Bilgi_Table WHERE Musteri_ID = @id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", id);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilergoster();
                b_temizle_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void b_guncelle_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Önce güncellenecek müşteriyi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand(
                        "UPDATE Yeni_Musteri_Bilgi_Table SET " +
                        "Ad=@ad,Soyad=@soyad,Cinsiyet=@cinsiyet,Telefon=@telefon,Mail=@mail,TC=@tc,Oda_No=@odaNo,Ucret=@ucret,Giris_Tarihi=@giris,Cikis_Tarihi=@cikis " +
                        "WHERE Musteri_ID=@id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", tb_ad.Text.Trim());
                        komut.Parameters.AddWithValue("@soyad", tb_soyad.Text.Trim());
                        komut.Parameters.AddWithValue("@cinsiyet", cb_cin.Text.Trim());
                        komut.Parameters.AddWithValue("@telefon", mtb_tel.Text.Trim());
                        komut.Parameters.AddWithValue("@mail", tb_mail.Text.Trim());
                        komut.Parameters.AddWithValue("@tc", tb_tc.Text.Trim());
                        komut.Parameters.AddWithValue("@odaNo", tb_odanum.Text.Trim());
                        komut.Parameters.AddWithValue("@ucret", tb_ucret.Text.Trim());
                        komut.Parameters.AddWithValue("@giris", dtp_giris.Value.ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@cikis", dtp_cikis.Value.ToString("yyyy-MM-dd"));
                        komut.Parameters.AddWithValue("@id", id);

                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilergoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private void b_ekle_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void b_temizle_Click(object sender, EventArgs e)
        {
            tb_ad.Clear();
            tb_soyad.Clear();
            cb_cin.Text = "";
            mtb_tel.Clear();
            tb_mail.Clear();
            tb_tc.Clear();
            tb_odanum.Clear();
            tb_ucret.Clear();
            dtp_giris.Text = "";
            dtp_cikis.Text = "";
            id = 0;
        }

        private void b_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand(
                        "SELECT * FROM Yeni_Musteri_Bilgi_Table WHERE Ad LIKE @ad", baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", "%" + tb_adara.Text.Trim() + "%");
                        using (SqlDataReader oku = komut.ExecuteReader())
                        {
                            while (oku.Read())
                            {
                                ListViewItem ekle = new ListViewItem(oku["Musteri_ID"].ToString());
                                ekle.SubItems.Add(oku["Ad"].ToString());
                                ekle.SubItems.Add(oku["Soyad"].ToString());
                                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                                ekle.SubItems.Add(oku["Telefon"].ToString());
                                ekle.SubItems.Add(oku["Mail"].ToString());
                                ekle.SubItems.Add(oku["TC"].ToString());
                                ekle.SubItems.Add(oku["Oda_No"].ToString());
                                ekle.SubItems.Add(oku["Ucret"].ToString());
                                ekle.SubItems.Add(oku["Giris_Tarihi"].ToString());
                                ekle.SubItems.Add(oku["Cikis_Tarihi"].ToString());

                                listView1.Items.Add(ekle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
