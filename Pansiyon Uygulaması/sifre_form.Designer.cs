namespace Pansiyon_Uygulaması
{
    partial class sifre_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifre_form));
            b_gun = new Button();
            tb_ad = new TextBox();
            tb_sifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b_gun
            // 
            b_gun.BackColor = Color.FromArgb(79, 175, 255);
            b_gun.FlatAppearance.BorderSize = 0;
            b_gun.FlatStyle = FlatStyle.Flat;
            b_gun.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_gun.ForeColor = Color.White;
            b_gun.Location = new Point(328, 306);
            b_gun.Name = "b_gun";
            b_gun.Size = new Size(134, 56);
            b_gun.TabIndex = 2;
            b_gun.Text = "Güncelle";
            b_gun.UseVisualStyleBackColor = false;
            b_gun.Click += button1_Click;
            // 
            // tb_ad
            // 
            tb_ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_ad.Location = new Point(369, 172);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(192, 34);
            tb_ad.TabIndex = 0;
            tb_ad.TextChanged += tb_ad_TextChanged;
            // 
            // tb_sifre
            // 
            tb_sifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_sifre.Location = new Point(369, 224);
            tb_sifre.Name = "tb_sifre";
            tb_sifre.Size = new Size(192, 34);
            tb_sifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(196, 178);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(266, 230);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-12, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 103);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(704, 32);
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
            label4.Location = new Point(40, 32);
            label4.Name = "label4";
            label4.Size = new Size(74, 50);
            label4.TabIndex = 6;
            label4.Text = "🏛";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(138, 47);
            label3.Name = "label3";
            label3.Size = new Size(162, 31);
            label3.TabIndex = 9;
            label3.Text = "Şifre İşlemleri";
            // 
            // sifre_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(782, 454);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_sifre);
            Controls.Add(tb_ad);
            Controls.Add(b_gun);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sifre_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Değiştir";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_gun;
        private TextBox tb_ad;
        private TextBox tb_sifre;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Button button4;
        private Label label3;
    }
}