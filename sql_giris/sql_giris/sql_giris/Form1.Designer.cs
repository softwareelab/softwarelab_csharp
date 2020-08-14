namespace sql_giris
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sql_baglanti = new System.Windows.Forms.Button();
            this.bgl_adi = new System.Windows.Forms.Label();
            this.bgl_soyadi = new System.Windows.Forms.Label();
            this.bgl_numarasi = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_numarasi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_kisisil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sql_baglanti
            // 
            this.sql_baglanti.BackColor = System.Drawing.Color.DarkGray;
            this.sql_baglanti.Location = new System.Drawing.Point(26, 137);
            this.sql_baglanti.Name = "sql_baglanti";
            this.sql_baglanti.Size = new System.Drawing.Size(102, 38);
            this.sql_baglanti.TabIndex = 0;
            this.sql_baglanti.Text = "Kişi Ekle";
            this.sql_baglanti.UseVisualStyleBackColor = false;
            this.sql_baglanti.Click += new System.EventHandler(this.sql_baglanti_Click);
            // 
            // bgl_adi
            // 
            this.bgl_adi.AutoSize = true;
            this.bgl_adi.Location = new System.Drawing.Point(23, 41);
            this.bgl_adi.Name = "bgl_adi";
            this.bgl_adi.Size = new System.Drawing.Size(29, 13);
            this.bgl_adi.TabIndex = 1;
            this.bgl_adi.Text = "Adı:";
            // 
            // bgl_soyadi
            // 
            this.bgl_soyadi.AutoSize = true;
            this.bgl_soyadi.Location = new System.Drawing.Point(23, 75);
            this.bgl_soyadi.Name = "bgl_soyadi";
            this.bgl_soyadi.Size = new System.Drawing.Size(49, 13);
            this.bgl_soyadi.TabIndex = 2;
            this.bgl_soyadi.Text = "Soyadı:";
            // 
            // bgl_numarasi
            // 
            this.bgl_numarasi.AutoSize = true;
            this.bgl_numarasi.Location = new System.Drawing.Point(23, 107);
            this.bgl_numarasi.Name = "bgl_numarasi";
            this.bgl_numarasi.Size = new System.Drawing.Size(63, 13);
            this.bgl_numarasi.TabIndex = 3;
            this.bgl_numarasi.Text = "Numarası:";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(133, 34);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(224, 20);
            this.txt_adi.TabIndex = 4;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(133, 68);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(224, 20);
            this.txt_soyadi.TabIndex = 5;
            // 
            // txt_numarasi
            // 
            this.txt_numarasi.Location = new System.Drawing.Point(133, 100);
            this.txt_numarasi.Name = "txt_numarasi";
            this.txt_numarasi.Size = new System.Drawing.Size(224, 20);
            this.txt_numarasi.TabIndex = 6;
            this.txt_numarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numarasi_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Eklenme Tarihi(Önce Yeni)",
            "Eklenme Tarihi(Önce Eski)",
            "Ad (A>Z)",
            "Ad(Z>A)"});
            this.comboBox1.Location = new System.Drawing.Point(12, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Listeleme Türü";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_kisisil
            // 
            this.btn_kisisil.BackColor = System.Drawing.Color.DimGray;
            this.btn_kisisil.Location = new System.Drawing.Point(217, 137);
            this.btn_kisisil.Name = "btn_kisisil";
            this.btn_kisisil.Size = new System.Drawing.Size(101, 38);
            this.btn_kisisil.TabIndex = 9;
            this.btn_kisisil.Text = "Kişiyi Sil";
            this.btn_kisisil.UseVisualStyleBackColor = false;
            this.btn_kisisil.Click += new System.EventHandler(this.btn_kisisil_Click);
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 422);
            this.Controls.Add(this.btn_kisisil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_numarasi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.bgl_numarasi);
            this.Controls.Add(this.bgl_soyadi);
            this.Controls.Add(this.bgl_adi);
            this.Controls.Add(this.sql_baglanti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sql_baglanti;
        private System.Windows.Forms.Label bgl_adi;
        private System.Windows.Forms.Label bgl_soyadi;
        private System.Windows.Forms.Label bgl_numarasi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_numarasi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_kisisil;
    }
}

