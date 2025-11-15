namespace Pansiyon_Uygulaması
{
    partial class gelir_gider_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gelir_gider_form));
            label1 = new Label();
            l_toplam = new Label();
            label3 = new Label();
            l_personel = new Label();
            label5 = new Label();
            l_gida = new Label();
            label7 = new Label();
            l_elek = new Label();
            label9 = new Label();
            label10 = new Label();
            l_sonuc = new Label();
            tb_personel = new TextBox();
            b_hesapla = new Button();
            l_icecek = new Label();
            l_cerez = new Label();
            l_su = new Label();
            l_int = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            label6 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Toplam Tutar:";
            // 
            // l_toplam
            // 
            l_toplam.AutoSize = true;
            l_toplam.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            l_toplam.ForeColor = Color.White;
            l_toplam.Location = new Point(24, 112);
            l_toplam.Name = "l_toplam";
            l_toplam.Size = new Size(58, 46);
            l_toplam.TabIndex = 0;
            l_toplam.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(450, 233);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 0;
            label3.Text = "Personel Maaşları:";
            // 
            // l_personel
            // 
            l_personel.AutoSize = true;
            l_personel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_personel.Location = new Point(647, 233);
            l_personel.Name = "l_personel";
            l_personel.Size = new Size(34, 28);
            l_personel.TabIndex = 0;
            l_personel.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(397, 297);
            label5.Name = "label5";
            label5.Size = new Size(230, 28);
            label5.TabIndex = 0;
            label5.Text = "Alınan Ürünleri Toplamı:";
            // 
            // l_gida
            // 
            l_gida.AutoSize = true;
            l_gida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_gida.Location = new Point(647, 297);
            l_gida.Name = "l_gida";
            l_gida.Size = new Size(34, 28);
            l_gida.TabIndex = 0;
            l_gida.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(530, 366);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 0;
            label7.Text = "Faturalar:";
            label7.Click += label7_Click;
            // 
            // l_elek
            // 
            l_elek.AutoSize = true;
            l_elek.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_elek.Location = new Point(647, 366);
            l_elek.Name = "l_elek";
            l_elek.Size = new Size(34, 28);
            l_elek.TabIndex = 0;
            l_elek.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(457, 137);
            label9.Name = "label9";
            label9.Size = new Size(173, 31);
            label9.TabIndex = 0;
            label9.Text = "Personel Sayısı:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 304);
            label10.Name = "label10";
            label10.Size = new Size(84, 31);
            label10.TabIndex = 0;
            label10.Text = "Sonuç:";
            // 
            // l_sonuc
            // 
            l_sonuc.AutoSize = true;
            l_sonuc.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            l_sonuc.ForeColor = Color.White;
            l_sonuc.Location = new Point(24, 380);
            l_sonuc.Name = "l_sonuc";
            l_sonuc.Size = new Size(58, 46);
            l_sonuc.TabIndex = 0;
            l_sonuc.Text = "00";
            // 
            // tb_personel
            // 
            tb_personel.Font = new Font("Segoe UI", 13.8F);
            tb_personel.Location = new Point(647, 134);
            tb_personel.Name = "tb_personel";
            tb_personel.Size = new Size(186, 38);
            tb_personel.TabIndex = 0;
            // 
            // b_hesapla
            // 
            b_hesapla.BackColor = Color.FromArgb(79, 175, 255);
            b_hesapla.FlatAppearance.BorderSize = 0;
            b_hesapla.FlatStyle = FlatStyle.Flat;
            b_hesapla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            b_hesapla.ForeColor = Color.White;
            b_hesapla.Location = new Point(673, 482);
            b_hesapla.Name = "b_hesapla";
            b_hesapla.Size = new Size(140, 60);
            b_hesapla.TabIndex = 1;
            b_hesapla.Text = "Hesapla";
            b_hesapla.UseVisualStyleBackColor = false;
            b_hesapla.Click += b_hesapla_Click;
            // 
            // l_icecek
            // 
            l_icecek.AutoSize = true;
            l_icecek.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_icecek.Location = new Point(799, 297);
            l_icecek.Name = "l_icecek";
            l_icecek.Size = new Size(34, 28);
            l_icecek.TabIndex = 0;
            l_icecek.Text = "00";
            // 
            // l_cerez
            // 
            l_cerez.AutoSize = true;
            l_cerez.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_cerez.Location = new Point(954, 297);
            l_cerez.Name = "l_cerez";
            l_cerez.Size = new Size(34, 28);
            l_cerez.TabIndex = 0;
            l_cerez.Text = "00";
            // 
            // l_su
            // 
            l_su.AutoSize = true;
            l_su.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_su.Location = new Point(799, 366);
            l_su.Name = "l_su";
            l_su.Size = new Size(34, 28);
            l_su.TabIndex = 0;
            l_su.Text = "00";
            // 
            // l_int
            // 
            l_int.AutoSize = true;
            l_int.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            l_int.Location = new Point(954, 366);
            l_int.Name = "l_int";
            l_int.Size = new Size(34, 28);
            l_int.TabIndex = 0;
            l_int.Text = "00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(l_toplam);
            panel1.Controls.Add(l_sonuc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(23, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 462);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 220);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 1;
            label2.Text = "-------------------------------------------------";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-6, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 84);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1026, 15);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(123, 30);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 6;
            label6.Text = "Gelir-Gider";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(29, 15);
            label4.Name = "label4";
            label4.Size = new Size(74, 50);
            label4.TabIndex = 5;
            label4.Text = "🏛";
            // 
            // gelir_gider_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1110, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(b_hesapla);
            Controls.Add(tb_personel);
            Controls.Add(l_int);
            Controls.Add(l_su);
            Controls.Add(l_elek);
            Controls.Add(label7);
            Controls.Add(l_cerez);
            Controls.Add(l_icecek);
            Controls.Add(l_gida);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(l_personel);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gelir_gider_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Gider";
            Load += gelir_gider_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label l_toplam;
        private Label label3;
        private Label l_personel;
        private Label label5;
        private Label l_gida;
        private Label label7;
        private Label l_elek;
        private Label label9;
        private Label label10;
        private Label l_sonuc;
        private TextBox tb_personel;
        private Button b_hesapla;
        private Label l_icecek;
        private Label l_cerez;
        private Label l_su;
        private Label l_int;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label4;
        private Button button4;
    }
}