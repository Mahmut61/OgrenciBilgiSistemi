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
    public partial class frmNotlarEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmNotlarEkle()
        {
            InitializeComponent();
        }

        private void btnNotiptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlar frm = Application.OpenForms["frmNotlar"] as frmNotlar; //Ana forma geri döner
            frm.Show();
        }

        void OgrenciGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrenciNo.DataSource = new BindingSource(dt, null);
            cmbOgrenciNo.DisplayMember = "OgrenciNo";
            cmbOgrenciNo.ValueMember = "Id";


        }

        void DersGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler where BolumAdi='" + txtBolum.Text + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDersKodu.DataSource = new BindingSource(dt, null);
            cmbDersKodu.DisplayMember = "DersAdi";
            cmbDersKodu.ValueMember = "Id";
        }

        private void frmNotlarEkle_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
            DersGetir();
        }

        private void cmbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler where OgrenciNo='" + cmbOgrenciNo.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBolum.Text = dr[8].ToString();
            }
            baglanti.Close();
            DersGetir();

        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            
            
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Notlar (OgrenciNo,DersAdi,Vize,Final,Ortalama) values (@OgrenciNo,@DersAdi,@Vize,@Final,@Ortalama)", baglanti);
            cmd.Parameters.Add("OgrenciNo", cmbOgrenciNo.Text);
            cmd.Parameters.Add("DersAdi", cmbDersKodu.Text);
            cmd.Parameters.Add("Vize", txtVize.Text);
            cmd.Parameters.Add("Final", txtFinal.Text);
            cmd.Parameters.Add("Ortalama", txtOrtalama.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            double Vize = 0;
            double Final = 0;
            double Ortalama = 0;

            Vize = Convert.ToDouble(txtVize.Text);
            Final = Convert.ToDouble(txtFinal.Text);
            

            Ortalama = (Vize * 0.40) + (Final * 0.60);

            txtOrtalama.Text = Ortalama.ToString();
        }  
    }
}
