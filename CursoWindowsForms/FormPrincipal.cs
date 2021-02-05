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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnDemonstracaoKey_Click(object sender, EventArgs e)
        {
            FormDemonstracaoKey f = new FormDemonstracaoKey();
            f.ShowDialog();
        }

        private void BtnHelloWorld_Click(object sender, EventArgs e)
        {
            FormHelloWorld helloWorld = new FormHelloWorld();
            helloWorld.ShowDialog();
        }

        private void BtnMascara_Click(object sender, EventArgs e)
        {
            FormMascara mascara = new FormMascara();
            mascara.ShowDialog();
        }

        private void BtnValidaCPF_Click(object sender, EventArgs e)
        {
            FormValidaCpf validaCpf = new FormValidaCpf();
            validaCpf.ShowDialog();
        }

        private void BtnValidaCPF2_Click(object sender, EventArgs e)
        {
            FormValidaCpf2 validaCpf = new FormValidaCpf2();
            validaCpf.ShowDialog();
        }

        private void BtnValidaSenha_Click(object sender, EventArgs e)
        {
            FormValidaSenha validaSenha = new FormValidaSenha();
            validaSenha.ShowDialog();
        }
    }
}
