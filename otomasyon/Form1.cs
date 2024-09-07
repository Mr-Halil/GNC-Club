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
using AForge.Video.DirectShow;
using ZXing;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

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
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }

            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox5.Image = (Bitmap)eventArgs.Frame.Clone();
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

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(groupBox1.Visible == true)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    textBox1.Text = sonuc.ToString();
                }
            }
        }
    }
}
