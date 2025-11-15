using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Pansiyon_Uygulaması
{
    public partial class gazete_form : Form
    {
        public gazete_form()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.sozcu.com.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.hurriyet.com.tr/");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.haberturk.com/");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
