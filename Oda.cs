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
    public partial class Oda : Form
    {
        int islem;//0: kayıt ekle, 1:Kayıt güncelle
        int VarlikID;//kayıt güncelleme sürecinde kullanılmaktadır.
        bool Sonuc = false;

        public Oda()
        {
            InitializeComponent();
            // ComboBoxListesiAyarla(Program, "PROGRAMLISTESI");
            //ComboBoxListesiAyarla(Durum, "OGRENCIDURUM");
            ComboBoxListesiAyarla(OdaTipi, "ODATIPI");
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

        public bool KayitGuncelle(int RoomVarlikID)
        {
            islem = 1;
            VarlikID = RoomVarlikID;
            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = veritabani.SELECTCalistir("SELECT * FROM room WHERE room_id=" +
           RoomVarlikID.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Oda kaydı bulunamadı!..");
                return false;
            }
            OdaNumarasi.Text = f_kayit.Rows[0]["room_number"].ToString();
            Aciklama.Text = f_kayit.Rows[0]["description"].ToString();
            OdaTipi.SelectedValue = f_kayit.Rows[0]["room_type_id"].ToString();
            this.ShowDialog();
            return Sonuc;
        }

        public bool KayitSil(int VarlikID)
        {
            if (MessageBox.Show("Seçilen oda kaydı silinecek. Emin misiniz?", "Onayla",
           MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            return (veritabani.ProsedurCalistir_MesajDegerlendir("OdaSil", parametreler));
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();

            if (islem == 1)
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));

            parametreler.Add(new DictionaryEntry("OdaNumarasi", OdaNumarasi.Text));
            parametreler.Add(new DictionaryEntry("Aciklama", Aciklama.Text));
            parametreler.Add(new DictionaryEntry("OdaTipiId", OdaTipi.SelectedValue));
            //if (islem == 1)
            //   parametreler.Add(new DictionaryEntry("BitirmeTarihi", BitirmeTarihi.Value));
            string f_prosedurAdi = "OdaEkle";
            if (islem == 1)
                f_prosedurAdi = "OdaGuncelle";
            if (veritabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }

        }

    }


    

}

