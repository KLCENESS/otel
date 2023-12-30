namespace otel
{
    partial class Musteri
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
            this.MusteriKomutPaneli = new System.Windows.Forms.Panel();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.TelefonNo = new System.Windows.Forms.NumericUpDown();
            this.Cinsiyet = new System.Windows.Forms.ComboBox();
            this.TCNo = new System.Windows.Forms.NumericUpDown();
            this.TCNolabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.MusteriKomutPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCNo)).BeginInit();
            this.SuspendLayout();
            // 
            // MusteriKomutPaneli
            // 
            this.MusteriKomutPaneli.Controls.Add(this.Kaydet);
            this.MusteriKomutPaneli.Controls.Add(this.Iptal);
            this.MusteriKomutPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusteriKomutPaneli.Location = new System.Drawing.Point(0, 325);
            this.MusteriKomutPaneli.Name = "MusteriKomutPaneli";
            this.MusteriKomutPaneli.Size = new System.Drawing.Size(694, 40);
            this.MusteriKomutPaneli.TabIndex = 0;
            // 
            // Kaydet
            // 
            this.Kaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kaydet.Location = new System.Drawing.Point(544, 0);
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
            this.Iptal.Location = new System.Drawing.Point(619, 0);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 40);
            this.Iptal.TabIndex = 0;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(203, 28);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(223, 22);
            this.Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cinsiyet";
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(203, 60);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(223, 22);
            this.Soyad.TabIndex = 7;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(203, 92);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(447, 22);
            this.Adres.TabIndex = 8;
            // 
            // TelefonNo
            // 
            this.TelefonNo.Location = new System.Drawing.Point(203, 156);
            this.TelefonNo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.TelefonNo.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(223, 22);
            this.TelefonNo.TabIndex = 9;
            this.TelefonNo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.TelefonNo.Value = new decimal(new int[] {
            757034724,
            1,
            0,
            0});
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cinsiyet.FormattingEnabled = true;
            this.Cinsiyet.Location = new System.Drawing.Point(203, 188);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(92, 24);
            this.Cinsiyet.TabIndex = 10;
            // 
            // TCNo
            // 
            this.TCNo.Location = new System.Drawing.Point(202, 124);
            this.TCNo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.TCNo.Minimum = new decimal(new int[] {
            -1773790777,
            2,
            0,
            0});
            this.TCNo.Name = "TCNo";
            this.TCNo.Size = new System.Drawing.Size(223, 22);
            this.TCNo.TabIndex = 12;
            this.TCNo.Value = new decimal(new int[] {
            -1773790777,
            2,
            0,
            0});
            // 
            // TCNolabel
            // 
            this.TCNolabel.AutoSize = true;
            this.TCNolabel.Location = new System.Drawing.Point(41, 127);
            this.TCNolabel.Name = "TCNolabel";
            this.TCNolabel.Size = new System.Drawing.Size(130, 17);
            this.TCNolabel.TabIndex = 11;
            this.TCNolabel.Text = "TC Kimlik Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doğum Tarihi";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.CustomFormat = "dd.MM.yyyy";
            this.DogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DogumTarihi.Location = new System.Drawing.Point(203, 222);
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.DogumTarihi.TabIndex = 14;
            this.DogumTarihi.Value = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 365);
            this.Controls.Add(this.DogumTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TCNo);
            this.Controls.Add(this.TCNolabel);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.TelefonNo);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.MusteriKomutPaneli);
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Formu";
            this.MusteriKomutPaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MusteriKomutPaneli;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown TelefonNo;
        private System.Windows.Forms.ComboBox Cinsiyet;
        private System.Windows.Forms.NumericUpDown TCNo;
        private System.Windows.Forms.Label TCNolabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DogumTarihi;
    }
}