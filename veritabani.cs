using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel
{
    class veritabani
    {
        //Data Source=localhost;Initial Catalog=MRPII;Integrated Security=true;
        // "Data Source=localhost;Initial Catalog=OgrenciDB;Integrated Security=true;";
        // "Data Source=LAPTOP-66I7EPUD\\SQLEXPRESS;Initial Catalog=otel;Integrated Security=True"; //Herhangi bir DataGridView'in ayarlarından bu adres çekilebilir.
        static string ConnectionString = "Data Source=ENESLERRR\\SQLEXPRESS;Initial Catalog=otel;Integrated Security=True";
        //NOT: Sunucu bağlantısı için yukarıdaki adreslemeleride içeriğini değiştirerek kullanabilirsiniz. 


        // "Data Source=localhost;Initial Catalog=OgrenciDB;Integrated Security=true;";
        static SqlConnection SunucuBaglantisi = new SqlConnection(ConnectionString);
        static public DataTable ProsedurCalistir_TabloGelir(string prosedurAdi, ArrayList parametreler)
        {
            DataTable f_table = new DataTable();
            SunucuBaglantisi.Open();
            SqlCommand komut = SunucuBaglantisi.CreateCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = prosedurAdi;
            if (parametreler != null)
            {
                foreach (DictionaryEntry parametre in parametreler)
                {
                    komut.Parameters.Add(new SqlParameter(parametre.Key.ToString(), parametre.Value));
                }
            }
            SqlDataReader dr = komut.ExecuteReader();
            f_table.Load(dr);
            SunucuBaglantisi.Close();
            return f_table;
        }
        static public bool ProsedurCalistir_MesajDegerlendir(string prosedurAdi, ArrayList parametreler)
        {
            DataTable f_table = ProsedurCalistir_TabloGelir(prosedurAdi, parametreler);
            if (Convert.ToInt32(f_table.Rows[0]["Sonuc"]) == 0) return true;
            System.Windows.Forms.MessageBox.Show(f_table.Rows[0]["Mesaj"].ToString());
            return false;
        }

        static public bool ProsedurCalistir_MesajDegerlendir2(string prosedurAdi, ArrayList parametreler)
        {
            DataTable f_table = ProsedurCalistir_TabloGelir(prosedurAdi, parametreler);
         //   if (Convert.ToInt32(f_table.Rows[0]["Sonuc"]) == 0) return true;
            //System.Windows.Forms.MessageBox.Show(f_table.Rows[0]["Mesaj"].ToString());
            return false;
        }

        static public DataTable SELECTCalistir(string SQLKomutu)
        {
            DataTable f_table = new DataTable();
            SunucuBaglantisi.Open();
            SqlCommand komut = SunucuBaglantisi.CreateCommand();
            komut.CommandType = CommandType.Text;
            komut.CommandText = SQLKomutu;
            SqlDataReader dr = komut.ExecuteReader();
            f_table.Load(dr);
            SunucuBaglantisi.Close();
            return f_table;
        }


    
    }
}

