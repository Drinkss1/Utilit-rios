namespace CursoWindowsForms
{
    partial class FormHelloWordUserControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtConteudoLabel = new System.Windows.Forms.TextBox();
            this.BtnModificaTexto = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtConteudoLabel
            // 
            this.TxtConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConteudoLabel.Location = new System.Drawing.Point(16, 51);
            this.TxtConteudoLabel.Name = "TxtConteudoLabel";
            this.TxtConteudoLabel.Size = new System.Drawing.Size(501, 20);
            this.TxtConteudoLabel.TabIndex = 6;
            // 
            // BtnModificaTexto
            // 
            this.BtnModificaTexto.Location = new System.Drawing.Point(16, 79);
            this.BtnModificaTexto.Name = "BtnModificaTexto";
            this.BtnModificaTexto.Size = new System.Drawing.Size(233, 33);
            this.BtnModificaTexto.TabIndex = 5;
            this.BtnModificaTexto.Text = "Clique aqui para modificar o texto";
            this.BtnModificaTexto.UseVisualStyleBackColor = true;
            this.BtnModificaTexto.Click += new System.EventHandler(this.BtnModificaTexto_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitulo.Location = new System.Drawing.Point(13, 19);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(93, 18);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Visual Studio";
            // 
            // FormHelloWordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtConteudoLabel);
            this.Controls.Add(this.BtnModificaTexto);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FormHelloWordUserControl";
            this.Size = new System.Drawing.Size(537, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtConteudoLabel;
        private System.Windows.Forms.Button BtnModificaTexto;
        private System.Windows.Forms.Label LblTitulo;
    }
}
