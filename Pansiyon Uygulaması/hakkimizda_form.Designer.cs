namespace Pansiyon_Uygulaması
{
    partial class hakkimizda_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hakkimizda_form));
            listView1 = new ListView();
            lblYildizOrtalamasi = new Label();
            tbMesajDetay = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listView1.Location = new Point(60, 113);
            listView1.Name = "listView1";
            listView1.Size = new Size(282, 371);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lblYildizOrtalamasi
            // 
            lblYildizOrtalamasi.AutoSize = true;
            lblYildizOrtalamasi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYildizOrtalamasi.ForeColor = Color.FromArgb(192, 192, 0);
            lblYildizOrtalamasi.Location = new Point(87, 557);
            lblYildizOrtalamasi.Name = "lblYildizOrtalamasi";
            lblYildizOrtalamasi.Size = new Size(42, 41);
            lblYildizOrtalamasi.TabIndex = 1;
            lblYildizOrtalamasi.Text = "...";
            lblYildizOrtalamasi.Click += lblYildizOrtalamasi_Click;
            // 
            // tbMesajDetay
            // 
            tbMesajDetay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbMesajDetay.Location = new Point(409, 113);
            tbMesajDetay.Multiline = true;
            tbMesajDetay.Name = "tbMesajDetay";
            tbMesajDetay.Size = new Size(619, 544);
            tbMesajDetay.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-6, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 97);
            panel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(956, 21);
            button4.Name = "button4";
            button4.Size = new Size(78, 57);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 43);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 6;
            label1.Text = "Hakkımızda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(29, 28);
            label4.Name = "label4";
            label4.Size = new Size(74, 50);
            label4.TabIndex = 5;
            label4.Text = "🏛";
            // 
            // hakkimizda_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1040, 669);
            Controls.Add(panel1);
            Controls.Add(tbMesajDetay);
            Controls.Add(lblYildizOrtalamasi);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "hakkimizda_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hakkımızda";
            Load += hakkimizda_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label lblYildizOrtalamasi;
        private TextBox tbMesajDetay;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Button button4;
    }
}