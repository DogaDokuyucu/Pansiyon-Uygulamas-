namespace Pansiyon_Uygulaması
{
    partial class mesaj_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mesaj_form));
            b_kaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_mesaj = new RichTextBox();
            tb_ad = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            b_y1 = new Button();
            b_y2 = new Button();
            b_y3 = new Button();
            b_y4 = new Button();
            b_y5 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b_kaydet
            // 
            b_kaydet.BackColor = Color.FromArgb(79, 175, 255);
            b_kaydet.FlatAppearance.BorderSize = 0;
            b_kaydet.FlatStyle = FlatStyle.Flat;
            b_kaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            b_kaydet.ForeColor = Color.White;
            b_kaydet.Location = new Point(532, 501);
            b_kaydet.Name = "b_kaydet";
            b_kaydet.Size = new Size(125, 47);
            b_kaydet.TabIndex = 2;
            b_kaydet.Text = "Kaydet";
            b_kaydet.UseVisualStyleBackColor = false;
            b_kaydet.Click += b_kaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(46, 225);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Mesaj:";
            // 
            // tb_mesaj
            // 
            tb_mesaj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tb_mesaj.Location = new Point(125, 237);
            tb_mesaj.Name = "tb_mesaj";
            tb_mesaj.Size = new Size(1014, 248);
            tb_mesaj.TabIndex = 1;
            tb_mesaj.Text = "";
            // 
            // tb_ad
            // 
            tb_ad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tb_ad.Location = new Point(125, 118);
            tb_ad.Name = "tb_ad";
            tb_ad.Size = new Size(279, 34);
            tb_ad.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listView1.Location = new Point(25, 564);
            listView1.Name = "listView1";
            listView1.Size = new Size(1114, 119);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesaj";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Yildiz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 180);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Yıldız:";
            // 
            // b_y1
            // 
            b_y1.Font = new Font("Segoe UI", 13.8F);
            b_y1.Location = new Point(125, 171);
            b_y1.Name = "b_y1";
            b_y1.Size = new Size(51, 44);
            b_y1.TabIndex = 5;
            b_y1.TabStop = false;
            b_y1.Text = "☆";
            b_y1.UseVisualStyleBackColor = true;
            b_y1.Click += b_y1_Click;
            // 
            // b_y2
            // 
            b_y2.Font = new Font("Segoe UI", 13.8F);
            b_y2.Location = new Point(182, 171);
            b_y2.Name = "b_y2";
            b_y2.Size = new Size(51, 44);
            b_y2.TabIndex = 5;
            b_y2.TabStop = false;
            b_y2.Text = "☆";
            b_y2.UseVisualStyleBackColor = true;
            b_y2.Click += b_y2_Click;
            // 
            // b_y3
            // 
            b_y3.Font = new Font("Segoe UI", 13.8F);
            b_y3.Location = new Point(239, 171);
            b_y3.Name = "b_y3";
            b_y3.Size = new Size(51, 44);
            b_y3.TabIndex = 5;
            b_y3.TabStop = false;
            b_y3.Text = "☆";
            b_y3.UseVisualStyleBackColor = true;
            b_y3.Click += b_y3_Click;
            // 
            // b_y4
            // 
            b_y4.Font = new Font("Segoe UI", 13.8F);
            b_y4.Location = new Point(296, 171);
            b_y4.Name = "b_y4";
            b_y4.Size = new Size(51, 44);
            b_y4.TabIndex = 5;
            b_y4.TabStop = false;
            b_y4.Text = "☆";
            b_y4.UseVisualStyleBackColor = true;
            b_y4.Click += b_y4_Click;
            // 
            // b_y5
            // 
            b_y5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            b_y5.Location = new Point(353, 171);
            b_y5.Name = "b_y5";
            b_y5.Size = new Size(51, 44);
            b_y5.TabIndex = 5;
            b_y5.TabStop = false;
            b_y5.Text = "☆";
            b_y5.UseVisualStyleBackColor = true;
            b_y5.Click += b_y5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-4, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 86);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1078, 18);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 9;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(120, 30);
            label5.Name = "label5";
            label5.Size = new Size(105, 31);
            label5.TabIndex = 8;
            label5.Text = "Mesajlar";
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
            label4.TabIndex = 7;
            label4.Text = "🏛";
            // 
            // mesaj_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1164, 704);
            Controls.Add(panel1);
            Controls.Add(b_y5);
            Controls.Add(b_y4);
            Controls.Add(b_y3);
            Controls.Add(b_y2);
            Controls.Add(b_y1);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(tb_ad);
            Controls.Add(tb_mesaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b_kaydet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mesaj_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesajlar";
            Load += mesaj_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_kaydet;
        private Label label1;
        private Label label2;
        private RichTextBox tb_mesaj;
        private TextBox tb_ad;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private Button b_y1;
        private Button b_y2;
        private Button b_y3;
        private Button b_y4;
        private Button b_y5;
        private ColumnHeader columnHeader4;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Button button4;
    }
}