namespace otel
{
    partial class MusteriListe
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
            this.MusteriListeKomutPaneli = new System.Windows.Forms.Panel();
            this.Sil = new System.Windows.Forms.Button();
            this.Degistir = new System.Windows.Forms.Button();
            this.YeniKayit = new System.Windows.Forms.Button();
            this.Sorgula = new System.Windows.Forms.Button();
            this.AdSoyadAraTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DurumAra = new System.Windows.Forms.ComboBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MusteriListeGrid = new System.Windows.Forms.DataGridView();
            this.MusteriListeKomutPaneli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MusteriListeKomutPaneli
            // 
            this.MusteriListeKomutPaneli.Controls.Add(this.Sil);
            this.MusteriListeKomutPaneli.Controls.Add(this.Degistir);
            this.MusteriListeKomutPaneli.Controls.Add(this.YeniKayit);
            this.MusteriListeKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusteriListeKomutPaneli.Location = new System.Drawing.Point(0, 393);
            this.MusteriListeKomutPaneli.Name = "MusteriListeKomutPaneli";
            this.MusteriListeKomutPaneli.Size = new System.Drawing.Size(1082, 40);
            this.MusteriListeKomutPaneli.TabIndex = 0;
            this.MusteriListeKomutPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.MusteriListeKomutPaneli_Paint);
            // 
            // Sil
            // 
            this.Sil.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sil.Location = new System.Drawing.Point(195, 0);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 40);
            this.Sil.TabIndex = 5;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Degistir
            // 
            this.Degistir.Dock = System.Windows.Forms.DockStyle.Left;
            this.Degistir.Location = new System.Drawing.Point(120, 0);
            this.Degistir.Name = "Degistir";
            this.Degistir.Size = new System.Drawing.Size(75, 40);
            this.Degistir.TabIndex = 4;
            this.Degistir.Text = "Değiştir";
            this.Degistir.UseVisualStyleBackColor = true;
            this.Degistir.UseWaitCursor = true;
            this.Degistir.Click += new System.EventHandler(this.Degistir_Click);
            // 
            // YeniKayit
            // 
            this.YeniKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.YeniKayit.Location = new System.Drawing.Point(0, 0);
            this.YeniKayit.Name = "YeniKayit";
            this.YeniKayit.Size = new System.Drawing.Size(120, 40);
            this.YeniKayit.TabIndex = 3;
            this.YeniKayit.Text = "Yeni Kayıt";
            this.YeniKayit.UseVisualStyleBackColor = true;
            this.YeniKayit.Click += new System.EventHandler(this.YeniKayit_Click);
            // 
            // Sorgula
            // 
            this.Sorgula.Location = new System.Drawing.Point(330, 6);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(199, 39);
            this.Sorgula.TabIndex = 13;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // AdSoyadAraTxt
            // 
            this.AdSoyadAraTxt.Location = new System.Drawing.Point(83, 15);
            this.AdSoyadAraTxt.Name = "AdSoyadAraTxt";
            this.AdSoyadAraTxt.Size = new System.Drawing.Size(222, 22);
            this.AdSoyadAraTxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Durum";
            // 
            // DurumAra
            // 
            this.DurumAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurumAra.FormattingEnabled = true;
            this.DurumAra.Location = new System.Drawing.Point(83, 50);
            this.DurumAra.Name = "DurumAra";
            this.DurumAra.Size = new System.Drawing.Size(164, 24);
            this.DurumAra.TabIndex = 14;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(330, 47);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(199, 39);
            this.Temizle.TabIndex = 15;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdSoyadAraTxt);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DurumAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sorgula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 90);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // MusteriListeGrid
            // 
            this.MusteriListeGrid.AllowUserToAddRows = false;
            this.MusteriListeGrid.AllowUserToDeleteRows = false;
            this.MusteriListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MusteriListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.MusteriListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusteriListeGrid.Location = new System.Drawing.Point(0, 90);
            this.MusteriListeGrid.MultiSelect = false;
            this.MusteriListeGrid.Name = "MusteriListeGrid";
            this.MusteriListeGrid.ReadOnly = true;
            this.MusteriListeGrid.RowHeadersWidth = 51;
            this.MusteriListeGrid.RowTemplate.Height = 24;
            this.MusteriListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriListeGrid.Size = new System.Drawing.Size(1082, 303);
            this.MusteriListeGrid.TabIndex = 17;
            // 
            // MusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 433);
            this.Controls.Add(this.MusteriListeGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MusteriListeKomutPaneli);
            this.Name = "MusteriListe";
            this.Text = "Müşteri Listesi";
            this.MusteriListeKomutPaneli.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MusteriListeKomutPaneli;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Degistir;
        private System.Windows.Forms.Button YeniKayit;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.TextBox AdSoyadAraTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DurumAra;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MusteriListeGrid;
    }
}