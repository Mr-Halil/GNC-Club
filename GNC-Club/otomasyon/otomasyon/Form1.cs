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

namespace otomasyon
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb");
        public Form1()
        {
            InitializeComponent();
        }
        private void kayitlariListele()
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select modelkodu,modeltanimi,renk,adet,fiyat from veriler", baglanti);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
                dataGridView1.Columns["modelkodu"].HeaderText = "Model Kodu";
                dataGridView1.Columns["modeltanimi"].HeaderText = "Model Tanımı";
                dataGridView1.Columns["renk"].HeaderText = "Renk";
                dataGridView1.Columns["adet"].HeaderText = "Adet";
                dataGridView1.Columns["fiyat"].HeaderText = "Fiyat";
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
        }
        private void temzile()
        {
            modelKoduTextBox.Clear();
            modelTanimiTextBox.Clear();
            renkTextBox.Clear();
            bedenlerComboBox.SelectedItem = null;
            adetTextBox.Clear();
            fiyatTextBox.Clear();
            modelFoto.ImageLocation = null;
            barkodFoto.ImageLocation = null;
            barkodTextBox.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlariListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kıyafetin fotoğrafını bilgisayardan yüklemek için
            openFileDialog1.ShowDialog();
            modelFoto.ImageLocation = openFileDialog1.FileName;
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter eklekomutu = new OleDbDataAdapter("insert into veriler (modelkodu,modeltanimi,modelfotografi,renk,beden,giristarihi,adet,fiyat,barkod) values('"+modelKoduTextBox.Text+"','"+modelTanimiTextBox.Text+ "','"+modelFoto.ImageLocation+"','"+renkTextBox.Text+"','"+bedenlerComboBox.SelectedItem.ToString()+"','"+DateTime.Now+"','"+adetTextBox.Text+"','"+fiyatTextBox.Text+"','"+barkodTextBox.Text+"')",baglanti);
                DataSet dshafiza2 = new DataSet();
                eklekomutu.Fill(dshafiza2);
                baglanti.Close();
                MessageBox.Show("Ürün eklendi");
                temzile();
                kayitlariListele();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
        }
    }
}
