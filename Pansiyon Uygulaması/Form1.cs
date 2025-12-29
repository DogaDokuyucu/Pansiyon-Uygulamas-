using System.Data;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması
{
    public partial class giris_form : Form
    {
        public giris_form()
        {
            InitializeComponent();
        }

        public static string KullaniciRolu = "";


        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Rol FROM Admin_Giris WHERE Kullanici=@KullaniciAdi AND Sifre=@Sifre";

                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@KullaniciAdi", tb_ad.Text.Trim());
                    komut.Parameters.AddWithValue("@Sifre", tb_sif.Text.Trim());

                    baglanti.Open();
                    object rolObj = komut.ExecuteScalar();

                    if (rolObj != null)
                    {
                        KullaniciRolu = rolObj.ToString();

                        ana_sayfa_form fr = new ana_sayfa_form();
                        fr.FormClosed += (s, args) => this.Show();
                        this.Hide();
                        fr.Show();
                        tb_ad.Clear();
                        tb_sif.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!",
                                        "Giriş Başarısız",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }



        private void giris_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
