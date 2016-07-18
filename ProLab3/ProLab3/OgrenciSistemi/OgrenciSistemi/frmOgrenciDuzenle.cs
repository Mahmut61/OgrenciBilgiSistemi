using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace OgrenciSistemi
{
    public partial class frmOgrenciDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgrenciDuzenle()
        {
            InitializeComponent();
        }

        private void btnOgrenciDuzenleCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenci frm = Application.OpenForms["frmOgrenci"] as frmOgrenci; //Ana forma geri döner
            frm.Show();
        }

        void DurumGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Durumlar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDurum.DataSource = new BindingSource(dt, null);
            cmbDurum.DisplayMember = "DurumAdi";
            cmbDurum.ValueMember = "DurumId";
        }

        void BolumGetir1()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolum1.DataSource = new BindingSource(dt, null);
            cmbBolum1.DisplayMember = "BolumAdi";
            cmbBolum1.ValueMember = "Id";


        }

        void BolumGetir2()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Bolumler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBolum2.DataSource = new BindingSource(dt, null);
            cmbBolum2.DisplayMember = "BolumAdi";
            cmbBolum2.ValueMember = "Id";


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
        void GuncelleOgrenci()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrenciNo.DataSource = null;
            cmbOgrenciNo.DisplayMember = "OgrenciNo";
            cmbOgrenciNo.ValueMember = "Id";
            cmbOgrenciNo.DataSource = new BindingSource(dt, null);
        }


        private void frmOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            DurumGetir();
            BolumGetir1();
            BolumGetir2();
            OgrenciGetir();
        }

        private void cmbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler where OgrenciNo='" + cmbOgrenciNo.Text + "'", baglanti);
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                txtOgrenciNo.Text = dr["OgrenciNo"].ToString();
                txtisim.Text = dr["Isim"].ToString();
                txtSoyisim.Text = dr["Soyisim"].ToString();
                txtTcKimlikNo.Text = dr["TcKimlik"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                cmbDurum.SelectedValue = dr["DurumId"].ToString();
                cmbBolum1.Text = dr["Bolum1"].ToString();
                cmbBolum2.Text = dr["Bolum2"].ToString();
                // = dr["Resim"].ToString();
                //if (lstStudents.SelectedItems.Count == 0) return;
                //Ogrenciler s = (Ogrenciler)lstStudents.SelectedItems[0].Tag;
                // byte[] data = s.Image;
                // MemoryStream ms = new MemoryStream();
                // ms.Write(data, 0, data.Length);
                // Image img = Image.FromStream(ms);
                //pcbResim.Image = img;
                
            }
            baglanti.Close();
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDurum.Text != "ÇAP")
            {
                cmbBolum2.Enabled = false;
            }
            else
            {
                cmbBolum2.Enabled = true;
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            opfDosyaAc.Filter = "JPEG Dosyalar|*.jpg|COM Dosyalar|*.com";
            DialogResult cevap = opfDosyaAc.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                pcbResim.ImageLocation = opfDosyaAc.FileName;
            }
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Ogrenciler Set TcKimlik=@TcKimlik, Isim=@Isim, Soyisim=@Soyisim, Telefon=@Telefon, OgrenciNo=@OgrenciNo , DurumId=@DurumId , Bolum1=@Bolum1 ,Bolum2=@Bolum2 where Id=" + cmbOgrenciNo.SelectedValue, baglanti);
            cmd.Parameters.Add("TcKimlik", txtTcKimlikNo.Text);
            cmd.Parameters.Add("Isim", txtisim.Text);
            cmd.Parameters.Add("Soyisim", txtSoyisim.Text);
            cmd.Parameters.Add("Telefon", txtTelefon.Text);
            cmd.Parameters.Add("OgrenciNo", txtOgrenciNo.Text);
            cmd.Parameters.Add("DurumId", cmbDurum.SelectedValue);
            //cmd.Parameters.Add("Resim", t.Text);
            cmd.Parameters.Add("Bolum1", cmbBolum1.Text);
            cmd.Parameters.Add("Bolum2", cmbBolum2.Text);


            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Güncelleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            GuncelleOgrenci();

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti.Close();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from Ogrenciler where Id=" + cmbOgrenciNo.SelectedValue, baglanti);
            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Silme işleminiz başarıyla gerçekleştirilmiştir";
            }
            baglanti.Close();
            GuncelleOgrenci();
        }

        private void txtOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (!Char.IsDigit(e.KeyChar) || txtOgrenciNo.Text.Length > 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (!Char.IsDigit(e.KeyChar) || txtTcKimlikNo.Text.Length > 10)
                {
                    e.Handled = true;
                }
            }
        }
        
    }
}
