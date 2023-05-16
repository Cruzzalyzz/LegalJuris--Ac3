using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Vara
{

    public partial class GridVaraForms : Form
    {
        public List<VaraModel> Varas = new List<VaraModel>();
        public GridVaraForms()
        {
            InitializeComponent();

            Init();

            varaGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Varas = MainWindow.Contexto.ObjetoVara.ToList();

            var varaRows = Varas.Select(vara1 => new VaraViewModel
            {
                VaraId = vara1.VaraId, 
                Nome = vara1.VaraNome,
            }).ToArray();

            varaGridView.DataSource = varaRows;

            varaGridView.Columns[0].Visible = false;
            varaGridView.Columns[1].HeaderText = "Nome";
            varaGridView.Columns[1].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var varaViewModel = ((VaraViewModel[])varaGridView.DataSource).ElementAt(c.RowIndex);

            var editVaraForms = new EditVaraForms(Action.Edit, varaViewModel.VaraId);
            editVaraForms.MdiParent = (MainWindow)this.Parent.Parent;
            editVaraForms.WindowState = FormWindowState.Maximized;
            editVaraForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var varaRows = Varas.Select(vara1 => new VaraViewModel
            {
                VaraId = vara1.VaraId,
                Nome = vara1.VaraNome
            }).Where(vara1 => vara1.Nome.Contains(filtro))
            .ToArray();

            varaGridView.DataSource = varaRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (varaGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)varaGridView.SelectedCells[0].RowIndex;
            var varaViewModel = ((VaraViewModel[])varaGridView.DataSource).ElementAt(rowIndex);

            var editVaraForms = new EditVaraForms(Action.Edit, varaViewModel.VaraId);
            editVaraForms.MdiParent = (MainWindow)this.Parent.Parent;
            editVaraForms.WindowState = FormWindowState.Maximized;
            editVaraForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (varaGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)varaGridView.SelectedCells[0].RowIndex;
            var varaViewModel = ((VaraViewModel[])varaGridView.DataSource).ElementAt(rowIndex);

            var vara = MainWindow.Contexto.ObjetoVara.Find(varaViewModel.VaraId);
            MainWindow.Contexto.ObjetoVara.Remove(vara);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Vara excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editVaraForms = new EditVaraForms(Action.Insert);
            editVaraForms.MdiParent = (MainWindow)this.Parent.Parent;
            editVaraForms.WindowState = FormWindowState.Maximized;
            editVaraForms.Show();
        }
    }
}
