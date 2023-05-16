using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Caso
{
    public partial class GridCasoForms : Form
    {
        public List<CasoModel> Casos = new List<CasoModel>();
        public GridCasoForms()
        {
            InitializeComponent();

            Init();

            casoGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Casos = MainWindow.Contexto.ObjetoCaso.ToList();

            var casoRows = Casos.Select(caso1 => new CasoViewModel
            {
                CasoId = caso1.CasoId, 
                Nome = caso1.CasoNome,
                Cliente = caso1.Cliente.ClienteNome,
            }).ToArray();

            casoGridView.DataSource = casoRows;

            casoGridView.Columns[0].Visible = false;
            casoGridView.Columns[1].HeaderText = "Nome";
            casoGridView.Columns[1].MinimumWidth = 200;
            casoGridView.Columns[2].HeaderText = "Cliente";
            casoGridView.Columns[2].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var casoViewModel = ((CasoViewModel[])casoGridView.DataSource).ElementAt(c.RowIndex);

            var editCasoForms = new EditCasoForms(Action.Edit, casoViewModel.CasoId);
            editCasoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editCasoForms.WindowState = FormWindowState.Maximized;
            editCasoForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var casoRows = Casos.Select(caso1 => new CasoViewModel
            {
                CasoId = caso1.CasoId,
                Nome = caso1.CasoNome,
                Cliente = caso1.Cliente.ClienteNome,
            }).Where(caso1 => caso1.Nome.Contains(filtro) ||
                caso1.Cliente.Contains(filtro))
            .ToArray();

            casoGridView.DataSource = casoRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (casoGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)casoGridView.SelectedCells[0].RowIndex;
            var casoViewModel = ((CasoViewModel[])casoGridView.DataSource).ElementAt(rowIndex);

            var editCasoForms = new EditCasoForms(Action.Edit, casoViewModel.CasoId);
            editCasoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editCasoForms.WindowState = FormWindowState.Maximized;
            editCasoForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (casoGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)casoGridView.SelectedCells[0].RowIndex;
            var casoViewModel = ((CasoViewModel[])casoGridView.DataSource).ElementAt(rowIndex);

            var caso = MainWindow.Contexto.ObjetoCaso.Find(casoViewModel.CasoId);
            MainWindow.Contexto.ObjetoCaso.Remove(caso);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Caso excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editCasoForms = new EditCasoForms(Action.Insert);
            editCasoForms.MdiParent = (MainWindow)this.Parent.Parent;
            editCasoForms.WindowState = FormWindowState.Maximized;
            editCasoForms.Show();
        }
    }
}
