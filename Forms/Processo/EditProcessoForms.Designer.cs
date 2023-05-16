namespace LegalJuris.Processo
{
    partial class EditProcessoForms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboCaso = new System.Windows.Forms.ComboBox();
            this.comboResponsavel = new System.Windows.Forms.ComboBox();
            this.comboVara = new System.Windows.Forms.ComboBox();
            this.comboComarca = new System.Windows.Forms.ComboBox();
            this.comboForo = new System.Windows.Forms.ComboBox();
            this.numeroProcesso = new System.Windows.Forms.TextBox();
            this.labelProcesso = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCaso = new System.Windows.Forms.Label();
            this.labelNumeroProcesso = new System.Windows.Forms.Label();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.labelComarca = new System.Windows.Forms.Label();
            this.labelForo = new System.Windows.Forms.Label();
            this.labelVara = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCliente
            // 
            this.comboCliente.BackColor = System.Drawing.Color.White;
            this.comboCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(12, 98);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(300, 26);
            this.comboCliente.TabIndex = 0;
            // 
            // comboCaso
            // 
            this.comboCaso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCaso.FormattingEnabled = true;
            this.comboCaso.Location = new System.Drawing.Point(12, 147);
            this.comboCaso.Name = "comboCaso";
            this.comboCaso.Size = new System.Drawing.Size(300, 26);
            this.comboCaso.TabIndex = 1;
            // 
            // comboResponsavel
            // 
            this.comboResponsavel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboResponsavel.FormattingEnabled = true;
            this.comboResponsavel.Location = new System.Drawing.Point(12, 244);
            this.comboResponsavel.Name = "comboResponsavel";
            this.comboResponsavel.Size = new System.Drawing.Size(300, 26);
            this.comboResponsavel.TabIndex = 2;
            // 
            // comboVara
            // 
            this.comboVara.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVara.FormattingEnabled = true;
            this.comboVara.Location = new System.Drawing.Point(343, 194);
            this.comboVara.Name = "comboVara";
            this.comboVara.Size = new System.Drawing.Size(300, 26);
            this.comboVara.TabIndex = 3;
            // 
            // comboComarca
            // 
            this.comboComarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboComarca.FormattingEnabled = true;
            this.comboComarca.Location = new System.Drawing.Point(340, 95);
            this.comboComarca.Name = "comboComarca";
            this.comboComarca.Size = new System.Drawing.Size(300, 26);
            this.comboComarca.TabIndex = 4;
            // 
            // comboForo
            // 
            this.comboForo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboForo.FormattingEnabled = true;
            this.comboForo.Location = new System.Drawing.Point(343, 145);
            this.comboForo.Name = "comboForo";
            this.comboForo.Size = new System.Drawing.Size(300, 26);
            this.comboForo.TabIndex = 5;
            // 
            // numeroProcesso
            // 
            this.numeroProcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroProcesso.Location = new System.Drawing.Point(12, 196);
            this.numeroProcesso.Name = "numeroProcesso";
            this.numeroProcesso.Size = new System.Drawing.Size(300, 26);
            this.numeroProcesso.TabIndex = 6;
            // 
            // labelProcesso
            // 
            this.labelProcesso.AutoSize = true;
            this.labelProcesso.BackColor = System.Drawing.Color.Lavender;
            this.labelProcesso.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelProcesso.Location = new System.Drawing.Point(8, 24);
            this.labelProcesso.Name = "labelProcesso";
            this.labelProcesso.Size = new System.Drawing.Size(111, 27);
            this.labelProcesso.TabIndex = 7;
            this.labelProcesso.Text = "Processo";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(10, 79);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(47, 16);
            this.labelCliente.TabIndex = 8;
            this.labelCliente.Text = "Cliente";
            // 
            // labelCaso
            // 
            this.labelCaso.AutoSize = true;
            this.labelCaso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaso.Location = new System.Drawing.Point(10, 128);
            this.labelCaso.Name = "labelCaso";
            this.labelCaso.Size = new System.Drawing.Size(37, 16);
            this.labelCaso.TabIndex = 9;
            this.labelCaso.Text = "Caso";
            // 
            // labelNumeroProcesso
            // 
            this.labelNumeroProcesso.AutoSize = true;
            this.labelNumeroProcesso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroProcesso.Location = new System.Drawing.Point(9, 177);
            this.labelNumeroProcesso.Name = "labelNumeroProcesso";
            this.labelNumeroProcesso.Size = new System.Drawing.Size(129, 16);
            this.labelNumeroProcesso.TabIndex = 10;
            this.labelNumeroProcesso.Text = "Número do Processo";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsavel.Location = new System.Drawing.Point(9, 225);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(80, 16);
            this.labelResponsavel.TabIndex = 11;
            this.labelResponsavel.Text = "Responsável";
            // 
            // labelComarca
            // 
            this.labelComarca.AutoSize = true;
            this.labelComarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComarca.Location = new System.Drawing.Point(340, 76);
            this.labelComarca.Name = "labelComarca";
            this.labelComarca.Size = new System.Drawing.Size(59, 16);
            this.labelComarca.TabIndex = 12;
            this.labelComarca.Text = "Comarca";
            // 
            // labelForo
            // 
            this.labelForo.AutoSize = true;
            this.labelForo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForo.Location = new System.Drawing.Point(340, 124);
            this.labelForo.Name = "labelForo";
            this.labelForo.Size = new System.Drawing.Size(33, 16);
            this.labelForo.TabIndex = 13;
            this.labelForo.Text = "Foro";
            // 
            // labelVara
            // 
            this.labelVara.AutoSize = true;
            this.labelVara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVara.Location = new System.Drawing.Point(340, 175);
            this.labelVara.Name = "labelVara";
            this.labelVara.Size = new System.Drawing.Size(33, 16);
            this.labelVara.TabIndex = 14;
            this.labelVara.Text = "Vara";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(503, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 32);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditProcessForms
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(652, 337);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelVara);
            this.Controls.Add(this.labelForo);
            this.Controls.Add(this.labelComarca);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelNumeroProcesso);
            this.Controls.Add(this.labelCaso);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelProcesso);
            this.Controls.Add(this.numeroProcesso);
            this.Controls.Add(this.comboForo);
            this.Controls.Add(this.comboComarca);
            this.Controls.Add(this.comboVara);
            this.Controls.Add(this.comboResponsavel);
            this.Controls.Add(this.comboCaso);
            this.Controls.Add(this.comboCliente);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditProcessForms";
            this.Text = "Editar Processo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboCaso;
        private System.Windows.Forms.ComboBox comboResponsavel;
        private System.Windows.Forms.ComboBox comboVara;
        private System.Windows.Forms.ComboBox comboComarca;
        private System.Windows.Forms.ComboBox comboForo;
        private System.Windows.Forms.TextBox numeroProcesso;
        private System.Windows.Forms.Label labelProcesso;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCaso;
        private System.Windows.Forms.Label labelNumeroProcesso;
        private System.Windows.Forms.Label labelResponsavel;
        private System.Windows.Forms.Label labelComarca;
        private System.Windows.Forms.Label labelForo;
        private System.Windows.Forms.Label labelVara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

