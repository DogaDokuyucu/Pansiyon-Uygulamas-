using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    public partial class ana_sayfa_form : Form
    {
        public ana_sayfa_form()
        {
            InitializeComponent();
        }

        private void b_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            giris_form fr = new giris_form();
            fr.Show();
        }

        private void b_musteri_Click(object sender, EventArgs e)
        {
            yeni_musteri_form fr1 = new yeni_musteri_form();
            this.Hide();
            fr1.FormClosed += (s, args) => this.Show();
            fr1.Show();
        }

        private void b_odalar_Click(object sender, EventArgs e)
        {
            odalar_form fr2 = new odalar_form();
            this.Hide();
            fr2.FormClosed += (s, args) => this.Show();
            fr2.Show();
        }

        private void b_musterigoruntule_Click(object sender, EventArgs e)
        {

        }

        private void b_musterigoruntule_Click_1(object sender, EventArgs e)
        {
            musteriler_form fr3 = new musteriler_form();
            this.Hide();
            fr3.FormClosed += (s, args) => this.Show();
            fr3.Show();
        }

        private void b_hakkimizda_Click(object sender, EventArgs e)
        {
            hakkimizda_form fr7 = new hakkimizda_form();
            this.Hide();
            fr7.FormClosed += (s, args) => this.Show();
            fr7.Show();
        }

        private void ana_sayfa_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void b_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            giris_form fr = new giris_form();
            fr.Show();
        }

        private void b_gelirgider_Click(object sender, EventArgs e)
        {
            gelir_gider_form fr4 = new gelir_gider_form();
            this.Hide();
            fr4.FormClosed += (s, args) => this.Show();
            fr4.Show();
        }

        private void b_stok_Click(object sender, EventArgs e)
        {
            stoklar_form fr5 = new stoklar_form();
            this.Hide();
            fr5.FormClosed += (s, args) => this.Show();
            fr5.Show();
        }

        private void b_radyo_Click(object sender, EventArgs e)
        {
            radyo_form fr6 = new radyo_form();
            this.Hide();
            fr6.FormClosed += (s, args) => this.Show();
            fr6.Show();
        }

        private void b_gazete_Click(object sender, EventArgs e)
        {
            gazete_form fr7 = new gazete_form();
            this.Hide();
            fr7.FormClosed += (s, args) => this.Show();
            fr7.Show();
        }

        private void b_hava_Click(object sender, EventArgs e)
        {
            sifre_form fr8 = new sifre_form();
            this.Hide();
            fr8.FormClosed += (s, args) => this.Show();
            fr8.Show();
        }

        private void b_mesaj_Click(object sender, EventArgs e)
        {
            mesaj_form fr9 = new mesaj_form();
            this.Hide();
            fr9.FormClosed += (s, args) => this.Show();
            fr9.Show();
        }
    }
}
