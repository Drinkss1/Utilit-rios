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
    public partial class FormPrincipalMenu : Form
    {
        public FormPrincipalMenu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDemonstracaoKey f = new FormDemonstracaoKey();
            f.ShowDialog();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelloWorld helloWorld = new FormHelloWorld();
            helloWorld.ShowDialog();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMascara mascara = new FormMascara();
            mascara.ShowDialog();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaCpf validaCpf = new FormValidaCpf();
            validaCpf.ShowDialog();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaCpf2 validaCpf = new FormValidaCpf2();
            validaCpf.ShowDialog();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaSenha validaSenha = new FormValidaSenha();
            validaSenha.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
