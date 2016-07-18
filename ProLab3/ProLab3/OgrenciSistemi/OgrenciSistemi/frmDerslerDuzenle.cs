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
    public partial class frmDerslerDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmDerslerDuzenle()
        {
            InitializeComponent();
        }

        private void btnBolumDuzenleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDersler frm = Application.OpenForms["frmDersler"] as frmDersler; //Ana forma geri döner
            frm.Show();
        }
        void DersGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDersKodu.DataSource = new BindingSource(dt, null);
            cmbDersKodu.DisplayMember = "DersKodu";
            cmbDersKodu.ValueMember = "Id";
        }

        void GuncelleDers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDersKodu.DataSource = null;
            cmbDersKodu.DisplayMember = "DersKodu";
            cmbDersKodu.ValueMember = "Id";

            cmbDersKodu.DataSource = new BindingSource(dt, null);
        }

        void SicilNo()
        {
            string bolumkod = cmbDersKodu.Text[0] + cmbDersKodu.Text[1].ToString();
            SqlDataAdapter da = new SqlDataAdapter("Select * from OgretimUyeleri where BolumKod='" + bolumkod + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbSicilNo.DataSource = new BindingSource(dt, null);
            cmbSicilNo.DisplayMember = "SicilNo";
            cmbSicilNo.ValueMember = "Id";
        }

        private void frmDerslerDuzenle_Load(object sender, EventArgs e)
        {
            DersGetir();
            SicilNo();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            string bolumkod = txtDersKodu.Text[2].ToString() + txtDersKodu.Text[3].ToString();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Dersler Set DersKodu=@DersKodu, DersAdi=@DersAdi, SicilNo=@SicilNo, Kredi=@Kredi, Kacinci=@Kacinci  where Id=" + cmbDersKodu.SelectedValue, baglanti);
            cmd.Parameters.Add("DersKodu", txtDersKodu.Text);
            cmd.Parameters.Add("DersAdi", txtDersAdi.Text);
            cmd.Parameters.Add("SicilNo", cmbSicilNo.Text);
            cmd.Parameters.Add("Kredi", txtKredi.Text);
            cmd.Parameters.Add("Kacinci", bolumkod);


            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Güncelleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            GuncelleDers();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti.Close();
        }

        private void cmbDersKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Dersler where DersKodu='" + cmbDersKodu.Text + "'", baglanti);
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                txtDersKodu.Text = dr["DersKodu"].ToString();
                txtDersAdi.Text = dr["DersAdi"].ToString();
                cmbSicilNo.Text = dr["SicilNo"].ToString();
                txtKredi.Text = dr["Kredi"].ToString();
                txtBolum.Text = dr["BolumAdi"].ToString();
            }
            baglanti.Close();
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from Dersler where Id=" + cmbDersKodu.SelectedValue, baglanti);
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Silme işleminiz başarıyla gerçekleştirilmiştir";
            }
            baglanti.Close();
            GuncelleDers();
        }
    }
}
