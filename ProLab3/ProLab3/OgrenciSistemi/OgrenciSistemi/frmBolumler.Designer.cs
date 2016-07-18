namespace OgrenciSistemi
{
    partial class frmBolumler
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
            this.dgBolumler = new System.Windows.Forms.DataGridView();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnBolumGeri = new System.Windows.Forms.Button();
            this.btnBolumDuzenle = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(297, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜMLER";
            // 
            // dgBolumler
            // 
            this.dgBolumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBolumler.Location = new System.Drawing.Point(99, 94);
            this.dgBolumler.Name = "dgBolumler";
            this.dgBolumler.Size = new System.Drawing.Size(774, 271);
            this.dgBolumler.TabIndex = 11;
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnBolumEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumEkle.Location = new System.Drawing.Point(99, 394);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(165, 57);
            this.btnBolumEkle.TabIndex = 12;
            this.btnBolumEkle.Text = "      EKLE";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnBolumGeri
            // 
            this.btnBolumGeri.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Geri;
            this.btnBolumGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumGeri.Location = new System.Drawing.Point(708, 394);
            this.btnBolumGeri.Name = "btnBolumGeri";
            this.btnBolumGeri.Size = new System.Drawing.Size(165, 57);
            this.btnBolumGeri.TabIndex = 13;
            this.btnBolumGeri.Text = "      GERİ";
            this.btnBolumGeri.UseVisualStyleBackColor = true;
            this.btnBolumGeri.Click += new System.EventHandler(this.btnBolumGeri_Click);
            // 
            // btnBolumDuzenle
            // 
            this.btnBolumDuzenle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnBolumDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBolumDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumDuzenle.Location = new System.Drawing.Point(297, 394);
            this.btnBolumDuzenle.Name = "btnBolumDuzenle";
            this.btnBolumDuzenle.Size = new System.Drawing.Size(165, 57);
            this.btnBolumDuzenle.TabIndex = 15;
            this.btnBolumDuzenle.Text = "      DÜZENLE";
            this.btnBolumDuzenle.UseVisualStyleBackColor = true;
            this.btnBolumDuzenle.Click += new System.EventHandler(this.btnBolumDuzenle_Click);
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Arama;
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Location = new System.Drawing.Point(502, 394);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(165, 57);
            this.btnArama.TabIndex = 16;
            this.btnArama.Text = "      ARAMA";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(959, 485);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnBolumDuzenle);
            this.Controls.Add(this.btnBolumGeri);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.dgBolumler);
            this.Controls.Add(this.panel2);
            this.Name = "frmBolumler";
            this.Text = "frmBolumler";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBolumler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBolumler;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Button btnBolumGeri;
        private System.Windows.Forms.Button btnBolumDuzenle;
        private System.Windows.Forms.Button btnArama;
    }
}