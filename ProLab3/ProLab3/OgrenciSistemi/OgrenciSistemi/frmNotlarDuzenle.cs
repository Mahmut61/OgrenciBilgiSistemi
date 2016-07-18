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
    public partial class frmNotlarDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmNotlarDuzenle()
        {
            InitializeComponent();
        }

        private void btnNotDuzenleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlar frm = Application.OpenForms["frmNotlar"] as frmNotlar; //Ana forma geri döner
            frm.Show();
        }

        void OgrenciGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Notlar", baglanti);
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

        void GuncelleOgrenci()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Notlar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbOgrenciNo.DataSource = null;
            cmbOgrenciNo.DisplayMember = "OgrenciNo";
            cmbOgrenciNo.ValueMember = "Id";

            cmbOgrenciNo.DataSource = new BindingSource(dt, null);
        }

        private void frmNotlarDuzenle_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
            DersGetir();
        }

        private void cmbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti1 = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler where OgrenciNo='" + cmbOgrenciNo.Text + "'", baglanti1);
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBolum.Text = dr[8].ToString();
            }
            dr.NextResult();
            
            DersGetir();
            baglanti1.Close();
        }

        private void cmbDersKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti2 = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");
            
            SqlCommand cmd = new SqlCommand("select * from Notlar where DersAdi='" + cmbDersKodu.Text + "'", baglanti2);
            if (baglanti2.State != ConnectionState.Open)
            {
                baglanti2.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                txtVizeNotu.Text = dr["Vize"].ToString();
                txtFinalNotu.Text = dr["Final"].ToString();
                txtOrtalama.Text = dr["Ortalama"].ToString();
                
            }
            dr.NextResult();
            baglanti2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Vize = 0;
            double Final = 0;
            double Ortalama = 0;

            Vize = Convert.ToDouble(txtVizeNotu.Text);
            Final = Convert.ToDouble(txtFinalNotu.Text);


            Ortalama = (Vize * 0.40) + (Final * 0.60);

            txtOrtalama.Text = Ortalama.ToString();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti3 = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");
            baglanti3.Open();
            SqlCommand cmd3 = new SqlCommand("Update Notlar Set OgrenciNo=@OgrenciNo, DersAdi=@DersAdi, Vize=@Vize, Final=@Final, Ortalama=@Ortalama  where Id=" + cmbOgrenciNo.SelectedValue, baglanti3);
            cmd3.Parameters.Add("OgrenciNo", cmbOgrenciNo.Text);
            cmd3.Parameters.Add("DersAdi", cmbDersKodu.Text);
            cmd3.Parameters.Add("Vize", txtVizeNotu.Text);
            cmd3.Parameters.Add("Final", txtFinalNotu.Text);
            cmd3.Parameters.Add("Ortalama", txtOrtalama.Text);


            int sonuc = cmd3.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Güncelleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            GuncelleOgrenci();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti3.Close();
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti4 = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");
            baglanti4.Open();
            SqlCommand cmd4 = new SqlCommand("Delete from Notlar where Id=" + cmbOgrenciNo.SelectedValue, baglanti4);
            int sonuc = cmd4.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Silme işleminiz başarıyla gerçekleştirilmiştir";
            }
            baglanti4.Close();
            GuncelleOgrenci();
        }
    }
}
