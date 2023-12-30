namespace otel
{
    partial class OdaTipi
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
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OdaTip = new System.Windows.Forms.TextBox();
            this.MusteriKomutPaneli = new System.Windows.Forms.Panel();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.Ucret = new System.Windows.Forms.TextBox();
            this.MusteriKomutPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(138, 46);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(346, 22);
            this.Aciklama.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ücret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Oda Tipi";
            // 
            // OdaTip
            // 
            this.OdaTip.Location = new System.Drawing.Point(138, 14);
            this.OdaTip.Name = "OdaTip";
            this.OdaTip.Size = new System.Drawing.Size(223, 22);
            this.OdaTip.TabIndex = 27;
            // 
            // MusteriKomutPaneli
            // 
            this.MusteriKomutPaneli.Controls.Add(this.Kaydet);
            this.MusteriKomutPaneli.Controls.Add(this.Iptal);
            this.MusteriKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusteriKomutPaneli.Location = new System.Drawing.Point(0, 135);
            this.MusteriKomutPaneli.Name = "MusteriKomutPaneli";
            this.MusteriKomutPaneli.Size = new System.Drawing.Size(496, 40);
            this.MusteriKomutPaneli.TabIndex = 26;
            // 
            // Kaydet
            // 
            this.Kaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kaydet.Location = new System.Drawing.Point(346, 0);
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
            this.Iptal.Location = new System.Drawing.Point(421, 0);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 40);
            this.Iptal.TabIndex = 0;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            // 
            // Ucret
            // 
            this.Ucret.Location = new System.Drawing.Point(138, 83);
            this.Ucret.Name = "Ucret";
            this.Ucret.Size = new System.Drawing.Size(223, 22);
            this.Ucret.TabIndex = 32;
            // 
            // OdaTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 175);
            this.Controls.Add(this.Ucret);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdaTip);
            this.Controls.Add(this.MusteriKomutPaneli);
            this.Name = "OdaTipi";
            this.Text = "OdaTipi";
            this.MusteriKomutPaneli.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OdaTip;
        private System.Windows.Forms.Panel MusteriKomutPaneli;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.TextBox Ucret;
    }
}