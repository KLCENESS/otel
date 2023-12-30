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
    public partial class MusteriListe : Form
    {
        public MusteriListe()
        {
            InitializeComponent();
            ListeGetir();
            ComboBoxListesiAyarla(DurumAra, "MUSTERIDURUM");

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
            parametreler.Add(new DictionaryEntry("ListeTipi", "MusteriListe"));
            MusteriListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);

        }

        private void YeniKayit_Click(object sender, EventArgs e)
        {
             Musteri mus = new Musteri();
            {
                if (mus.yeniKayitEkle())
                   ListeGetir();
            }

        }

        private void Degistir_Click(object sender, EventArgs e)
        {
           
                if (MusteriListeGrid.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Önce güncellenecek kaydı seçin.");
                    return;
                }
                int f_varlikID = Convert.ToInt32(MusteriListeGrid.SelectedRows[0].Cells["ID"].Value);
                Musteri mus = new Musteri();
                if (mus.KayitGuncelle(f_varlikID))
                    ListeGetir();
           

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (MusteriListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce silinecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(MusteriListeGrid.SelectedRows[0].Cells["ID"].Value);
            Musteri mus = new Musteri();
            if (mus.KayitSil(f_varlikID))
                ListeGetir();

        }

        private void MusteriListeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriListeKomutPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sorgula_Click(object sender, EventArgs e)
        {
            DataTable f_kayit = veritabani.SELECTCalistir("select* from MusteriListe_v where(Ad +' ' + Soyad) like '%" +AdSoyadAraTxt.Text +"%' AND Durum = '"+DurumAra.SelectedValue+"'");
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Müşteri kaydı bulunamadı!..");
                return;
            }

            MusteriListeGrid.DataSource = f_kayit;
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
}

