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
    public partial class Form6 : Form
    {

        public int[] AKTS { get; set; }
        public int OGRNO { get; set; }
        public string[] DERSADI { get; set; }


        public Form6()
        {
            InitializeComponent();
        }

        public Form6(int[] akts,string[] dersadi,int ogrno)
        {
            AKTS = akts;
            DERSADI = dersadi;
            OGRNO = ogrno;
            InitializeComponent();
        }
        int donemi;
        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AKTS.Length; i++)
            {
                SqlConnection Baglantim4 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
                SqlCommand cmd5 = new SqlCommand("insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim4);
                cmd5.Parameters.AddWithValue("@ogr", OGRNO);
                cmd5.Parameters.AddWithValue("@dersadi", DERSADI[i]);
                cmd5.Parameters.AddWithValue("@AKTS", AKTS[i]);
                Baglantim4.Open();

                cmd5.ExecuteNonQuery();

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
                if (DersSinif == 4 && DersDonem == 1)
                {
                    SqlCommand Komut1 = new SqlCommand("Insert into SecilenDers(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim5);
                    Komut1.Parameters.AddWithValue("ogr", OGRNO);
                    Komut1.Parameters.AddWithValue("dersadi", DersAd);
                    Komut1.Parameters.AddWithValue("AKTS", DersKredi);
                    Komut1.ExecuteNonQuery();
                }
            }
            Baglantim5.Close();

            SqlConnection Baglantim7 = new SqlConnection("Server =localhost;Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
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




            SqlConnection Baglantim3 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
            SqlCommand Komut4 = new SqlCommand("select * from DersSecimi", Baglantim3);
            SqlDataAdapter adaptor = new SqlDataAdapter(Komut4);
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
            txt_alinanakts.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }



    }
}
