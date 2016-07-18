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
    public partial class Excelslem : Form
    {
        public Excelslem()
        {
            InitializeComponent();
        }//constructor
        
        private void btnGozat_Click(object sender, EventArgs e)
        {
           DialogResult drExcel =  ofdExcel.ShowDialog();

           if (drExcel == DialogResult.Cancel) { return; }//if

           txtGozat.Text = ofdExcel.FileName;
           List<transkrip> dersler = transkrip.getir(txtGozat.Text);

           foreach (transkrip item in dersler)
           {
               SqlConnection Baglantim = new SqlConnection("Server =localhost;Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
               SqlCommand Komut = new SqlCommand("Insert into Transkript(OgrenciNo,DersAdi,HarfNotu,AKTS,Donem,Sinif,Katsayi) values(@ogrno,@dersadi,@harfnotu,@akts,@donem,@sinif,@katsayi)", Baglantim);
               Komut.Parameters.AddWithValue("@ogrno", item.OgrNo);
               Komut.Parameters.AddWithValue("@dersadi", item.DersAdi);
               Komut.Parameters.AddWithValue("@harfnotu", item.HarfNotu);
               Komut.Parameters.AddWithValue("@akts", item.AKTS);
               Komut.Parameters.AddWithValue("@donem", item.Donem);
               Komut.Parameters.AddWithValue("@sinif", item.Sinif);
               Komut.Parameters.AddWithValue("@katsayi", Convert.ToDecimal(item.Katsayi));
               Baglantim.Open();
               Komut.ExecuteNonQuery();
               Baglantim.Close();
               
           }
           
           Form1 f1 = new Form1();
           f1.Show();
           this.Hide();

        }

        private void Excelslem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();


        }//void
    }//class
}//namespace
