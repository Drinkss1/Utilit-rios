namespace CursoWindowsForms
{
    partial class FormMascara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMascara));
            this.MskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LblConteudo = new System.Windows.Forms.Label();
            this.LblMascaraAtiva = new System.Windows.Forms.Label();
            this.BtnHora = new System.Windows.Forms.Button();
            this.BtnCep = new System.Windows.Forms.Button();
            this.BtnMoeda = new System.Windows.Forms.Button();
            this.BtnData = new System.Windows.Forms.Button();
            this.BtnSenha = new System.Windows.Forms.Button();
            this.BtnTelefone = new System.Windows.Forms.Button();
            this.BtnVerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskTextBox
            // 
            this.MskTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTextBox.Location = new System.Drawing.Point(23, 31);
            this.MskTextBox.Name = "MskTextBox";
            this.MskTextBox.Size = new System.Drawing.Size(258, 26);
            this.MskTextBox.TabIndex = 0;
            // 
            // LblConteudo
            // 
            this.LblConteudo.AutoSize = true;
            this.LblConteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConteudo.Location = new System.Drawing.Point(23, 246);
            this.LblConteudo.Name = "LblConteudo";
            this.LblConteudo.Size = new System.Drawing.Size(0, 19);
            this.LblConteudo.TabIndex = 1;
            // 
            // LblMascaraAtiva
            // 
            this.LblMascaraAtiva.AutoSize = true;
            this.LblMascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.LblMascaraAtiva.Name = "LblMascaraAtiva";
            this.LblMascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.LblMascaraAtiva.TabIndex = 2;
            // 
            // BtnHora
            // 
            this.BtnHora.Location = new System.Drawing.Point(23, 110);
            this.BtnHora.Name = "BtnHora";
            this.BtnHora.Size = new System.Drawing.Size(82, 37);
            this.BtnHora.TabIndex = 3;
            this.BtnHora.Text = "Hora";
            this.BtnHora.UseVisualStyleBackColor = true;
            this.BtnHora.Click += new System.EventHandler(this.BtnHora_Click);
            // 
            // BtnCep
            // 
            this.BtnCep.Location = new System.Drawing.Point(111, 110);
            this.BtnCep.Name = "BtnCep";
            this.BtnCep.Size = new System.Drawing.Size(82, 37);
            this.BtnCep.TabIndex = 4;
            this.BtnCep.Text = "Cep";
            this.BtnCep.UseVisualStyleBackColor = true;
            this.BtnCep.Click += new System.EventHandler(this.BtnCep_Click);
            // 
            // BtnMoeda
            // 
            this.BtnMoeda.Location = new System.Drawing.Point(199, 110);
            this.BtnMoeda.Name = "BtnMoeda";
            this.BtnMoeda.Size = new System.Drawing.Size(82, 37);
            this.BtnMoeda.TabIndex = 5;
            this.BtnMoeda.Text = "Moeda";
            this.BtnMoeda.UseVisualStyleBackColor = true;
            this.BtnMoeda.Click += new System.EventHandler(this.BtnMoeda_Click);
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(23, 153);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(82, 37);
            this.BtnData.TabIndex = 6;
            this.BtnData.Text = "Data";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnSenha
            // 
            this.BtnSenha.Location = new System.Drawing.Point(111, 153);
            this.BtnSenha.Name = "BtnSenha";
            this.BtnSenha.Size = new System.Drawing.Size(82, 37);
            this.BtnSenha.TabIndex = 7;
            this.BtnSenha.Text = "Senha";
            this.BtnSenha.UseVisualStyleBackColor = true;
            this.BtnSenha.Click += new System.EventHandler(this.BtnSenha_Click);
            // 
            // BtnTelefone
            // 
            this.BtnTelefone.Location = new System.Drawing.Point(199, 153);
            this.BtnTelefone.Name = "BtnTelefone";
            this.BtnTelefone.Size = new System.Drawing.Size(82, 37);
            this.BtnTelefone.TabIndex = 8;
            this.BtnTelefone.Text = "Telefone";
            this.BtnTelefone.UseVisualStyleBackColor = true;
            this.BtnTelefone.Click += new System.EventHandler(this.BtnTelefone_Click);
            // 
            // BtnVerConteudo
            // 
            this.BtnVerConteudo.Location = new System.Drawing.Point(23, 196);
            this.BtnVerConteudo.Name = "BtnVerConteudo";
            this.BtnVerConteudo.Size = new System.Drawing.Size(258, 37);
            this.BtnVerConteudo.TabIndex = 9;
            this.BtnVerConteudo.Text = "Ver Conteudo";
            this.BtnVerConteudo.UseVisualStyleBackColor = true;
            this.BtnVerConteudo.Click += new System.EventHandler(this.BtnVerConteudo_Click);
            // 
            // FormMascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.BtnVerConteudo);
            this.Controls.Add(this.BtnTelefone);
            this.Controls.Add(this.BtnSenha);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.BtnMoeda);
            this.Controls.Add(this.BtnCep);
            this.Controls.Add(this.BtnHora);
            this.Controls.Add(this.LblMascaraAtiva);
            this.Controls.Add(this.LblConteudo);
            this.Controls.Add(this.MskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos de Mascáras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskTextBox;
        private System.Windows.Forms.Label LblConteudo;
        private System.Windows.Forms.Label LblMascaraAtiva;
        private System.Windows.Forms.Button BtnHora;
        private System.Windows.Forms.Button BtnCep;
        private System.Windows.Forms.Button BtnMoeda;
        private System.Windows.Forms.Button BtnData;
        private System.Windows.Forms.Button BtnSenha;
        private System.Windows.Forms.Button BtnTelefone;
        private System.Windows.Forms.Button BtnVerConteudo;
    }
}