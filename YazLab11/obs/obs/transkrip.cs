using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace obs
{
    class transkrip
    {
        public string OgrNo { get; set; }
        public string DersAdi { get; set; }
        public string AKTS { get; set; }
        public string HarfNotu { get; set; }
        public string Donem { get; set; }
        public string Sinif { get; set; }
        public string Katsayi { get; set; }
        public string Yol { get; set; }
        
        public static List<transkrip> getir(string yol)
        {
            List<transkrip> dersler = new List<transkrip>();
            
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+yol+";Extended Properties='Excel 12.0 Xml;HDR=YES';");

            OleDbCommand cmd = new OleDbCommand("select OgrNo,DersAdi,HarfNotu,AKTS,Donem,Sinif,Katsayi from [Sayfa1$]", con);

            con.Open();

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string ogrno = dr["OgrNo"].ToString();
                string dersadi = dr["DersAdi"].ToString();
                string harfnotu = dr["HarfNotu"].ToString();
                string akts = dr["AKTS"].ToString();
                string donem = dr["Donem"].ToString();
                string sinif = dr["Sinif"].ToString();
                string katsayi = dr["Katsayi"].ToString();
                transkrip t = new transkrip
                {
                    OgrNo = ogrno,
                    DersAdi = dersadi,
                    AKTS = akts,
                    HarfNotu = harfnotu,
                    Donem = donem,
                    Sinif = sinif,
                    Katsayi=katsayi,
                    Yol=yol,
                };

                dersler.Add(t);

            }

            con.Close();
            
            return dersler;
        }

    }
}
