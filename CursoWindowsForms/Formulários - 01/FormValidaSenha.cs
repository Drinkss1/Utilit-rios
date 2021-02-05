using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormsBiblioteca.ClsUteis;

namespace CursoWindowsForms
{
    public partial class FormValidaSenha : Form
    {
        public FormValidaSenha()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtSenha.Text = "";
            LblResultado.Text = "";
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(TxtSenha.Text);
            LblResultado.Text = forca.ToString();

            if(LblResultado.Text == "Inaceitavel" || LblResultado.Text == "Fraca")
            {
                LblResultado.ForeColor = Color.Red;
            }

            if (LblResultado.Text == "Aceitavel")
            {
                LblResultado.ForeColor = Color.Blue;
            }

            if (LblResultado.Text == "Forte" || LblResultado.Text == "Segura")
            {
                LblResultado.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtSenha.PasswordChar.ToString() == "*")
            {
                TxtSenha.PasswordChar = '\0';//Representa um caractere vazio
                BtnVerSenha.Text = "Ocultar senha";
            }
            else
            {
                TxtSenha.PasswordChar = '*';
                BtnVerSenha.Text = "Ver senha";
            }
            
        }
    }
}
