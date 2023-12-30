namespace otel
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RezervasyonIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HatırlatmaListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.OdemeAl = new System.Windows.Forms.ToolStripMenuItem();
            this.OdemeListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaTipiListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.CalisanListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.MasrafListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.MagazaListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisListesiGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RezervasyonIslemleri,
            this.MusteriListesiGoruntule,
            this.OdaIslemleri,
            this.CalisanListesiGoruntule,
            this.MasrafListesiGoruntule,
            this.MagazaListesiGoruntule});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RezervasyonIslemleri
            // 
            this.RezervasyonIslemleri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RezervasyonIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem,
            this.HatırlatmaListesiGoruntule,
            this.OdemeAl,
            this.OdemeListesiGoruntule});
            this.RezervasyonIslemleri.Name = "RezervasyonIslemleri";
            this.RezervasyonIslemleri.Size = new System.Drawing.Size(165, 24);
            this.RezervasyonIslemleri.Text = "Rezervasyon İşlemleri";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.RezervasyonListesiGoruntule_Click);
            // 
            // HatırlatmaListesiGoruntule
            // 
            this.HatırlatmaListesiGoruntule.Name = "HatırlatmaListesiGoruntule";
            this.HatırlatmaListesiGoruntule.Size = new System.Drawing.Size(185, 26);
            this.HatırlatmaListesiGoruntule.Text = "Hatırlatma";
            this.HatırlatmaListesiGoruntule.Click += new System.EventHandler(this.HatırlatmaListesiGoruntule_Click);
            // 
            // OdemeAl
            // 
            this.OdemeAl.Name = "OdemeAl";
            this.OdemeAl.Size = new System.Drawing.Size(185, 26);
            this.OdemeAl.Text = "Ödeme Al";
            this.OdemeAl.Click += new System.EventHandler(this.OdemeAl_Click);
            // 
            // OdemeListesiGoruntule
            // 
            this.OdemeListesiGoruntule.Name = "OdemeListesiGoruntule";
            this.OdemeListesiGoruntule.Size = new System.Drawing.Size(185, 26);
            this.OdemeListesiGoruntule.Text = "Ödeme Listesi";
            this.OdemeListesiGoruntule.Click += new System.EventHandler(this.OdemeListesiGoruntule_Click);
            // 
            // MusteriListesiGoruntule
            // 
            this.MusteriListesiGoruntule.Name = "MusteriListesiGoruntule";
            this.MusteriListesiGoruntule.Size = new System.Drawing.Size(72, 24);
            this.MusteriListesiGoruntule.Text = "Müşteri";
            this.MusteriListesiGoruntule.Click += new System.EventHandler(this.MusteriListesiGoruntule_Click);
            // 
            // OdaIslemleri
            // 
            this.OdaIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OdaListesiGoruntule,
            this.OdaTipiListesiGoruntule});
            this.OdaIslemleri.Name = "OdaIslemleri";
            this.OdaIslemleri.Size = new System.Drawing.Size(111, 24);
            this.OdaIslemleri.Text = "Oda İşlemleri";
            // 
            // OdaListesiGoruntule
            // 
            this.OdaListesiGoruntule.Name = "OdaListesiGoruntule";
            this.OdaListesiGoruntule.Size = new System.Drawing.Size(164, 26);
            this.OdaListesiGoruntule.Text = "Oda Listesi";
            this.OdaListesiGoruntule.Click += new System.EventHandler(this.OdaListesiGoruntule_Click);
            // 
            // OdaTipiListesiGoruntule
            // 
            this.OdaTipiListesiGoruntule.Name = "OdaTipiListesiGoruntule";
            this.OdaTipiListesiGoruntule.Size = new System.Drawing.Size(164, 26);
            this.OdaTipiListesiGoruntule.Text = "Oda Tipi";
            this.OdaTipiListesiGoruntule.Click += new System.EventHandler(this.OdaTipiListesiGoruntule_Click);
            // 
            // CalisanListesiGoruntule
            // 
            this.CalisanListesiGoruntule.Name = "CalisanListesiGoruntule";
            this.CalisanListesiGoruntule.Size = new System.Drawing.Size(87, 24);
            this.CalisanListesiGoruntule.Text = "Çalışanlar";
            this.CalisanListesiGoruntule.Click += new System.EventHandler(this.CalisanListesiGoruntule_Click);
            // 
            // MasrafListesiGoruntule
            // 
            this.MasrafListesiGoruntule.Name = "MasrafListesiGoruntule";
            this.MasrafListesiGoruntule.Size = new System.Drawing.Size(68, 24);
            this.MasrafListesiGoruntule.Text = "Masraf";
            this.MasrafListesiGoruntule.Click += new System.EventHandler(this.MasrafListesiGoruntule_Click);
            // 
            // MagazaListesiGoruntule
            // 
            this.MagazaListesiGoruntule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunListesiGoruntule,
            this.SiparisListesiGoruntule});
            this.MagazaListesiGoruntule.Name = "MagazaListesiGoruntule";
            this.MagazaListesiGoruntule.Size = new System.Drawing.Size(76, 24);
            this.MagazaListesiGoruntule.Text = "Mağaza";
            // 
            // UrunListesiGoruntule
            // 
            this.UrunListesiGoruntule.Name = "UrunListesiGoruntule";
            this.UrunListesiGoruntule.Size = new System.Drawing.Size(153, 26);
            this.UrunListesiGoruntule.Text = "Ürünler";
            this.UrunListesiGoruntule.Click += new System.EventHandler(this.UrunListesiGoruntule_Click);
            // 
            // SiparisListesiGoruntule
            // 
            this.SiparisListesiGoruntule.Name = "SiparisListesiGoruntule";
            this.SiparisListesiGoruntule.Size = new System.Drawing.Size(153, 26);
            this.SiparisListesiGoruntule.Text = "Siparişler";
            this.SiparisListesiGoruntule.Click += new System.EventHandler(this.SiparisListesiGoruntule_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonIslemleri;
        private System.Windows.Forms.ToolStripMenuItem HatırlatmaListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem OdemeAl;
        private System.Windows.Forms.ToolStripMenuItem MusteriListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem OdaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem OdaTipiListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem CalisanListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem MagazaListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem UrunListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem SiparisListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem MasrafListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OdaListesiGoruntule;
        private System.Windows.Forms.ToolStripMenuItem OdemeListesiGoruntule;
    }
}

