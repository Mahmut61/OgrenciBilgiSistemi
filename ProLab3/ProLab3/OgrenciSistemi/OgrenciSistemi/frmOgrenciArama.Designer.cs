namespace OgrenciSistemi
{
    partial class frmOgrenciArama
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgOgrenciArama = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciArama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(75, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 42);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(117, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÖĞRENCİ ARAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "ÖĞRENCİ NO:";
            // 
            // cmbOgrenciNo
            // 
            this.cmbOgrenciNo.FormattingEnabled = true;
            this.cmbOgrenciNo.Location = new System.Drawing.Point(196, 140);
            this.cmbOgrenciNo.Name = "cmbOgrenciNo";
            this.cmbOgrenciNo.Size = new System.Drawing.Size(160, 21);
            this.cmbOgrenciNo.TabIndex = 20;
            this.cmbOgrenciNo.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciNo_SelectedIndexChanged);
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Yellow;
            this.btnArama.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnArama.Location = new System.Drawing.Point(421, 140);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 23);
            this.btnArama.TabIndex = 21;
            this.btnArama.Text = "Ara";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Yellow;
            this.btnGeri.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGeri.Location = new System.Drawing.Point(533, 140);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgOgrenciArama
            // 
            this.dgOgrenciArama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOgrenciArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciArama.Location = new System.Drawing.Point(75, 202);
            this.dgOgrenciArama.Name = "dgOgrenciArama";
            this.dgOgrenciArama.Size = new System.Drawing.Size(606, 216);
            this.dgOgrenciArama.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(489, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "BÖLÜM  :";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(564, 39);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(160, 20);
            this.txtBolum.TabIndex = 25;
            // 
            // frmOgrenciArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(765, 449);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgOgrenciArama);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.cmbOgrenciNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "frmOgrenciArama";
            this.Text = "frmOgrenciArama";
            this.Load += new System.EventHandler(this.frmOgrenciArama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOgrenciNo;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgOgrenciArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolum;
    }
}