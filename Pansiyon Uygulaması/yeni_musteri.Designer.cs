namespace Pansiyon_Uygulaması
{
    partial class yeni_musteri_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeni_musteri_form));
            b_bos = new Button();
            b_dolu = new Button();
            groupBox1 = new GroupBox();
            cb_cin = new ComboBox();
            b_kaydet = new Button();
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
            l_gun = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            b_106 = new Button();
            b_109 = new Button();
            b_105 = new Button();
            b_108 = new Button();
            b_107 = new Button();
            b_103 = new Button();
            b_104 = new Button();
            b_102 = new Button();
            b_101 = new Button();
            panel1 = new Panel();
            label13 = new Label();
            button4 = new Button();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b_bos
            // 
            b_bos.BackColor = Color.Lime;
            b_bos.Enabled = false;
            b_bos.FlatAppearance.BorderSize = 0;
            b_bos.FlatStyle = FlatStyle.Flat;
            b_bos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_bos.Location = new Point(1061, 595);
            b_bos.Name = "b_bos";
            b_bos.Size = new Size(128, 81);
            b_bos.TabIndex = 5;
            b_bos.Text = "Bos";
            b_bos.UseVisualStyleBackColor = false;
            // 
            // b_dolu
            // 
            b_dolu.BackColor = Color.Red;
            b_dolu.Enabled = false;
            b_dolu.FlatAppearance.BorderSize = 0;
            b_dolu.FlatStyle = FlatStyle.Flat;
            b_dolu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_dolu.Location = new Point(872, 591);
            b_dolu.Name = "b_dolu";
            b_dolu.Size = new Size(128, 81);
            b_dolu.TabIndex = 5;
            b_dolu.Text = "Dolu";
            b_dolu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_cin);
            groupBox1.Controls.Add(b_kaydet);
            groupBox1.Controls.Add(dtp_cikis);
            groupBox1.Controls.Add(dtp_giris);
            groupBox1.Controls.Add(mtb_tel);
            groupBox1.Controls.Add(tb_ucret);
            groupBox1.Controls.Add(tb_tc);
            groupBox1.Controls.Add(tb_odanum);
            groupBox1.Controls.Add(tb_mail);
            groupBox1.Controls.Add(tb_soyad);
            groupBox1.Controls.Add(tb_ad);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(l_gun);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(71, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 572);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // cb_cin
            // 
            cb_cin.FormattingEnabled = true;
            cb_cin.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cb_cin.Location = new Point(199, 160);
            cb_cin.Name = "cb_cin";
            cb_cin.Size = new Size(274, 36);
            cb_cin.TabIndex = 2;
            cb_cin.TabStop = false;
            // 
            // b_kaydet
            // 
            b_kaydet.BackColor = Color.FromArgb(44, 62, 80);
            b_kaydet.FlatAppearance.BorderSize = 0;
            b_kaydet.FlatStyle = FlatStyle.Flat;
            b_kaydet.ForeColor = Color.White;
            b_kaydet.Location = new Point(239, 503);
            b_kaydet.Name = "b_kaydet";
            b_kaydet.Size = new Size(123, 51);
            b_kaydet.TabIndex = 6;
            b_kaydet.Text = "Kaydet";
            b_kaydet.UseVisualStyleBackColor = false;
            b_kaydet.Click += b_kaydet_Click;
            // 
            // dtp_cikis
            // 
            dtp_cikis.Location = new Point(199, 447);
            dtp_cikis.Name = "dtp_cikis";
            dtp_cikis.Size = new Size(274, 34);
            dtp_cikis.TabIndex = 22;
            dtp_cikis.TabStop = false;
            dtp_cikis.ValueChanged += dtp_cikis_ValueChanged;
            // 
            // dtp_giris
            // 
            dtp_giris.Location = new Point(199, 409);
            dtp_giris.Name = "dtp_giris";
            dtp_giris.Size = new Size(274, 34);
            dtp_giris.TabIndex = 21;
            dtp_giris.TabStop = false;
            // 
            // mtb_tel
            // 
            mtb_tel.Location = new Point(199, 204);
            mtb_tel.Mask = "(999) 000-0000";
            mtb_tel.Name = "mtb_tel";
            mtb_tel.Size = new Size(274, 34);
            mtb_tel.TabIndex = 2;
            // 
            // tb_ucret
            // 
            tb_ucret.Location = new Point(199, 369);
            tb_ucret.Name = "tb_ucret";
            tb_ucret.Size = new Size(274, 34);
            tb_ucret.TabIndex = 5;
            // 
            // tb_tc
            // 
            tb_tc.Location = new Point(199, 287);
            tb_tc.MaxLength = 11;
            tb_tc.Name = "tb_tc";
            tb_tc.Size = new Size(274, 34);
            tb_tc.TabIndex = 4;
            // 
            // tb_odanum
            // 
            tb_odanum.Location = new Point(199, 329);
            tb_odanum.Name = "tb_odanum";
            tb_odanum.ReadOnly = true;
            tb_odanum.Size = new Size(274, 34);
            tb_odanum.TabIndex = 16;
            tb_odanum.TabStop = false;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(199, 247);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(274, 34);
            tb_mail.TabIndex = 3;
            // 
            // tb_soyad
            // 
            tb_soyad.Location = new Point(199, 118);
            tb_soyad.Name = "tb_soyad";
            tb_soyad.Size = new Size(274, 34);
            tb_soyad.TabIndex = 1;
            // 
            // tb_ad
            // 
            tb_ad.Location = new Point(199, 71);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(274, 34);
            tb_ad.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 447);
            label9.Name = "label9";
            label9.Size = new Size(107, 28);
            label9.TabIndex = 12;
            label9.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 329);
            label6.Name = "label6";
            label6.Size = new Size(141, 28);
            label6.TabIndex = 11;
            label6.Text = "Oda Numarası:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 409);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 10;
            label8.Text = "Giriş Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 287);
            label5.Name = "label5";
            label5.Size = new Size(37, 28);
            label5.TabIndex = 9;
            label5.Text = "TC:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 160);
            label10.Name = "label10";
            label10.Size = new Size(84, 28);
            label10.TabIndex = 8;
            label10.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 204);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 8;
            label3.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 369);
            label7.Name = "label7";
            label7.Size = new Size(63, 28);
            label7.TabIndex = 7;
            label7.Text = "Ücret:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 247);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 6;
            label4.Text = "Mail:";
            // 
            // l_gun
            // 
            l_gun.AutoSize = true;
            l_gun.Location = new Point(510, 514);
            l_gun.Name = "l_gun";
            l_gun.Size = new Size(24, 28);
            l_gun.TabIndex = 13;
            l_gun.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 118);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 13;
            label2.Text = "Soyadı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(381, 514);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 5;
            label11.Text = "Gün Sayısı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 71);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 5;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(b_106);
            groupBox2.Controls.Add(b_109);
            groupBox2.Controls.Add(b_105);
            groupBox2.Controls.Add(b_108);
            groupBox2.Controls.Add(b_107);
            groupBox2.Controls.Add(b_103);
            groupBox2.Controls.Add(b_104);
            groupBox2.Controls.Add(b_102);
            groupBox2.Controls.Add(b_101);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(654, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 481);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            // 
            // b_106
            // 
            b_106.BackColor = Color.Lime;
            b_106.FlatAppearance.BorderSize = 0;
            b_106.FlatStyle = FlatStyle.Flat;
            b_106.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_106.Location = new Point(407, 221);
            b_106.Name = "b_106";
            b_106.Size = new Size(128, 81);
            b_106.TabIndex = 8;
            b_106.TabStop = false;
            b_106.Text = "106";
            b_106.UseVisualStyleBackColor = false;
            b_106.Click += b_106_Click;
            // 
            // b_109
            // 
            b_109.BackColor = Color.Lime;
            b_109.FlatAppearance.BorderSize = 0;
            b_109.FlatStyle = FlatStyle.Flat;
            b_109.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_109.Location = new Point(407, 335);
            b_109.Name = "b_109";
            b_109.Size = new Size(128, 81);
            b_109.TabIndex = 6;
            b_109.TabStop = false;
            b_109.Text = "109";
            b_109.UseVisualStyleBackColor = false;
            b_109.Click += b_109_Click;
            // 
            // b_105
            // 
            b_105.BackColor = Color.Lime;
            b_105.FlatAppearance.BorderSize = 0;
            b_105.FlatStyle = FlatStyle.Flat;
            b_105.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_105.Location = new Point(218, 221);
            b_105.Name = "b_105";
            b_105.Size = new Size(128, 81);
            b_105.TabIndex = 9;
            b_105.TabStop = false;
            b_105.Text = "105";
            b_105.UseVisualStyleBackColor = false;
            b_105.Click += b_105_Click;
            // 
            // b_108
            // 
            b_108.BackColor = Color.Lime;
            b_108.FlatAppearance.BorderSize = 0;
            b_108.FlatStyle = FlatStyle.Flat;
            b_108.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_108.Location = new Point(218, 335);
            b_108.Name = "b_108";
            b_108.Size = new Size(128, 81);
            b_108.TabIndex = 7;
            b_108.TabStop = false;
            b_108.Text = "108";
            b_108.UseVisualStyleBackColor = false;
            b_108.Click += b_108_Click;
            // 
            // b_107
            // 
            b_107.BackColor = Color.Lime;
            b_107.FlatAppearance.BorderSize = 0;
            b_107.FlatStyle = FlatStyle.Flat;
            b_107.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_107.Location = new Point(31, 335);
            b_107.Name = "b_107";
            b_107.Size = new Size(128, 81);
            b_107.TabIndex = 10;
            b_107.TabStop = false;
            b_107.Text = "107";
            b_107.UseVisualStyleBackColor = false;
            b_107.Click += b_107_Click;
            // 
            // b_103
            // 
            b_103.BackColor = Color.Lime;
            b_103.FlatAppearance.BorderSize = 0;
            b_103.FlatStyle = FlatStyle.Flat;
            b_103.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_103.Location = new Point(407, 113);
            b_103.Name = "b_103";
            b_103.Size = new Size(128, 81);
            b_103.TabIndex = 11;
            b_103.TabStop = false;
            b_103.Text = "103";
            b_103.UseVisualStyleBackColor = false;
            b_103.Click += b_103_Click;
            // 
            // b_104
            // 
            b_104.BackColor = Color.Lime;
            b_104.FlatAppearance.BorderSize = 0;
            b_104.FlatStyle = FlatStyle.Flat;
            b_104.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_104.Location = new Point(31, 221);
            b_104.Name = "b_104";
            b_104.Size = new Size(128, 81);
            b_104.TabIndex = 12;
            b_104.TabStop = false;
            b_104.Text = "104";
            b_104.UseVisualStyleBackColor = false;
            b_104.Click += b_104_Click;
            // 
            // b_102
            // 
            b_102.BackColor = Color.Lime;
            b_102.FlatAppearance.BorderSize = 0;
            b_102.FlatStyle = FlatStyle.Flat;
            b_102.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_102.Location = new Point(218, 113);
            b_102.Name = "b_102";
            b_102.Size = new Size(128, 81);
            b_102.TabIndex = 13;
            b_102.TabStop = false;
            b_102.Text = "102";
            b_102.UseVisualStyleBackColor = false;
            b_102.Click += b_102_Click;
            // 
            // b_101
            // 
            b_101.BackColor = Color.Lime;
            b_101.FlatAppearance.BorderSize = 0;
            b_101.FlatStyle = FlatStyle.Flat;
            b_101.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_101.Location = new Point(31, 113);
            b_101.Name = "b_101";
            b_101.Size = new Size(128, 81);
            b_101.TabIndex = 14;
            b_101.TabStop = false;
            b_101.Text = "101";
            b_101.UseVisualStyleBackColor = false;
            b_101.Click += b_101_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(-17, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 102);
            panel1.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.White;
            label13.Location = new Point(140, 41);
            label13.Name = "label13";
            label13.Size = new Size(148, 31);
            label13.TabIndex = 9;
            label13.Text = "Yeni Müşteri";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1197, 26);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 8;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(46, 26);
            label12.Name = "label12";
            label12.Size = new Size(74, 50);
            label12.TabIndex = 6;
            label12.Text = "🏛";
            // 
            // yeni_musteri_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1290, 747);
            Controls.Add(panel1);
            Controls.Add(b_dolu);
            Controls.Add(groupBox2);
            Controls.Add(b_bos);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "yeni_musteri_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Müşteri Ekleme";
            Load += yeni_musteri_form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button b_bos;
        private Button b_dolu;
        private GroupBox groupBox1;
        private Button b_kaydet;
        private DateTimePicker dtp_cikis;
        private DateTimePicker dtp_giris;
        private MaskedTextBox mtb_tel;
        private TextBox tb_ucret;
        private TextBox tb_tc;
        private TextBox tb_odanum;
        private TextBox tb_soyad;
        private TextBox tb_ad;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button b_109;
        private Button b_108;
        private Button b_106;
        private Button b_105;
        private Button b_107;
        private Button b_103;
        private Button b_104;
        private Button b_102;
        private Button b_101;
        private ComboBox cb_cin;
        private Label label10;
        private Label l_gun;
        private Label label11;
        private TextBox tb_mail;
        private Panel panel1;
        private Label label12;
        private Button button4;
        private Label label13;
    }
}