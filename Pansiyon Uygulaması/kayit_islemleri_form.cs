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
    public partial class kayit_islemleri_form : Form
    {
        public kayit_islemleri_form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void b_kaldir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ad.Text))
            {
                MessageBox.Show("Silmek için bir kullanıcı adı girin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullanici = tb_ad.Text.Trim();

            List<string> silinemez = new List<string>
    {
        "admin", "personel", "musteri"
    };

            if (silinemez.Contains(kullanici.ToLower()))
            {
                MessageBox.Show("Bu kullanıcı silinemez!", "Engellendi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(
                    @"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;"))
                {
                    baglanti.Open();

                    SqlCommand kontrol = new SqlCommand(
                        "SELECT COUNT(*) FROM Admin_Giris WHERE Kullanici=@k", baglanti);
                    kontrol.Parameters.AddWithValue("@k", kullanici);

                    int varMi = (int)kontrol.ExecuteScalar();

                    if (varMi == 0)
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SqlCommand sil = new SqlCommand(
                        "DELETE FROM Admin_Giris WHERE Kullanici=@k", baglanti);
                    sil.Parameters.AddWithValue("@k", kullanici);
                    sil.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı başarıyla silindi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_ad.Clear();
                    tb_sif.Clear();
                    cb_rol.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void b_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ad.Text) ||
                string.IsNullOrWhiteSpace(tb_sif.Text) ||
                cb_rol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Eksik Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(
                    @"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;"))
                {
                    baglanti.Open();

                    SqlCommand kontrol = new SqlCommand(
                        "SELECT COUNT(*) FROM Admin_Giris WHERE Kullanici=@k", baglanti);
                    kontrol.Parameters.AddWithValue("@k", tb_ad.Text.Trim());

                    int varMi = (int)kontrol.ExecuteScalar();

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı zaten kayıtlı!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SqlCommand ekle = new SqlCommand(
                        "INSERT INTO Admin_Giris (Kullanici, Sifre, Rol) VALUES (@k, @s, @r)", baglanti);

                    ekle.Parameters.AddWithValue("@k", tb_ad.Text.Trim());
                    ekle.Parameters.AddWithValue("@s", tb_sif.Text.Trim());
                    ekle.Parameters.AddWithValue("@r", cb_rol.SelectedItem.ToString());

                    ekle.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_ad.Clear();
                    tb_sif.Clear();
                    cb_rol.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
