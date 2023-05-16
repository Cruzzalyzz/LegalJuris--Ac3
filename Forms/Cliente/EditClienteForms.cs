using LegalJuris.Dal;
using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Cliente
{
    public partial class EditClienteForms : Form
    {
        public Action Action { get; set; }
        public ClienteModel Cliente { get; set; }

        public EditClienteForms(Action action, Int32? clienteId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && clienteId != null)
            {
                Cliente = MainWindow.Contexto.ObjetoCliente.Find(clienteId);
                nomeCliente.Text = Cliente.ClienteNome;
            }
        }

        private void Init()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            var nomeClienteValue = nomeCliente.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var cliente = new ClienteModel()
                    {
                        ClienteNome = nomeClienteValue
                    };

                    MainWindow.Contexto.ObjetoCliente.Add(cliente);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Cliente incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Cliente.ClienteNome = nomeClienteValue;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Cliente editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Close();

                var gridClienteForms = Application.OpenForms.OfType<GridClienteForms>();
                foreach (var gridClienteForm in gridClienteForms) gridClienteForm.Init();
            } 
            catch 
            {
                MessageBox.Show("Erro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
