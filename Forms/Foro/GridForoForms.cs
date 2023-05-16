using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Foro
{

    public partial class GridForoForms : Form
    {
        public List<ForoModel> Foros = new List<ForoModel>();
        public GridForoForms()
        {
            InitializeComponent();

            Init();

            foroGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Foros = MainWindow.Contexto.ObjetoForo.ToList();

            var foroRows = Foros.Select(foro1 => new ForoViewModel
            {
                ForoId = foro1.ForoId, 
                Nome = foro1.ForoNome,
                Vara = foro1.Vara.VaraNome,
            }).ToArray();

            foroGridView.DataSource = foroRows;

            foroGridView.Columns[0].Visible = false;
            foroGridView.Columns[1].HeaderText = "Nome";
            foroGridView.Columns[1].MinimumWidth = 200;
            foroGridView.Columns[2].HeaderText = "Vara";
            foroGridView.Columns[2].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var foroViewModel = ((ForoViewModel[])foroGridView.DataSource).ElementAt(c.RowIndex);

            var editForoForms = new EditForoForms(Action.Edit, foroViewModel.ForoId);
            editForoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editForoForms.WindowState = FormWindowState.Maximized;
            editForoForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var foroRows = Foros.Select(foro1 => new ForoViewModel
            {
                ForoId = foro1.ForoId,
                Nome = foro1.ForoNome,
                Vara = foro1.Vara.VaraNome,
            }).Where(foro1 => foro1.Nome.Contains(filtro) ||
                foro1.Vara.Contains(filtro))
            .ToArray();

            foroGridView.DataSource = foroRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (foroGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)foroGridView.SelectedCells[0].RowIndex;
            var foroViewModel = ((ForoViewModel[])foroGridView.DataSource).ElementAt(rowIndex);

            var editForoForms = new EditForoForms(Action.Edit, foroViewModel.ForoId);
            editForoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editForoForms.WindowState = FormWindowState.Maximized;
            editForoForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (foroGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)foroGridView.SelectedCells[0].RowIndex;
            var foroViewModel = ((ForoViewModel[])foroGridView.DataSource).ElementAt(rowIndex);

            var foro = MainWindow.Contexto.ObjetoForo.Find(foroViewModel.ForoId);
            MainWindow.Contexto.ObjetoForo.Remove(foro);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Foro excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editForoForms = new EditForoForms(Action.Insert);
            editForoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editForoForms.WindowState = FormWindowState.Maximized;
            editForoForms.Show();
        }
    }
}
