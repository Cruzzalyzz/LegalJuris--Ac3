using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Cliente
{
    public partial class GridClienteForms : Form
    {
        public List<ClienteModel> Clientes = new List<ClienteModel>();
        public GridClienteForms()
        {
            InitializeComponent();

            Init();

            clienteGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Clientes = MainWindow.Contexto.ObjetoCliente.ToList();

            var clienteRows = Clientes.Select(cliente1 => new ClienteViewModel
            {
                ClienteId = cliente1.ClienteId, 
                Nome = cliente1.ClienteNome,
            }).ToArray();

            clienteGridView.DataSource = clienteRows;

            clienteGridView.Columns[0].Visible = false;
            clienteGridView.Columns[1].HeaderText = "Nome";
            clienteGridView.Columns[1].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var clienteViewModel = ((ClienteViewModel[])clienteGridView.DataSource).ElementAt(c.RowIndex);

            var editClienteForms = new EditClienteForms(Action.Edit, clienteViewModel.ClienteId);
            editClienteForms.MdiParent = (MainWindow)this.Parent.Parent;
            editClienteForms.WindowState = FormWindowState.Maximized;
            editClienteForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var clienteRows = Clientes.Select(cliente1 => new ClienteViewModel
            {
                ClienteId = cliente1.ClienteId,
                Nome = cliente1.ClienteNome
            }).Where(cliente1 => cliente1.Nome.Contains(filtro))
            .ToArray();

            clienteGridView.DataSource = clienteRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (clienteGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)clienteGridView.SelectedCells[0].RowIndex;
            var clienteViewModel = ((ClienteViewModel[])clienteGridView.DataSource).ElementAt(rowIndex);

            var editClienteForms = new EditClienteForms(Action.Edit, clienteViewModel.ClienteId);
            editClienteForms.MdiParent = (MainWindow)this.Parent.Parent;
            editClienteForms.WindowState = FormWindowState.Maximized;
            editClienteForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (clienteGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)clienteGridView.SelectedCells[0].RowIndex;
            var clienteViewModel = ((ClienteViewModel[])clienteGridView.DataSource).ElementAt(rowIndex);

            var cliente = MainWindow.Contexto.ObjetoCliente.Find(clienteViewModel.ClienteId);
            MainWindow.Contexto.ObjetoCliente.Remove(cliente);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Cliente excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editClienteForms = new EditClienteForms(Action.Insert);
            editClienteForms.MdiParent = (MainWindow)this.Parent.Parent;
            editClienteForms.WindowState = FormWindowState.Maximized;
            editClienteForms.Show();
        }
    }
}
