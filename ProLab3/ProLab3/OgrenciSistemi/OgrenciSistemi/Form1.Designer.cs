namespace OgrenciSistemi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretimÜyeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümlerToolStripMenuItem,
            this.öğretimÜyeleriToolStripMenuItem,
            this.öğrencilerToolStripMenuItem,
            this.derslerToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            this.bölümlerToolStripMenuItem.Click += new System.EventHandler(this.bölümlerToolStripMenuItem_Click);
            // 
            // öğretimÜyeleriToolStripMenuItem
            // 
            this.öğretimÜyeleriToolStripMenuItem.Name = "öğretimÜyeleriToolStripMenuItem";
            this.öğretimÜyeleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.öğretimÜyeleriToolStripMenuItem.Text = "Öğretim Üyeleri";
            this.öğretimÜyeleriToolStripMenuItem.Click += new System.EventHandler(this.öğretimÜyeleriToolStripMenuItem_Click);
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            this.öğrencilerToolStripMenuItem.Click += new System.EventHandler(this.öğrencilerToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.notlarToolStripMenuItem.Text = "Notlar";
            this.notlarToolStripMenuItem.Click += new System.EventHandler(this.notlarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::OgrenciSistemi.Properties.Resources.OgrenciSistemi;
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 287);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Öğrenci Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretimÜyeleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;

    }
}

