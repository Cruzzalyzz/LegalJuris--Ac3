using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Responsavel
{
    public partial class GridResponsavelForms : Form
    {
        public List<ResponsavelModel> Responsaveis = new List<ResponsavelModel>();
        public GridResponsavelForms()
        {
            InitializeComponent();

            Init();

            responsavelGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Responsaveis = MainWindow.Contexto.ObjetoResponsavel.ToList();

            var responsavelRows = Responsaveis.Select(responsavel1 => new ResponsavelViewModel
            {
                ResponsavelId = responsavel1.ResponsavelId, 
                Nome = responsavel1.NomeResponsavel,
            }).ToArray();

            responsavelGridView.DataSource = responsavelRows;

            responsavelGridView.Columns[0].Visible = false;
            responsavelGridView.Columns[1].HeaderText = "Nome";
            responsavelGridView.Columns[1].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var responsavelViewModel = ((ResponsavelViewModel[])responsavelGridView.DataSource).ElementAt(c.RowIndex);

            var editResponsavelForms = new EditResponsavelForms(Action.Edit, responsavelViewModel.ResponsavelId);
            editResponsavelForms.MdiParent = (MainWindow)this.Parent.Parent;
            editResponsavelForms.WindowState = FormWindowState.Maximized;
            editResponsavelForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var responsavelRows = Responsaveis.Select(responsavel1 => new ResponsavelViewModel
            {
                ResponsavelId = responsavel1.ResponsavelId,
                Nome = responsavel1.NomeResponsavel
            }).Where(responsavel1 => responsavel1.Nome.Contains(filtro))
            .ToArray();

            responsavelGridView.DataSource = responsavelRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (responsavelGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)responsavelGridView.SelectedCells[0].RowIndex;
            var resonsavelViewModel = ((ResponsavelViewModel[])responsavelGridView.DataSource).ElementAt(rowIndex);

            var editResponsavelForms = new EditResponsavelForms(Action.Edit, resonsavelViewModel.ResponsavelId);
            editResponsavelForms.MdiParent = (MainWindow)this.Parent.Parent;
            editResponsavelForms.WindowState = FormWindowState.Maximized;
            editResponsavelForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (responsavelGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)responsavelGridView.SelectedCells[0].RowIndex;
            var responsavelViewModel = ((ResponsavelViewModel[])responsavelGridView.DataSource).ElementAt(rowIndex);

            var responsavel = MainWindow.Contexto.ObjetoResponsavel.Find(responsavelViewModel.ResponsavelId);
            MainWindow.Contexto.ObjetoResponsavel.Remove(responsavel);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Responsável excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editResponsavelForms = new EditResponsavelForms(Action.Insert);
            editResponsavelForms.MdiParent = (MainWindow)this.Parent.Parent;
            editResponsavelForms.WindowState = FormWindowState.Maximized;
            editResponsavelForms.Show();
        }
    }
}
