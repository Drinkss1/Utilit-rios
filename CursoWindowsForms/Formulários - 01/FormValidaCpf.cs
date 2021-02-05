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
    public partial class FormValidaCpf : Form
    {
        public FormValidaCpf()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblResultado.Text = "";
            MskCpf.Text = "";
        }

        private void BtnValida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = ClsUteis.Valida(MskCpf.Text);
            if (validaCpf)
            {
                LblResultado.Text = "CPF VÁLIDO";
                LblResultado.ForeColor = Color.Green;
            }
            else
            {
                LblResultado.Text = "CPF Inválido";
                LblResultado.ForeColor = Color.Red;
            }
        }
    }
}
