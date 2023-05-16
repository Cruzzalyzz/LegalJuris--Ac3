using LegalJuris.Dal;
using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Vara
{
    public partial class EditVaraForms : Form
    {
        public Action Action { get; set; }
        //public Contexto Contexto { get; set; }
        public VaraModel Vara { get; set; }

        public EditVaraForms(Action action, Int32? varaId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && varaId != null)
            {
                Vara = MainWindow.Contexto.ObjetoVara.Find(varaId);
                nomeVara.Text = Vara.VaraNome;
            }
        }

        private void Init()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            var nomeVaraValue = nomeVara.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var vara = new VaraModel()
                    {
                        VaraNome = nomeVaraValue
                    };

                    MainWindow.Contexto.ObjetoVara.Add(vara);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Vara incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Vara.VaraNome = nomeVaraValue;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Vara editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Close();

                var gridVaraForms = Application.OpenForms.OfType<GridVaraForms>();
                foreach (var gridVaraForm in gridVaraForms) gridVaraForm.Init();
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
