namespace CursoWindowsForms
{
    partial class FormHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelloWorld));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnModificaTexto = new System.Windows.Forms.Button();
            this.TxtConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitulo.Location = new System.Drawing.Point(114, 58);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(93, 18);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Visual Studio";
            // 
            // BtnModificaTexto
            // 
            this.BtnModificaTexto.Location = new System.Drawing.Point(53, 107);
            this.BtnModificaTexto.Name = "BtnModificaTexto";
            this.BtnModificaTexto.Size = new System.Drawing.Size(233, 33);
            this.BtnModificaTexto.TabIndex = 2;
            this.BtnModificaTexto.Text = "Clique aqui para modificar o texto";
            this.BtnModificaTexto.UseVisualStyleBackColor = true;
            this.BtnModificaTexto.Click += new System.EventHandler(this.BtnModificaTexto_Click);
            // 
            // TxtConteudoLabel
            // 
            this.TxtConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConteudoLabel.Location = new System.Drawing.Point(53, 79);
            this.TxtConteudoLabel.Name = "TxtConteudoLabel";
            this.TxtConteudoLabel.Size = new System.Drawing.Size(313, 22);
            this.TxtConteudoLabel.TabIndex = 3;
            // 
            // FormHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 218);
            this.Controls.Add(this.TxtConteudoLabel);
            this.Controls.Add(this.BtnModificaTexto);
            this.Controls.Add(this.LblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnModificaTexto;
        private System.Windows.Forms.TextBox TxtConteudoLabel;
    }
}

