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
    public partial class RezervasyonListe : Form
    {
        public RezervasyonListe()
        {
            InitializeComponent();
            ListeGetir();
            ComboBoxListesiAyarla(OdaSorgula, "ODALISTESI");
            ComboBoxListesiAyarla(ZamanSorgula, "REZERVASYONZAMANLISTESI");

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
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeTipi", "RezervasyonListe"));
            RezervasyonListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);

        }

        private void YeniKayit_Click(object sender, EventArgs e)
        {
            Rezervasyon r = new Rezervasyon();
            {
                if (r.yeniKayitEkle())
                    ListeGetir();
            }

        }

        private void Degistir_Click(object sender, EventArgs e)
        {

            if (RezervasyonListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce güncellenecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(RezervasyonListeGrid.SelectedRows[0].Cells["ID"].Value);
            Rezervasyon r = new Rezervasyon();
            if (r.KayitGuncelle(f_varlikID))
                ListeGetir();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (RezervasyonListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce silinecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(RezervasyonListeGrid.SelectedRows[0].Cells["ID"].Value);
            Rezervasyon r = new Rezervasyon();
            if (r.KayitSil(f_varlikID))
                ListeGetir();
        }

        private void RezervasyonListe_Load(object sender, EventArgs e)
        {

        }
        private void Sorgula_Click(object sender, EventArgs e)
        {
            DataTable f_kayit = veritabani.SELECTCalistir("select * from RezervasyonListe_v where Müşteri like '%"+AdSoyadSorgula.Text+"%' and [Kalan Zaman] like '%"+ZamanSorgula.SelectedValue+"%' and [Oda Numarası] like '%"+OdaSorgula.SelectedValue+"%'");
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Rezervasyon kaydı bulunamadı!..");
                return;
            }

            RezervasyonListeGrid.DataSource = f_kayit;
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
}

