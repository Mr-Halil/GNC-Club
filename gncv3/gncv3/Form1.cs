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

namespace gncv3
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ctnib\\OneDrive\\Masaüstü\\gncv3\\gncv3\\bin\\Debug\\bilgiler.mdb");
        DataTable tablo = new DataTable();
        private void listele()
        {
            try {
                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from veriler", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
                dataGridView1.Columns["modelkodu"].HeaderText = "Model Kodu";
                dataGridView1.Columns["renk"].HeaderText = "Renk";
                dataGridView1.Columns["beden"].HeaderText = "Beden";
                dataGridView1.Columns["adet"].HeaderText = "Adet";
                dataGridView1.Columns["fiyat"].HeaderText = "Fiyat";

                dataGridView1.Columns["modeltanimi"].Visible = false;
                dataGridView1.Columns["fotograf"].Visible = false;
                dataGridView1.Columns["barkod"].Visible = false;
            }catch {
                MessageBox.Show("Listelemede Hata Var");
                baglanti.Close() ;
            }
        }
        private void temizle()
        {
            modelKoduTextBox.Clear();
            modelTanimiTextBox.Clear();
            renkTextBox.Clear();
            bedenComboBox.SelectedItem = null; 
            adetTextBox.Clear();
            fiyatTextBox.Clear();
            modelPictureBox.Image = null;
            barkodPictureBox.Image = null;
        }
        private void stok_Load(object sender, EventArgs e)
        {
            listele();  
        }

        private void urunekleButon_Click(object sender, EventArgs e)
        {
            try
            {
                bool durum = false;
                baglanti.Open();
                OleDbCommand cmdall = new OleDbCommand("select * from veriler", baglanti);
                OleDbCommand cmd = new OleDbCommand("insert into veriler(modelkodu,modeltanimi,renk,beden,adet,fiyat,fotograf,barkod) values('" + modelKoduTextBox.Text + "','" + modelTanimiTextBox.Text + "','" + renkTextBox.Text + "','" + bedenComboBox.SelectedItem.ToString() + "','" + adetTextBox.Text + "','" + fiyatTextBox.Text + "','" + modelPictureBox.ImageLocation + "','" + barkodPictureBox.ImageLocation + "')", baglanti);
                OleDbDataReader dr = cmdall.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["modelkodu"].ToString() == modelKoduTextBox.Text && dr["beden"].ToString() == bedenComboBox.SelectedItem.ToString() && dr["renk"].ToString() == renkTextBox.Text) durum = true;
                    else durum = false;
                }
                if (durum == true) MessageBox.Show("Ürün sistemde kayıtlı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün sisteme eklendi");

                    
                    temizle();
                }
                baglanti.Close();
                tablo.Clear();
                listele();
            }
            catch
            {
                MessageBox.Show("Ekle Butonunda Hata Var");
                baglanti.Close();
            }
            
        }

        private void fotografsecButon_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                modelPictureBox.ImageLocation = openFileDialog1.FileName;
            }catch {
                MessageBox.Show("Fotoğraf Seçme Butonunda Hata Var");
                baglanti.Close();
            }
            
        }

        private void urunsilButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("delete * from veriler where modelkodu ='"+modelKoduTextBox.Text+"' and beden='"+bedenComboBox.SelectedItem.ToString()+"'and renk='"+renkTextBox.Text+"'",baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Sistemden Silindi", "UYARI");
                tablo.Clear();
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme Butonunda Hata Var");
                baglanti.Close();
            }

        }

        private void modelKoduBulTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from veriler where modelkodu like '"+modelKoduBulTextBox.Text+"%'", baglanti);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Model Kodundan Bulmada Hata Var");
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                modelKoduTextBox.Text = dataGridView1.CurrentRow.Cells["modelkodu"].Value.ToString();
                modelTanimiTextBox.Text = dataGridView1.CurrentRow.Cells["modeltanimi"].Value.ToString();
                renkTextBox.Text = dataGridView1.CurrentRow.Cells["renk"].Value.ToString();
                bedenComboBox.Text = dataGridView1.CurrentRow.Cells["beden"].Value.ToString();
                adetTextBox.Text = dataGridView1.CurrentRow.Cells["adet"].Value.ToString();
                fiyatTextBox.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
                modelPictureBox.ImageLocation = dataGridView1.CurrentRow.Cells["fotograf"].Value.ToString();
                barkodPictureBox.ImageLocation = dataGridView1.CurrentRow.Cells["barkod"].Value.ToString();
                barkodTextBox.Text = dataGridView1.CurrentRow.Cells["barkod"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Listeye tıklamada hata var");
            }
        }

        private void urunguncelleButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("update veriler set modeltanimi='" + modelTanimiTextBox.Text + "',renk='" + renkTextBox.Text + "',beden='" + bedenComboBox.SelectedItem.ToString() + "',adet='" + adetTextBox.Text + "',fiyat='" + fiyatTextBox.Text + "',fotograf='" + modelPictureBox.ImageLocation + "',barkod='" + barkodTextBox.Text + "'where modelkodu='" + modelKoduTextBox.Text + "'AND renk='"+renkTextBox.Text+"'AND beden='"+bedenComboBox.SelectedItem.ToString()+"'", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürünün Bilgileri Güncellendi", "UYARI");
                tablo.Clear();
                listele();
            }
            catch
            {
                MessageBox.Show("Güncelleme Butonunda Hata Var");
                baglanti.Close() ;
            }
        }
    }
}
