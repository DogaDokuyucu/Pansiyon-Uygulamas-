namespace Pansiyon_Uygulaması
{
    partial class stoklar_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stoklar_form));
            b_kaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_gida = new TextBox();
            tb_icecek = new TextBox();
            tb_atis = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_elek = new TextBox();
            tb_su = new TextBox();
            tb_int = new TextBox();
            b_kaydet2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            button4 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b_kaydet
            // 
            b_kaydet.BackColor = Color.FromArgb(79, 175, 255);
            b_kaydet.FlatAppearance.BorderSize = 0;
            b_kaydet.FlatStyle = FlatStyle.Flat;
            b_kaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_kaydet.ForeColor = Color.White;
            b_kaydet.Location = new Point(308, 297);
            b_kaydet.Name = "b_kaydet";
            b_kaydet.Size = new Size(122, 50);
            b_kaydet.TabIndex = 3;
            b_kaydet.Text = "Kaydet";
            b_kaydet.UseVisualStyleBackColor = false;
            b_kaydet.Click += b_kaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(123, 141);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 1;
            label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(107, 192);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 1;
            label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(62, 242);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 1;
            label3.Text = "Atıştırmalık Tutarı:";
            // 
            // tb_gida
            // 
            tb_gida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_gida.Location = new Point(249, 135);
            tb_gida.Name = "tb_gida";
            tb_gida.Size = new Size(181, 34);
            tb_gida.TabIndex = 0;
            // 
            // tb_icecek
            // 
            tb_icecek.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_icecek.Location = new Point(249, 185);
            tb_icecek.Name = "tb_icecek";
            tb_icecek.Size = new Size(181, 34);
            tb_icecek.TabIndex = 1;
            // 
            // tb_atis
            // 
            tb_atis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_atis.Location = new Point(249, 236);
            tb_atis.Name = "tb_atis";
            tb_atis.Size = new Size(181, 34);
            tb_atis.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(570, 363);
            listView1.Name = "listView1";
            listView1.Size = new Size(531, 222);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıdalar";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecekler";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atıştırmalıklar";
            columnHeader3.Width = 120;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(12, 363);
            listView2.Name = "listView2";
            listView2.Size = new Size(531, 222);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            columnHeader6.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(590, 146);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 1;
            label4.Text = "Elektrik:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(635, 196);
            label5.Name = "label5";
            label5.Size = new Size(40, 28);
            label5.TabIndex = 1;
            label5.Text = "Su:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(590, 240);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 1;
            label6.Text = "İnternet:";
            // 
            // tb_elek
            // 
            tb_elek.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_elek.Location = new Point(709, 139);
            tb_elek.Name = "tb_elek";
            tb_elek.Size = new Size(182, 34);
            tb_elek.TabIndex = 4;
            // 
            // tb_su
            // 
            tb_su.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_su.Location = new Point(709, 189);
            tb_su.Name = "tb_su";
            tb_su.Size = new Size(182, 34);
            tb_su.TabIndex = 5;
            // 
            // tb_int
            // 
            tb_int.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_int.Location = new Point(709, 236);
            tb_int.Name = "tb_int";
            tb_int.Size = new Size(182, 34);
            tb_int.TabIndex = 6;
            // 
            // b_kaydet2
            // 
            b_kaydet2.BackColor = Color.FromArgb(79, 175, 255);
            b_kaydet2.FlatAppearance.BorderSize = 0;
            b_kaydet2.FlatStyle = FlatStyle.Flat;
            b_kaydet2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            b_kaydet2.ForeColor = Color.White;
            b_kaydet2.Location = new Point(709, 297);
            b_kaydet2.Name = "b_kaydet2";
            b_kaydet2.Size = new Size(122, 50);
            b_kaydet2.TabIndex = 7;
            b_kaydet2.Text = "Kaydet";
            b_kaydet2.UseVisualStyleBackColor = false;
            b_kaydet2.Click += b_kaydet2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 98);
            panel1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(126, 38);
            label8.Name = "label8";
            label8.Size = new Size(110, 38);
            label8.TabIndex = 11;
            label8.Text = "Stoklar";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1026, 19);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 10;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(35, 26);
            label7.Name = "label7";
            label7.Size = new Size(74, 50);
            label7.TabIndex = 9;
            label7.Text = "🏛";
            // 
            // stoklar_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1113, 597);
            Controls.Add(panel1);
            Controls.Add(b_kaydet2);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(tb_int);
            Controls.Add(tb_su);
            Controls.Add(tb_atis);
            Controls.Add(tb_elek);
            Controls.Add(tb_icecek);
            Controls.Add(label6);
            Controls.Add(tb_gida);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b_kaydet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stoklar_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stoklar";
            Load += stoklar_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_kaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_gida;
        private TextBox tb_icecek;
        private TextBox tb_atis;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_elek;
        private TextBox tb_su;
        private TextBox tb_int;
        private Button b_kaydet2;
        private Panel panel1;
        private Label label7;
        private Button button4;
        private Label label8;
    }
}