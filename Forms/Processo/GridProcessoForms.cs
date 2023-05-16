using LegalJuris.Dal;
using LegalJuris.Model;
using LegalJuris.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace LegalJuris.Processo
{
    
    public partial class GridProcessoForms : Form
    {
        public List<ProcessoModel> Processos = new List<ProcessoModel>();
        public GridProcessoForms()
        {
            InitializeComponent();

            Init();

            processGridView.CellDoubleClick += ProcessGridView_CellDoubleClick;
        }

        public void Init()
        {
            Processos = MainWindow.Contexto.ObjetoProcesso.ToList();

            var processosRows = Processos.Select(process1 => new ProcessoViewModel
            {
                ProcessoId = process1.ProcessoId, 
                Numero = process1.NumeroProcesso,
                Cliente = process1.Caso.Cliente.ClienteNome,
                Caso = process1.Caso.CasoNome,
                Responsavel = process1.Responsavel.NomeResponsavel
            }).ToArray();

            processGridView.DataSource = processosRows;

            processGridView.Columns[0].Visible = false;
            processGridView.Columns[1].HeaderText = "Número do Processo";
            processGridView.Columns[1].MinimumWidth = 200;
            processGridView.Columns[2].HeaderText = "Nome do Cliente";
            processGridView.Columns[2].MinimumWidth = 200;
            processGridView.Columns[3].HeaderText = "Assunto do Caso";
            processGridView.Columns[3].MinimumWidth = 200;
            processGridView.Columns[4].HeaderText = "Nome do Responsável";
            processGridView.Columns[4].MinimumWidth = 200;
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs c)
        {
            var processViewModel = ((ProcessoViewModel[])processGridView.DataSource).ElementAt(c.RowIndex);

            var editProcessForms = new EditProcessoForms(Action.Edit, processViewModel.ProcessoId);
            editProcessForms.MdiParent = (MainWindow)this.Parent.Parent;
            editProcessForms.WindowState = FormWindowState.Maximized;
            editProcessForms.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var filtro = textBoxFiltro.Text.Trim();

            Init();
            var processosRows = Processos.Select(process1 => new ProcessoViewModel
            {
                ProcessoId = process1.ProcessoId,
                Numero = process1.NumeroProcesso,
                Cliente = process1.Caso.Cliente.ClienteNome,
                Caso = process1.Caso.CasoNome,
                Responsavel = process1.Responsavel.NomeResponsavel
            }).Where(process1 => process1.Numero.Contains(filtro) ||
                process1.Cliente.Contains(filtro) ||
                process1.Caso.Contains(filtro) ||
                process1.Responsavel.Contains(filtro))
            .ToArray();

            processGridView.DataSource = processosRows;
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (processGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)processGridView.SelectedCells[0].RowIndex;
            var processViewModel = ((ProcessoViewModel[])processGridView.DataSource).ElementAt(rowIndex);

            var editProcessForms = new EditProcessoForms(Action.Edit, processViewModel.ProcessoId);
            editProcessForms.MdiParent = (MainWindow)this.Parent.Parent;
            editProcessForms.WindowState = FormWindowState.Maximized;
            editProcessForms.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (processGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um registro.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rowIndex = (Int32)processGridView.SelectedCells[0].RowIndex;
            var processViewModel = ((ProcessoViewModel[])processGridView.DataSource).ElementAt(rowIndex);

            var processo = MainWindow.Contexto.ObjetoProcesso.Find(processViewModel.ProcessoId);
            MainWindow.Contexto.ObjetoProcesso.Remove(processo);

            MainWindow.Contexto.SaveChanges();

            Init();
            MessageBox.Show("Processo excluído com sucesso.", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            var editProcessForms = new EditProcessoForms(Action.Insert);
            editProcessForms.MdiParent = (MainWindow)this.Parent.Parent;
            editProcessForms.WindowState = FormWindowState.Maximized;
            editProcessForms.Show();
        }
    }
}
