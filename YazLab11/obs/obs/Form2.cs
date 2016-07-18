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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int ogrno;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            ogrno = Convert.ToInt32(lbl_ogrno.Text);

            SqlConnection Baglantim1 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
            Baglantim1.Open();
            SqlCommand Komut2 = new SqlCommand("select OgrenciNo,SecildiMi from SinifListe", Baglantim1);
            SqlDataReader dr1 = Komut2.ExecuteReader();
            while (dr1.Read())
            {
                int ogrencino = Convert.ToInt32(dr1["OgrenciNo"]);
                if (ogrno == ogrencino)
                {
                    derssec = Convert.ToInt32(dr1["SecildiMi"]);
                    break;
                }

            }
            Baglantim1.Close();
            if (derssec == 1)
            {
                btn_dersecim.Enabled = false;
                lblSecildiMi.Visible = true;
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();
            f1.Show();

        }
        int sinifno;
        int derssec;

        private void btn_dersecim_Click(object sender, EventArgs e)
        {
            sinifno = Convert.ToInt32(lbl_sinifno.Text);
            float[,] donemort = new float[sinifno - 1, 2];
            for (int k = 0; k < sinifno - 1; k++)
            {
                for (int l = 0; l < 2; l++)
                {
                    donemort[k, l] = 0;
                }

            }
            for (int i = 1; i < sinifno; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    float toplam = 0;
                    float tplmakts = 0;
                    float ort = 0;
                    SqlConnection Baglantim = new SqlConnection("Server =localhost;Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                    SqlCommand Komut = new SqlCommand("select OgrenciNo,AKTS,Donem,Katsayi from Transkript where OgrenciNo=@ogrno and Donem=@ortdonem", Baglantim);
                    Komut.Parameters.AddWithValue("ogrno", ogrno);
                    Komut.Parameters.AddWithValue("ortdonem", j);
                    Baglantim.Open();

                    SqlDataReader dr = Komut.ExecuteReader();

                    while (dr.Read())
                    {
                        int ortakts = Convert.ToInt32(dr["AKTS"]);
                        float ortkatsayi = Convert.ToInt64(dr["Katsayi"]);
                        toplam = toplam + ortakts * ortkatsayi;
                        tplmakts = tplmakts + ortakts;
                    }
                    ort = toplam / tplmakts;
                    donemort[i - 1, j] = ort;
                    Baglantim.Close();
                }
            }

            if (derssec != 1)
            {
                if (derssec == 0)  // 1.SINIF GÜZ DÖNEMİ
                {
                    if (sinifno == 1)
                    {
                        SqlConnection Baglantim = new SqlConnection("Server =localhost;Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                        Baglantim.Open();
                        SqlCommand cmd = new SqlCommand("select DersAdi,DersSinif,Donem,Kredi from Dersler", Baglantim);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            string DersAd = dr["DersAdi"].ToString();
                            int DersSinif = Convert.ToInt32(dr["DersSinif"]);
                            int DersDonem = Convert.ToInt32(dr["Donem"]);
                            int DersKredi = Convert.ToInt32(dr["Kredi"]);
                            if (DersSinif == sinifno && DersDonem == derssec + 1)
                            {
                                SqlCommand Komut1 = new SqlCommand("insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim);
                                Komut1.Parameters.AddWithValue("ogr", ogrno);
                                Komut1.Parameters.AddWithValue("dersadi", DersAd);
                                Komut1.Parameters.AddWithValue("AKTS", DersKredi);
                                Komut1.ExecuteNonQuery();
                            }
                        }
                        SqlCommand Komut3 = new SqlCommand("update SinifListe set SecildiMi=@derssec where OgrenciNo=@ogrno", Baglantim);
                        Komut3.Parameters.AddWithValue("ogrno", ogrno);
                        Komut3.Parameters.AddWithValue("derssec", 1);
                        Komut3.ExecuteNonQuery();
                        Baglantim.Close();
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                    }
                    else if (sinifno == 2)
                    {
                        if (derssec != 1)
                        {
                            int[] secimakts = new int[0];
                            string[] secimdersadi = new string[0];
                            if (donemort[0, 0] < 2 && donemort[0, 1] < 2)
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("select OgrenciNo,DersAdi,AKTS,Donem,Katsayi from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 2)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 0);
                                f4.Show();

                                this.Hide();
                            }
                            else if ((donemort[0, 0] > 2 || donemort[0, 1] > 2) && (donemort[0, 1] < 3))
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 1)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 0);
                                f4.Show();

                                this.Hide();
                            }
                            else
                            {
                                Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 1);
                                f4.Show();

                                this.Hide();
                            }
                        }
                    }
                    else if (sinifno == 3)
                    {
                        if (derssec != 1)
                        {
                            int[] secimakts = new int[0];
                            string[] secimdersadi = new string[0];
                            for (int a = 0; a < 2; a++)
                            {
                                if (donemort[a, 0] < 2 && donemort[a, 1] < 2)
                                {
                                    SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                    SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                    Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                    Komut.Parameters.AddWithValue("@donem", derssec);
                                    Baglantim.Open();
                                    SqlDataReader dr = Komut.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        int akts = Convert.ToInt32(dr["AKTS"]);
                                        int sinif = Convert.ToInt32(dr["Sinif"]);
                                        string dersadi = dr["DersAdi"].ToString();
                                        decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                        if (katsayi < 2 && sinif == a + 1)
                                        {
                                            Array.Resize(ref secimakts, secimakts.Length + 1);
                                            Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                            secimakts[secimakts.Length - 1] = akts;
                                            secimdersadi[secimdersadi.Length - 1] = dersadi;
                                        }
                                    }
                                    Baglantim.Close();
                                    if (a == 1)
                                    {
                                        Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 0);
                                        f5.Show();

                                        this.Hide();
                                    }
                                }
                                else if ((donemort[a, 0] > 2 || donemort[a, 1] > 2) && (donemort[a, 1] < 3))
                                {
                                    SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                    SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                    Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                    Komut.Parameters.AddWithValue("@donem", derssec);
                                    Baglantim.Open();
                                    SqlDataReader dr = Komut.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        int akts = Convert.ToInt32(dr["AKTS"]);
                                        int sinif = Convert.ToInt32(dr["Sinif"]);
                                        string dersadi = dr["DersAdi"].ToString();
                                        decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                        if (katsayi < 1 && sinif == a + 1)
                                        {
                                            Array.Resize(ref secimakts, secimakts.Length + 1);
                                            Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                            secimakts[secimakts.Length - 1] = akts;
                                            secimdersadi[secimdersadi.Length - 1] = dersadi;
                                        }
                                    }
                                    Baglantim.Close();
                                    if (a == 1)
                                    {
                                        Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 0);
                                        f5.Show();

                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    if (a == 1)
                                    {
                                        Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 1);
                                        f5.Show();

                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }
                    else if (sinifno == 4)
                    {
                        if (derssec != 1)
                        {
                            int[] secimakts = new int[0];
                            string[] secimdersadi = new string[0];
                            for (int a = 0; a < 3; a++)
                            {
                                if (donemort[a, 0] < 2 && donemort[a, 1] < 2)
                                {
                                    SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                    SqlCommand Komut = new SqlCommand("select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                    Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                    Komut.Parameters.AddWithValue("@donem", derssec);
                                    Baglantim.Open();
                                    SqlDataReader dr = Komut.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        int akts = Convert.ToInt32(dr["AKTS"]);
                                        int sinif = Convert.ToInt32(dr["Sinif"]);
                                        string dersadi = dr["DersAdi"].ToString();
                                        decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                        if (katsayi < 2 && sinif == a + 1)
                                        {
                                            Array.Resize(ref secimakts, secimakts.Length + 1);
                                            Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                            secimakts[secimakts.Length - 1] = akts;
                                            secimdersadi[secimdersadi.Length - 1] = dersadi;
                                        }
                                    }
                                    Baglantim.Close();
                                    if (a == 2)
                                    {
                                        Form6 f6 = new Form6(secimakts, secimdersadi, ogrno);
                                        f6.Show();

                                        this.Hide();
                                    }
                                }
                                else if (donemort[a, 0] > 2 || donemort[a, 1] > 2)
                                {
                                    SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                    SqlCommand Komut = new SqlCommand("select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                    Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                    Komut.Parameters.AddWithValue("@donem", derssec);
                                    Baglantim.Open();
                                    SqlDataReader dr = Komut.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        int akts = Convert.ToInt32(dr["AKTS"]);
                                        int sinif = Convert.ToInt32(dr["Sinif"]);
                                        string dersadi = dr["DersAdi"].ToString();
                                        decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                        if (katsayi < 1 && sinif == a + 1)
                                        {
                                            Array.Resize(ref secimakts, secimakts.Length + 1);
                                            Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                            secimakts[secimakts.Length - 1] = akts;
                                            secimdersadi[secimdersadi.Length - 1] = dersadi;
                                        }
                                    }
                                    Baglantim.Close();
                                    if (a == 2)
                                    {
                                        Form6 f6 = new Form6(secimakts, secimdersadi, ogrno);
                                        f6.Show();

                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (derssec == 1)  // 1.SINIF BAHAR DÖNEMİ
            {
                if (sinifno == 1)
                {
                    SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                    Baglantim.Open();
                    SqlCommand Komut = new SqlCommand("Select DersAdi,DersSinif,Donem,Kredi from Dersler", Baglantim);
                    SqlDataReader dr = Komut.ExecuteReader();
                    while (dr.Read())
                    {
                        string DersAd = dr["DersAdi"].ToString();
                        int DersSinif = Convert.ToInt32(dr["DersSinif"]);
                        int DersDonem = Convert.ToInt32(dr["Donem"]);
                        int DersKredi = Convert.ToInt32(dr["Kredi"]);
                        if (DersSinif == sinifno && DersDonem == derssec + 1)
                        {
                            SqlCommand Komut1 = new SqlCommand("Insert into DersSecimi(OgrenciNo,Dersler,AKTS) values(@ogr,@dersadi,@AKTS)", Baglantim);
                            Komut1.Parameters.AddWithValue("ogr", ogrno);
                            Komut1.Parameters.AddWithValue("dersadi", DersAd);
                            Komut1.Parameters.AddWithValue("AKTS", DersKredi);
                            Komut1.ExecuteNonQuery();
                        }
                    }
                    SqlCommand Komut3 = new SqlCommand("Update SinifListe set SecildiMi=@derssec where OgrenciNo=@ogrno", Baglantim);
                    Komut3.Parameters.AddWithValue("ogrno", ogrno);
                    Komut3.Parameters.AddWithValue("derssec", 1);
                    Komut3.ExecuteNonQuery();
                    Baglantim.Close();
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else if (sinifno == 2)
                {
                    if (derssec != 1)
                    {
                        int[] secimakts = new int[0];
                        string[] secimdersadi = new string[0];
                        if (donemort[0, 0] < 2 && donemort[0, 1] < 2)
                        {
                            SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                            SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                            Komut.Parameters.AddWithValue("@ogrno", ogrno);
                            Komut.Parameters.AddWithValue("@donem", derssec);
                            Baglantim.Open();
                            SqlDataReader dr = Komut.ExecuteReader();
                            while (dr.Read())
                            {
                                int akts = Convert.ToInt32(dr["AKTS"]);
                                string dersadi = dr["DersAdi"].ToString();
                                decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                if (katsayi < 2)
                                {
                                    Array.Resize(ref secimakts, secimakts.Length + 1);
                                    Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                    secimakts[secimakts.Length - 1] = akts;
                                    secimdersadi[secimdersadi.Length - 1] = dersadi;
                                }
                            }
                            Baglantim.Close();
                            Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 0);
                            f4.Show();

                            this.Hide();
                        }
                        else if ((donemort[0, 0] > 2 || donemort[0, 1] > 2) && (donemort[0, 1] < 3))
                        {
                            SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                            SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                            Komut.Parameters.AddWithValue("@ogrno", ogrno);
                            Komut.Parameters.AddWithValue("@donem", derssec);
                            Baglantim.Open();
                            SqlDataReader dr = Komut.ExecuteReader();
                            while (dr.Read())
                            {
                                int akts = Convert.ToInt32(dr["AKTS"]);
                                string dersadi = dr["DersAdi"].ToString();
                                decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                if (katsayi < 1)
                                {
                                    Array.Resize(ref secimakts, secimakts.Length + 1);
                                    Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                    secimakts[secimakts.Length - 1] = akts;
                                    secimdersadi[secimdersadi.Length - 1] = dersadi;
                                }
                            }
                            Baglantim.Close();
                            Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 0);
                            f4.Show();

                            this.Hide();
                        }
                        else
                        {
                            Form4 f4 = new Form4(secimakts, secimdersadi, ogrno, 1);
                            f4.Show();

                            this.Hide();
                        }
                    }
                }
                else if (sinifno == 3)
                {
                    if (derssec != 1)
                    {
                        int[] secimakts = new int[0];
                        string[] secimdersadi = new string[0];
                        for (int a = 0; a < 2; a++)
                        {
                            if (donemort[a, 0] < 2 && donemort[a, 1] < 2)
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    int sinif = Convert.ToInt32(dr["Sinif"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 2 && sinif == a + 1)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                if (a == 1)
                                {
                                    Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 0);
                                    f5.Show();

                                    this.Hide();
                                }
                            }
                            else if ((donemort[a, 0] > 2 || donemort[a, 1] > 2) && (donemort[a, 1] < 3))
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("Select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    int sinif = Convert.ToInt32(dr["Sinif"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 1 && sinif == a + 1)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                if (a == 1)
                                {
                                    Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 0);
                                    f5.Show();

                                    this.Hide();
                                }
                            }
                            else
                            {
                                if (a == 1)
                                {
                                    Form5 f5 = new Form5(secimakts, secimdersadi, ogrno, 1);
                                    f5.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                else if (sinifno == 4)
                {
                    if (derssec != 1)
                    {
                        int[] secimakts = new int[0];
                        string[] secimdersadi = new string[0];
                        for (int a = 0; a < 3; a++)
                        {
                            if (donemort[a, 0] < 2 && donemort[a, 1] < 2)
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    int sinif = Convert.ToInt32(dr["Sinif"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 2 && sinif == a + 1)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                if (a == 2)
                                {
                                    Form6 f6 = new Form6(secimakts, secimdersadi, ogrno);
                                    f6.Show();

                                    this.Hide();
                                }
                            }
                            else if (donemort[a, 0] > 2 || donemort[a, 1] > 2)
                            {
                                SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True; MultipleActiveResultSets = true");
                                SqlCommand Komut = new SqlCommand("select OgrenciNo,DersAdi,AKTS,Donem,Katsayi,Sinif from Transkript where OgrenciNo=@ogrno and Donem=@donem", Baglantim);
                                Komut.Parameters.AddWithValue("@ogrno", ogrno);
                                Komut.Parameters.AddWithValue("@donem", derssec);
                                Baglantim.Open();
                                SqlDataReader dr = Komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    int akts = Convert.ToInt32(dr["AKTS"]);
                                    int sinif = Convert.ToInt32(dr["Sinif"]);
                                    string dersadi = dr["DersAdi"].ToString();
                                    decimal katsayi = Convert.ToDecimal(dr["Katsayi"]);
                                    if (katsayi < 1 && sinif == a + 1)
                                    {
                                        Array.Resize(ref secimakts, secimakts.Length + 1);
                                        Array.Resize(ref secimdersadi, secimdersadi.Length + 1);
                                        secimakts[secimakts.Length - 1] = akts;
                                        secimdersadi[secimdersadi.Length - 1] = dersadi;
                                    }
                                }
                                Baglantim.Close();
                                if (a == 2)
                                {
                                    Form6 f6 = new Form6(secimakts, secimdersadi, ogrno);
                                    f6.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
