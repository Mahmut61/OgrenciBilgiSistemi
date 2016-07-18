using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class frmOgrenciEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Server =localhost; Database = OGRENCI; Trusted_Connection = True;");

        public frmOgrenciEkle()
        {
            InitializeComponent();
        }
        void DurumGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Durumlar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDurumlar.DataSource = new BindingSource(dt, null);
            cmbDurumlar.DisplayMember = "DurumAdi";
            cmbDurumlar.ValueMember = "DurumId";
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenci frm = Application.OpenForms["frmOgrenci"] as frmOgrenci; //Ana forma geri döner
            frm.Show();
        }

        private void frmOgrenciEkle_Load(object sender, EventArgs e)
        {
            DurumGetir();
            BolumGetir1();
            BolumGetir2();
        }


        private void cmbDurumlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDurumlar.Text != "ÇAP")
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

        //private byte[] ImageToByte(string ImagePath)
        //{
        //    FileInfo picInfo = new FileInfo(ImagePath);
        //    FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
        //    BinaryReader byteReader = new BinaryReader(fs);

        //    return byteReader.ReadBytes((int)picInfo.Length);
        //}

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Insert into Ogrenciler (TcKimlik,Isim,Soyisim,Telefon,OgrenciNo,DurumId,Bolum1,Bolum2) values (@TcKimlik,@Isim,@Soyisim,@Telefon,@OgrenciNo,@DurumId,@Bolum1,@Bolum2)", baglanti);
            cmd.Parameters.Add("TcKimlik", txtTcNo.Text);
            cmd.Parameters.Add("Isim", txtOgrenciAd.Text);
            cmd.Parameters.Add("Soyisim", txtOgrenciSoyad.Text);
            cmd.Parameters.Add("Telefon", txtTelefon.Text);
            cmd.Parameters.Add("OgrenciNo", txtOgrenciNo.Text);
            //cmd.Parameters.Add("Resim",ImageToByte(pcbResim.ImageLocation));
            cmd.Parameters.Add("DurumId", cmbDurumlar.SelectedValue);
            cmd.Parameters.Add("Bolum1", cmbBolum1.Text);
            cmd.Parameters.Add("Bolum2", cmbBolum2.Text);

            int sonuc = cmd.ExecuteNonQuery();

            if (sonuc > 0)
            {
                lblMesaj.Text = "Ekleme işleminiz başarıyla gerçekleştirilmiştir";
            }
            

            foreach (Control ktn in this.Controls)
            {
                if (ktn is TextBox)
                {
                    ktn.Text = "";
                }
            }
            baglanti.Close();
            
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

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)Keys.Back != e.KeyChar)
            {
                if (!Char.IsDigit(e.KeyChar) || txtTcNo.Text.Length > 10)
                {
                    e.Handled = true;
                }
            }
        }
        }
    }

