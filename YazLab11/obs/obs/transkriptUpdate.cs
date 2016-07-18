using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace obs
{
    class transkriptUpdate
    {
        public string OgrNo1 { get; set; }
        public string DersAdi1 { get; set; }
        public string AKTS1 { get; set; }
        public string HarfNotu1 { get; set; }
        public string Donem1 { get; set; }
        public string Sinif1 { get; set; }
        public string Katsayi1 { get; set; }
        public string Yol1 { get; set; }
        
        public static List<transkriptUpdate> getir1()
        {
            transkrip t1 = new transkrip();
            string yol1 = t1.Yol;
            List<transkriptUpdate> dersler1 = new List<transkriptUpdate>();
            
            SqlConnection con = new SqlConnection("Server =localhost; Database = SorgulamaDB; Trusted_Connection = True;");

            SqlCommand cmd = new SqlCommand("select OgrNo,DersAdi,HarfNotu,AKTS,Donem,Sinif,Katsayi from EklenenDers", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                string ogrno = dr["OgrNo"].ToString();
                string dersadi = dr["DersAdi"].ToString();
                string harfnotu = dr["HarfNotu"].ToString();
                string akts = dr["AKTS"].ToString();
                string donem = dr["Donem"].ToString();
                string sinif = dr["Sinif"].ToString();
                string katsayi = dr["Katsayi"].ToString();
                transkriptUpdate t = new transkriptUpdate
                {
                    OgrNo1 = ogrno,
                    DersAdi1 = dersadi,
                    AKTS1 = akts,
                    HarfNotu1 = harfnotu,
                    Donem1 = donem,
                    Sinif1 = sinif,
                    Katsayi1 = katsayi,
                    Yol1=yol1,
                };

                dersler1.Add(t);

            }

            con.Close();

            return dersler1;
        }
    }
}
