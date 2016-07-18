namespace OgrenciSistemi
{
    partial class frmNotlar
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
            this.dgNotlar = new System.Windows.Forms.DataGridView();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.btnNotGeri = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnNotDuzenle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(294, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTLAR";
            // 
            // dgNotlar
            // 
            this.dgNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotlar.Location = new System.Drawing.Point(102, 96);
            this.dgNotlar.Name = "dgNotlar";
            this.dgNotlar.Size = new System.Drawing.Size(774, 271);
            this.dgNotlar.TabIndex = 11;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnNotEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotEkle.Location = new System.Drawing.Point(102, 395);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(165, 57);
            this.btnNotEkle.TabIndex = 12;
            this.btnNotEkle.Text = "      EKLE";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // btnNotGeri
            // 
            this.btnNotGeri.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Geri;
            this.btnNotGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGeri.Location = new System.Drawing.Point(711, 395);
            this.btnNotGeri.Name = "btnNotGeri";
            this.btnNotGeri.Size = new System.Drawing.Size(165, 57);
            this.btnNotGeri.TabIndex = 13;
            this.btnNotGeri.Text = "      GERİ";
            this.btnNotGeri.UseVisualStyleBackColor = true;
            this.btnNotGeri.Click += new System.EventHandler(this.btnNotGeri_Click);
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Arama;
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Location = new System.Drawing.Point(499, 395);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(165, 57);
            this.btnArama.TabIndex = 14;
            this.btnArama.Text = "      ARAMA";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnNotDuzenle
            // 
            this.btnNotDuzenle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnNotDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotDuzenle.Location = new System.Drawing.Point(294, 395);
            this.btnNotDuzenle.Name = "btnNotDuzenle";
            this.btnNotDuzenle.Size = new System.Drawing.Size(165, 57);
            this.btnNotDuzenle.TabIndex = 15;
            this.btnNotDuzenle.Text = "      DÜZENLE";
            this.btnNotDuzenle.UseVisualStyleBackColor = true;
            this.btnNotDuzenle.Click += new System.EventHandler(this.btnNotDuzenle_Click);
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(959, 485);
            this.Controls.Add(this.btnNotDuzenle);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnNotGeri);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.dgNotlar);
            this.Controls.Add(this.panel2);
            this.Name = "frmNotlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.frmNotlar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgNotlar;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Button btnNotGeri;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnNotDuzenle;
    }
}