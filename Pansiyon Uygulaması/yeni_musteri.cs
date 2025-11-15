using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması
{
    public partial class yeni_musteri_form : Form
    {
        public yeni_musteri_form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");

        private void OdaDurumGuncelle()
        {
            var odalar = new Dictionary<string, Button>
    {
        { "Oda101", b_101 },
        { "Oda102", b_102 },
        { "Oda103", b_103 },
        { "Oda104", b_104 },
        { "Oda105", b_105 },
        { "Oda106", b_106 },
        { "Oda107", b_107 },
        { "Oda108", b_108 },
        { "Oda109", b_109 }
    };

            foreach (var oda in odalar)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand($"SELECT Ad, Soyad FROM {oda.Key}", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        string ad = oku["Ad"].ToString();
                        string soyad = oku["Soyad"].ToString();
                        oda.Value.Text = string.IsNullOrWhiteSpace(ad) ? oda.Key.Substring(3) : ad + " " + soyad;
                        oda.Value.BackColor = Color.Red;
                        oda.Value.ForeColor = Color.White;
                        oda.Value.Enabled = false;
                    }
                    else
                    {
                        oda.Value.Text = oda.Key.Substring(3);
                        oda.Value.BackColor = Color.Lime;
                        oda.Value.ForeColor = Color.Black;
                        oda.Value.Enabled = true;
                    }

                    oku.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oda güncelleme hatası: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }


        private void OdaSec(Button odaButon)
        {
            tb_odanum.Text = odaButon.Text;
        }

        private void b_101_Click(object sender, EventArgs e) => OdaSec(b_101);
        private void b_102_Click(object sender, EventArgs e) => OdaSec(b_102);
        private void b_103_Click(object sender, EventArgs e) => OdaSec(b_103);
        private void b_104_Click(object sender, EventArgs e) => OdaSec(b_104);
        private void b_105_Click(object sender, EventArgs e) => OdaSec(b_105);
        private void b_106_Click(object sender, EventArgs e) => OdaSec(b_106);
        private void b_107_Click(object sender, EventArgs e) => OdaSec(b_107);
        private void b_108_Click(object sender, EventArgs e) => OdaSec(b_108);
        private void b_109_Click(object sender, EventArgs e) => OdaSec(b_109);

        private void b_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_mail.Text) ||
                !Regex.IsMatch(tb_mail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cinsiyet = cb_cin.Text?.Trim() ?? "";
            if (!(cinsiyet.Equals("Kadın", StringComparison.OrdinalIgnoreCase) ||
                  cinsiyet.Equals("Erkek", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Lütfen cinsiyet alanından yalnızca 'Kadın' veya 'Erkek' seçiniz.", "Hatalı Cinsiyet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mtb_tel.MaskCompleted)
            {
                MessageBox.Show("Lütfen telefon numarasını eksiksiz giriniz.", "Hatalı Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tc = tb_tc.Text.Trim();
            if (!Regex.IsMatch(tc, @"^[1-9][0-9]{10}$"))
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_odanum.Text))
            {
                MessageBox.Show("Lütfen bir oda seçiniz.", "Oda Seçimi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;"))
                {
                    baglanti.Open();

                    using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Yeni_Musteri_Bilgi_Table WHERE TC = @tc", baglanti))
                    {
                        kontrolKomut.Parameters.AddWithValue("@tc", tc);
                        int kayitSayisi = (int)kontrolKomut.ExecuteScalar();
                        if (kayitSayisi > 0)
                        {
                            MessageBox.Show("Bu TC numarasına sahip bir müşteri zaten kayıtlı.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand ekleKomut = new SqlCommand(
                        "INSERT INTO Yeni_Musteri_Bilgi_Table " +
                        "(Ad, Soyad, Cinsiyet, Telefon, Mail, TC, Oda_No, Ucret, Giris_Tarihi, Cikis_Tarihi) " +
                        "VALUES (@ad, @soyad, @cinsiyet, @telefon, @mail, @tc, @odaNo, @ucret, @giris, @cikis)", baglanti))
                    {
                        ekleKomut.Parameters.AddWithValue("@ad", tb_ad.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@soyad", tb_soyad.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        ekleKomut.Parameters.AddWithValue("@telefon", mtb_tel.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@mail", tb_mail.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@tc", tc);
                        ekleKomut.Parameters.AddWithValue("@odaNo", tb_odanum.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@ucret", tb_ucret.Text.Trim());
                        ekleKomut.Parameters.AddWithValue("@giris", dtp_giris.Value.ToString("yyyy-MM-dd"));
                        ekleKomut.Parameters.AddWithValue("@cikis", dtp_cikis.Value.ToString("yyyy-MM-dd"));

                        ekleKomut.ExecuteNonQuery();
                    }

                    string odaTablo = "Oda" + tb_odanum.Text;
                    using (SqlCommand odaKomut = new SqlCommand($"INSERT INTO {odaTablo} (Ad, Soyad) VALUES (@ad, @soyad)", baglanti))
                    {
                        odaKomut.Parameters.AddWithValue("@ad", tb_ad.Text.Trim());
                        odaKomut.Parameters.AddWithValue("@soyad", tb_soyad.Text.Trim());
                        odaKomut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OdaDurumGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtp_cikis_ValueChanged(object sender, EventArgs e)
        {
            DateTime giris = dtp_giris.Value;
            DateTime cikis = dtp_cikis.Value;
            TimeSpan fark = cikis - giris;
            int gun = (int)fark.TotalDays;
            l_gun.Text = gun.ToString();
            tb_ucret.Text = (gun * 2000).ToString();
        }

        private void dtp_giris_ValueChanged(object sender, EventArgs e)
        {
            dtp_cikis_ValueChanged(sender, e);
        }

        private void yeni_musteri_form_Load(object sender, EventArgs e)
        {
            cb_cin.Items.Clear();
            cb_cin.Items.Add("Kadın");
            cb_cin.Items.Add("Erkek");
            cb_cin.DropDownStyle = ComboBoxStyle.DropDownList;

            OdaDurumGuncelle();
        }

        private void b_dolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void b_bos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
