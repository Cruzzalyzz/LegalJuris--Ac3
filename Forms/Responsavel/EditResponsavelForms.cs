using LegalJuris.Dal;
using LegalJuris.Model;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LegalJuris.Responsavel
{
    public partial class EditResponsavelForms : Form
    {
        public Action Action { get; set; }
        //public Contexto Contexto { get; set; }
        public ResponsavelModel Responsavel { get; set; }

        public EditResponsavelForms(Action action, Int32? responsavelId = null)
        {
            InitializeComponent();

            Init();
            Action = action;

            if (Action == Action.Edit && responsavelId != null)
            {
                Responsavel = MainWindow.Contexto.ObjetoResponsavel.Find(responsavelId);
                nomeResponsavel.Text = Responsavel.NomeResponsavel;
            }
        }

        private void Init()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            var nomeResponsavelValue = nomeResponsavel.Text.Trim();

            try
            {
                if (Action == Action.Insert)
                {
                    var responsavel = new ResponsavelModel()
                    {
                        NomeResponsavel = nomeResponsavelValue
                    };

                    MainWindow.Contexto.ObjetoResponsavel.Add(responsavel);
                    MainWindow.Contexto.SaveChanges();
                    MessageBox.Show("Responsável incluído com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Responsavel.NomeResponsavel = nomeResponsavelValue;

                    MainWindow.Contexto.SaveChanges();

                    MessageBox.Show("Responsável editado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Close();

                var gridResponsavelForms = Application.OpenForms.OfType<GridResponsavelForms>();
                foreach (var gridResponsavelForm in gridResponsavelForms) gridResponsavelForm.Init();
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
