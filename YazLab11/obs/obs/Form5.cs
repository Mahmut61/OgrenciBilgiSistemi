using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace obs
{
    public partial class Form5 : Form
    {
        public int[] AKTS { get; set; }
        public int OGRNO { get; set; }
        public int USTENDERS { get; set; }
        public string[] DERSADI { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

         public Form5(int[] akts,string[] dersadi,int ogrno,int ustenders)
        {
            AKTS = akts;
            DERSADI = dersadi;
            USTENDERS = ustenders;
            OGRNO = ogrno;
            InitializeComponent();
        }
         int donemi;

         private void Form5_Load(object sender, EventArgs e)
         {


             if (USTENDERS == 0)
             {
                 for (int i = 0; i < AKTS.Length; i++)
                 {
                     SqlConnection Baglantim4 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
                     SqlCommand Komut5 = new SqlCommand("Insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim4);
                     Komut5.Parameters.AddWithValue("@ogr", OGRNO);
                     Komut5.Parameters.AddWithValue("@dersadi", DERSADI[i]);
                     Komut5.Parameters.AddWithValue("@AKTS", AKTS[i]);
                     Baglantim4.Open();

                     Komut5.ExecuteNonQuery();

                     Baglantim4.Close();
                 }

                 SqlConnection Baglantim5 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                 Baglantim5.Open();
                 SqlCommand Komut = new SqlCommand("Select DersAdi,DersSinif,Donem,Kredi from Dersler", Baglantim5);
                 SqlDataReader dr = Komut.ExecuteReader();
                 while (dr.Read())
                 {
                     string DersAd = dr["DersAdi"].ToString();
                     int DersSinif = Convert.ToInt32(dr["DersSinif"]);
                     int DersDonem = Convert.ToInt32(dr["Donem"]);
                     int DersKredi = Convert.ToInt32(dr["Kredi"]);
                     if (DersSinif == 3 && DersDonem == 1)
                     {
                         SqlCommand komut1 = new SqlCommand("insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim5);
                         komut1.Parameters.AddWithValue("ogr", OGRNO);
                         komut1.Parameters.AddWithValue("dersadi", DersAd);
                         komut1.Parameters.AddWithValue("AKTS", DersKredi);
                         komut1.ExecuteNonQuery();
                     }
                 }
                 Baglantim5.Close();
             }
             else if (USTENDERS == 1)
             {
                 SqlConnection Baglantim5 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                 Baglantim5.Open();
                 SqlCommand Komut = new SqlCommand("Select DersAdi,DersSinif,Donem,Kredi from Dersler", Baglantim5);
                 SqlDataReader dr = Komut.ExecuteReader();
                 while (dr.Read())
                 {
                     string DersAd = dr["DersAdi"].ToString();
                     int DersSinif = Convert.ToInt32(dr["DersSinif"]);
                     int DersDonem = Convert.ToInt32(dr["Donem"]);
                     int DersKredi = Convert.ToInt32(dr["Kredi"]);
                     if ((DersSinif == 3 || DersSinif == 4) && DersDonem == 1)
                     {
                         SqlCommand Komut1 = new SqlCommand("insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim5);
                         Komut1.Parameters.AddWithValue("ogr", OGRNO);
                         Komut1.Parameters.AddWithValue("dersadi", DersAd);
                         Komut1.Parameters.AddWithValue("AKTS", DersKredi);
                         Komut1.ExecuteNonQuery();
                     }
                 }
                 Baglantim5.Close();
             }

             SqlConnection Baglantim7 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
             Baglantim7.Open();
             SqlCommand Komut8 = new SqlCommand("Select SecildiMi,OgrenciNo from SinifListe where OgrenciNo=@ogrno ", Baglantim7);
             Komut8.Parameters.AddWithValue("@ogrno", OGRNO);
             SqlDataReader dr1 = Komut8.ExecuteReader();
             while (dr1.Read())
             {
                 donemi = Convert.ToInt32(dr1["SecildiMi"]);
             }
             SqlConnection Baglantim6 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
             Baglantim6.Open();
             SqlCommand Komut7 = new SqlCommand("Update SinifListe set SecildiMi=@derssec where OgrenciNo=@ogrno", Baglantim6);
             Komut7.Parameters.AddWithValue("ogrno", OGRNO);
             if (donemi == 0)
             {
                 Komut7.Parameters.AddWithValue("derssec", 1);
             }
             if (donemi == 1)
             {
                 Komut7.Parameters.AddWithValue("derssec", 0);
             }
             Komut7.ExecuteNonQuery();
             Baglantim6.Close();




             SqlConnection con3 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
             SqlCommand cmd4 = new SqlCommand("select * from DersSecimi", con3);
             SqlDataAdapter adaptor = new SqlDataAdapter(cmd4);
             DataTable ds = new DataTable();
             adaptor.Fill(ds);
             dataGridView1.DataSource = ds;
             dataGridView1.Columns[1].Visible = false;
             dataGridView1.Columns[2].Visible = true;

             int toplam = 0;

             for (int i = 0; i < dataGridView1.Rows.Count; i++)
             {
                 toplam = Convert.ToInt32(dataGridView1[4, i].Value) + toplam;
             }
             

         }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             txt_alinanogrno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             txt_alinanders.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             txt_akts.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
         }

       

}
}
