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
    public partial class frmNotlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        frmNotlarEkle frmNotlarEkle = new frmNotlarEkle();
        frmNotlarDuzenle frmNotlarDuzenle = new frmNotlarDuzenle();
        frmNotlarArama frmNotlarArama = new frmNotlarArama();

        public frmNotlar()
        {
            InitializeComponent();
        }

        private void btnNotGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = Application.OpenForms["Form1"] as Form1; //Ana forma geri döner
            frm.Show();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlarEkle.Show();
        }

        private void btnNotDuzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlarDuzenle.Show();
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OgrenciNo as 'Ogrenci No', DersAdi as 'Ders Adi' , Vize as 'Vize Notu' , Final as 'Final Notu' , Ortalama as 'Ortalama Not'  From Notlar", baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgNotlar.DataSource = ds.Tables[0];
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlarArama.Show();
        }

    }
}
