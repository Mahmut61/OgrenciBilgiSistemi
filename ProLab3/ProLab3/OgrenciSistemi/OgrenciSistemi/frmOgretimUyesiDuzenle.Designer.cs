namespace OgrenciSistemi
{
    partial class frmOgretimUyesiDuzenle
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
            this.cmbSicilNo = new System.Windows.Forms.ComboBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.btnOgretimGuncelle = new System.Windows.Forms.Button();
            this.btnOgretimUyeleriDuzenleCikis = new System.Windows.Forms.Button();
            this.btnOgretimSil = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(87, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRETİM ÜYESİ DÜZENLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "DÜZENLENECEK SİCİL NUMARASINI SEÇİNİZ   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "SİCİL NO              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "SOYİSİM               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "İSİM                      :";
            // 
            // cmbSicilNo
            // 
            this.cmbSicilNo.FormattingEnabled = true;
            this.cmbSicilNo.Location = new System.Drawing.Point(493, 135);
            this.cmbSicilNo.Name = "cmbSicilNo";
            this.cmbSicilNo.Size = new System.Drawing.Size(160, 21);
            this.cmbSicilNo.TabIndex = 15;
            this.cmbSicilNo.SelectedIndexChanged += new System.EventHandler(this.cmbSicilNo_SelectedIndexChanged);
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(234, 220);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(160, 20);
            this.txtSicilNo.TabIndex = 16;
            this.txtSicilNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSicilNo_KeyPress);
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(234, 268);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(160, 20);
            this.txtisim.TabIndex = 17;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(234, 323);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(160, 20);
            this.txtSoyisim.TabIndex = 18;
            // 
            // btnOgretimGuncelle
            // 
            this.btnOgretimGuncelle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnOgretimGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgretimGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretimGuncelle.Location = new System.Drawing.Point(51, 411);
            this.btnOgretimGuncelle.Name = "btnOgretimGuncelle";
            this.btnOgretimGuncelle.Size = new System.Drawing.Size(153, 57);
            this.btnOgretimGuncelle.TabIndex = 19;
            this.btnOgretimGuncelle.Text = "      GÜNCELLE";
            this.btnOgretimGuncelle.UseVisualStyleBackColor = true;
            this.btnOgretimGuncelle.Click += new System.EventHandler(this.btnOgretimGuncelle_Click);
            // 
            // btnOgretimUyeleriDuzenleCikis
            // 
            this.btnOgretimUyeleriDuzenleCikis.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnOgretimUyeleriDuzenleCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgretimUyeleriDuzenleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretimUyeleriDuzenleCikis.Location = new System.Drawing.Point(500, 411);
            this.btnOgretimUyeleriDuzenleCikis.Name = "btnOgretimUyeleriDuzenleCikis";
            this.btnOgretimUyeleriDuzenleCikis.Size = new System.Drawing.Size(153, 57);
            this.btnOgretimUyeleriDuzenleCikis.TabIndex = 20;
            this.btnOgretimUyeleriDuzenleCikis.Text = "      İPTAL";
            this.btnOgretimUyeleriDuzenleCikis.UseVisualStyleBackColor = true;
            this.btnOgretimUyeleriDuzenleCikis.Click += new System.EventHandler(this.btnOgretimUyeleriDuzenleCikis_Click);
            // 
            // btnOgretimSil
            // 
            this.btnOgretimSil.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Sil;
            this.btnOgretimSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgretimSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretimSil.Location = new System.Drawing.Point(277, 411);
            this.btnOgretimSil.Name = "btnOgretimSil";
            this.btnOgretimSil.Size = new System.Drawing.Size(153, 57);
            this.btnOgretimSil.TabIndex = 21;
            this.btnOgretimSil.Text = "      SİL";
            this.btnOgretimSil.UseVisualStyleBackColor = true;
            this.btnOgretimSil.Click += new System.EventHandler(this.btnOgretimSil_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(197, 497);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 22;
            // 
            // frmOgretimUyesiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(753, 534);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnOgretimSil);
            this.Controls.Add(this.btnOgretimUyeleriDuzenleCikis);
            this.Controls.Add(this.btnOgretimGuncelle);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.txtSicilNo);
            this.Controls.Add(this.cmbSicilNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmOgretimUyesiDuzenle";
            this.Text = "frmOgretimUyesiDuzenle";
            this.Load += new System.EventHandler(this.frmOgretimUyesiDuzenle_Load);
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
        private System.Windows.Forms.ComboBox cmbSicilNo;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Button btnOgretimGuncelle;
        private System.Windows.Forms.Button btnOgretimUyeleriDuzenleCikis;
        private System.Windows.Forms.Button btnOgretimSil;
        private System.Windows.Forms.Label lblMesaj;
    }
}