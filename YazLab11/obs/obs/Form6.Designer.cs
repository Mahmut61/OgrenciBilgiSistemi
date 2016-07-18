namespace obs
{
    partial class Form6
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
            this.txt_alinanogrno = new System.Windows.Forms.TextBox();
            this.txt_alinanakts = new System.Windows.Forms.TextBox();
            this.txt_alinanders = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(404, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ekle";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // txt_alinanogrno
            // 
            this.txt_alinanogrno.Location = new System.Drawing.Point(12, 275);
            this.txt_alinanogrno.Name = "txt_alinanogrno";
            this.txt_alinanogrno.Size = new System.Drawing.Size(78, 20);
            this.txt_alinanogrno.TabIndex = 1;
            // 
            // txt_alinanakts
            // 
            this.txt_alinanakts.Location = new System.Drawing.Point(276, 275);
            this.txt_alinanakts.Name = "txt_alinanakts";
            this.txt_alinanakts.Size = new System.Drawing.Size(42, 20);
            this.txt_alinanakts.TabIndex = 2;
            // 
            // txt_alinanders
            // 
            this.txt_alinanders.Location = new System.Drawing.Point(96, 275);
            this.txt_alinanders.Name = "txt_alinanders";
            this.txt_alinanders.Size = new System.Drawing.Size(174, 20);
            this.txt_alinanders.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(341, 272);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 322);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_alinanders);
            this.Controls.Add(this.txt_alinanakts);
            this.Controls.Add(this.txt_alinanogrno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox txt_alinanogrno;
        private System.Windows.Forms.TextBox txt_alinanakts;
        private System.Windows.Forms.TextBox txt_alinanders;
        private System.Windows.Forms.Button btn_ekle;
    }
}