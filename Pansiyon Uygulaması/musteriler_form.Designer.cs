namespace Pansiyon_Uygulaması
{
    partial class musteriler_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriler_form));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            b_verilerigoster = new Button();
            b_guncelle = new Button();
            b_sil = new Button();
            b_ara = new Button();
            cb_cin = new ComboBox();
            dtp_cikis = new DateTimePicker();
            dtp_giris = new DateTimePicker();
            mtb_tel = new MaskedTextBox();
            tb_ucret = new TextBox();
            tb_tc = new TextBox();
            tb_odanum = new TextBox();
            tb_mail = new TextBox();
            tb_soyad = new TextBox();
            tb_ad = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label10 = new Label();
            label3 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            b_temizle = new Button();
            tb_adara = new TextBox();
            panel1 = new Panel();
            label12 = new Label();
            button4 = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(12, 347);
            listView1.Name = "listView1";
            listView1.Size = new Size(1143, 243);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tc";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Oda No";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Giriş Tarihi";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Çıkış Tarihi";
            columnHeader11.Width = 120;
            // 
            // b_verilerigoster
            // 
            b_verilerigoster.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_verilerigoster.Location = new Point(952, 95);
            b_verilerigoster.Name = "b_verilerigoster";
            b_verilerigoster.Size = new Size(203, 41);
            b_verilerigoster.TabIndex = 8;
            b_verilerigoster.Text = "Verileri Göster";
            b_verilerigoster.UseVisualStyleBackColor = true;
            b_verilerigoster.Click += b_ekle_Click;
            // 
            // b_guncelle
            // 
            b_guncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_guncelle.Location = new Point(952, 142);
            b_guncelle.Name = "b_guncelle";
            b_guncelle.Size = new Size(203, 42);
            b_guncelle.TabIndex = 9;
            b_guncelle.Text = "Güncelle";
            b_guncelle.UseVisualStyleBackColor = true;
            b_guncelle.Click += b_guncelle_Click;
            // 
            // b_sil
            // 
            b_sil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_sil.Location = new Point(952, 190);
            b_sil.Name = "b_sil";
            b_sil.Size = new Size(203, 42);
            b_sil.TabIndex = 10;
            b_sil.Text = "Sil";
            b_sil.UseVisualStyleBackColor = true;
            b_sil.Click += b_sil_Click;
            // 
            // b_ara
            // 
            b_ara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_ara.Location = new Point(952, 293);
            b_ara.Name = "b_ara";
            b_ara.Size = new Size(203, 42);
            b_ara.TabIndex = 12;
            b_ara.Text = "Ara";
            b_ara.UseVisualStyleBackColor = true;
            b_ara.Click += b_ara_Click;
            // 
            // cb_cin
            // 
            cb_cin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cb_cin.FormattingEnabled = true;
            cb_cin.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cb_cin.Location = new Point(137, 181);
            cb_cin.Name = "cb_cin";
            cb_cin.Size = new Size(220, 36);
            cb_cin.TabIndex = 44;
            cb_cin.TabStop = false;
            // 
            // dtp_cikis
            // 
            dtp_cikis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtp_cikis.Location = new Point(626, 222);
            dtp_cikis.Name = "dtp_cikis";
            dtp_cikis.Size = new Size(276, 34);
            dtp_cikis.TabIndex = 43;
            dtp_cikis.TabStop = false;
            // 
            // dtp_giris
            // 
            dtp_giris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtp_giris.Location = new Point(626, 182);
            dtp_giris.Name = "dtp_giris";
            dtp_giris.Size = new Size(276, 34);
            dtp_giris.TabIndex = 42;
            dtp_giris.TabStop = false;
            // 
            // mtb_tel
            // 
            mtb_tel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            mtb_tel.Location = new Point(137, 224);
            mtb_tel.Mask = "(999) 000-0000";
            mtb_tel.Name = "mtb_tel";
            mtb_tel.Size = new Size(220, 34);
            mtb_tel.TabIndex = 2;
            // 
            // tb_ucret
            // 
            tb_ucret.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_ucret.Location = new Point(626, 142);
            tb_ucret.Name = "tb_ucret";
            tb_ucret.Size = new Size(276, 34);
            tb_ucret.TabIndex = 6;
            // 
            // tb_tc
            // 
            tb_tc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_tc.Location = new Point(137, 304);
            tb_tc.MaxLength = 11;
            tb_tc.Name = "tb_tc";
            tb_tc.Size = new Size(220, 34);
            tb_tc.TabIndex = 4;
            // 
            // tb_odanum
            // 
            tb_odanum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_odanum.Location = new Point(626, 102);
            tb_odanum.Name = "tb_odanum";
            tb_odanum.Size = new Size(276, 34);
            tb_odanum.TabIndex = 5;
            // 
            // tb_mail
            // 
            tb_mail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_mail.Location = new Point(137, 264);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(220, 34);
            tb_mail.TabIndex = 3;
            // 
            // tb_soyad
            // 
            tb_soyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_soyad.Location = new Point(137, 141);
            tb_soyad.Name = "tb_soyad";
            tb_soyad.Size = new Size(220, 34);
            tb_soyad.TabIndex = 1;
            // 
            // tb_ad
            // 
            tb_ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_ad.Location = new Point(137, 99);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(220, 34);
            tb_ad.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(499, 227);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 33;
            label9.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(466, 105);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 32;
            label6.Text = "Oda Numarası:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(501, 187);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 31;
            label8.Text = "Giriş Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(83, 307);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 30;
            label5.Text = "TC:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(34, 184);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 29;
            label10.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 224);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 28;
            label3.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(547, 145);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 27;
            label7.Text = "Ücret:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(67, 261);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 26;
            label4.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(45, 146);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 34;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 102);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 25;
            label1.Text = "Adı:";
            // 
            // b_temizle
            // 
            b_temizle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_temizle.Location = new Point(952, 238);
            b_temizle.Name = "b_temizle";
            b_temizle.Size = new Size(203, 42);
            b_temizle.TabIndex = 11;
            b_temizle.Text = "Temizle";
            b_temizle.UseVisualStyleBackColor = true;
            b_temizle.Click += b_temizle_Click;
            // 
            // tb_adara
            // 
            tb_adara.BackColor = Color.White;
            tb_adara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_adara.Location = new Point(626, 297);
            tb_adara.Name = "tb_adara";
            tb_adara.Size = new Size(276, 34);
            tb_adara.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-3, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 92);
            panel1.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.White;
            label12.Location = new Point(109, 39);
            label12.Name = "label12";
            label12.Size = new Size(125, 31);
            label12.TabIndex = 50;
            label12.Text = "Müşteriler";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1080, 23);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 49;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(18, 24);
            label11.Name = "label11";
            label11.Size = new Size(74, 50);
            label11.TabIndex = 48;
            label11.Text = "🏛";
            // 
            // musteriler_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1167, 602);
            Controls.Add(panel1);
            Controls.Add(tb_adara);
            Controls.Add(b_temizle);
            Controls.Add(cb_cin);
            Controls.Add(dtp_cikis);
            Controls.Add(dtp_giris);
            Controls.Add(mtb_tel);
            Controls.Add(tb_ucret);
            Controls.Add(tb_tc);
            Controls.Add(tb_odanum);
            Controls.Add(tb_mail);
            Controls.Add(tb_soyad);
            Controls.Add(tb_ad);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b_ara);
            Controls.Add(b_sil);
            Controls.Add(b_guncelle);
            Controls.Add(b_verilerigoster);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "musteriler_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteriler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button b_verilerigoster;
        private Button b_guncelle;
        private Button b_sil;
        private Button b_ara;
        private ComboBox cb_cin;
        private DateTimePicker dtp_cikis;
        private DateTimePicker dtp_giris;
        private MaskedTextBox mtb_tel;
        private TextBox tb_ucret;
        private TextBox tb_tc;
        private TextBox tb_odanum;
        private TextBox tb_mail;
        private TextBox tb_soyad;
        private TextBox tb_ad;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label10;
        private Label label3;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button b_temizle;
        private TextBox tb_adara;
        private Panel panel1;
        private Label label11;
        private Button button4;
        private Label label12;
    }
}