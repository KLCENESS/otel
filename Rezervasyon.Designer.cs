namespace otel
{
    partial class Rezervasyon
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
            this.GirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.RezervasyonKomutPaneli = new System.Windows.Forms.Panel();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.Musteri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RezervasyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.OdaSorgula = new System.Windows.Forms.Button();
            this.Tarihler = new System.Windows.Forms.GroupBox();
            this.MevcutOdaSorgula = new System.Windows.Forms.Button();
            this.FarkliOdaSorgula = new System.Windows.Forms.Button();
            this.BosOdaListeGrid = new System.Windows.Forms.DataGridView();
            this.RezervasyondakiOdalarListeGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.RezervasyondakiOdalarLabel = new System.Windows.Forms.Label();
            this.MevcutOdaKaydiGroupBox = new System.Windows.Forms.GroupBox();
            this.BosOdalarGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.YeniMusteriEkle = new System.Windows.Forms.Button();
            this.RezervasyonKomutPaneli.SuspendLayout();
            this.Tarihler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BosOdaListeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyondakiOdalarListeGrid)).BeginInit();
            this.MevcutOdaKaydiGroupBox.SuspendLayout();
            this.BosOdalarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.CustomFormat = "dd.MM.yyyy";
            this.GirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GirisTarihi.Location = new System.Drawing.Point(144, 73);
            this.GirisTarihi.Name = "GirisTarihi";
            this.GirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.GirisTarihi.TabIndex = 29;
            this.GirisTarihi.Value = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giriş Tarihi";
            // 
            // RezervasyonKomutPaneli
            // 
            this.RezervasyonKomutPaneli.Controls.Add(this.Kaydet);
            this.RezervasyonKomutPaneli.Controls.Add(this.Iptal);
            this.RezervasyonKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RezervasyonKomutPaneli.Location = new System.Drawing.Point(0, 515);
            this.RezervasyonKomutPaneli.Name = "RezervasyonKomutPaneli";
            this.RezervasyonKomutPaneli.Size = new System.Drawing.Size(1225, 40);
            this.RezervasyonKomutPaneli.TabIndex = 15;
            // 
            // Kaydet
            // 
            this.Kaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kaydet.Location = new System.Drawing.Point(1075, 0);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 40);
            this.Kaydet.TabIndex = 1;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Dock = System.Windows.Forms.DockStyle.Right;
            this.Iptal.Location = new System.Drawing.Point(1150, 0);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 40);
            this.Iptal.TabIndex = 0;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            // 
            // Musteri
            // 
            this.Musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri.FormattingEnabled = true;
            this.Musteri.Location = new System.Drawing.Point(72, 26);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(293, 24);
            this.Musteri.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Müşteri";
            // 
            // RezervasyonTarihi
            // 
            this.RezervasyonTarihi.CustomFormat = "dd.MM.yyyy";
            this.RezervasyonTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RezervasyonTarihi.Location = new System.Drawing.Point(144, 24);
            this.RezervasyonTarihi.Name = "RezervasyonTarihi";
            this.RezervasyonTarihi.Size = new System.Drawing.Size(200, 22);
            this.RezervasyonTarihi.TabIndex = 35;
            this.RezervasyonTarihi.Value = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rezervasyon Tarihi";
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.CustomFormat = "dd.MM.yyyy";
            this.CikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CikisTarihi.Location = new System.Drawing.Point(144, 122);
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.CikisTarihi.TabIndex = 37;
            this.CikisTarihi.Value = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // OdaSorgula
            // 
            this.OdaSorgula.Location = new System.Drawing.Point(144, 158);
            this.OdaSorgula.Name = "OdaSorgula";
            this.OdaSorgula.Size = new System.Drawing.Size(200, 43);
            this.OdaSorgula.TabIndex = 38;
            this.OdaSorgula.Text = "Oda Sorgula";
            this.OdaSorgula.UseVisualStyleBackColor = true;
            this.OdaSorgula.Click += new System.EventHandler(this.OdaSorgula_Click);
            // 
            // Tarihler
            // 
            this.Tarihler.Controls.Add(this.MevcutOdaSorgula);
            this.Tarihler.Controls.Add(this.FarkliOdaSorgula);
            this.Tarihler.Controls.Add(this.RezervasyonTarihi);
            this.Tarihler.Controls.Add(this.label2);
            this.Tarihler.Controls.Add(this.label1);
            this.Tarihler.Controls.Add(this.OdaSorgula);
            this.Tarihler.Controls.Add(this.GirisTarihi);
            this.Tarihler.Controls.Add(this.CikisTarihi);
            this.Tarihler.Controls.Add(this.label6);
            this.Tarihler.Location = new System.Drawing.Point(14, 91);
            this.Tarihler.Name = "Tarihler";
            this.Tarihler.Size = new System.Drawing.Size(351, 261);
            this.Tarihler.TabIndex = 39;
            this.Tarihler.TabStop = false;
            // 
            // MevcutOdaSorgula
            // 
            this.MevcutOdaSorgula.Location = new System.Drawing.Point(30, 158);
            this.MevcutOdaSorgula.Name = "MevcutOdaSorgula";
            this.MevcutOdaSorgula.Size = new System.Drawing.Size(314, 43);
            this.MevcutOdaSorgula.TabIndex = 40;
            this.MevcutOdaSorgula.Text = "Mevcut Oda İçin Sorgula";
            this.MevcutOdaSorgula.UseVisualStyleBackColor = true;
            this.MevcutOdaSorgula.Click += new System.EventHandler(this.MevcutOdaSorgula_Click);
            // 
            // FarkliOdaSorgula
            // 
            this.FarkliOdaSorgula.Location = new System.Drawing.Point(30, 207);
            this.FarkliOdaSorgula.Name = "FarkliOdaSorgula";
            this.FarkliOdaSorgula.Size = new System.Drawing.Size(314, 43);
            this.FarkliOdaSorgula.TabIndex = 39;
            this.FarkliOdaSorgula.Text = "Farklı Odaları Sorgula";
            this.FarkliOdaSorgula.UseVisualStyleBackColor = true;
            this.FarkliOdaSorgula.Click += new System.EventHandler(this.FarkliOdaSorgula_Click);
            // 
            // BosOdaListeGrid
            // 
            this.BosOdaListeGrid.AllowUserToAddRows = false;
            this.BosOdaListeGrid.AllowUserToDeleteRows = false;
            this.BosOdaListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BosOdaListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.BosOdaListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BosOdaListeGrid.Location = new System.Drawing.Point(6, 44);
            this.BosOdaListeGrid.MultiSelect = false;
            this.BosOdaListeGrid.Name = "BosOdaListeGrid";
            this.BosOdaListeGrid.ReadOnly = true;
            this.BosOdaListeGrid.RowHeadersWidth = 51;
            this.BosOdaListeGrid.RowTemplate.Height = 24;
            this.BosOdaListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BosOdaListeGrid.Size = new System.Drawing.Size(809, 295);
            this.BosOdaListeGrid.TabIndex = 40;
            // 
            // RezervasyondakiOdalarListeGrid
            // 
            this.RezervasyondakiOdalarListeGrid.AllowUserToAddRows = false;
            this.RezervasyondakiOdalarListeGrid.AllowUserToDeleteRows = false;
            this.RezervasyondakiOdalarListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RezervasyondakiOdalarListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.RezervasyondakiOdalarListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyondakiOdalarListeGrid.Location = new System.Drawing.Point(6, 63);
            this.RezervasyondakiOdalarListeGrid.MultiSelect = false;
            this.RezervasyondakiOdalarListeGrid.Name = "RezervasyondakiOdalarListeGrid";
            this.RezervasyondakiOdalarListeGrid.ReadOnly = true;
            this.RezervasyondakiOdalarListeGrid.RowHeadersWidth = 51;
            this.RezervasyondakiOdalarListeGrid.RowTemplate.Height = 24;
            this.RezervasyondakiOdalarListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RezervasyondakiOdalarListeGrid.Size = new System.Drawing.Size(918, 85);
            this.RezervasyondakiOdalarListeGrid.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Boş Odalar";
            // 
            // RezervasyondakiOdalarLabel
            // 
            this.RezervasyondakiOdalarLabel.AutoSize = true;
            this.RezervasyondakiOdalarLabel.Location = new System.Drawing.Point(6, 30);
            this.RezervasyondakiOdalarLabel.Name = "RezervasyondakiOdalarLabel";
            this.RezervasyondakiOdalarLabel.Size = new System.Drawing.Size(164, 17);
            this.RezervasyondakiOdalarLabel.TabIndex = 43;
            this.RezervasyondakiOdalarLabel.Text = "Rezervasyondaki Odalar";
            // 
            // MevcutOdaKaydiGroupBox
            // 
            this.MevcutOdaKaydiGroupBox.Controls.Add(this.RezervasyondakiOdalarListeGrid);
            this.MevcutOdaKaydiGroupBox.Controls.Add(this.RezervasyondakiOdalarLabel);
            this.MevcutOdaKaydiGroupBox.Location = new System.Drawing.Point(14, 342);
            this.MevcutOdaKaydiGroupBox.Name = "MevcutOdaKaydiGroupBox";
            this.MevcutOdaKaydiGroupBox.Size = new System.Drawing.Size(1119, 154);
            this.MevcutOdaKaydiGroupBox.TabIndex = 47;
            this.MevcutOdaKaydiGroupBox.TabStop = false;
            // 
            // BosOdalarGroupBox
            // 
            this.BosOdalarGroupBox.Controls.Add(this.label9);
            this.BosOdalarGroupBox.Controls.Add(this.BosOdaListeGrid);
            this.BosOdalarGroupBox.Controls.Add(this.label3);
            this.BosOdalarGroupBox.Location = new System.Drawing.Point(388, 6);
            this.BosOdalarGroupBox.Name = "BosOdalarGroupBox";
            this.BosOdalarGroupBox.Size = new System.Drawing.Size(825, 354);
            this.BosOdalarGroupBox.TabIndex = 48;
            this.BosOdalarGroupBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 43;
            // 
            // YeniMusteriEkle
            // 
            this.YeniMusteriEkle.Location = new System.Drawing.Point(124, 56);
            this.YeniMusteriEkle.Name = "YeniMusteriEkle";
            this.YeniMusteriEkle.Size = new System.Drawing.Size(241, 43);
            this.YeniMusteriEkle.TabIndex = 41;
            this.YeniMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.YeniMusteriEkle.UseVisualStyleBackColor = true;
            this.YeniMusteriEkle.Click += new System.EventHandler(this.YeniMusteriEkle_Click);
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 555);
            this.Controls.Add(this.YeniMusteriEkle);
            this.Controls.Add(this.BosOdalarGroupBox);
            this.Controls.Add(this.MevcutOdaKaydiGroupBox);
            this.Controls.Add(this.Tarihler);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RezervasyonKomutPaneli);
            this.Name = "Rezervasyon";
            this.Text = "Rezervasyon";
            this.RezervasyonKomutPaneli.ResumeLayout(false);
            this.Tarihler.ResumeLayout(false);
            this.Tarihler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BosOdaListeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyondakiOdalarListeGrid)).EndInit();
            this.MevcutOdaKaydiGroupBox.ResumeLayout(false);
            this.MevcutOdaKaydiGroupBox.PerformLayout();
            this.BosOdalarGroupBox.ResumeLayout(false);
            this.BosOdalarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker GirisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel RezervasyonKomutPaneli;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.ComboBox Musteri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker RezervasyonTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CikisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OdaSorgula;
        private System.Windows.Forms.GroupBox Tarihler;
        private System.Windows.Forms.DataGridView BosOdaListeGrid;
        private System.Windows.Forms.Button FarkliOdaSorgula;
        private System.Windows.Forms.DataGridView RezervasyondakiOdalarListeGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RezervasyondakiOdalarLabel;
        private System.Windows.Forms.GroupBox MevcutOdaKaydiGroupBox;
        private System.Windows.Forms.GroupBox BosOdalarGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button MevcutOdaSorgula;
        private System.Windows.Forms.Button YeniMusteriEkle;
    }
}