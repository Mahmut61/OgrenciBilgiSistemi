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
    public partial class frmDerslerEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmDerslerEkle()
        {
            InitializeComponent();
        }

        void BolumGetir()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolumKodu.DataSource = new BindingSource(dt, null);
            cmbBolumKodu.DisplayMember = "BolumAdi";
            cmbBolumKodu.ValueMember = "Id";
            

        }

        void OgretmenGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from OgretimUyeleri where BolumKod='" + txtDersKodu.Text + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSicilNo.DataSource = new BindingSource(dt, null);
            cmbSicilNo.DisplayMember = "SicilNo";
            cmbSicilNo.ValueMember = "Id";           
        }

   

        private void frmDerslerEkle_Load(object sender, EventArgs e)
        {
            BolumGetir();          
        }

        private void btnDersleriptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDersler frm = Application.OpenForms["frmDersler"] as frmDersler; //Ana forma geri döner
            frm.Show();
        }

        private void cmbBolumKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Bolumler where BolumAdi='" + cmbBolumKodu.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDersKodu.Text = dr[1].ToString();
            }
            baglanti.Close();
            OgretmenGetir();
        }

        private void btnDerslerEkle_Click(object sender, EventArgs e)
        {
            string bolumkod = txtDersKodu.Text[2].ToString() + txtDersKodu.Text[3].ToString();
            baglanti.Open();           
            SqlCommand cmd = new SqlCommand("insert into Dersler (DersKodu,DersAdi,BolumAdi,SicilNo,Kredi,Kacinci) values (@DersKodu,@DersAdi,@BolumAdi,@SicilNo,@Kredi,@Kacinci)", baglanti);
            cmd.Parameters.Add("DersKodu", txtDersKodu.Text);
            cmd.Parameters.Add("DersAdi", txtDersAdi.Text);
            cmd.Parameters.Add("BolumAdi", cmbBolumKodu.Text);
            cmd.Parameters.Add("SicilNo", cmbSicilNo.Text);
            cmd.Parameters.Add("Kredi", txtKredi.Text);
            cmd.Parameters.Add("Kacinci", bolumkod);
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Kaydınız başarıyla gerçekleştirilmiş";
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


    }


}
