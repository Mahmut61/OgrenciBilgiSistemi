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
    public partial class frmBolumler : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");
        

        frmBolumlerEkle frmBolumlerEkle = new frmBolumlerEkle();
        frmBolumlerDuzenle frmBolumlerDuzenle = new frmBolumlerDuzenle();
        frmBolumlerArama frmBolumlerArama = new frmBolumlerArama();

        public frmBolumler()
        {
            InitializeComponent();
        }

        private void btnBolumGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = Application.OpenForms["Form1"] as Form1; //Ana forma geri döner
            frm.Show();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumlerEkle.Show();

        }

        private void btnBolumDuzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumlerDuzenle.Show();
            
        }

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BolumKod as 'Bolum Kodu', BolumAdi as 'Bolum Adi' From Bolumler", baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgBolumler.DataSource = ds.Tables[0];
            
            
          
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumlerArama.Show();
        }

    }
}
