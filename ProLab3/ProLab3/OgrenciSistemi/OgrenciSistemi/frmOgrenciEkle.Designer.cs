namespace OgrenciSistemi
{
    partial class frmOgrenciEkle
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.cmbBolum1 = new System.Windows.Forms.ComboBox();
            this.cmbDurumlar = new System.Windows.Forms.ComboBox();
            this.cmbBolum2 = new System.Windows.Forms.ComboBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgreciIptal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.btnGozat = new System.Windows.Forms.Button();
            this.opfDosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(50, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 42);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(136, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "İSİM                    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "SOYİSİM             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(50, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "RESİM                :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(46, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "TC KİMLİK NO    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "TELEFON NO    :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(47, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "BOLUM1             :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(47, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "DURUM              :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(47, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "BOLUM2             :";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(199, 141);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(160, 20);
            this.txtOgrenciAd.TabIndex = 18;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(199, 303);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(160, 20);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(199, 252);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(160, 20);
            this.txtTcNo.TabIndex = 21;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(199, 197);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(160, 20);
            this.txtOgrenciSoyad.TabIndex = 22;
            // 
            // cmbBolum1
            // 
            this.cmbBolum1.FormattingEnabled = true;
            this.cmbBolum1.Location = new System.Drawing.Point(199, 409);
            this.cmbBolum1.Name = "cmbBolum1";
            this.cmbBolum1.Size = new System.Drawing.Size(160, 21);
            this.cmbBolum1.TabIndex = 23;
            // 
            // cmbDurumlar
            // 
            this.cmbDurumlar.FormattingEnabled = true;
            this.cmbDurumlar.Location = new System.Drawing.Point(199, 354);
            this.cmbDurumlar.Name = "cmbDurumlar";
            this.cmbDurumlar.Size = new System.Drawing.Size(160, 21);
            this.cmbDurumlar.TabIndex = 24;
            this.cmbDurumlar.SelectedIndexChanged += new System.EventHandler(this.cmbDurumlar_SelectedIndexChanged);
            // 
            // cmbBolum2
            // 
            this.cmbBolum2.FormattingEnabled = true;
            this.cmbBolum2.Location = new System.Drawing.Point(199, 461);
            this.cmbBolum2.Name = "cmbBolum2";
            this.cmbBolum2.Size = new System.Drawing.Size(160, 21);
            this.cmbBolum2.TabIndex = 25;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnOgrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(48, 635);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(153, 57);
            this.btnOgrenciEkle.TabIndex = 26;
            this.btnOgrenciEkle.Text = "      EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgreciIptal
            // 
            this.btnOgreciIptal.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnOgreciIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgreciIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgreciIptal.Location = new System.Drawing.Point(289, 635);
            this.btnOgreciIptal.Name = "btnOgreciIptal";
            this.btnOgreciIptal.Size = new System.Drawing.Size(153, 57);
            this.btnOgreciIptal.TabIndex = 27;
            this.btnOgreciIptal.Text = "      İPTAL";
            this.btnOgreciIptal.UseVisualStyleBackColor = true;
            this.btnOgreciIptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(45, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "ÖĞRENCİ NO    :";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(199, 99);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(160, 20);
            this.txtOgrenciNo.TabIndex = 29;
            this.txtOgrenciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrenciNo_KeyPress);
            // 
            // pcbResim
            // 
            this.pcbResim.BackColor = System.Drawing.Color.AliceBlue;
            this.pcbResim.Location = new System.Drawing.Point(199, 528);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(67, 75);
            this.pcbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResim.TabIndex = 30;
            this.pcbResim.TabStop = false;
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(273, 572);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(86, 31);
            this.btnGozat.TabIndex = 31;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // opfDosyaAc
            // 
            this.opfDosyaAc.FileName = "openFileDialog1";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(45, 705);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 32;
            // 
            // frmOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(493, 749);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.pcbResim);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOgreciIptal);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.cmbBolum2);
            this.Controls.Add(this.cmbDurumlar);
            this.Controls.Add(this.cmbBolum1);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmOgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.frmOgrenciEkle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.ComboBox cmbBolum1;
        private System.Windows.Forms.ComboBox cmbDurumlar;
        private System.Windows.Forms.ComboBox cmbBolum2;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgreciIptal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.OpenFileDialog opfDosyaAc;
        private System.Windows.Forms.Label lblMesaj;
    }
}