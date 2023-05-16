using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Comarca
{

    public partial class GridComarcaForms : Form
    {
        public List<ComarcaModel> Comarcas = new List<ComarcaModel>();
        public GridComarcaForms()
        {
            InitializeComponent();

            Init();

            comarcaGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Comarcas = MainWindow.Contexto.ObjetoComarca.ToList();

            var comarcaRows = Comarcas.Select(comarca1 => new ComarcaViewModel
            {
                ComarcaId = comarca1.ComarcaId, 
                Nome = comarca1.ComarcaNome,
                Foro = comarca1.Foro.ForoNome,
            }).ToArray();

            comarcaGridView.DataSource = comarcaRows;

            comarcaGridView.Columns[0].Visible = false;
            comarcaGridView.Columns[1].HeaderText = "Nome";
            comarcaGridView.Columns[1].MinimumWidth = 200;
            comarcaGridView.Columns[2].HeaderText = "Foro";
            comarcaGridView.Columns[2].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var comarcaViewModel = ((ComarcaViewModel[])comarcaGridView.DataSource).ElementAt(c.RowIndex);

            var editComarcaForms = new EditComarcaForms(Action.Edit, comarcaViewModel.ComarcaId);
            editComarcaForms.MdiParent = (MainWindow)this.Parent.Parent;
            editComarcaForms.WindowState = FormWindowState.Maximized;
            editComarcaForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var comarcaRows = Comarcas.Select(comarca1 => new ComarcaViewModel
            {
                ComarcaId = comarca1.ComarcaId,
                Nome = comarca1.ComarcaNome,
                Foro = comarca1.Foro.ForoNome,
            }).Where(comarca1 => comarca1.Nome.Contains(filtro) ||
                comarca1.Foro.Contains(filtro))
            .ToArray();

            comarcaGridView.DataSource = comarcaRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (comarcaGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)comarcaGridView.SelectedCells[0].RowIndex;
            var comarcaViewModel = ((ComarcaViewModel[])comarcaGridView.DataSource).ElementAt(rowIndex);

            var editComarcaForms = new EditComarcaForms(Action.Edit, comarcaViewModel.ComarcaId);
            editComarcaForms.MdiParent = (MainWindow)this.Parent.Parent;
            editComarcaForms.WindowState = FormWindowState.Maximized;
            editComarcaForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (comarcaGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)comarcaGridView.SelectedCells[0].RowIndex;
            var comarcaViewModel = ((ComarcaViewModel[])comarcaGridView.DataSource).ElementAt(rowIndex);

            var comarca = MainWindow.Contexto.ObjetoComarca.Find(comarcaViewModel.ComarcaId);
            MainWindow.Contexto.ObjetoComarca.Remove(comarca);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Comarca excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editComarcaForms = new EditComarcaForms(Action.Insert);
            editComarcaForms.MdiParent = (MainWindow)this.Parent.Parent;
            editComarcaForms.WindowState = FormWindowState.Maximized;
            editComarcaForms.Show();
        }
    }
}
