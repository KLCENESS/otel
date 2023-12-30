using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace otel
{
    public partial class Musteri : Form
    {
        int islem;//0: kayıt ekle, 1:Kayıt güncelle
        int VarlikID;//kayıt güncelleme sürecinde kullanılmaktadır.
        bool Sonuc = false;


        public Musteri()
        {
            InitializeComponent();
           // ComboBoxListesiAyarla(Program, "PROGRAMLISTESI");
            //ComboBoxListesiAyarla(Durum, "OGRENCIDURUM");
            ComboBoxListesiAyarla(Cinsiyet, "CINSIYET");
         //  ComboBoxListesiAyarla(Isimler, "MUSTERILISTESI");
        }

        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = veritabani.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }
        public bool yeniKayitEkle()
        {
            islem = 0;
           // LabelDurum.Visible = Durum.Visible = LabelBitirmeTarihi.Visible = BitirmeTarihi.Visible = false;
            this.ShowDialog();
            return Sonuc;
        }



        public bool KayitGuncelle(int MusteriVarlikID)
        {
            islem = 1;
            VarlikID = MusteriVarlikID;
            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = veritabani.SELECTCalistir("SELECT * FROM customer WHERE customer_id=" +
           MusteriVarlikID.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Müşteri kaydı bulunamadı!..");
                return false; 
            }
            //Program.SelectedValue = Convert.ToInt32(f_kayit.Rows[0]["ProgramID"]);
            TelefonNo.Text = f_kayit.Rows[0]["contact_no"].ToString();
            //Durum.SelectedValue = Convert.ToInt32(f_kayit.Rows[0]["Durum"]);
            TCNo.Value = Convert.ToInt64(f_kayit.Rows[0]["national_identifier"]);
            Ad.Text = f_kayit.Rows[0]["first_name"].ToString();
            Soyad.Text = f_kayit.Rows[0]["last_name"].ToString();
            Adres.Text = f_kayit.Rows[0]["address"].ToString();
            Cinsiyet.SelectedValue = f_kayit.Rows[0]["gender"].ToString();
            DogumTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["date_of_birth"]);
            //BitirmeTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["BitirmeTarihi"]);
            this.ShowDialog();
            return Sonuc;
        }

        public bool KayitSil(int VarlikID)
        {
            if (MessageBox.Show("Seçilen müşteri kaydı silinecek. Emin misiniz?", "Onayla",
           MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            return (veritabani.ProsedurCalistir_MesajDegerlendir("MusteriSil", parametreler));
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();

            if (islem == 1)
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            //parametreler.Add(new DictionaryEntry("ProgramID", Program.SelectedValue));
          //  if (islem == 1)6
           //     parametreler.Add(new DictionaryEntry("Durum", Durum.SelectedValue));
            parametreler.Add(new DictionaryEntry("TelefonNo", TelefonNo.Text));
            parametreler.Add(new DictionaryEntry("Adres", Adres.Text));
            parametreler.Add(new DictionaryEntry("TCNo", TCNo.Value));
            parametreler.Add(new DictionaryEntry("Ad", Ad.Text));
            parametreler.Add(new DictionaryEntry("Soyad", Soyad.Text));
            parametreler.Add(new DictionaryEntry("Cinsiyet", Cinsiyet.SelectedValue));
            parametreler.Add(new DictionaryEntry("DogumTarihi", DogumTarihi.Value));
            //if (islem == 1)
             //   parametreler.Add(new DictionaryEntry("BitirmeTarihi", BitirmeTarihi.Value));
            string f_prosedurAdi = "MusteriEkle";
            if (islem == 1)
                   f_prosedurAdi = "MusteriGuncelle";
            if (veritabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
        }      
    }
}
