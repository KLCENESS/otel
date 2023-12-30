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
    public partial class Odeme : Form
    {

        string VarlikTC;
        string Islem; //Odeme veya OdemeIptal 
        int RezervasyonID;
        string TekrarCalistir = "ilk"; //ödeme yap veya ödeme iptal butonundan sonra tekrar sorgu çekildiğinde rezervasyon bulunamadı uyarısı vermesin.

        public Odeme()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(OdenmeDurumu, "ODEMEDURUMULISTESI");
            ComboBoxListesiAyarla(OdemeTip, "ODEMETIPLISTESI");

        }

        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = veritabani.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }

        private void MusteriSorgula_Click(object sender, EventArgs e)
        {
            DataTable f_kayit = veritabani.SELECTCalistir("select*from musteri_v where Ad_Soyad like '%" +AdSoyad.Text + "%' AND TCNo Like '%"+TCNo.Text +"%'");
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Müşteri kaydı bulunamadı!..");
                return;
            }
            
            MusteriListesiGrid.DataSource = f_kayit;
         }

        private void RezervasyonSorgula_Click(object sender, EventArgs e)
        {
            VarlikTC = Convert.ToString(MusteriListesiGrid.SelectedRows[0].Cells["TCNo"].Value);

            DataTable f_kayit = veritabani.SELECTCalistir("select*from OdemeEkraniRezervasyon_v where TCNo = '" + VarlikTC + "' AND Durum like '%"+ OdenmeDurumu.SelectedValue+ "%'");
            if (TekrarCalistir == "ilk")
            {
                if (f_kayit.Rows.Count < 1)
                {
                    MessageBox.Show("Rezervasyon kaydı bulunamadı!..");
                    return;
                }
                else
                {
                    OdenecekRezervasyonlarGrid.DataSource = f_kayit;
                }

                string f_Ucret = Convert.ToString(OdenecekRezervasyonlarGrid.SelectedRows[0].Cells["Ücret"].Value);
                ToplamFiyat.Text = f_Ucret;
            }
            else
            {
                OdenecekRezervasyonlarGrid.DataSource = f_kayit;
            }

            if (Convert.ToString(OdenmeDurumu.SelectedValue) == "Ödendi")
            {
                OdemeYap.Visible = false;
                OdemeIptal.Visible = true;
            }
            else
            {
                OdemeYap.Visible = true;
                OdemeIptal.Visible = false;
            }


           
        }


        private void OdenecekRezervasyonlarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string f_Ucret = Convert.ToString(OdenecekRezervasyonlarGrid.SelectedRows[0].Cells["Ücret"].Value);
            ToplamFiyat.Text = f_Ucret;

        }

        private void OdemeYap_Click(object sender, EventArgs e)
        {
            Islem = "Odeme";
            RezervasyonID = Convert.ToInt32(OdenecekRezervasyonlarGrid.SelectedRows[0].Cells["RezervasyonID"].Value);

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("RezervasyonID", RezervasyonID));
            parametreler.Add(new DictionaryEntry("Islem", Islem));
            parametreler.Add(new DictionaryEntry("OdemeTipi", OdemeTip.SelectedValue));
            veritabani.ProsedurCalistir_TabloGelir("OdemeAl", parametreler);

            TekrarCalistir = "iki";
            RezervasyonSorgula_Click(sender, e);
        }

        private void OdemeIptal_Click(object sender, EventArgs e)
        {
            Islem = "OdemeIptal";
            RezervasyonID = Convert.ToInt32(OdenecekRezervasyonlarGrid.SelectedRows[0].Cells["RezervasyonID"].Value);

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("RezervasyonID", RezervasyonID));
            parametreler.Add(new DictionaryEntry("OdemeTipi", OdemeTip.SelectedValue));
            parametreler.Add(new DictionaryEntry("Islem", Islem));
            veritabani.ProsedurCalistir_TabloGelir("OdemeAl", parametreler);


            TekrarCalistir = "iki";
            RezervasyonSorgula_Click(sender, e);

        }

    }
}

