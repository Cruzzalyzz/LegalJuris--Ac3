using LegalJuris.Caso;
using LegalJuris.Cliente;
using LegalJuris.Comarca;
using LegalJuris.Dal;
using LegalJuris.Foro;
using LegalJuris.Processo;
using LegalJuris.Responsavel;
using LegalJuris.Vara;
using System;
using System.Windows.Forms;

namespace LegalJuris
{
    public enum Action
    {
        Insert,
        Edit
    }

    public partial class MainWindow : Form
    {
        public static Contexto Contexto { get; set; }
        public MainWindow()
        {
            Contexto = new Contexto();
            InitializeComponent();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridProcessForms = new GridProcessoForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridProcessForms.Show();
        }

        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridForoForms = new GridForoForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridForoForms.Show();
        }

        private void varaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridVaraForms = new GridVaraForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridVaraForms.Show();
        }

        private void comarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridComarcaForms = new GridComarcaForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridComarcaForms.Show();
        }

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridResponsavelForms = new GridResponsavelForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridResponsavelForms.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridClienteForms = new GridClienteForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridClienteForms.Show();
        }

        private void casoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridCasoForms = new GridCasoForms
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            gridCasoForms.Show();
        }
    }
}
