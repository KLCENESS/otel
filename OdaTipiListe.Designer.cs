namespace otel
{
    partial class OdaTipiListe
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
            this.OdaTipiListeGrid = new System.Windows.Forms.DataGridView();
            this.OdaTipiListeKomutPaneli = new System.Windows.Forms.Panel();
            this.Degistir = new System.Windows.Forms.Button();
            this.YeniKayit = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdaTipiListeGrid)).BeginInit();
            this.OdaTipiListeKomutPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdaTipiListeGrid
            // 
            this.OdaTipiListeGrid.AllowUserToAddRows = false;
            this.OdaTipiListeGrid.AllowUserToDeleteRows = false;
            this.OdaTipiListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OdaTipiListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.OdaTipiListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaTipiListeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OdaTipiListeGrid.Location = new System.Drawing.Point(0, 0);
            this.OdaTipiListeGrid.MultiSelect = false;
            this.OdaTipiListeGrid.Name = "OdaTipiListeGrid";
            this.OdaTipiListeGrid.ReadOnly = true;
            this.OdaTipiListeGrid.RowHeadersWidth = 51;
            this.OdaTipiListeGrid.RowTemplate.Height = 24;
            this.OdaTipiListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdaTipiListeGrid.Size = new System.Drawing.Size(800, 410);
            this.OdaTipiListeGrid.TabIndex = 5;
            // 
            // OdaTipiListeKomutPaneli
            // 
            this.OdaTipiListeKomutPaneli.Controls.Add(this.Sil);
            this.OdaTipiListeKomutPaneli.Controls.Add(this.Degistir);
            this.OdaTipiListeKomutPaneli.Controls.Add(this.YeniKayit);
            this.OdaTipiListeKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OdaTipiListeKomutPaneli.Location = new System.Drawing.Point(0, 410);
            this.OdaTipiListeKomutPaneli.Name = "OdaTipiListeKomutPaneli";
            this.OdaTipiListeKomutPaneli.Size = new System.Drawing.Size(800, 40);
            this.OdaTipiListeKomutPaneli.TabIndex = 4;
            // 
            // Degistir
            // 
            this.Degistir.Dock = System.Windows.Forms.DockStyle.Left;
            this.Degistir.Location = new System.Drawing.Point(120, 0);
            this.Degistir.Name = "Degistir";
            this.Degistir.Size = new System.Drawing.Size(75, 40);
            this.Degistir.TabIndex = 3;
            this.Degistir.Text = "Değiştir";
            this.Degistir.UseVisualStyleBackColor = true;
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
            // Sil
            // 
            this.Sil.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sil.Location = new System.Drawing.Point(195, 0);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 40);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // OdaTipiListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OdaTipiListeGrid);
            this.Controls.Add(this.OdaTipiListeKomutPaneli);
            this.Name = "OdaTipiListe";
            this.Text = "Oda Tipi Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.OdaTipiListeGrid)).EndInit();
            this.OdaTipiListeKomutPaneli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OdaTipiListeGrid;
        private System.Windows.Forms.Panel OdaTipiListeKomutPaneli;
        private System.Windows.Forms.Button YeniKayit;
        private System.Windows.Forms.Button Degistir;
        private System.Windows.Forms.Button Sil;
    }
}