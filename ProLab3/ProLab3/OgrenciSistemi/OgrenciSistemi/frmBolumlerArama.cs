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
    public partial class frmBolumlerArama : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmBolumlerArama()
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

        private void frmBolumlerArama_Load(object sender, EventArgs e)
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
                    SqlDataAdapter da = new SqlDataAdapter("Select TcKimlik as 'TC Kimlik No', Isim as 'Isim' , Soyisim as 'Soyisim' , Telefon as 'Telefon No' , OgrenciNo as 'Ogrenci No' , Bolum1 as 'Bolum1' , Bolum2 as 'Bolum2'  From Ogrenciler where Bolum2 = '" + cmbBolumAdi.Text + "'", baglanti);
                    DataTable ds = new DataTable();
                    baglanti.Open();
                    da.Fill(ds);
                    baglanti.Close();
                    dgBolumlerArama.DataSource = ds;
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
            frmBolumler frm = Application.OpenForms["frmBolumler"] as frmBolumler; //Ana forma geri döner
            frm.Show();
        }
    }
}
