namespace otomasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.modelKoduTextBox = new System.Windows.Forms.TextBox();
            this.modelTanimiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelFoto = new System.Windows.Forms.PictureBox();
            this.renkTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bedenlerComboBox = new System.Windows.Forms.ComboBox();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ekleButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.guncelleButon = new System.Windows.Forms.Button();
            this.bulButon = new System.Windows.Forms.Button();
            this.barkodFoto = new System.Windows.Forms.PictureBox();
            this.barkodButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODEL KODU:";
            // 
            // modelKoduTextBox
            // 
            this.modelKoduTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelKoduTextBox.Location = new System.Drawing.Point(183, 13);
            this.modelKoduTextBox.Name = "modelKoduTextBox";
            this.modelKoduTextBox.Size = new System.Drawing.Size(217, 30);
            this.modelKoduTextBox.TabIndex = 1;
            // 
            // modelTanimiTextBox
            // 
            this.modelTanimiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTanimiTextBox.Location = new System.Drawing.Point(183, 58);
            this.modelTanimiTextBox.Name = "modelTanimiTextBox";
            this.modelTanimiTextBox.Size = new System.Drawing.Size(217, 30);
            this.modelTanimiTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODEL TANIMI:";
            // 
            // modelFoto
            // 
            this.modelFoto.Location = new System.Drawing.Point(418, 13);
            this.modelFoto.Name = "modelFoto";
            this.modelFoto.Size = new System.Drawing.Size(239, 261);
            this.modelFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modelFoto.TabIndex = 4;
            this.modelFoto.TabStop = false;
            // 
            // renkTextBox
            // 
            this.renkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renkTextBox.Location = new System.Drawing.Point(183, 103);
            this.renkTextBox.Name = "renkTextBox";
            this.renkTextBox.Size = new System.Drawing.Size(217, 30);
            this.renkTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "RENK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "BEDENLER:";
            // 
            // bedenlerComboBox
            // 
            this.bedenlerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedenlerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedenlerComboBox.FormattingEnabled = true;
            this.bedenlerComboBox.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "3XL",
            "4XL",
            "5XL",
            "6XL",
            "7XL"});
            this.bedenlerComboBox.Location = new System.Drawing.Point(183, 152);
            this.bedenlerComboBox.Name = "bedenlerComboBox";
            this.bedenlerComboBox.Size = new System.Drawing.Size(217, 30);
            this.bedenlerComboBox.TabIndex = 8;
            // 
            // adetTextBox
            // 
            this.adetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adetTextBox.Location = new System.Drawing.Point(183, 194);
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.Size = new System.Drawing.Size(217, 30);
            this.adetTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADET:";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatTextBox.Location = new System.Drawing.Point(183, 244);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(217, 30);
            this.fiyatTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "FİYAT:";
            // 
            // ekleButon
            // 
            this.ekleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButon.Location = new System.Drawing.Point(16, 344);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(129, 60);
            this.ekleButon.TabIndex = 13;
            this.ekleButon.Text = "EKLE";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // silButon
            // 
            this.silButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silButon.Location = new System.Drawing.Point(184, 344);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(129, 60);
            this.silButon.TabIndex = 14;
            this.silButon.Text = "SİL";
            this.silButon.UseVisualStyleBackColor = true;
            // 
            // guncelleButon
            // 
            this.guncelleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButon.Location = new System.Drawing.Point(337, 344);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(154, 60);
            this.guncelleButon.TabIndex = 15;
            this.guncelleButon.Text = "GÜNCELLE";
            this.guncelleButon.UseVisualStyleBackColor = true;
            // 
            // bulButon
            // 
            this.bulButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulButon.Location = new System.Drawing.Point(523, 344);
            this.bulButon.Name = "bulButon";
            this.bulButon.Size = new System.Drawing.Size(135, 60);
            this.bulButon.TabIndex = 16;
            this.bulButon.Text = "BUL";
            this.bulButon.UseVisualStyleBackColor = true;
            // 
            // barkodFoto
            // 
            this.barkodFoto.Location = new System.Drawing.Point(674, 13);
            this.barkodFoto.Name = "barkodFoto";
            this.barkodFoto.Size = new System.Drawing.Size(207, 261);
            this.barkodFoto.TabIndex = 17;
            this.barkodFoto.TabStop = false;
            // 
            // barkodButon
            // 
            this.barkodButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodButon.Location = new System.Drawing.Point(693, 344);
            this.barkodButon.Name = "barkodButon";
            this.barkodButon.Size = new System.Drawing.Size(189, 60);
            this.barkodButon.TabIndex = 18;
            this.barkodButon.Text = "BARKODU YAZDIR";
            this.barkodButon.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 284);
            this.dataGridView1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(483, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "FOTOĞRAF EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodTextBox.Location = new System.Drawing.Point(674, 286);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(207, 30);
            this.barkodTextBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 706);
            this.Controls.Add(this.barkodTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barkodButon);
            this.Controls.Add(this.barkodFoto);
            this.Controls.Add(this.bulButon);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adetTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bedenlerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.renkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelFoto);
            this.Controls.Add(this.modelTanimiTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelKoduTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "STOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelKoduTextBox;
        private System.Windows.Forms.TextBox modelTanimiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox modelFoto;
        private System.Windows.Forms.TextBox renkTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bedenlerComboBox;
        private System.Windows.Forms.TextBox adetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button guncelleButon;
        private System.Windows.Forms.Button bulButon;
        private System.Windows.Forms.PictureBox barkodFoto;
        private System.Windows.Forms.Button barkodButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox barkodTextBox;
    }
}

