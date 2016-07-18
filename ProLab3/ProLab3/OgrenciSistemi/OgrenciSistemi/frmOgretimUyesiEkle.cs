using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OgrenciSistemi
{
    public partial class frmOgretimUyesiEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgretimUyesiEkle()
        {
            InitializeComponent();
        }

        private void btnOgretimUyesiIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesi frm = Application.OpenForms["frmOgretimUyesi"] as frmOgretimUyesi; //Ana forma geri döner
            frm.Show();
        }

        private void btnOgretimUyesiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            bool bolum_varmi = false;
            string b = txtSicilNo.Text;

            SqlCommand cmd2 = new SqlCommand("Select BolumKod from Bolumler", baglanti);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                string a = dr[0].ToString();
                if (a[1] == b[0])
                {
                    bolum_varmi = true;
                }
            }
            baglanti.Close();

            if (bolum_varmi)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into OgretimUyeleri (SicilNo,Isim,Soyisim,BolumKod) values (@SicilNo,@Isim,@Soyisim,@Bolumkodu)", baglanti);
                cmd.Parameters.Add("SicilNo", txtSicilNo.Text);
                cmd.Parameters.Add("Isim", txtOgretimisim.Text);
                cmd.Parameters.Add("Soyisim", txtOgretimSoyisim.Text);
                cmd.Parameters.Add("Bolumkodu", "B" + b[0]);
                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    lblMesaj.Text = "Kaydınız başarıyla gerçekleştirilmiş";
                }
            }
            else
            {
                lblMesaj.Text = "Sicil No yanlış girilmiştir.Lütfen düzeltiniz!";
            }
            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti.Close();
        }



        //SicilNo'yu 4 hane ile sınırlandırır

        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (!Char.IsDigit(e.KeyChar) || txtSicilNo.Text.Length > 3)
                {
                    e.Handled = true;
                }
            }
        }



    }
}
