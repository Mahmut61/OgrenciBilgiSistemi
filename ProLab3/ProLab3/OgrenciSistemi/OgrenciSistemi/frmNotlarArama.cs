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
    public partial class frmNotlarArama : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmNotlarArama()
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

        void DersGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler where BolumAdi='" + txtBolum.Text + "'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDersKodu.DataSource = new BindingSource(dt, null);
            cmbDersKodu.DisplayMember = "DersAdi";
            cmbDersKodu.ValueMember = "Id";
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
            DersGetir();
        }

        private void frmNotlarArama_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
            DersGetir();
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciNo.Text == string.Empty || cmbDersKodu.Text == string.Empty)
            {
                MessageBox.Show("Bilgiler eksik!");
            }
            else
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select OgrenciNo as 'Ogrenci No', DersAdi as 'Ders Adi' , Vize as 'Vize Notu' , Final as 'Final Notu' , Ortalama as 'Ortalama Not' from Notlar where OgrenciNo = '" + cmbOgrenciNo.Text + "' and DersAdi = '" + cmbDersKodu.Text + "'", baglanti);
                    DataTable ds = new DataTable();
                    baglanti.Open();
                    da.Fill(ds);
                    baglanti.Close();
                    dgNotArama.DataSource = ds;
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
            frmNotlar frm = Application.OpenForms["frmNotlar"] as frmNotlar; //Ana forma geri döner
            frm.Show();
        }

       

    }
}
