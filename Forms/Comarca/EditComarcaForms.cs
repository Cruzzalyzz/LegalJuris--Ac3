using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Comarca
{
    public partial class EditComarcaForms : Form
    {
        public Action Action { get; set; }
        //public Contexto Contexto { get; set; }
        public ComarcaModel Comarca { get; set; }

        public EditComarcaForms(Action action, Int32? comarcaId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && comarcaId != null)
            {
                Comarca = MainWindow.Contexto.ObjetoComarca.Find(comarcaId);

                comboForo.SelectedItem = comboForo.Items.OfType<ForoModel>().FirstOrDefault(foro1 => foro1.ForoId == Comarca.ForoId);
                nomeComarca.Text = Comarca.ComarcaNome;
            }
        }

        private void Init()
        {
            var foros = MainWindow.Contexto.ObjetoForo.ToArray();

            comboForo.Items.AddRange(foros);
            comboForo.DisplayMember = "ForoNome";
            comboForo.ValueMember = "ForoId";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var foro = comboForo.SelectedItem as ForoModel;
            var nomeComarcaValue = nomeComarca.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var comarca = new ComarcaModel()
                    {
                        ComarcaNome = nomeComarcaValue,
                        ForoId = foro.ForoId,
                    };

                    MainWindow.Contexto.ObjetoComarca.Add(comarca);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Comarca incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Comarca.ComarcaNome = nomeComarcaValue;
                    Comarca.ForoId = foro.ForoId;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Comarca editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Close();

                var gridComarcaForms = Application.OpenForms.OfType<GridComarcaForms>();
                foreach (var gridComarcaForm in gridComarcaForms) gridComarcaForm.Init();
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
