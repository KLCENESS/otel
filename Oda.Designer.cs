namespace otel
{
    partial class Oda
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
            this.Kaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.OdaTipi = new System.Windows.Forms.ComboBox();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OdaNumarasi = new System.Windows.Forms.TextBox();
            this.MusteriKomutPaneli = new System.Windows.Forms.Panel();
            this.MusteriKomutPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kaydet.Location = new System.Drawing.Point(428, 0);
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
            this.Iptal.Location = new System.Drawing.Point(503, 0);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 40);
            this.Iptal.TabIndex = 0;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            // 
            // OdaTipi
            // 
            this.OdaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdaTipi.FormattingEnabled = true;
            this.OdaTipi.Location = new System.Drawing.Point(138, 98);
            this.OdaTipi.Name = "OdaTipi";
            this.OdaTipi.Size = new System.Drawing.Size(92, 24);
            this.OdaTipi.TabIndex = 25;
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(138, 59);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(249, 22);
            this.Aciklama.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Oda Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Oda Numarası";
            // 
            // OdaNumarasi
            // 
            this.OdaNumarasi.Location = new System.Drawing.Point(138, 27);
            this.OdaNumarasi.Name = "OdaNumarasi";
            this.OdaNumarasi.Size = new System.Drawing.Size(223, 22);
            this.OdaNumarasi.TabIndex = 16;
            // 
            // MusteriKomutPaneli
            // 
            this.MusteriKomutPaneli.Controls.Add(this.Kaydet);
            this.MusteriKomutPaneli.Controls.Add(this.Iptal);
            this.MusteriKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusteriKomutPaneli.Location = new System.Drawing.Point(0, 172);
            this.MusteriKomutPaneli.Name = "MusteriKomutPaneli";
            this.MusteriKomutPaneli.Size = new System.Drawing.Size(578, 40);
            this.MusteriKomutPaneli.TabIndex = 15;
            // 
            // Oda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 212);
            this.Controls.Add(this.OdaTipi);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdaNumarasi);
            this.Controls.Add(this.MusteriKomutPaneli);
            this.Name = "Oda";
            this.Text = "Oda";
            this.MusteriKomutPaneli.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.ComboBox OdaTipi;
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OdaNumarasi;
        private System.Windows.Forms.Panel MusteriKomutPaneli;
    }
}