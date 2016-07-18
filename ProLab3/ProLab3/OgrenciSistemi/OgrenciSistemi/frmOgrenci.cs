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
    public partial class frmOgrenci : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        frmOgrenciEkle frmOgrenciEkle = new frmOgrenciEkle();
        frmOgrenciDuzenle frmOgrenciDuzenle = new frmOgrenciDuzenle();
        frmOgrenciArama frmOgrenciArama = new frmOgrenciArama();

        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void btnOgrenciGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = Application.OpenForms["Form1"] as Form1; //Ana forma geri döner
            frm.Show();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciEkle.Show();
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciDuzenle.Show();
        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TcKimlik as 'TC Kimlik No', Isim as 'Isim' , Soyisim as 'Soyisim' , Telefon as 'Telefon No' , OgrenciNo as 'Ogrenci No' , Bolum1 as 'Bolum1' , Bolum2 as 'Bolum2'  From Ogrenciler", baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgOgrenci.DataSource = ds.Tables[0];
        }

        private void btnOgrenciArama_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciArama.Show();
        }
    }
}
