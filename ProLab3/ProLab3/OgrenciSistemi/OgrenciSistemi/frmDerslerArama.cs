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
    public partial class frmDerslerArama : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmDerslerArama()
        {
            InitializeComponent();
        }

        void BolumGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolumAdi.DataSource = new BindingSource(dt, null);
            cmbBolumAdi.DisplayMember = "BolumAdi";
            cmbBolumAdi.ValueMember = "Id";


        }

        private void frmDerslerArama_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbBolumAdi.Text == string.Empty || cmbBolumAdi.Text == string.Empty)
            {
                MessageBox.Show("Bilgiler eksik!");
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select DersKodu as 'Ders Kodu', DersAdi as 'Ders Adi' , BolumAdi as 'Bolum Adi' , SicilNo as 'Sicil No' , Kredi as 'Kredi'  From Dersler where BolumAdi = '" + cmbBolumAdi.Text + "'", baglanti);
                    DataTable ds = new DataTable();
                    baglanti.Open();
                    da.Fill(ds);
                    baglanti.Close();
                    dgDerslerArama.DataSource = ds;
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
            frmDersler frm = Application.OpenForms["frmDersler"] as frmDersler; //Ana forma geri döner
            frm.Show();
        }
    }
}
