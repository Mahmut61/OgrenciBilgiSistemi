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
    public partial class frmOgretimUyesiDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgretimUyesiDuzenle()
        {
            InitializeComponent();
        }

        private void btnOgretimUyeleriDuzenleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesi frm = Application.OpenForms["frmOgretimUyesi"] as frmOgretimUyesi; //Ana forma geri döner
            frm.Show();
        }
        void SicilNoGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from OgretimUyeleri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbSicilNo.DataSource = new BindingSource(dt, null);
            cmbSicilNo.DisplayMember = "SicilNo";
            cmbSicilNo.ValueMember = "Id";
        }
        void GuncelleSicil()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from OgretimUyeleri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbSicilNo.DataSource = null;
            cmbSicilNo.DisplayMember = "SicilNo";
            cmbSicilNo.ValueMember = "Id";

            cmbSicilNo.DataSource = new BindingSource(dt, null);

        }

        private void frmOgretimUyesiDuzenle_Load(object sender, EventArgs e)
        {
            SicilNoGetir();
        }

        private void btnOgretimGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update OgretimUyeleri Set SicilNo=@SicilNo, Isim=@Isim, Soyisim=@Soyisim, BolumKod='" + "B" + txtSicilNo.Text[0] + "'  where Id=" + cmbSicilNo.SelectedValue, baglanti);
            cmd.Parameters.Add("SicilNo", txtSicilNo.Text);
            cmd.Parameters.Add("Isim", txtisim.Text);
            cmd.Parameters.Add("Soyisim", txtSoyisim.Text);


            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Güncelleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            GuncelleSicil();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti.Close();
        }

        private void cmbSicilNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from OgretimUyeleri where SicilNo='" + cmbSicilNo.Text + "'", baglanti);
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                txtSicilNo.Text = dr["SicilNo"].ToString();
                txtisim.Text = dr["Isim"].ToString();
                txtSoyisim.Text = dr["Soyisim"].ToString();
            }
            baglanti.Close();


        }

        private void btnOgretimSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from OgretimUyeleri where Id=" + cmbSicilNo.SelectedValue, baglanti);
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Silme işleminiz başarıyla gerçekleştirilmiştir";
            }
            GuncelleSicil();
            baglanti.Close();
        }

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
