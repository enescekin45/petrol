namespace Petrol
{
    partial class Urun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxturunMiktarı = new System.Windows.Forms.TextBox();
            this.TxturunFiyat = new System.Windows.Forms.TextBox();
            this.TxturunMarka = new System.Windows.Forms.TextBox();
            this.TxturunAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.silme = new System.Windows.Forms.PictureBox();
            this.Listeleme = new System.Windows.Forms.PictureBox();
            this.Ekleme = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtArma = new System.Windows.Forms.TextBox();
            this.Ara = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petroleriDataSet1 = new Petrol.petroleriDataSet1();
            this.ürünTableAdapter = new Petrol.petroleriDataSet1TableAdapters.ÜrünTableAdapter();
            this.petroleriDataSet3 = new Petrol.petroleriDataSet3();
            this.urunTableAdapter = new Petrol.petroleriDataSet3TableAdapters.UrunTableAdapter();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listeleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekleme)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guncelle)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petroleriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petroleriDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxturunMiktarı);
            this.groupBox1.Controls.Add(this.TxturunFiyat);
            this.groupBox1.Controls.Add(this.TxturunMarka);
            this.groupBox1.Controls.Add(this.TxturunAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜrünBilgilerini Giriniz";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // TxturunMiktarı
            // 
            this.TxturunMiktarı.Location = new System.Drawing.Point(111, 158);
            this.TxturunMiktarı.Name = "TxturunMiktarı";
            this.TxturunMiktarı.Size = new System.Drawing.Size(195, 26);
            this.TxturunMiktarı.TabIndex = 3;
            // 
            // TxturunFiyat
            // 
            this.TxturunFiyat.Location = new System.Drawing.Point(111, 119);
            this.TxturunFiyat.Name = "TxturunFiyat";
            this.TxturunFiyat.Size = new System.Drawing.Size(195, 26);
            this.TxturunFiyat.TabIndex = 2;
            // 
            // TxturunMarka
            // 
            this.TxturunMarka.Location = new System.Drawing.Point(111, 78);
            this.TxturunMarka.Name = "TxturunMarka";
            this.TxturunMarka.Size = new System.Drawing.Size(195, 26);
            this.TxturunMarka.TabIndex = 1;
            // 
            // TxturunAdi
            // 
            this.TxturunAdi.Location = new System.Drawing.Point(111, 37);
            this.TxturunAdi.Name = "TxturunAdi";
            this.TxturunAdi.Size = new System.Drawing.Size(195, 26);
            this.TxturunAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.silme);
            this.groupBox2.Controls.Add(this.Listeleme);
            this.groupBox2.Controls.Add(this.Ekleme);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt İşlemleri";
            // 
            // silme
            // 
            this.silme.Image = ((System.Drawing.Image)(resources.GetObject("silme.Image")));
            this.silme.Location = new System.Drawing.Point(252, 25);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(100, 50);
            this.silme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.silme.TabIndex = 2;
            this.silme.TabStop = false;
            this.silme.Click += new System.EventHandler(this.Silme_Click);
            // 
            // Listeleme
            // 
            this.Listeleme.Image = ((System.Drawing.Image)(resources.GetObject("Listeleme.Image")));
            this.Listeleme.Location = new System.Drawing.Point(129, 25);
            this.Listeleme.Name = "Listeleme";
            this.Listeleme.Size = new System.Drawing.Size(100, 50);
            this.Listeleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Listeleme.TabIndex = 1;
            this.Listeleme.TabStop = false;
            this.Listeleme.Click += new System.EventHandler(this.Listeleme_Click);
            // 
            // Ekleme
            // 
            this.Ekleme.Image = ((System.Drawing.Image)(resources.GetObject("Ekleme.Image")));
            this.Ekleme.Location = new System.Drawing.Point(6, 25);
            this.Ekleme.Name = "Ekleme";
            this.Ekleme.Size = new System.Drawing.Size(100, 50);
            this.Ekleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ekleme.TabIndex = 0;
            this.Ekleme.TabStop = false;
            this.Ekleme.Click += new System.EventHandler(this.Ekleme_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Guncelle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Düzenleme İşlemleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(159, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Değişikleri onayla";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(159, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Guncelle
            // 
            this.Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("Guncelle.Image")));
            this.Guncelle.Location = new System.Drawing.Point(14, 25);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(122, 75);
            this.Guncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guncelle.TabIndex = 0;
            this.Guncelle.TabStop = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtArma);
            this.groupBox4.Controls.Add(this.Ara);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(409, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arma İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Adını Giriniz";
            // 
            // TxtArma
            // 
            this.TxtArma.Location = new System.Drawing.Point(125, 51);
            this.TxtArma.Name = "TxtArma";
            this.TxtArma.Size = new System.Drawing.Size(314, 26);
            this.TxtArma.TabIndex = 1;
            // 
            // Ara
            // 
            this.Ara.Image = ((System.Drawing.Image)(resources.GetObject("Ara.Image")));
            this.Ara.Location = new System.Drawing.Point(17, 25);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(79, 67);
            this.Ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ara.TabIndex = 0;
            this.Ara.TabStop = false;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunFiyatiDataGridViewTextBoxColumn,
            this.urunTipiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(395, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 342);
            this.dataGridView1.TabIndex = 4;
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataMember = "Ürün";
            this.ürünBindingSource.DataSource = this.petroleriDataSet1;
            // 
            // petroleriDataSet1
            // 
            this.petroleriDataSet1.DataSetName = "petroleriDataSet1";
            this.petroleriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTableAdapter
            // 
            this.ürünTableAdapter.ClearBeforeFill = true;
            // 
            // petroleriDataSet3
            // 
            this.petroleriDataSet3.DataSetName = "petroleriDataSet3";
            this.petroleriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "Urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "Urun_id";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunFiyatiDataGridViewTextBoxColumn
            // 
            this.urunFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.Name = "urunFiyatiDataGridViewTextBoxColumn";
            // 
            // urunTipiDataGridViewTextBoxColumn
            // 
            this.urunTipiDataGridViewTextBoxColumn.DataPropertyName = "UrunTipi";
            this.urunTipiDataGridViewTextBoxColumn.HeaderText = "UrunTipi";
            this.urunTipiDataGridViewTextBoxColumn.Name = "urunTipiDataGridViewTextBoxColumn";
            // 
            // stokMiktariDataGridViewTextBoxColumn
            // 
            this.stokMiktariDataGridViewTextBoxColumn.DataPropertyName = "StokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.HeaderText = "StokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.Name = "stokMiktariDataGridViewTextBoxColumn";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Urun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.Urun_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.silme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listeleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekleme)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Guncelle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petroleriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petroleriDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxturunMiktarı;
        private System.Windows.Forms.TextBox TxturunFiyat;
        private System.Windows.Forms.TextBox TxturunMarka;
        private System.Windows.Forms.TextBox TxturunAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox silme;
        private System.Windows.Forms.PictureBox Listeleme;
        private System.Windows.Forms.PictureBox Ekleme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Guncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtArma;
        private System.Windows.Forms.PictureBox Ara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private petroleriDataSet1 petroleriDataSet1;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private petroleriDataSet1TableAdapters.ÜrünTableAdapter ürünTableAdapter;
        private petroleriDataSet3 petroleriDataSet3;
        private petroleriDataSet3TableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
    }
}