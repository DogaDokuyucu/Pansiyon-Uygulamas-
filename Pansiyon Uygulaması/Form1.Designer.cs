namespace Pansiyon_Uygulaması
{
    partial class giris_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_ad = new TextBox();
            tb_sif = new TextBox();
            b_giris = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(307, 227);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(307, 318);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // tb_ad
            // 
            tb_ad.Font = new Font("Segoe UI", 13.8F);
            tb_ad.Location = new Point(471, 227);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(197, 38);
            tb_ad.TabIndex = 0;
            // 
            // tb_sif
            // 
            tb_sif.Font = new Font("Segoe UI", 13.8F);
            tb_sif.Location = new Point(471, 311);
            tb_sif.Name = "tb_sif";
            tb_sif.Size = new Size(197, 38);
            tb_sif.TabIndex = 1;
            // 
            // b_giris
            // 
            b_giris.BackColor = Color.FromArgb(52, 73, 94);
            b_giris.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            b_giris.ForeColor = Color.White;
            b_giris.Location = new Point(427, 390);
            b_giris.Name = "b_giris";
            b_giris.Size = new Size(155, 80);
            b_giris.TabIndex = 2;
            b_giris.Text = "Giriş Yap";
            b_giris.UseVisualStyleBackColor = false;
            b_giris.Click += b_giris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 94);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 62, 80);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(949, 12);
            button1.Name = "button1";
            button1.Size = new Size(77, 67);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "🗙";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(40, 23);
            label4.Name = "label4";
            label4.Size = new Size(74, 50);
            label4.TabIndex = 0;
            label4.Text = "🏛";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 33);
            label3.Name = "label3";
            label3.Size = new Size(310, 38);
            label3.TabIndex = 0;
            label3.Text = "Pansiyon Otomasyonu";
            // 
            // giris_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1023, 609);
            Controls.Add(panel1);
            Controls.Add(b_giris);
            Controls.Add(tb_sif);
            Controls.Add(tb_ad);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "giris_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            Load += giris_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_ad;
        private TextBox tb_sif;
        private Button b_giris;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
