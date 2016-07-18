using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class frmBolumlerDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmBolumlerDuzenle()
        {
            InitializeComponent();
        }

        private void btnBolumDuzenleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumler frm = Application.OpenForms["frmBolumler"] as frmBolumler; //Ana forma geri döner
            frm.Show();
        }
        void BolumGetir()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolumKoduSec.DataSource = new BindingSource(dt, null);
            cmbBolumKoduSec.DisplayMember = "BolumKod";
            cmbBolumKoduSec.ValueMember = "Id";
            

        }

        void BolumGuncelle()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolumKoduSec.DataSource = null;
            cmbBolumKoduSec.DisplayMember = "BolumKod";
            cmbBolumKoduSec.ValueMember = "Id";
            cmbBolumKoduSec.DataSource = new BindingSource(dt, null);
 
        }

        private void frmBolumlerDuzenle_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }

        private void cmbBolumKoduSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Bolumler where BolumKod='" + cmbBolumKoduSec.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBolumKodu.Text = dr["BolumKod"].ToString();
                txtBolumAdi.Text = dr["BolumAdi"].ToString();
            }
            baglanti.Close();
        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Bolumler Set BolumKod=@BolumKod, BolumAdi=@BolumAdi where Id=" + cmbBolumKoduSec.SelectedValue, baglanti);
            cmd.Parameters.Add("BolumKod", txtBolumKodu.Text);
            cmd.Parameters.Add("BolumAdi", txtBolumAdi.Text);

            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Güncelleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            baglanti.Close();
            BolumGuncelle();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from Bolumler where Id=" + cmbBolumKoduSec.SelectedValue, baglanti);
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Silme işleminiz başarıyla gerçekleştirilmiştir";
            }
            baglanti.Close();
            BolumGuncelle();
        }

    }
}
