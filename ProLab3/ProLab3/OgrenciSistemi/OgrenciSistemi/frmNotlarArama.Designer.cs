namespace OgrenciSistemi
{
    partial class frmNotlarArama
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.cmbDersKodu = new System.Windows.Forms.ComboBox();
            this.dgNotArama = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotArama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(170, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTLAR ARAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ÖĞRENCİ NO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(306, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "DERS KODU  :";
            // 
            // cmbOgrenciNo
            // 
            this.cmbOgrenciNo.FormattingEnabled = true;
            this.cmbOgrenciNo.Location = new System.Drawing.Point(141, 116);
            this.cmbOgrenciNo.Name = "cmbOgrenciNo";
            this.cmbOgrenciNo.Size = new System.Drawing.Size(143, 21);
            this.cmbOgrenciNo.TabIndex = 16;
            this.cmbOgrenciNo.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciNo_SelectedIndexChanged);
            // 
            // cmbDersKodu
            // 
            this.cmbDersKodu.FormattingEnabled = true;
            this.cmbDersKodu.Location = new System.Drawing.Point(414, 116);
            this.cmbDersKodu.Name = "cmbDersKodu";
            this.cmbDersKodu.Size = new System.Drawing.Size(160, 21);
            this.cmbDersKodu.TabIndex = 17;
            // 
            // dgNotArama
            // 
            this.dgNotArama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNotArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotArama.Location = new System.Drawing.Point(34, 173);
            this.dgNotArama.Name = "dgNotArama";
            this.dgNotArama.Size = new System.Drawing.Size(882, 216);
            this.dgNotArama.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(642, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "BÖLÜM  :";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(717, 23);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(160, 20);
            this.txtBolum.TabIndex = 20;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Yellow;
            this.btnAra.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAra.Location = new System.Drawing.Point(654, 117);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Dersin Notu";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(608, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "ARA:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Yellow;
            this.btnGeri.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGeri.Location = new System.Drawing.Point(770, 117);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmNotlarArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(940, 421);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgNotArama);
            this.Controls.Add(this.cmbDersKodu);
            this.Controls.Add(this.cmbOgrenciNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "frmNotlarArama";
            this.Text = "frmNotlarArama";
            this.Load += new System.EventHandler(this.frmNotlarArama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgrenciNo;
        private System.Windows.Forms.ComboBox cmbDersKodu;
        private System.Windows.Forms.DataGridView dgNotArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeri;
    }
}