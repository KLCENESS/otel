namespace otel
{
    partial class OdaListe
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
            this.Sil = new System.Windows.Forms.Button();
            this.Degistir = new System.Windows.Forms.Button();
            this.YeniKayit = new System.Windows.Forms.Button();
            this.OdaListeKomutPaneli = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OdaTipiSorgula = new System.Windows.Forms.ComboBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DurumSorgula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sorgula = new System.Windows.Forms.Button();
            this.OdaListeGrid = new System.Windows.Forms.DataGridView();
            this.OdaListeKomutPaneli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Sil
            // 
            this.Sil.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sil.Location = new System.Drawing.Point(195, 0);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 40);
            this.Sil.TabIndex = 2;
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
            this.Degistir.TabIndex = 1;
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
            this.YeniKayit.TabIndex = 0;
            this.YeniKayit.Text = "Yeni Kayıt";
            this.YeniKayit.UseVisualStyleBackColor = true;
            this.YeniKayit.Click += new System.EventHandler(this.YeniKayit_Click);
            // 
            // OdaListeKomutPaneli
            // 
            this.OdaListeKomutPaneli.Controls.Add(this.Sil);
            this.OdaListeKomutPaneli.Controls.Add(this.Degistir);
            this.OdaListeKomutPaneli.Controls.Add(this.YeniKayit);
            this.OdaListeKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OdaListeKomutPaneli.Location = new System.Drawing.Point(0, 410);
            this.OdaListeKomutPaneli.Name = "OdaListeKomutPaneli";
            this.OdaListeKomutPaneli.Size = new System.Drawing.Size(780, 40);
            this.OdaListeKomutPaneli.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OdaTipiSorgula);
            this.groupBox1.Controls.Add(this.Temizle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DurumSorgula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sorgula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // OdaTipiSorgula
            // 
            this.OdaTipiSorgula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdaTipiSorgula.FormattingEnabled = true;
            this.OdaTipiSorgula.Location = new System.Drawing.Point(106, 15);
            this.OdaTipiSorgula.Name = "OdaTipiSorgula";
            this.OdaTipiSorgula.Size = new System.Drawing.Size(164, 24);
            this.OdaTipiSorgula.TabIndex = 16;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(305, 52);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(199, 39);
            this.Temizle.TabIndex = 15;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Durum";
            // 
            // DurumSorgula
            // 
            this.DurumSorgula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurumSorgula.FormattingEnabled = true;
            this.DurumSorgula.Location = new System.Drawing.Point(106, 52);
            this.DurumSorgula.Name = "DurumSorgula";
            this.DurumSorgula.Size = new System.Drawing.Size(164, 24);
            this.DurumSorgula.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oda Tipi";
            // 
            // Sorgula
            // 
            this.Sorgula.Location = new System.Drawing.Point(305, 7);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(199, 39);
            this.Sorgula.TabIndex = 13;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // OdaListeGrid
            // 
            this.OdaListeGrid.AllowUserToAddRows = false;
            this.OdaListeGrid.AllowUserToDeleteRows = false;
            this.OdaListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OdaListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.OdaListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaListeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OdaListeGrid.Location = new System.Drawing.Point(0, 100);
            this.OdaListeGrid.MultiSelect = false;
            this.OdaListeGrid.Name = "OdaListeGrid";
            this.OdaListeGrid.ReadOnly = true;
            this.OdaListeGrid.RowHeadersWidth = 51;
            this.OdaListeGrid.RowTemplate.Height = 24;
            this.OdaListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdaListeGrid.Size = new System.Drawing.Size(780, 310);
            this.OdaListeGrid.TabIndex = 18;
            // 
            // OdaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.OdaListeGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OdaListeKomutPaneli);
            this.Name = "OdaListe";
            this.Text = "OdaListe";
            this.OdaListeKomutPaneli.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Degistir;
        private System.Windows.Forms.Button YeniKayit;
        private System.Windows.Forms.Panel OdaListeKomutPaneli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DurumSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.DataGridView OdaListeGrid;
        private System.Windows.Forms.ComboBox OdaTipiSorgula;
    }
}