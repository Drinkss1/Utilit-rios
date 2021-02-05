using FormsBiblioteca;
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
    public partial class FormValidaCpf2 : Form
    {
        public FormValidaCpf2()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            MskCpf.Text = "";
        }

        private void BtnValida_Click(object sender, EventArgs e)
        {
            string vConteudo = MskCpf.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if (!String.IsNullOrEmpty(vConteudo) && vConteudo.Length == 11)
            {
                var question = MessageBox.Show("Você tem certeza que deseja validar o CPF?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    bool validaCpf = false;
                    validaCpf = ClsUteis.Valida(MskCpf.Text);
                    if (validaCpf)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (vConteudo.Length > 0)
                {
                    MessageBox.Show("O campo CPF está incompleto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("O campo CPF está vázio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
