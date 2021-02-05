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
    public partial class FormPrincipalMenuMDI : Form
    {
        public FormPrincipalMenuMDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDemonstracaoKey f = new FormDemonstracaoKey();
            f.MdiParent = this; // Fazer essa chamada quando o Formulário principal for um MDI
            f.Show();
            // f.ShowDialog(); Usar esse quando não for utilizar chamada MDI para poder abrir a tela e a principal pode mexer ela
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelloWorld helloWorld = new FormHelloWorld();
            helloWorld.MdiParent = this;
            helloWorld.Show();
            //helloWorld.ShowDialog();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMascara mascara = new FormMascara();
            mascara.MdiParent = this;
            mascara.Show();
            //mascara.ShowDialog();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaCpf validaCpf = new FormValidaCpf();
            validaCpf.MdiParent = this;
            validaCpf.Show();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaCpf2 validaCpf = new FormValidaCpf2();
            validaCpf.MdiParent = this;
            validaCpf.Show();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidaSenha validaSenha = new FormValidaSenha();
            validaSenha.MdiParent = this;
            validaSenha.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);//para quando abrimos varias telas e quando clicar no botão vertical
            //todas as telas ficaram em vertical
            //Temos o TileHorizontal e o Cascade
        }
    }
}
