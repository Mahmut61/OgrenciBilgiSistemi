namespace obs
{
    partial class Form3
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
            this.lbl_topyazi = new System.Windows.Forms.Label();
            this.lbl_toplamkredi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_topyazi
            // 
            this.lbl_topyazi.AutoSize = true;
            this.lbl_topyazi.Location = new System.Drawing.Point(154, 283);
            this.lbl_topyazi.Name = "lbl_topyazi";
            this.lbl_topyazi.Size = new System.Drawing.Size(72, 13);
            this.lbl_topyazi.TabIndex = 2;
            this.lbl_topyazi.Text = "Toplam Kredi:";
            // 
            // lbl_toplamkredi
            // 
            this.lbl_toplamkredi.AutoSize = true;
            this.lbl_toplamkredi.Location = new System.Drawing.Point(232, 283);
            this.lbl_toplamkredi.Name = "lbl_toplamkredi";
            this.lbl_toplamkredi.Size = new System.Drawing.Size(17, 13);
            this.lbl_toplamkredi.TabIndex = 3;
            this.lbl_toplamkredi.Text = "xx";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 308);
            this.Controls.Add(this.lbl_toplamkredi);
            this.Controls.Add(this.lbl_topyazi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_topyazi;
        private System.Windows.Forms.Label lbl_toplamkredi;

    }
}