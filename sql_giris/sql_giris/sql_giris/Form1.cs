using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sql_giris
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=rehber.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader okuyucu;

        OleDbDataAdapter da;
        DataTable dt = new DataTable();

        int id;
        int listelemeturu = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void sql_baglanti_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

            if (sql_baglanti.Text == "Düzenlemeyi Kaydet")
            {
                try
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE kisiler set ad='" + txt_adi.Text + "', soyad='" + txt_soyadi.Text + "', numara='" + txt_numarasi.Text + "' where id= " + id;
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi Başarıyla Güncellendi!");
                    baglanti.Close();
                    listele();
                }
                catch (Exception)
                {


                }


                txt_adi.Text = "";
                txt_soyadi.Text = "";
                txt_numarasi.Text = "";
                id = 0;
                sql_baglanti.Text = "Kişi Ekle";
            }
            else
            {

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Select * FROM kisiler WHERE numara=" + txt_numarasi.Text;
                okuyucu = komut.ExecuteReader();//okuyucuya üstteki numara değerini atadık
                okuyucu.Read();
                if (okuyucu.HasRows)//aynı numara kayıtlı mı , kullanıcı adı yapılabilir
                {
                    MessageBox.Show("Bu numara zaten kayıtlı!");
                }
                else
                {
                    komut.Dispose();
                    okuyucu.Dispose();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO kisiler (ad, soyad, numara) VALUES('" + txt_adi.Text + "','" + txt_soyadi.Text + "','" + txt_numarasi.Text + "') ";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi Başarıyla Eklendi!");
                    listele();

                    txt_adi.Text = "";
                    txt_soyadi.Text = "";
                    txt_numarasi.Text = "";
                }

                baglanti.Close();
            }
        }

        void listele()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            dt.Clear();//data grid temizleme-üstüne yeniden yazmasın diye
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;

                //listeleme türü comboboxtan gelen degere göre olacak
                switch (listelemeturu)
                {
                    case 1:
                        komut.CommandText = "SELECT * from kisiler ORDER BY id DESC";
                        break;
                    case 2:
                        komut.CommandText = "SELECT * from kisiler ORDER BY id ASC";
                        break;
                    case 3:
                        komut.CommandText = "SELECT * from kisiler ORDER BY ad ASC";
                        break;
                    case 4:
                        komut.CommandText = "SELECT * from kisiler ORDER BY ad DESC";
                        break;
                    default:
                        komut.CommandText = "SELECT * from kisiler";
                        break;
                }
                


                da = new OleDbDataAdapter(komut);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            listele();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ADI";
            dataGridView1.Columns[2].HeaderText = "SOYADI";
            dataGridView1.Columns[3].HeaderText = "NUMARA";

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //0 indexte yani id kolonunu alıyoruz
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txt_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_numarasi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sql_baglanti.Text = "Düzenlemeyi Kaydet";
        }

        void silme()
        {

            DialogResult dr = MessageBox.Show("kişiyi silmek istediginizden emin misiniz ?", "kişi silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                try
                {
                    if (id > 0)
                    {
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from kisiler where id = " + id;
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kişi başarıyla silindi!");
                        listele();
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message.ToString());
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listelemeturu = 1;
            } else if (comboBox1.SelectedIndex == 1)
            {
                listelemeturu = 2;
            } else if (comboBox1.SelectedIndex == 2)
            {
                listelemeturu = 3;
            }else if(comboBox1.SelectedIndex == 3)
            {
                listelemeturu = 4;
            }
            listele();
        }

        private void txt_numarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_kisisil_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            silme();
        }
    }
}
