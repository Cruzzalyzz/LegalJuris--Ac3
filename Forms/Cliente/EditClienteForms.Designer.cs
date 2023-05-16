namespace LegalJuris.Cliente
{
    partial class EditClienteForms
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
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.labelProcesso = new System.Windows.Forms.Label();
            this.labelNumeroProcesso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeCliente
            // 
            this.nomeCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente.Location = new System.Drawing.Point(13, 90);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(300, 26);
            this.nomeCliente.TabIndex = 6;
            // 
            // labelProcesso
            // 
            this.labelProcesso.AutoSize = true;
            this.labelProcesso.BackColor = System.Drawing.Color.Lavender;
            this.labelProcesso.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelProcesso.Location = new System.Drawing.Point(8, 24);
            this.labelProcesso.Name = "labelProcesso";
            this.labelProcesso.Size = new System.Drawing.Size(87, 27);
            this.labelProcesso.TabIndex = 7;
            this.labelProcesso.Text = "Cliente";
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
            // EditClienteForms
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(652, 337);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNumeroProcesso);
            this.Controls.Add(this.labelProcesso);
            this.Controls.Add(this.nomeCliente);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditClienteForms";
            this.Text = "Editar Processo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label labelProcesso;
        private System.Windows.Forms.Label labelNumeroProcesso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

