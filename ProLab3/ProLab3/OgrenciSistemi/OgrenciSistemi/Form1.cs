using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class Form1 : Form
    {
        frmOgretimUyesi frmOgretimUyesi = new frmOgretimUyesi();
        frmOgrenci frmOgrenci = new frmOgrenci();
        frmDersler frmDersler = new frmDersler();
        frmBolumler frmBolumler = new frmBolumler();
        frmNotlar frmNotlar = new frmNotlar();
       
        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolumler.Show();
        }

        private void öğretimÜyeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretimUyesi.Show();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenci.Show();
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDersler.Show();
        }

        private void notlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotlar.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
