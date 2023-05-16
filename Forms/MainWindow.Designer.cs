namespace LegalJuris
{
    partial class MainWindow
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.foroToolStripMenuItem,
            this.varaToolStripMenuItem,
            this.comarcaToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.casoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gridToolStripMenuItem.Text = "Processo";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // foroToolStripMenuItem
            // 
            this.foroToolStripMenuItem.Name = "foroToolStripMenuItem";
            this.foroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foroToolStripMenuItem.Text = "Foro";
            this.foroToolStripMenuItem.Click += new System.EventHandler(this.foroToolStripMenuItem_Click);
            // 
            // varaToolStripMenuItem
            // 
            this.varaToolStripMenuItem.Name = "varaToolStripMenuItem";
            this.varaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.varaToolStripMenuItem.Text = "Vara";
            this.varaToolStripMenuItem.Click += new System.EventHandler(this.varaToolStripMenuItem_Click);
            // 
            // comarcaToolStripMenuItem
            // 
            this.comarcaToolStripMenuItem.Name = "comarcaToolStripMenuItem";
            this.comarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comarcaToolStripMenuItem.Text = "Comarca";
            this.comarcaToolStripMenuItem.Click += new System.EventHandler(this.comarcaToolStripMenuItem_Click);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            this.responsávelToolStripMenuItem.Click += new System.EventHandler(this.responsávelToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // casoToolStripMenuItem
            // 
            this.casoToolStripMenuItem.Name = "casoToolStripMenuItem";
            this.casoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casoToolStripMenuItem.Text = "Caso";
            this.casoToolStripMenuItem.Click += new System.EventHandler(this.casoToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casoToolStripMenuItem;
    }
}