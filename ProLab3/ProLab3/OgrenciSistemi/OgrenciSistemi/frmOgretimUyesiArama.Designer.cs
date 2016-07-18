namespace OgrenciSistemi
{
    partial class frmOgretimUyesiArama
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSicilNo = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgOgretimArama = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgretimArama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(196, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(91, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÖĞRETİM ÜYESİ ARAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "SİCİL NO:";
            // 
            // cmbSicilNo
            // 
            this.cmbSicilNo.FormattingEnabled = true;
            this.cmbSicilNo.Location = new System.Drawing.Point(196, 139);
            this.cmbSicilNo.Name = "cmbSicilNo";
            this.cmbSicilNo.Size = new System.Drawing.Size(160, 21);
            this.cmbSicilNo.TabIndex = 19;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Yellow;
            this.btnAra.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAra.Location = new System.Drawing.Point(420, 136);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Yellow;
            this.btnGeri.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGeri.Location = new System.Drawing.Point(535, 136);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgOgretimArama
            // 
            this.dgOgretimArama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOgretimArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgretimArama.Location = new System.Drawing.Point(75, 202);
            this.dgOgretimArama.Name = "dgOgretimArama";
            this.dgOgretimArama.Size = new System.Drawing.Size(606, 216);
            this.dgOgretimArama.TabIndex = 22;
            // 
            // frmOgretimUyesiArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(765, 449);
            this.Controls.Add(this.dgOgretimArama);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbSicilNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "frmOgretimUyesiArama";
            this.Text = "frmOgretimUyesiArama";
            this.Load += new System.EventHandler(this.frmOgretimUyesiArama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgretimArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSicilNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgOgretimArama;
    }
}