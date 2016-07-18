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
    public partial class frmOgretimUyesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        frmOgretimUyesiEkle frmOgretimUyesiEkle = new frmOgretimUyesiEkle();
        frmOgretimUyesiDuzenle frmOgretimUyesiDuzenle = new frmOgretimUyesiDuzenle();
        frmOgretimUyesiArama frmOgretimUyesiArama = new frmOgretimUyesiArama();

        public frmOgretimUyesi()
        {
            InitializeComponent();
        }


        private void btnOgretimGeri1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = Application.OpenForms["Form1"] as Form1; //Ana forma geri döner
            frm.Show();
        }

        private void btnOgretimEkle1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesiEkle.Show();
        }

        private void btnOgretimDuzenle1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesiDuzenle.Show();
        }

        private void frmOgretimUyesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select SicilNo as 'Sicil No', Isim as 'Isim' , Soyisim as 'Soyisim' , BolumKod as 'Bolum Kodu'  From OgretimUyeleri", baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgOgretim.DataSource = ds.Tables[0];
        }

        private void btnOgretimArama1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesiArama.Show();
        }
    }
}
