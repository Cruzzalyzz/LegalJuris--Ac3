namespace LegalJuris.Comarca
{
    partial class EditComarcaForms
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
            this.comboForo = new System.Windows.Forms.ComboBox();
            this.nomeComarca = new System.Windows.Forms.TextBox();
            this.labelProcesso = new System.Windows.Forms.Label();
            this.labelNumeroProcesso = new System.Windows.Forms.Label();
            this.labelVara = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboVara
            // 
            this.comboForo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboForo.FormattingEnabled = true;
            this.comboForo.Location = new System.Drawing.Point(344, 88);
            this.comboForo.Name = "comboVara";
            this.comboForo.Size = new System.Drawing.Size(300, 26);
            this.comboForo.TabIndex = 3;
            // 
            // nomeForo
            // 
            this.nomeComarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeComarca.Location = new System.Drawing.Point(13, 90);
            this.nomeComarca.Name = "nomeForo";
            this.nomeComarca.Size = new System.Drawing.Size(300, 26);
            this.nomeComarca.TabIndex = 6;
            // 
            // labelProcesso
            // 
            this.labelProcesso.AutoSize = true;
            this.labelProcesso.BackColor = System.Drawing.Color.Lavender;
            this.labelProcesso.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelProcesso.Location = new System.Drawing.Point(8, 24);
            this.labelProcesso.Name = "labelProcesso";
            this.labelProcesso.Size = new System.Drawing.Size(108, 27);
            this.labelProcesso.TabIndex = 7;
            this.labelProcesso.Text = "Comarca";
            // 
            // labelNumeroProcesso
            // 
            this.labelNumeroProcesso.AutoSize = true;
            this.labelNumeroProcesso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroProcesso.Location = new System.Drawing.Point(12, 71);
            this.labelNumeroProcesso.Name = "labelNumeroProcesso";
            this.labelNumeroProcesso.Size = new System.Drawing.Size(41, 16);
            this.labelNumeroProcesso.TabIndex = 10;
            this.labelNumeroProcesso.Text = "Nome";
            // 
            // labelVara
            // 
            this.labelVara.AutoSize = true;
            this.labelVara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVara.Location = new System.Drawing.Point(341, 69);
            this.labelVara.Name = "labelVara";
            this.labelVara.Size = new System.Drawing.Size(33, 16);
            this.labelVara.TabIndex = 14;
            this.labelVara.Text = "Foro";
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
            // EditComarcaForms
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(652, 337);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelVara);
            this.Controls.Add(this.labelNumeroProcesso);
            this.Controls.Add(this.labelProcesso);
            this.Controls.Add(this.nomeComarca);
            this.Controls.Add(this.comboForo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditComarcaForms";
            this.Text = "Editar Processo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox comboForo;
        private System.Windows.Forms.TextBox nomeComarca;
        private System.Windows.Forms.Label labelProcesso;
        private System.Windows.Forms.Label labelNumeroProcesso;
        private System.Windows.Forms.Label labelVara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

