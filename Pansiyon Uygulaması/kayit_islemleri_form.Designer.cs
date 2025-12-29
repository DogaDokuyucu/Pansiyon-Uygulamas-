namespace Pansiyon_Uygulaması
{
    partial class kayit_islemleri_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_islemleri_form));
            panel1 = new Panel();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            b_kaydet = new Button();
            b_kaldir = new Button();
            tb_ad = new TextBox();
            tb_sif = new TextBox();
            cb_rol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 99);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(130, 39);
            label3.Name = "label3";
            label3.Size = new Size(167, 31);
            label3.TabIndex = 9;
            label3.Text = "Kayıt İşlemleri";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(701, 22);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 8;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(37, 24);
            label4.Name = "label4";
            label4.Size = new Size(74, 50);
            label4.TabIndex = 6;
            label4.Text = "🏛";
            // 
            // b_kaydet
            // 
            b_kaydet.BackColor = Color.Lime;
            b_kaydet.FlatAppearance.BorderSize = 0;
            b_kaydet.FlatStyle = FlatStyle.Flat;
            b_kaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_kaydet.ForeColor = Color.Black;
            b_kaydet.Location = new Point(411, 336);
            b_kaydet.Name = "b_kaydet";
            b_kaydet.Size = new Size(153, 60);
            b_kaydet.TabIndex = 5;
            b_kaydet.Text = "Kaydet";
            b_kaydet.UseVisualStyleBackColor = false;
            b_kaydet.Click += b_kaydet_Click;
            // 
            // b_kaldir
            // 
            b_kaldir.BackColor = Color.Red;
            b_kaldir.FlatAppearance.BorderSize = 0;
            b_kaldir.FlatStyle = FlatStyle.Flat;
            b_kaldir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_kaldir.ForeColor = Color.White;
            b_kaldir.Location = new Point(215, 336);
            b_kaldir.Name = "b_kaldir";
            b_kaldir.Size = new Size(153, 60);
            b_kaldir.TabIndex = 4;
            b_kaldir.Text = "Kaldır";
            b_kaldir.UseVisualStyleBackColor = false;
            b_kaldir.Click += b_kaldir_Click;
            // 
            // tb_ad
            // 
            tb_ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_ad.Location = new Point(348, 147);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(215, 34);
            tb_ad.TabIndex = 1;
            // 
            // tb_sif
            // 
            tb_sif.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_sif.Location = new Point(348, 196);
            tb_sif.Name = "tb_sif";
            tb_sif.Size = new Size(215, 34);
            tb_sif.TabIndex = 2;
            // 
            // cb_rol
            // 
            cb_rol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cb_rol.FormattingEnabled = true;
            cb_rol.Items.AddRange(new object[] { "Admin", "Personel", "Musteri" });
            cb_rol.Location = new Point(348, 251);
            cb_rol.Name = "cb_rol";
            cb_rol.Size = new Size(215, 36);
            cb_rol.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(204, 153);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 11;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(274, 202);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 12;
            label2.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(287, 259);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 13;
            label5.Text = "Rol:";
            // 
            // kayit_islemleri_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(802, 441);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_rol);
            Controls.Add(tb_sif);
            Controls.Add(tb_ad);
            Controls.Add(b_kaldir);
            Controls.Add(b_kaydet);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayit_islemleri_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayit_islemleri_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button4;
        private Label label4;
        private Button b_kaydet;
        private Button b_kaldir;
        private TextBox tb_ad;
        private TextBox tb_sif;
        private ComboBox cb_rol;
        private Label label1;
        private Label label2;
        private Label label5;
    }
}