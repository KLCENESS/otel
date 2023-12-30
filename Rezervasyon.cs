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
    public partial class Rezervasyon : Form
    {
        int islem;//0: kayıt ekle, 1:Kayıt güncelle
        int OdaDegis;
        int VarlikID;//kayıt güncelleme sürecinde kullanılmaktadır.
        bool Sonuc = false;

        public Rezervasyon()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(Musteri, "MUSTERILISTESI");

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
            MevcutOdaKaydiGroupBox.Visible = FarkliOdaSorgula.Visible = MevcutOdaSorgula.Visible = false;
            this.ShowDialog();
            return Sonuc;
        }

        public bool KayitGuncelle(int RezervasyonVarlikID)
        {

            // ListeGetir();
            OdaSorgula.Visible =YeniMusteriEkle.Visible= false;
            islem = 1;
            VarlikID = RezervasyonVarlikID;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("RezervasyonVarlikID", RezervasyonVarlikID));
            RezervasyondakiOdalarListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("MevcutRezervasyon", parametreler);

            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = veritabani.SELECTCalistir("SELECT * FROM booking WHERE booking_id=" +
           RezervasyonVarlikID.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Rezervasyon kaydı bulunamadı!..");
                return false;
            }

            Musteri.SelectedValue = f_kayit.Rows[0]["customer_id"].ToString();
            //OdaNumarasi.SelectedValue = f_kayit.Rows[0]["room_number"].ToString();
            //Durum.SelectedValue = f_kayit.Rows[0]["status"].ToString();
            RezervasyonTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["booking_date"]);
            GirisTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["checkin"]);
            CikisTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["checkout"]);
            this.ShowDialog();
            return Sonuc;
        }

        public bool KayitSil(int VarlikID)
        {
            if (MessageBox.Show("Seçilen rezervasyon kaydı silinecek. Emin misiniz?", "Onayla",
           MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            return (veritabani.ProsedurCalistir_MesajDegerlendir("RezervasyonSil", parametreler));
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            //önce forma doğru veri getir sonra kaydete gel.
            if (islem == 1)
                parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            parametreler.Add(new DictionaryEntry("Musteri_ID", Musteri.SelectedValue));
            //if (islem == 1)
              //  parametreler.Add(new DictionaryEntry("Durum", Durum.SelectedValue));
            parametreler.Add(new DictionaryEntry("RezervasyonTarihi", RezervasyonTarihi.Value));
            parametreler.Add(new DictionaryEntry("GirisTarihi", GirisTarihi.Value));
            parametreler.Add(new DictionaryEntry("CikisTarihi", CikisTarihi.Value));

            int f_Oda_ID= 0;

            if (islem == 0)
            {
                f_Oda_ID = Convert.ToInt32(BosOdaListeGrid.SelectedRows[0].Cells["ID"].Value);
            }
            else if (islem == 1)
            {
                f_Oda_ID = Convert.ToInt32(RezervasyondakiOdalarListeGrid.SelectedRows[0].Cells["OdaID"].Value);
                if (OdaDegis == 1)
                {
                    f_Oda_ID = Convert.ToInt32(BosOdaListeGrid.SelectedRows[0].Cells["ID"].Value);
                }
            }

            parametreler.Add(new DictionaryEntry("OdaID", f_Oda_ID));

            string f_prosedurAdi = "RezervasyonEkle";
            if (islem == 1)
                f_prosedurAdi = "RezervasyonGuncelle";
            if (veritabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }

        }

        private void OdaSorgula_Click(object sender, EventArgs e)
        {

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("checkin", GirisTarihi.Value));
            parametreler.Add(new DictionaryEntry("checkout", CikisTarihi.Value));
            BosOdaListeGrid.DataSource= veritabani.ProsedurCalistir_TabloGelir("BosOda", parametreler);     
            
        }

        private void MevcutOdaSorgula_Click(object sender, EventArgs e)
        {
            OdaDegis = 1;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("RezervasyonVarlikID", VarlikID));
            parametreler.Add(new DictionaryEntry("checkin", GirisTarihi.Value));
            parametreler.Add(new DictionaryEntry("checkout", CikisTarihi.Value));
            BosOdaListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("MevcutOdaUygunluk", parametreler);
        }

        private void FarkliOdaSorgula_Click(object sender, EventArgs e)
        {
            OdaDegis = 1;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("checkin", GirisTarihi.Value));
            parametreler.Add(new DictionaryEntry("checkout", CikisTarihi.Value));
            BosOdaListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("BosOda", parametreler);
        }

        private void YeniMusteriEkle_Click(object sender, EventArgs e)
        {

            Musteri mus = new Musteri();
            //mus.MdiParent = this;
            mus.ShowDialog();
            ComboBoxListesiAyarla(Musteri, "MUSTERILISTESI");
            
        }
    }
}

