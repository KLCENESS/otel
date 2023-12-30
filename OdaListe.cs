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
    public partial class OdaListe : Form
    {
        public OdaListe()
        {
            InitializeComponent();
            ListeGetir();
            ComboBoxListesiAyarla(OdaTipiSorgula, "ODATIPI2");
            ComboBoxListesiAyarla(DurumSorgula, "ODADURUM");

        }

        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = veritabani.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }

        void ListeGetir()
        {
            //   MusteriListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("MusteriListe", null);

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeTipi", "OdaListe"));
            OdaListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);

        }

        private void YeniKayit_Click(object sender, EventArgs e)
        {
            Oda o = new Oda();
            {
                if (o.yeniKayitEkle())
                    ListeGetir();
            }

        }

        private void Degistir_Click(object sender, EventArgs e)
        {

            if (OdaListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce güncellenecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(OdaListeGrid.SelectedRows[0].Cells["ID"].Value);
            Oda o = new Oda();
            if (o.KayitGuncelle(f_varlikID))
                ListeGetir();
        }


        private void Sil_Click(object sender, EventArgs e)
        {
            if (OdaListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce silinecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(OdaListeGrid.SelectedRows[0].Cells["ID"].Value);
            Oda o = new Oda(); 
            if (o.KayitSil(f_varlikID))
                ListeGetir();
        }
        private void Sorgula_Click(object sender, EventArgs e)
        {
            DataTable f_kayit = veritabani.SELECTCalistir("select * from OdaListe_v where [Oda Tipi] like '%"+OdaTipiSorgula.SelectedValue+"%' AND Durum like '%"+DurumSorgula.SelectedValue+"%'");
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Oda kaydı bulunamadı!..");
                return;
            }

            OdaListeGrid.DataSource = f_kayit;
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
}

