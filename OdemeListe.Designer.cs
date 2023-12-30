namespace otel
{
    partial class OdemeListe
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
            this.OdemeListeKomutPaneli = new System.Windows.Forms.Panel();
            this.OdemeIslemleri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RezervasyonIDSorgula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Temizle = new System.Windows.Forms.Button();
            this.labeloda = new System.Windows.Forms.Label();
            this.OdenmeDurumuSorgula = new System.Windows.Forms.ComboBox();
            this.Sorgula = new System.Windows.Forms.Button();
            this.OdemeListeGrid = new System.Windows.Forms.DataGridView();
            this.OdemeListeKomutPaneli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OdemeListeKomutPaneli
            // 
            this.OdemeListeKomutPaneli.Controls.Add(this.OdemeIslemleri);
            this.OdemeListeKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OdemeListeKomutPaneli.Location = new System.Drawing.Point(0, 410);
            this.OdemeListeKomutPaneli.Name = "OdemeListeKomutPaneli";
            this.OdemeListeKomutPaneli.Size = new System.Drawing.Size(800, 40);
            this.OdemeListeKomutPaneli.TabIndex = 3;
            // 
            // OdemeIslemleri
            // 
            this.OdemeIslemleri.Dock = System.Windows.Forms.DockStyle.Right;
            this.OdemeIslemleri.Location = new System.Drawing.Point(545, 0);
            this.OdemeIslemleri.Name = "OdemeIslemleri";
            this.OdemeIslemleri.Size = new System.Drawing.Size(255, 40);
            this.OdemeIslemleri.TabIndex = 5;
            this.OdemeIslemleri.Text = "Ödeme işlemleri";
            this.OdemeIslemleri.UseVisualStyleBackColor = true;
            this.OdemeIslemleri.Click += new System.EventHandler(this.OdemeIslemleri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RezervasyonIDSorgula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.labeloda);
            this.groupBox1.Controls.Add(this.OdenmeDurumuSorgula);
            this.groupBox1.Controls.Add(this.Sorgula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 107);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // RezervasyonIDSorgula
            // 
            this.RezervasyonIDSorgula.Location = new System.Drawing.Point(190, 24);
            this.RezervasyonIDSorgula.Name = "RezervasyonIDSorgula";
            this.RezervasyonIDSorgula.Size = new System.Drawing.Size(260, 22);
            this.RezervasyonIDSorgula.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rezervasyon Numarası";
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(589, 55);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(199, 39);
            this.Temizle.TabIndex = 15;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // labeloda
            // 
            this.labeloda.AutoSize = true;
            this.labeloda.Location = new System.Drawing.Point(67, 67);
            this.labeloda.Name = "labeloda";
            this.labeloda.Size = new System.Drawing.Size(116, 17);
            this.labeloda.TabIndex = 8;
            this.labeloda.Text = "Ödenme Durumu";
            // 
            // OdenmeDurumuSorgula
            // 
            this.OdenmeDurumuSorgula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdenmeDurumuSorgula.FormattingEnabled = true;
            this.OdenmeDurumuSorgula.Location = new System.Drawing.Point(190, 64);
            this.OdenmeDurumuSorgula.Name = "OdenmeDurumuSorgula";
            this.OdenmeDurumuSorgula.Size = new System.Drawing.Size(164, 24);
            this.OdenmeDurumuSorgula.TabIndex = 14;
            // 
            // Sorgula
            // 
            this.Sorgula.Location = new System.Drawing.Point(589, 10);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(199, 39);
            this.Sorgula.TabIndex = 13;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // OdemeListeGrid
            // 
            this.OdemeListeGrid.AllowUserToAddRows = false;
            this.OdemeListeGrid.AllowUserToDeleteRows = false;
            this.OdemeListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OdemeListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.OdemeListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeListeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OdemeListeGrid.Location = new System.Drawing.Point(0, 107);
            this.OdemeListeGrid.MultiSelect = false;
            this.OdemeListeGrid.Name = "OdemeListeGrid";
            this.OdemeListeGrid.ReadOnly = true;
            this.OdemeListeGrid.RowHeadersWidth = 51;
            this.OdemeListeGrid.RowTemplate.Height = 24;
            this.OdemeListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdemeListeGrid.Size = new System.Drawing.Size(800, 303);
            this.OdemeListeGrid.TabIndex = 20;
            // 
            // OdemeListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OdemeListeGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OdemeListeKomutPaneli);
            this.Name = "OdemeListe";
            this.Text = "Ödeme Listesi";
            this.OdemeListeKomutPaneli.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OdemeListeKomutPaneli;
        private System.Windows.Forms.Button OdemeIslemleri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RezervasyonIDSorgula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Label labeloda;
        private System.Windows.Forms.ComboBox OdenmeDurumuSorgula;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.DataGridView OdemeListeGrid;
    }
}