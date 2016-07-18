namespace OgrenciSistemi
{
    partial class frmDersler
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
            this.dgDersler = new System.Windows.Forms.DataGridView();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersGeri = new System.Windows.Forms.Button();
            this.btnDersArama = new System.Windows.Forms.Button();
            this.btnDersDuzenle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(298, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(144, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERSLER";
            // 
            // dgDersler
            // 
            this.dgDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDersler.Location = new System.Drawing.Point(92, 94);
            this.dgDersler.Name = "dgDersler";
            this.dgDersler.Size = new System.Drawing.Size(774, 271);
            this.dgDersler.TabIndex = 11;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Ekle;
            this.btnDersEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(92, 386);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(165, 57);
            this.btnDersEkle.TabIndex = 12;
            this.btnDersEkle.Text = "      EKLE";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersGeri
            // 
            this.btnDersGeri.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Geri;
            this.btnDersGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDersGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersGeri.Location = new System.Drawing.Point(701, 386);
            this.btnDersGeri.Name = "btnDersGeri";
            this.btnDersGeri.Size = new System.Drawing.Size(165, 57);
            this.btnDersGeri.TabIndex = 13;
            this.btnDersGeri.Text = "      GERİ";
            this.btnDersGeri.UseVisualStyleBackColor = true;
            this.btnDersGeri.Click += new System.EventHandler(this.btnDersGeri_Click);
            // 
            // btnDersArama
            // 
            this.btnDersArama.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Arama;
            this.btnDersArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDersArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersArama.Location = new System.Drawing.Point(503, 386);
            this.btnDersArama.Name = "btnDersArama";
            this.btnDersArama.Size = new System.Drawing.Size(165, 57);
            this.btnDersArama.TabIndex = 14;
            this.btnDersArama.Text = "      ARAMA";
            this.btnDersArama.UseVisualStyleBackColor = true;
            this.btnDersArama.Click += new System.EventHandler(this.btnDersArama_Click);
            // 
            // btnDersDuzenle
            // 
            this.btnDersDuzenle.BackgroundImage = global::OgrenciSistemi.Properties.Resources.Duzenle;
            this.btnDersDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDersDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersDuzenle.Location = new System.Drawing.Point(298, 386);
            this.btnDersDuzenle.Name = "btnDersDuzenle";
            this.btnDersDuzenle.Size = new System.Drawing.Size(165, 57);
            this.btnDersDuzenle.TabIndex = 15;
            this.btnDersDuzenle.Text = "      DÜZENLE";
            this.btnDersDuzenle.UseVisualStyleBackColor = true;
            this.btnDersDuzenle.Click += new System.EventHandler(this.btnDersDuzenle_Click);
            // 
            // frmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(959, 485);
            this.Controls.Add(this.btnDersDuzenle);
            this.Controls.Add(this.btnDersArama);
            this.Controls.Add(this.btnDersGeri);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.dgDersler);
            this.Controls.Add(this.panel2);
            this.Name = "frmDersler";
            this.Text = "Dersler";
            this.Load += new System.EventHandler(this.frmDersler_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDersler;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersGeri;
        private System.Windows.Forms.Button btnDersArama;
        private System.Windows.Forms.Button btnDersDuzenle;
    }
}