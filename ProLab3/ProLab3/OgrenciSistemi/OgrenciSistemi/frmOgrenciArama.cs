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
    public partial class frmOgrenciArama : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgrenciArama()
        {
            InitializeComponent();
        }
       
        void OgrenciGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrenciNo.DataSource = new BindingSource(dt, null);
            cmbOgrenciNo.DisplayMember = "OgrenciNo";
            cmbOgrenciNo.ValueMember = "Id";


        }


        private void frmOgrenciArama_Load(object sender, EventArgs e)
        {
            OgrenciGetir();

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciNo.Text == string.Empty || cmbOgrenciNo.Text == string.Empty)
            {
                MessageBox.Show("Bilgiler eksik!");
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select DersKodu as 'Ders Kodu', DersAdi as 'Ders Adi' , BolumAdi as 'Bolum Adi' , SicilNo as 'Sicil No' , Kredi as 'Kredi'  From Dersler where BolumAdi = '" + txtBolum.Text + "'", baglanti);
                    DataTable ds = new DataTable();
                    baglanti.Open();
                    da.Fill(ds);
                    baglanti.Close();
                    dgOgrenciArama.DataSource = ds;
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
            frmOgrenci frm = Application.OpenForms["frmOgrenci"] as frmOgrenci; //Ana forma geri döner
            frm.Show();
        }

        private void cmbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler where OgrenciNo='" + cmbOgrenciNo.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBolum.Text = dr[8].ToString();
            }
            baglanti.Close();
            
        }
    }
}
