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
    public partial class OdaTipi : Form
    {

        int islem;//0: kayıt ekle, 1:Kayıt güncelle
        int VarlikID;//kayıt güncelleme sürecinde kullanılmaktadır.
        bool Sonuc = false;

        public OdaTipi()
        {
            InitializeComponent();
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
            DataTable f_kayit = veritabani.SELECTCalistir("SELECT * FROM room_type WHERE room_type_id=" +
           RoomVarlikID.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Oda Tipi kaydı bulunamadı!..");
                return false;
            }
            OdaTip.Text = f_kayit.Rows[0]["room_type"].ToString();
            Aciklama.Text = f_kayit.Rows[0]["description"].ToString();
            Ucret.Text = f_kayit.Rows[0]["price"].ToString();
            this.ShowDialog();
            return Sonuc;
        }

        public bool KayitSil(int VarlikID)
        {
            if (MessageBox.Show("Seçilen oda tipi kaydı silinecek. Emin misiniz?", "Onayla",
           MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));
            return (veritabani.ProsedurCalistir_MesajDegerlendir("OdaTipiSil", parametreler));
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();

            if (islem == 1)
                parametreler.Add(new DictionaryEntry("VarlikID", VarlikID));

            parametreler.Add(new DictionaryEntry("OdaTipi", OdaTip.Text));
            parametreler.Add(new DictionaryEntry("Aciklama", Aciklama.Text));
            parametreler.Add(new DictionaryEntry("Ucret ", Ucret.Text));
              string f_prosedurAdi = "OdaTipiEkle";
            if (islem == 1)
                f_prosedurAdi = "OdaTipiGuncelle";
            if (veritabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }

        }
        
    }
}



