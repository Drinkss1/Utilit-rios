namespace CursoWindowsForms
{
    partial class FormValidaCpf2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaCpf2));
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnValida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskCpf
            // 
            this.MskCpf.Location = new System.Drawing.Point(12, 45);
            this.MskCpf.Mask = "000,000,000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(218, 20);
            this.MskCpf.TabIndex = 0;
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
            // BtnValida
            // 
            this.BtnValida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnValida.Location = new System.Drawing.Point(245, 71);
            this.BtnValida.Name = "BtnValida";
            this.BtnValida.Size = new System.Drawing.Size(111, 23);
            this.BtnValida.TabIndex = 3;
            this.BtnValida.Text = "Valida";
            this.BtnValida.UseVisualStyleBackColor = true;
            this.BtnValida.Click += new System.EventHandler(this.BtnValida_Click);
            // 
            // FormValidaCpf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.BtnValida);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.MskCpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormValidaCpf2";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação Cpf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnValida;
    }
}