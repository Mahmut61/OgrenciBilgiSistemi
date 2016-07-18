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
    public partial class frmBolumlerEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmBolumlerEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumler frm = Application.OpenForms["frmBolumler"] as frmBolumler; //Ana forma geri döner
            frm.Show();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Insert into Bolumler (BolumKod,BolumAdi) values (@BolumKod,@BolumAdi)", baglanti);
            cmd.Parameters.Add("BolumKod", txtBolumKodu.Text);
            cmd.Parameters.Add("BolumAdi", txtBolumAdi.Text);
 
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Kaydınız başarıyla gerçekleştirilmiş";
            }

            baglanti.Close();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }

        }



       
    }
}
