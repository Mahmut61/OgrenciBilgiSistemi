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
    public partial class frmDersler : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        frmDerslerEkle frmDerslerEkle = new frmDerslerEkle();
        frmDerslerDuzenle frmDerslerDuzenle = new frmDerslerDuzenle();
        frmDerslerArama frmDerslerArama = new frmDerslerArama();

        public frmDersler()
        {
            InitializeComponent();
        }

        private void btnDersGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = Application.OpenForms["Form1"] as Form1; //Ana forma geri döner
            frm.Show();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDerslerEkle.Show();
        }

        private void btnDersDuzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDerslerDuzenle.Show();
        }

        private void frmDersler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select DersKodu as 'Ders Kodu', DersAdi as 'Ders Adi' , BolumAdi as 'Bolum Adi' , SicilNo as 'Sicil No' , Kredi as 'Kredi'  From Dersler", baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgDersler.DataSource = ds.Tables[0];
        }

        private void btnDersArama_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDerslerArama.Show();
        }

        
    }
}
