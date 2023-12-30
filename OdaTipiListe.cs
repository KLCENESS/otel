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
    public partial class OdaTipiListe : Form
    {
        public OdaTipiListe()
        {
            InitializeComponent();
            ListeGetir();
        }

        void ListeGetir()
        {
            //   MusteriListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("MusteriListe", null);

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeTipi", "OdaTipiListe"));
            OdaTipiListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);

        }

        private void YeniKayit_Click(object sender, EventArgs e)
        {
            OdaTipi o = new OdaTipi();
           {
                if (o.yeniKayitEkle())
                ListeGetir();
           }

        }

        private void Degistir_Click(object sender, EventArgs e)
        {
            if (OdaTipiListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce güncellenecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(OdaTipiListeGrid.SelectedRows[0].Cells["ID"].Value);
            OdaTipi o = new OdaTipi();
            if (o.KayitGuncelle(f_varlikID))
                ListeGetir();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (OdaTipiListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce silinecek kaydı seçin.");
                return;
            }
            int f_varlikID = Convert.ToInt32(OdaTipiListeGrid.SelectedRows[0].Cells["ID"].Value);
            OdaTipi o = new OdaTipi();
            if (o.KayitSil(f_varlikID))
                ListeGetir();

        }

    }
}

