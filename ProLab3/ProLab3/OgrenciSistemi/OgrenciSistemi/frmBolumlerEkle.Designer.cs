namespace OgrenciSistemi
{
    partial class frmBolumlerEkle
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
            this.txtBolumKodu = new System.Windows.Forms.TextBox();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnBolumiptal = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜM EKLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "BÖLÜM KODU       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "BÖLÜM ADİ           :";
            // 
            // txtBolumKodu
            // 
            this.txtBolumKodu.Location = new System.Drawing.Point(213, 141);
            this.txtBolumKodu.MaxLength = 2;
            this.txtBolumKodu.Name = "txtBolumKodu";
            this.txtBolumKodu.Size = new System.Drawing.Size(160, 20);
            this.txtBolumKodu.TabIndex = 12;
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(213, 192);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(160, 20);
            this.txtBolumAdi.TabIndex = 13;
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnBolumEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumEkle.Location = new System.Drawing.Point(50, 377);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(153, 57);
            this.btnBolumEkle.TabIndex = 14;
            this.btnBolumEkle.Text = "      EKLE";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnBolumiptal
            // 
            this.btnBolumiptal.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Cikis;
            this.btnBolumiptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumiptal.Location = new System.Drawing.Point(289, 377);
            this.btnBolumiptal.Name = "btnBolumiptal";
            this.btnBolumiptal.Size = new System.Drawing.Size(153, 57);
            this.btnBolumiptal.TabIndex = 15;
            this.btnBolumiptal.Text = "      İPTAL";
            this.btnBolumiptal.UseVisualStyleBackColor = true;
            this.btnBolumiptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Yellow;
            this.lblMesaj.Location = new System.Drawing.Point(85, 451);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 16;
            // 
            // frmBolumlerEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(493, 494);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnBolumiptal);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.txtBolumKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(50, 27);
            this.Name = "frmBolumlerEkle";
            this.Text = "frmBolumlerEkle";
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
        private System.Windows.Forms.TextBox txtBolumKodu;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Button btnBolumiptal;
        private System.Windows.Forms.Label lblMesaj;
    }
}