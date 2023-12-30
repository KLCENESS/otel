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
    public partial class OdemeListe : Form
    {
        public OdemeListe()
        {
            InitializeComponent();
            ListeGetir();
            ComboBoxListesiAyarla(OdenmeDurumuSorgula, "ODENMEDURUMULISTESI");

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
            parametreler.Add(new DictionaryEntry("ListeTipi", "OdemeListe"));
            OdemeListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);
        }

        private void OdemeIslemleri_Click(object sender, EventArgs e)
        {
            Odeme o = new Odeme();
            o.ShowDialog();

        }

        private void Sorgula_Click(object sender, EventArgs e)
        {
            DataTable f_kayit = veritabani.SELECTCalistir("select*from OdemeListe_v where RezervasyonID like '%" + RezervasyonIDSorgula.Text+"%' and Durum like '%"+OdenmeDurumuSorgula.SelectedValue+"%'");
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Ödeme kaydı bulunamadı!..");
                return;
            }

            OdemeListeGrid.DataSource = f_kayit;
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
}

