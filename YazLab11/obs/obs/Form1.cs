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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {

            string ad = "", soyad = "", sinif = "", no = "";
            SqlConnection Baglantim = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
            Baglantim.Open();

            try
            {
                SqlCommand Komut = new SqlCommand("Select Ad,Soyad,Sinif,OgrenciNo,Sifre from SinifListe where OgrenciNo='" + txt_ogrno.Text + "' and Sifre ='" + txt_sifre.Text + "' ", Baglantim);

                Komut.ExecuteNonQuery();
                Komut.Parameters.AddWithValue("@Sifre", txt_sifre.Text);

                SqlDataReader dr = Komut.ExecuteReader();
                while (dr.Read())
                {
                    
                    ad = dr["Ad"].ToString();
                    soyad = dr["Soyad"].ToString();
                    sinif = dr["Sinif"].ToString();
                    no = dr["OgrenciNo"].ToString();
                }
                dr.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(Komut);
                da.Fill(ds, "SinifListe");

                DataRow dro;
                dro = ds.Tables["SinifListe"].Rows[0];

                if ((txt_ogrno.Text == dro["OgrenciNo"].ToString()) || (txt_sifre.Text == dro["Sifre"].ToString()))
                {
                    Form2 f2 = new Form2();

                    f2.lbl_ad.Text = ad;
                    f2.lbl_soyad.Text = soyad;
                    f2.lbl_sinifno.Text = sinif;
                    f2.lbl_ogrno.Text = no;
                    f2.Show();


                    this.Hide();
                }

            }
            catch
            {
                MessageBox.Show("Bilgiler Eksik veya Hatalı.");
                txt_ogrno.Clear();
                txt_sifre.Clear();
            }

            finally
            {
                Baglantim.Close();
            }
        }

        private void txt_ogrno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ogrno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);

        }
    }
}
