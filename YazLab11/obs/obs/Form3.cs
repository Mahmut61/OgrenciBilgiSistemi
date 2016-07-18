using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace obs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection Baglantim3 = new SqlConnection("Server =localhost; Database = YazLab1; uid=sa; password=1; Trusted_Connection = True;");
            SqlCommand Komut4 = new SqlCommand("select * from DersSecimi", Baglantim3);
            SqlDataAdapter adaptor = new SqlDataAdapter(Komut4);
            DataTable ds = new DataTable();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;


            int toplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam = Convert.ToInt32(dataGridView1[3, i].Value) + toplam;
            }
            
            lbl_toplamkredi.Text = Convert.ToString(toplam);
           

        }
 
    }
}
