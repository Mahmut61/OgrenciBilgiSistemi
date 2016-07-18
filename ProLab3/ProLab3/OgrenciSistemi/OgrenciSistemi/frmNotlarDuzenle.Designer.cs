namespace OgrenciSistemi
{
    partial class frmNotlarDuzenle
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.cmbDersKodu = new System.Windows.Forms.ComboBox();
            this.txtVizeNotu = new System.Windows.Forms.TextBox();
            this.txtFinalNotu = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.btnNotDuzenleCikis = new System.Windows.Forms.Button();
            this.btnNotSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(140, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOT DÜZENLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ÖĞRENCİ NUMARASINI SEÇİNİZ   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(113, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "DERS KODUNU SEÇİNİZ               :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "VİZE NOTU               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(52, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ORTALAMA              :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(52, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "FİNAL NOTU             :";
            // 
            // cmbOgrenciNo
            // 
            this.cmbOgrenciNo.FormattingEnabled = true;
            this.cmbOgrenciNo.Location = new System.Drawing.Point(420, 118);
            this.cmbOgrenciNo.Name = "cmbOgrenciNo";
            this.cmbOgrenciNo.Size = new System.Drawing.Size(160, 21);
            this.cmbOgrenciNo.TabIndex = 16;
            this.cmbOgrenciNo.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciNo_SelectedIndexChanged);
            // 
            // cmbDersKodu
            // 
            this.cmbDersKodu.FormattingEnabled = true;
            this.cmbDersKodu.Location = new System.Drawing.Point(420, 194);
            this.cmbDersKodu.Name = "cmbDersKodu";
            this.cmbDersKodu.Size = new System.Drawing.Size(160, 21);
            this.cmbDersKodu.TabIndex = 17;
            this.cmbDersKodu.SelectedIndexChanged += new System.EventHandler(this.cmbDersKodu_SelectedIndexChanged);
            // 
            // txtVizeNotu
            // 
            this.txtVizeNotu.Location = new System.Drawing.Point(246, 248);
            this.txtVizeNotu.Name = "txtVizeNotu";
            this.txtVizeNotu.Size = new System.Drawing.Size(160, 20);
            this.txtVizeNotu.TabIndex = 18;
            // 
            // txtFinalNotu
            // 
            this.txtFinalNotu.Location = new System.Drawing.Point(246, 289);
            this.txtFinalNotu.Name = "txtFinalNotu";
            this.txtFinalNotu.Size = new System.Drawing.Size(160, 20);
            this.txtFinalNotu.TabIndex = 19;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(246, 334);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(160, 20);
            this.txtOrtalama.TabIndex = 20;
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnNotGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGuncelle.Location = new System.Drawing.Point(48, 405);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(153, 57);
            this.btnNotGuncelle.TabIndex = 21;
            this.btnNotGuncelle.Text = "      GÜNCELLE";
            this.btnNotGuncelle.UseVisualStyleBackColor = true;
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // btnNotDuzenleCikis
            // 
            this.btnNotDuzenleCikis.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnNotDuzenleCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotDuzenleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotDuzenleCikis.Location = new System.Drawing.Point(514, 405);
            this.btnNotDuzenleCikis.Name = "btnNotDuzenleCikis";
            this.btnNotDuzenleCikis.Size = new System.Drawing.Size(153, 57);
            this.btnNotDuzenleCikis.TabIndex = 22;
            this.btnNotDuzenleCikis.Text = "      İPTAL";
            this.btnNotDuzenleCikis.UseVisualStyleBackColor = true;
            this.btnNotDuzenleCikis.Click += new System.EventHandler(this.btnNotDuzenleCikis_Click);
            // 
            // btnNotSil
            // 
            this.btnNotSil.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Sil;
            this.btnNotSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotSil.Location = new System.Drawing.Point(288, 405);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(153, 57);
            this.btnNotSil.TabIndex = 23;
            this.btnNotSil.Text = "      SİL";
            this.btnNotSil.UseVisualStyleBackColor = true;
            this.btnNotSil.Click += new System.EventHandler(this.btnNotSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(114, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "SEÇİLEN ÖĞRENCİNİN BÖLÜMÜ  :";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(419, 156);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(160, 20);
            this.txtBolum.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(456, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(183, 485);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 27;
            // 
            // frmNotlarDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(753, 526);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNotSil);
            this.Controls.Add(this.btnNotDuzenleCikis);
            this.Controls.Add(this.btnNotGuncelle);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtFinalNotu);
            this.Controls.Add(this.txtVizeNotu);
            this.Controls.Add(this.cmbDersKodu);
            this.Controls.Add(this.cmbOgrenciNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmNotlarDuzenle";
            this.Text = "frmNotlarDuzenle";
            this.Load += new System.EventHandler(this.frmNotlarDuzenle_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgrenciNo;
        private System.Windows.Forms.ComboBox cmbDersKodu;
        private System.Windows.Forms.TextBox txtVizeNotu;
        private System.Windows.Forms.TextBox txtFinalNotu;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.Button btnNotDuzenleCikis;
        private System.Windows.Forms.Button btnNotSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMesaj;
    }
}