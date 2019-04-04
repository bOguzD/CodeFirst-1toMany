namespace OgrenciSinif
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
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıflarınTanımlanmasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem,
            this.sınıflarınTanımlanmasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerinSınıflandırılmasıToolStripMenuItem
            // 
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem.Name = "öğrencilerinSınıflandırılmasıToolStripMenuItem";
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem.Text = "Öğrencilerin Tanımlanması";
            this.öğrencilerinSınıflandırılmasıToolStripMenuItem.Click += new System.EventHandler(this.öğrencilerinSınıflandırılmasıToolStripMenuItem_Click);
            // 
            // sınıflarınTanımlanmasiToolStripMenuItem
            // 
            this.sınıflarınTanımlanmasiToolStripMenuItem.Name = "sınıflarınTanımlanmasiToolStripMenuItem";
            this.sınıflarınTanımlanmasiToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.sınıflarınTanımlanmasiToolStripMenuItem.Text = "Sınıfların Tanımlanması";
            this.sınıflarınTanımlanmasiToolStripMenuItem.Click += new System.EventHandler(this.sınıflarınTanımlanmasıToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 195);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerinSınıflandırılmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıflarınTanımlanmasiToolStripMenuItem;
    }
}