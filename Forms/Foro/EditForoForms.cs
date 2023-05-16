using LegalJuris.Dal;
using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Foro
{
    public partial class EditForoForms : Form
    {
        public Action Action { get; set; }
        //public Contexto Contexto { get; set; }
        public ForoModel Foro { get; set; }

        public EditForoForms(Action action, Int32? foroId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && foroId != null)
            {
                Foro = MainWindow.Contexto.ObjetoForo.Find(foroId);

                comboVara.SelectedItem = comboVara.Items.OfType<VaraModel>().FirstOrDefault(vara1 => vara1.VaraId == Foro.VaraId);
                nomeForo.Text = Foro.ForoNome;
            }
        }

        private void Init()
        {
            var varas = MainWindow.Contexto.ObjetoVara.ToArray();

            comboVara.Items.AddRange(varas);
            comboVara.DisplayMember = "VaraNome";
            comboVara.ValueMember = "VaraId";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var vara = comboVara.SelectedItem as VaraModel;
            var nomeForoValue = nomeForo.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var foro = new ForoModel()
                    {
                        ForoNome = nomeForoValue,
                        VaraId = vara.VaraId,
                    };

                    MainWindow.Contexto.ObjetoForo.Add(foro);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Foro incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Foro.ForoNome = nomeForoValue;
                    Foro.VaraId = vara.VaraId;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Foro editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Close();

                var gridForoForms = Application.OpenForms.OfType<GridForoForms>();
                foreach (var gridForoForm in gridForoForms) gridForoForm.Init();
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
