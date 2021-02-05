namespace CursoWindowsForms
{
    partial class FormValidaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaSenha));
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnVerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSenha
            // 
            this.TxtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSenha.Location = new System.Drawing.Point(12, 45);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(218, 20);
            this.TxtSenha.TabIndex = 0;
            this.TxtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // LblResultado
            // 
            this.LblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(12, 90);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 19);
            this.LblResultado.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.Location = new System.Drawing.Point(245, 42);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(111, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Limpa";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnVerSenha
            // 
            this.BtnVerSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerSenha.Location = new System.Drawing.Point(245, 71);
            this.BtnVerSenha.Name = "BtnVerSenha";
            this.BtnVerSenha.Size = new System.Drawing.Size(111, 23);
            this.BtnVerSenha.TabIndex = 3;
            this.BtnVerSenha.Text = "Ver senha";
            this.BtnVerSenha.UseVisualStyleBackColor = true;
            this.BtnVerSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.BtnVerSenha);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação da Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnVerSenha;
    }
}