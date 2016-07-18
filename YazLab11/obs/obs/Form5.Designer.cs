namespace obs
{
    partial class Form5
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
            this.txt_alinanders = new System.Windows.Forms.TextBox();
            this.txt_akts = new System.Windows.Forms.TextBox();
            this.btn_dersekle = new System.Windows.Forms.Button();
            this.txt_alinanogrno = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_alinanders
            // 
            this.txt_alinanders.Location = new System.Drawing.Point(87, 286);
            this.txt_alinanders.Name = "txt_alinanders";
            this.txt_alinanders.Size = new System.Drawing.Size(219, 20);
            this.txt_alinanders.TabIndex = 1;
            // 
            // txt_akts
            // 
            this.txt_akts.Location = new System.Drawing.Point(312, 286);
            this.txt_akts.Name = "txt_akts";
            this.txt_akts.Size = new System.Drawing.Size(36, 20);
            this.txt_akts.TabIndex = 2;
            // 
            // btn_dersekle
            // 
            this.btn_dersekle.Location = new System.Drawing.Point(354, 286);
            this.btn_dersekle.Name = "btn_dersekle";
            this.btn_dersekle.Size = new System.Drawing.Size(75, 23);
            this.btn_dersekle.TabIndex = 3;
            this.btn_dersekle.Text = "Ekle";
            this.btn_dersekle.UseVisualStyleBackColor = true;
            // 
            // txt_alinanogrno
            // 
            this.txt_alinanogrno.Location = new System.Drawing.Point(12, 286);
            this.txt_alinanogrno.Name = "txt_alinanogrno";
            this.txt_alinanogrno.Size = new System.Drawing.Size(69, 20);
            this.txt_alinanogrno.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ekle";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 330);
            this.Controls.Add(this.txt_alinanogrno);
            this.Controls.Add(this.btn_dersekle);
            this.Controls.Add(this.txt_akts);
            this.Controls.Add(this.txt_alinanders);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_alinanders;
        private System.Windows.Forms.TextBox txt_akts;
        private System.Windows.Forms.Button btn_dersekle;
        private System.Windows.Forms.TextBox txt_alinanogrno;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}