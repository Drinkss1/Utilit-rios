namespace CursoWindowsForms
{
    partial class FormDemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemonstracaoKey));
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblMinus = new System.Windows.Forms.Label();
            this.LblMaius = new System.Windows.Forms.Label();
            this.LblUpper = new System.Windows.Forms.Label();
            this.LblLower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(8, 8);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyDown);
            // 
            // TxtMsg
            // 
            this.TxtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMsg.Location = new System.Drawing.Point(8, 40);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMsg.Size = new System.Drawing.Size(304, 232);
            this.TxtMsg.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.Location = new System.Drawing.Point(328, 8);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 28);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Limpa";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblMinus
            // 
            this.LblMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMinus.AutoSize = true;
            this.LblMinus.Location = new System.Drawing.Point(320, 104);
            this.LblMinus.Name = "LblMinus";
            this.LblMinus.Size = new System.Drawing.Size(38, 13);
            this.LblMinus.TabIndex = 3;
            this.LblMinus.Text = "Minus.";
            // 
            // LblMaius
            // 
            this.LblMaius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMaius.AutoSize = true;
            this.LblMaius.Location = new System.Drawing.Point(320, 56);
            this.LblMaius.Name = "LblMaius";
            this.LblMaius.Size = new System.Drawing.Size(38, 13);
            this.LblMaius.TabIndex = 4;
            this.LblMaius.Text = "Maius.";
            // 
            // LblUpper
            // 
            this.LblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUpper.Location = new System.Drawing.Point(368, 56);
            this.LblUpper.Name = "LblUpper";
            this.LblUpper.Size = new System.Drawing.Size(38, 23);
            this.LblUpper.TabIndex = 5;
            // 
            // LblLower
            // 
            this.LblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLower.Location = new System.Drawing.Point(368, 104);
            this.LblLower.Name = "LblLower";
            this.LblLower.Size = new System.Drawing.Size(38, 23);
            this.LblLower.TabIndex = 6;
            // 
            // FormDemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.LblLower);
            this.Controls.Add(this.LblUpper);
            this.Controls.Add(this.LblMaius);
            this.Controls.Add(this.LblMinus);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TxtMsg);
            this.Controls.Add(this.TxtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LblMinus;
        private System.Windows.Forms.Label LblMaius;
        private System.Windows.Forms.Label LblUpper;
        private System.Windows.Forms.Label LblLower;
    }
}