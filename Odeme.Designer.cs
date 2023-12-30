namespace otel
{
    partial class Odeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TCNo = new System.Windows.Forms.TextBox();
            this.MusteriSorgula = new System.Windows.Forms.Button();
            this.MusteriListesiGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OdenmeDurumu = new System.Windows.Forms.ComboBox();
            this.RezervasyonSorgula = new System.Windows.Forms.Button();
            this.OdenecekRezervasyonlarGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ToplamFiyat = new System.Windows.Forms.TextBox();
            this.OdemeYap = new System.Windows.Forms.Button();
            this.OdemeIptal = new System.Windows.Forms.Button();
            this.OdemeTipi = new System.Windows.Forms.Label();
            this.OdemeTip = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListesiGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdenecekRezervasyonlarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TCNo);
            this.groupBox1.Controls.Add(this.MusteriSorgula);
            this.groupBox1.Controls.Add(this.MusteriListesiGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AdSoyad);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 467);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC No";
            // 
            // TCNo
            // 
            this.TCNo.Location = new System.Drawing.Point(81, 63);
            this.TCNo.Name = "TCNo";
            this.TCNo.Size = new System.Drawing.Size(276, 22);
            this.TCNo.TabIndex = 7;
            // 
            // MusteriSorgula
            // 
            this.MusteriSorgula.Location = new System.Drawing.Point(210, 96);
            this.MusteriSorgula.Name = "MusteriSorgula";
            this.MusteriSorgula.Size = new System.Drawing.Size(147, 37);
            this.MusteriSorgula.TabIndex = 6;
            this.MusteriSorgula.Text = "Sorgula";
            this.MusteriSorgula.UseVisualStyleBackColor = true;
            this.MusteriSorgula.Click += new System.EventHandler(this.MusteriSorgula_Click);
            // 
            // MusteriListesiGrid
            // 
            this.MusteriListesiGrid.AllowUserToAddRows = false;
            this.MusteriListesiGrid.AllowUserToDeleteRows = false;
            this.MusteriListesiGrid.AllowUserToResizeColumns = false;
            this.MusteriListesiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListesiGrid.Location = new System.Drawing.Point(10, 144);
            this.MusteriListesiGrid.MultiSelect = false;
            this.MusteriListesiGrid.Name = "MusteriListesiGrid";
            this.MusteriListesiGrid.ReadOnly = true;
            this.MusteriListesiGrid.RowHeadersWidth = 51;
            this.MusteriListesiGrid.RowTemplate.Height = 24;
            this.MusteriListesiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriListesiGrid.Size = new System.Drawing.Size(358, 311);
            this.MusteriListesiGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(81, 32);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(276, 22);
            this.AdSoyad.TabIndex = 3;
            this.AdSoyad.Tag = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OdenmeDurumu);
            this.groupBox2.Controls.Add(this.RezervasyonSorgula);
            this.groupBox2.Controls.Add(this.OdenecekRezervasyonlarGrid);
            this.groupBox2.Location = new System.Drawing.Point(393, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 326);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervasyonlar";
            // 
            // OdenmeDurumu
            // 
            this.OdenmeDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdenmeDurumu.FormattingEnabled = true;
            this.OdenmeDurumu.Location = new System.Drawing.Point(19, 33);
            this.OdenmeDurumu.Name = "OdenmeDurumu";
            this.OdenmeDurumu.Size = new System.Drawing.Size(164, 24);
            this.OdenmeDurumu.TabIndex = 12;
            // 
            // RezervasyonSorgula
            // 
            this.RezervasyonSorgula.Location = new System.Drawing.Point(200, 26);
            this.RezervasyonSorgula.Name = "RezervasyonSorgula";
            this.RezervasyonSorgula.Size = new System.Drawing.Size(208, 37);
            this.RezervasyonSorgula.TabIndex = 1;
            this.RezervasyonSorgula.Text = "Rezervasyonları Getir";
            this.RezervasyonSorgula.UseVisualStyleBackColor = true;
            this.RezervasyonSorgula.Click += new System.EventHandler(this.RezervasyonSorgula_Click);
            // 
            // OdenecekRezervasyonlarGrid
            // 
            this.OdenecekRezervasyonlarGrid.AllowUserToAddRows = false;
            this.OdenecekRezervasyonlarGrid.AllowUserToDeleteRows = false;
            this.OdenecekRezervasyonlarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdenecekRezervasyonlarGrid.Location = new System.Drawing.Point(19, 69);
            this.OdenecekRezervasyonlarGrid.Name = "OdenecekRezervasyonlarGrid";
            this.OdenecekRezervasyonlarGrid.ReadOnly = true;
            this.OdenecekRezervasyonlarGrid.RowHeadersWidth = 51;
            this.OdenecekRezervasyonlarGrid.RowTemplate.Height = 24;
            this.OdenecekRezervasyonlarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdenecekRezervasyonlarGrid.Size = new System.Drawing.Size(889, 239);
            this.OdenecekRezervasyonlarGrid.TabIndex = 0;
            this.OdenecekRezervasyonlarGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdenecekRezervasyonlarGrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Toplam Fiyat";
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.Location = new System.Drawing.Point(581, 398);
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.ReadOnly = true;
            this.ToplamFiyat.Size = new System.Drawing.Size(210, 22);
            this.ToplamFiyat.TabIndex = 7;
            // 
            // OdemeYap
            // 
            this.OdemeYap.Location = new System.Drawing.Point(838, 389);
            this.OdemeYap.Name = "OdemeYap";
            this.OdemeYap.Size = new System.Drawing.Size(208, 37);
            this.OdemeYap.TabIndex = 2;
            this.OdemeYap.Text = "Ödeme Yap";
            this.OdemeYap.UseVisualStyleBackColor = true;
            this.OdemeYap.Click += new System.EventHandler(this.OdemeYap_Click);
            // 
            // OdemeIptal
            // 
            this.OdemeIptal.Location = new System.Drawing.Point(838, 390);
            this.OdemeIptal.Name = "OdemeIptal";
            this.OdemeIptal.Size = new System.Drawing.Size(208, 37);
            this.OdemeIptal.TabIndex = 32;
            this.OdemeIptal.Text = "Ödemeyi İptal Et";
            this.OdemeIptal.UseVisualStyleBackColor = true;
            this.OdemeIptal.Click += new System.EventHandler(this.OdemeIptal_Click);
            // 
            // OdemeTipi
            // 
            this.OdemeTipi.AutoSize = true;
            this.OdemeTipi.Location = new System.Drawing.Point(458, 360);
            this.OdemeTipi.Name = "OdemeTipi";
            this.OdemeTipi.Size = new System.Drawing.Size(81, 17);
            this.OdemeTipi.TabIndex = 33;
            this.OdemeTipi.Text = "Ödeme Tipi";
            // 
            // OdemeTip
            // 
            this.OdemeTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdemeTip.FormattingEnabled = true;
            this.OdemeTip.Location = new System.Drawing.Point(582, 355);
            this.OdemeTip.Name = "OdemeTip";
            this.OdemeTip.Size = new System.Drawing.Size(164, 24);
            this.OdemeTip.TabIndex = 13;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 491);
            this.Controls.Add(this.OdemeTip);
            this.Controls.Add(this.OdemeTipi);
            this.Controls.Add(this.OdemeIptal);
            this.Controls.Add(this.OdemeYap);
            this.Controls.Add(this.ToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListesiGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OdenecekRezervasyonlarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MusteriSorgula;
        private System.Windows.Forms.DataGridView MusteriListesiGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdSoyad;
        private System.Windows.Forms.Button RezervasyonSorgula;
        private System.Windows.Forms.DataGridView OdenecekRezervasyonlarGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ToplamFiyat;
        private System.Windows.Forms.Button OdemeYap;
        private System.Windows.Forms.ComboBox OdenmeDurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TCNo;
        private System.Windows.Forms.Button OdemeIptal;
        private System.Windows.Forms.Label OdemeTipi;
        private System.Windows.Forms.ComboBox OdemeTip;
    }
}