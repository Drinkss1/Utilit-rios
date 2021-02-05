namespace CursoWindowsForms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.BtnDemonstracaoKey = new System.Windows.Forms.Button();
            this.BtnHelloWorld = new System.Windows.Forms.Button();
            this.BtnMascara = new System.Windows.Forms.Button();
            this.BtnValidaCPF = new System.Windows.Forms.Button();
            this.BtnValidaSenha = new System.Windows.Forms.Button();
            this.BtnValidaCPF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDemonstracaoKey
            // 
            this.BtnDemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("BtnDemonstracaoKey.Image")));
            this.BtnDemonstracaoKey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.BtnDemonstracaoKey.Name = "BtnDemonstracaoKey";
            this.BtnDemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.BtnDemonstracaoKey.TabIndex = 0;
            this.BtnDemonstracaoKey.Text = "Demonstração Key";
            this.BtnDemonstracaoKey.UseVisualStyleBackColor = true;
            this.BtnDemonstracaoKey.Click += new System.EventHandler(this.BtnDemonstracaoKey_Click);
            // 
            // BtnHelloWorld
            // 
            this.BtnHelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelloWorld.Image")));
            this.BtnHelloWorld.Location = new System.Drawing.Point(132, 12);
            this.BtnHelloWorld.Name = "BtnHelloWorld";
            this.BtnHelloWorld.Size = new System.Drawing.Size(114, 48);
            this.BtnHelloWorld.TabIndex = 1;
            this.BtnHelloWorld.Text = "Hello Word";
            this.BtnHelloWorld.UseVisualStyleBackColor = true;
            this.BtnHelloWorld.Click += new System.EventHandler(this.BtnHelloWorld_Click);
            // 
            // BtnMascara
            // 
            this.BtnMascara.Image = ((System.Drawing.Image)(resources.GetObject("BtnMascara.Image")));
            this.BtnMascara.Location = new System.Drawing.Point(252, 12);
            this.BtnMascara.Name = "BtnMascara";
            this.BtnMascara.Size = new System.Drawing.Size(114, 48);
            this.BtnMascara.TabIndex = 2;
            this.BtnMascara.Text = "Máscara";
            this.BtnMascara.UseVisualStyleBackColor = true;
            this.BtnMascara.Click += new System.EventHandler(this.BtnMascara_Click);
            // 
            // BtnValidaCPF
            // 
            this.BtnValidaCPF.Image = ((System.Drawing.Image)(resources.GetObject("BtnValidaCPF.Image")));
            this.BtnValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.BtnValidaCPF.Name = "BtnValidaCPF";
            this.BtnValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.BtnValidaCPF.TabIndex = 3;
            this.BtnValidaCPF.Text = "Válida CPF";
            this.BtnValidaCPF.UseVisualStyleBackColor = true;
            this.BtnValidaCPF.Click += new System.EventHandler(this.BtnValidaCPF_Click);
            // 
            // BtnValidaSenha
            // 
            this.BtnValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("BtnValidaSenha.Image")));
            this.BtnValidaSenha.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.BtnValidaSenha.Name = "BtnValidaSenha";
            this.BtnValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.BtnValidaSenha.TabIndex = 4;
            this.BtnValidaSenha.Text = "Válida Senha";
            this.BtnValidaSenha.UseVisualStyleBackColor = true;
            this.BtnValidaSenha.Click += new System.EventHandler(this.BtnValidaSenha_Click);
            // 
            // BtnValidaCPF2
            // 
            this.BtnValidaCPF2.Image = ((System.Drawing.Image)(resources.GetObject("BtnValidaCPF2.Image")));
            this.BtnValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.BtnValidaCPF2.Name = "BtnValidaCPF2";
            this.BtnValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.BtnValidaCPF2.TabIndex = 5;
            this.BtnValidaCPF2.Text = "Válida CPF 2";
            this.BtnValidaCPF2.UseVisualStyleBackColor = true;
            this.BtnValidaCPF2.Click += new System.EventHandler(this.BtnValidaCPF2_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.BtnValidaCPF2);
            this.Controls.Add(this.BtnValidaSenha);
            this.Controls.Add(this.BtnValidaCPF);
            this.Controls.Add(this.BtnMascara);
            this.Controls.Add(this.BtnHelloWorld);
            this.Controls.Add(this.BtnDemonstracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDemonstracaoKey;
        private System.Windows.Forms.Button BtnHelloWorld;
        private System.Windows.Forms.Button BtnMascara;
        private System.Windows.Forms.Button BtnValidaCPF;
        private System.Windows.Forms.Button BtnValidaSenha;
        private System.Windows.Forms.Button BtnValidaCPF2;
    }
}