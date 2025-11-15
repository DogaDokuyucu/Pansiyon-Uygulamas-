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

        SqlConnection baglanti = new SqlConnection(@"Data Source=DOĞA;Initial Catalog=Pansiyon_db;Integrated Security=True;");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Admin_Giris WHERE Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@Kullaniciadi", tb_ad.Text.Trim());
                    komut.Parameters.AddWithValue("@Sifresi", tb_sif.Text.Trim());

                    using (SqlDataAdapter da = new SqlDataAdapter(komut))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            ana_sayfa_form fr = new ana_sayfa_form();
                            this.Hide();
                            fr.ShowDialog();
                            tb_ad.Clear();
                            tb_sif.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
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
