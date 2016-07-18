namespace OgrenciSistemi
{
    partial class frmDerslerDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDersKodu = new System.Windows.Forms.ComboBox();
            this.cmbSicilNo = new System.Windows.Forms.ComboBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnBolumDuzenleCikis = new System.Windows.Forms.Button();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(187, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 42);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(134, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS DÜZENLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "DÜZENLENEK OLAN DERS KODUNU SEÇİNİZ    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "DERS KODU              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "DERS ADI                  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(61, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "SİCİL NO                    :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(61, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "KREDİ                        :";
            // 
            // cmbDersKodu
            // 
            this.cmbDersKodu.FormattingEnabled = true;
            this.cmbDersKodu.Location = new System.Drawing.Point(462, 118);
            this.cmbDersKodu.Name = "cmbDersKodu";
            this.cmbDersKodu.Size = new System.Drawing.Size(160, 21);
            this.cmbDersKodu.TabIndex = 16;
            this.cmbDersKodu.SelectedIndexChanged += new System.EventHandler(this.cmbDersKodu_SelectedIndexChanged);
            // 
            // cmbSicilNo
            // 
            this.cmbSicilNo.FormattingEnabled = true;
            this.cmbSicilNo.Location = new System.Drawing.Point(245, 344);
            this.cmbSicilNo.Name = "cmbSicilNo";
            this.cmbSicilNo.Size = new System.Drawing.Size(160, 21);
            this.cmbSicilNo.TabIndex = 18;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(245, 241);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(160, 20);
            this.txtDersKodu.TabIndex = 19;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(245, 288);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(160, 20);
            this.txtDersAdi.TabIndex = 20;
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(245, 396);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(160, 20);
            this.txtKredi.TabIndex = 21;
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnDersGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDersGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersGuncelle.Location = new System.Drawing.Point(57, 478);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(153, 57);
            this.btnDersGuncelle.TabIndex = 22;
            this.btnDersGuncelle.Text = "      GÜNCELLE";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnBolumDuzenleCikis
            // 
            this.btnBolumDuzenleCikis.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnBolumDuzenleCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumDuzenleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumDuzenleCikis.Location = new System.Drawing.Point(521, 478);
            this.btnBolumDuzenleCikis.Name = "btnBolumDuzenleCikis";
            this.btnBolumDuzenleCikis.Size = new System.Drawing.Size(153, 57);
            this.btnBolumDuzenleCikis.TabIndex = 23;
            this.btnBolumDuzenleCikis.Text = "      İPTAL";
            this.btnBolumDuzenleCikis.UseVisualStyleBackColor = true;
            this.btnBolumDuzenleCikis.Click += new System.EventHandler(this.btnBolumDuzenleCikis_Click);
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Sil;
            this.btnBolumSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumSil.Location = new System.Drawing.Point(291, 478);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(153, 57);
            this.btnBolumSil.TabIndex = 24;
            this.btnBolumSil.Text = "      SİL";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(183, 569);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 26;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(245, 194);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(160, 20);
            this.txtBolum.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(61, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "BÖLÜM                      :";
            // 
            // frmDerslerDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(753, 609);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBolumSil);
            this.Controls.Add(this.btnBolumDuzenleCikis);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.cmbSicilNo);
            this.Controls.Add(this.cmbDersKodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmDerslerDuzenle";
            this.Text = "frmDerslerDuzenle";
            this.Load += new System.EventHandler(this.frmDerslerDuzenle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDersKodu;
        private System.Windows.Forms.ComboBox cmbSicilNo;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnBolumDuzenleCikis;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label8;
    }
}