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
    public partial class frmOgretimUyesiArama : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgretimUyesiArama()
        {
            InitializeComponent();
        }

        void OgretmenGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from OgretimUyeleri ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSicilNo.DataSource = new BindingSource(dt, null);
            cmbSicilNo.DisplayMember = "SicilNo";
            cmbSicilNo.ValueMember = "Id";
        }

        private void frmOgretimUyesiArama_Load(object sender, EventArgs e)
        {
            OgretmenGetir();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbSicilNo.Text == string.Empty || cmbSicilNo.Text == string.Empty)
            {
                MessageBox.Show("Bilgiler eksik!");
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select DersKodu as 'Ders Kodu', DersAdi as 'Ders Adi' , BolumAdi as 'Bolum Adi' , SicilNo as 'Sicil No' , Kredi as 'Kredi'  From Dersler where SicilNo = '" + cmbSicilNo.Text + "'", baglanti);
                    DataTable ds = new DataTable();
                    baglanti.Open();
                    da.Fill(ds);
                    baglanti.Close();
                    dgOgretimArama.DataSource = ds;
                }
                catch
                {
                    MessageBox.Show("Eksik ya da hatalı bilgi!");
                }
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesi frm = Application.OpenForms["frmOgretimUyesi"] as frmOgretimUyesi; //Ana forma geri döner
            frm.Show();
        }
    }
}
