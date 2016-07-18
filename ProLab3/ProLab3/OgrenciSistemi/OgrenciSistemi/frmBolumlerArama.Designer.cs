namespace OgrenciSistemi
{
    partial class frmBolumlerArama
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
            this.cmbBolumAdi = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgBolumlerArama = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBolumlerArama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(196, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(78, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÇAP ÖĞRENCİLERİ ARAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "BÖLÜM ADI:";
            // 
            // cmbBolumAdi
            // 
            this.cmbBolumAdi.FormattingEnabled = true;
            this.cmbBolumAdi.Location = new System.Drawing.Point(196, 140);
            this.cmbBolumAdi.Name = "cmbBolumAdi";
            this.cmbBolumAdi.Size = new System.Drawing.Size(160, 21);
            this.cmbBolumAdi.TabIndex = 20;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Yellow;
            this.btnAra.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAra.Location = new System.Drawing.Point(402, 137);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Yellow;
            this.btnGeri.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGeri.Location = new System.Drawing.Point(510, 137);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgBolumlerArama
            // 
            this.dgBolumlerArama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBolumlerArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBolumlerArama.Location = new System.Drawing.Point(75, 202);
            this.dgBolumlerArama.Name = "dgBolumlerArama";
            this.dgBolumlerArama.Size = new System.Drawing.Size(606, 216);
            this.dgBolumlerArama.TabIndex = 23;
            // 
            // frmBolumlerArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(765, 449);
            this.Controls.Add(this.dgBolumlerArama);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbBolumAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "frmBolumlerArama";
            this.Text = "frmBolumlerArama";
            this.Load += new System.EventHandler(this.frmBolumlerArama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBolumlerArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBolumAdi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgBolumlerArama;
    }
}