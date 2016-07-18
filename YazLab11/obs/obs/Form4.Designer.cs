namespace obs
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_topyazi = new System.Windows.Forms.Label();
            this.lbl_toplamkredi = new System.Windows.Forms.Label();
            this.txt_alinanogrno = new System.Windows.Forms.TextBox();
            this.txt_alinanakts = new System.Windows.Forms.TextBox();
            this.txt_alinanders = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(31, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ekle";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Ekle";
            this.Column1.Width = 50;
            // 
            // lbl_topyazi
            // 
            this.lbl_topyazi.AutoSize = true;
            this.lbl_topyazi.Location = new System.Drawing.Point(28, 329);
            this.lbl_topyazi.Name = "lbl_topyazi";
            this.lbl_topyazi.Size = new System.Drawing.Size(72, 13);
            this.lbl_topyazi.TabIndex = 1;
            this.lbl_topyazi.Text = "Toplam Kredi:";
            // 
            // lbl_toplamkredi
            // 
            this.lbl_toplamkredi.AutoSize = true;
            this.lbl_toplamkredi.Location = new System.Drawing.Point(99, 329);
            this.lbl_toplamkredi.Name = "lbl_toplamkredi";
            this.lbl_toplamkredi.Size = new System.Drawing.Size(17, 13);
            this.lbl_toplamkredi.TabIndex = 2;
            this.lbl_toplamkredi.Text = "xx";
            // 
            // txt_alinanogrno
            // 
            this.txt_alinanogrno.Location = new System.Drawing.Point(31, 291);
            this.txt_alinanogrno.Name = "txt_alinanogrno";
            this.txt_alinanogrno.Size = new System.Drawing.Size(85, 20);
            this.txt_alinanogrno.TabIndex = 3;
            // 
            // txt_alinanakts
            // 
            this.txt_alinanakts.Location = new System.Drawing.Point(302, 291);
            this.txt_alinanakts.Name = "txt_alinanakts";
            this.txt_alinanakts.Size = new System.Drawing.Size(40, 20);
            this.txt_alinanakts.TabIndex = 4;
            // 
            // txt_alinanders
            // 
            this.txt_alinanders.Location = new System.Drawing.Point(122, 291);
            this.txt_alinanders.Name = "txt_alinanders";
            this.txt_alinanders.Size = new System.Drawing.Size(174, 20);
            this.txt_alinanders.TabIndex = 5;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(348, 289);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(475, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 238);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(746, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(81, 238);
            this.listBox2.TabIndex = 8;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(614, 288);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(125, 23);
            this.btnOnayla.TabIndex = 9;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 375);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_alinanders);
            this.Controls.Add(this.txt_alinanakts);
            this.Controls.Add(this.txt_alinanogrno);
            this.Controls.Add(this.lbl_toplamkredi);
            this.Controls.Add(this.lbl_topyazi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_topyazi;
        private System.Windows.Forms.Label lbl_toplamkredi;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox txt_alinanogrno;
        private System.Windows.Forms.TextBox txt_alinanakts;
        private System.Windows.Forms.TextBox txt_alinanders;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnOnayla;
    }
}