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
    public partial class FormMascara : Form
    {
        public FormMascara()
        {
            InitializeComponent();
        }

        private void BtnHora_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = false;
            LblConteudo.Text = "";
            MskTextBox.Mask = "00:00";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }

        private void BtnVerConteudo_Click(object sender, EventArgs e)
        {
            LblConteudo.Text = MskTextBox.Text;
            if (MskTextBox.Mask == "000000")
            {
                LblConteudo.Visible = false;
            }
            else
            {
                LblConteudo.Visible = true;
            }
        }

        private void BtnCep_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = false;
            LblConteudo.Text = "";
            MskTextBox.Mask = "00000-000";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }

        private void BtnMoeda_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = false;
            LblConteudo.Text = "";
            MskTextBox.Mask = "$ 000,000,000.00";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = false;
            LblConteudo.Text = "";
            MskTextBox.Mask = "00/00/0000";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }

        private void BtnSenha_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = true;
            LblConteudo.Text = "";
            MskTextBox.Mask = "000000";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }

        private void BtnTelefone_Click(object sender, EventArgs e)
        {
            MskTextBox.UseSystemPasswordChar = false;
            LblConteudo.Text = "";
            MskTextBox.Mask = "(00) 0 0000-0000";
            LblMascaraAtiva.Text = MskTextBox.Mask;
            MskTextBox.Text = "";
            MskTextBox.Focus();
        }
    }
}
