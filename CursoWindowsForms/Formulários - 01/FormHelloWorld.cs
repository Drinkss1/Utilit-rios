using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class FormHelloWorld : Form
    {
        public FormHelloWorld()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();//Finalizar aplicação ao clicar no botão
        }

        private void BtnModificaTexto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtConteudoLabel.Text))
            {
                MessageBox.Show("Digite uma mensagem para alterar o texto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblTitulo.Focus();
            }
            else
            {
                LblTitulo.Text = TxtConteudoLabel.Text; //Quando eu clicar vai mudar o texto 'LblTitulo'
            }
        }
    }
}
