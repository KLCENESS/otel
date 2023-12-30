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
    public partial class HatirlatmaListe : Form
    {
        public HatirlatmaListe()
        {
            InitializeComponent();
            ListeGetir();
        }

        void ListeGetir()
        {
            //   MusteriListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("MusteriListe", null);

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeTipi", "HatirlatmaListe"));
            HatirlatmaListeGrid.DataSource = veritabani.ProsedurCalistir_TabloGelir("ListeGetir", parametreler);

        }

        private void HatirlatmaListe_Load(object sender, EventArgs e){}
    }
}



      