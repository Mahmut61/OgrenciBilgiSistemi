namespace OgrenciSistemi
{
    partial class frmOgrenci
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
            this.dgOgrenci = new System.Windows.Forms.DataGridView();
            this.btnOgrenciGeri = new System.Windows.Forms.Button();
            this.btnOgrenciArama = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(297, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİLER";
            // 
            // dgOgrenci
            // 
            this.dgOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenci.Location = new System.Drawing.Point(90, 95);
            this.dgOgrenci.Name = "dgOgrenci";
            this.dgOgrenci.Size = new System.Drawing.Size(774, 271);
            this.dgOgrenci.TabIndex = 10;
            // 
            // btnOgrenciGeri
            // 
            this.btnOgrenciGeri.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Geri;
            this.btnOgrenciGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgrenciGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGeri.Location = new System.Drawing.Point(699, 393);
            this.btnOgrenciGeri.Name = "btnOgrenciGeri";
            this.btnOgrenciGeri.Size = new System.Drawing.Size(165, 57);
            this.btnOgrenciGeri.TabIndex = 17;
            this.btnOgrenciGeri.Text = "      GERİ";
            this.btnOgrenciGeri.UseVisualStyleBackColor = true;
            this.btnOgrenciGeri.Click += new System.EventHandler(this.btnOgrenciGeri_Click);
            // 
            // btnOgrenciArama
            // 
            this.btnOgrenciArama.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Arama;
            this.btnOgrenciArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgrenciArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciArama.Location = new System.Drawing.Point(502, 393);
            this.btnOgrenciArama.Name = "btnOgrenciArama";
            this.btnOgrenciArama.Size = new System.Drawing.Size(165, 57);
            this.btnOgrenciArama.TabIndex = 16;
            this.btnOgrenciArama.Text = "      ARAMA";
            this.btnOgrenciArama.UseVisualStyleBackColor = true;
            this.btnOgrenciArama.Click += new System.EventHandler(this.btnOgrenciArama_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnOgrenciGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgrenciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(297, 393);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(165, 57);
            this.btnOgrenciGuncelle.TabIndex = 15;
            this.btnOgrenciGuncelle.Text = "      DÜZENLE";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnOgrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(90, 393);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(165, 57);
            this.btnOgrenciEkle.TabIndex = 14;
            this.btnOgrenciEkle.Text = "      EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(959, 485);
            this.Controls.Add(this.btnOgrenciGeri);
            this.Controls.Add(this.btnOgrenciArama);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.dgOgrenci);
            this.Controls.Add(this.panel2);
            this.Name = "frmOgrenci";
            this.Text = "frmOgrenci";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOgrenci;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciArama;
        private System.Windows.Forms.Button btnOgrenciGeri;
    }
}