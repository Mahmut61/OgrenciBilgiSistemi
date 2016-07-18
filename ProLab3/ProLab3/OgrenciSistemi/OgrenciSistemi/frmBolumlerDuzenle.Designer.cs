namespace OgrenciSistemi
{
    partial class frmBolumlerDuzenle
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
            this.txtBolumKodu = new System.Windows.Forms.TextBox();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.cmbBolumKoduSec = new System.Windows.Forms.ComboBox();
            this.btnBolumDuzenleCikis = new System.Windows.Forms.Button();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblMesaj1 = new System.Windows.Forms.Label();
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
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜM DÜZENLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "DÜZENLENECEK BÖLÜM KODU SEÇİNİZ   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "BÖLÜM ADI             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "BÖLÜM KODU        :";
            // 
            // txtBolumKodu
            // 
            this.txtBolumKodu.Location = new System.Drawing.Point(207, 217);
            this.txtBolumKodu.Name = "txtBolumKodu";
            this.txtBolumKodu.Size = new System.Drawing.Size(160, 20);
            this.txtBolumKodu.TabIndex = 13;
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(207, 276);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(160, 20);
            this.txtBolumAdi.TabIndex = 14;
            // 
            // cmbBolumKoduSec
            // 
            this.cmbBolumKoduSec.FormattingEnabled = true;
            this.cmbBolumKoduSec.Location = new System.Drawing.Point(456, 136);
            this.cmbBolumKoduSec.Name = "cmbBolumKoduSec";
            this.cmbBolumKoduSec.Size = new System.Drawing.Size(160, 21);
            this.cmbBolumKoduSec.TabIndex = 15;
            this.cmbBolumKoduSec.SelectedIndexChanged += new System.EventHandler(this.cmbBolumKoduSec_SelectedIndexChanged);
            // 
            // btnBolumDuzenleCikis
            // 
            this.btnBolumDuzenleCikis.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnBolumDuzenleCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumDuzenleCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumDuzenleCikis.Location = new System.Drawing.Point(512, 377);
            this.btnBolumDuzenleCikis.Name = "btnBolumDuzenleCikis";
            this.btnBolumDuzenleCikis.Size = new System.Drawing.Size(153, 57);
            this.btnBolumDuzenleCikis.TabIndex = 18;
            this.btnBolumDuzenleCikis.Text = "      İPTAL";
            this.btnBolumDuzenleCikis.UseVisualStyleBackColor = true;
            this.btnBolumDuzenleCikis.Click += new System.EventHandler(this.btnBolumDuzenleCikis_Click);
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Sil;
            this.btnBolumSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumSil.Location = new System.Drawing.Point(289, 377);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(153, 57);
            this.btnBolumSil.TabIndex = 17;
            this.btnBolumSil.Text = "      SİL";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);
            // 
            // btnBolumGuncelle
            // 
            this.btnBolumGuncelle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnBolumGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumGuncelle.Location = new System.Drawing.Point(50, 377);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(153, 57);
            this.btnBolumGuncelle.TabIndex = 16;
            this.btnBolumGuncelle.Text = "      GÜNCELLE";
            this.btnBolumGuncelle.UseVisualStyleBackColor = true;
            this.btnBolumGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(129, 454);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 19;
            // 
            // lblMesaj1
            // 
            this.lblMesaj1.AutoSize = true;
            this.lblMesaj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj1.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj1.Location = new System.Drawing.Point(184, 459);
            this.lblMesaj1.Name = "lblMesaj1";
            this.lblMesaj1.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj1.TabIndex = 20;
            // 
            // frmBolumlerDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(753, 494);
            this.Controls.Add(this.lblMesaj1);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnBolumDuzenleCikis);
            this.Controls.Add(this.btnBolumSil);
            this.Controls.Add(this.btnBolumGuncelle);
            this.Controls.Add(this.cmbBolumKoduSec);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.txtBolumKodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmBolumlerDuzenle";
            this.Text = "BolumlerDuzenle";
            this.Load += new System.EventHandler(this.frmBolumlerDuzenle_Load);
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
        private System.Windows.Forms.TextBox txtBolumKodu;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.ComboBox cmbBolumKoduSec;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Button btnBolumDuzenleCikis;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblMesaj1;
    }
}