using System;
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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void RezervasyonListesiGoruntule_Click(object sender, EventArgs e)
        {
            RezervasyonListe rListe = new RezervasyonListe();
            rListe.MdiParent = this;
            rListe.Show();

        }

        private void HatırlatmaListesiGoruntule_Click(object sender, EventArgs e)
        {
            HatirlatmaListe Liste = new HatirlatmaListe();
            Liste.MdiParent = this;
            Liste.Show();

        }



        private void MusteriListesiGoruntule_Click(object sender, EventArgs e)
        {
            MusteriListe mListe = new MusteriListe();
            mListe.MdiParent = this;
            mListe.Show();
        }


        private void OdaListesiGoruntule_Click(object sender, EventArgs e)
        {
            OdaListe Liste = new OdaListe();
            Liste.MdiParent = this;
            Liste.Show();

        }
    
        private void OdaTipiListesiGoruntule_Click(object sender, EventArgs e)
        {
            OdaTipiListe Liste = new OdaTipiListe();
            Liste.MdiParent = this;
            Liste.Show();

        }

        private void CalisanListesiGoruntule_Click(object sender, EventArgs e)
        {
            CalisanListe Liste = new CalisanListe();
            Liste.MdiParent = this;
            Liste.Show();

        }

        private void MasrafListesiGoruntule_Click(object sender, EventArgs e)
        {
            MasrafListe Liste = new MasrafListe();
            Liste.MdiParent = this;
            Liste.Show();
            
        }

        private void UrunListesiGoruntule_Click(object sender, EventArgs e)
        {
            UrunListe Liste = new UrunListe();
            Liste.MdiParent = this;
            Liste.Show();

        }

        private void SiparisListesiGoruntule_Click(object sender, EventArgs e)
        {
            SiparisListe Liste = new SiparisListe();
            Liste.MdiParent = this;
            Liste.Show();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            veritabani.ProsedurCalistir_TabloGelir("StatuGuncelle",null);
            veritabani.ProsedurCalistir_TabloGelir("HatirlatmaTablosuDoldurBosalt", null);
            
        }

        private void OdemeAl_Click(object sender, EventArgs e)
        {
            Odeme Liste = new Odeme();
            Liste.MdiParent = this;
            Liste.Show();
        }

        private void OdemeListesiGoruntule_Click(object sender, EventArgs e)
        {
            OdemeListe Liste = new OdemeListe();
            Liste.MdiParent = this;
            Liste.Show();
        }
    }
}
