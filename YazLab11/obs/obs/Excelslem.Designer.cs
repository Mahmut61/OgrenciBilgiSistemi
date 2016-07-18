namespace obs
{
    partial class Excelslem
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
            this.btnGozat = new System.Windows.Forms.Button();
            this.txtGozat = new System.Windows.Forms.TextBox();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(301, 24);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(75, 23);
            this.btnGozat.TabIndex = 0;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // txtGozat
            // 
            this.txtGozat.Location = new System.Drawing.Point(21, 24);
            this.txtGozat.Name = "txtGozat";
            this.txtGozat.ReadOnly = true;
            this.txtGozat.Size = new System.Drawing.Size(241, 20);
            this.txtGozat.TabIndex = 1;
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Excelslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGozat);
            this.Controls.Add(this.btnGozat);
            this.Name = "Excelslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excelslem";
            this.Load += new System.EventHandler(this.Excelslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        public System.Windows.Forms.TextBox txtGozat;
        private System.Windows.Forms.Button button1;
    }
}