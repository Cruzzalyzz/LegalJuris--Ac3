using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Caso
{
    public partial class EditCasoForms : Form
    {
        public Action Action { get; set; }
        public CasoModel Caso { get; set; }

        public EditCasoForms(Action action, Int32? casoId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && casoId != null)
            {
                Caso = MainWindow.Contexto.ObjetoCaso.Find(casoId);

                comboCliente.SelectedItem = 
                    comboCliente.Items.OfType<ClienteModel>().FirstOrDefault(cliente1 => cliente1.ClienteId == Caso.ClienteId);
                nomeCaso.Text = Caso.CasoNome;
            }
        }

        private void Init()
        {
            var clientes = MainWindow.Contexto.ObjetoCliente.ToArray();

            comboCliente.Items.AddRange(clientes);
            comboCliente.DisplayMember = "ClienteNome";
            comboCliente.ValueMember = "ClienteId";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var cliente = comboCliente.SelectedItem as ClienteModel;
            var nomeCasoValue = nomeCaso.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var caso = new CasoModel()
                    {
                        CasoNome = nomeCasoValue,
                        ClienteId = cliente.ClienteId
                    };

                    MainWindow.Contexto.ObjetoCaso.Add(caso);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Caso incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Caso.CasoNome = nomeCasoValue;
                    Caso.ClienteId = cliente.ClienteId;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Caso editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();

                var gridCasoForms = Application.OpenForms.OfType<GridCasoForms>();
                foreach (var gridCasoForm in gridCasoForms) gridCasoForm.Init();
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

        private void labelProcesso_Click(object sender, EventArgs e)
        {

        }
    }
}
