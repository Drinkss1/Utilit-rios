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
    public partial class FormDemonstracaoKey : Form
    {
        public FormDemonstracaoKey()
        {
            InitializeComponent();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            TxtMsg.AppendText("\r\n" + "Pressionei uma tecla :" + e.KeyCode + "\r\n");
            TxtMsg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n"); //O \t da um tab 
            TxtMsg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

            LblLower.Text = e.KeyCode.ToString().ToLower();
            LblUpper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtMsg.Text = "";
            TxtInput.Text = "";
            LblUpper.Text = "";
            LblLower.Text = "";
        }
    }
}
