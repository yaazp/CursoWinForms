
using CursoWinFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWinForms.Frms
{
    public partial class FrmMascara : Form
    {
        public FrmMascara()
        {
            InitializeComponent();
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            AlteraMascara("00:00");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lblConteudo.Text = mtbInput.Text;
        }

        private void AlteraMascara (string Mascara)
        {
            mtbInput.UseSystemPasswordChar = false;
            mtbInput.Mask = Mascara;
            lblMascaraAtiva.Text = mtbInput.Mask;
            mtbInput.Text = "";
            mtbInput.Focus();
            lblConteudo.Text = "";
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            AlteraMascara("00000-000");
        }

        private void btnMoeda_Click(object sender, EventArgs e)
        {
            AlteraMascara("$ 00.00"); //neste caso o símbolo de dólar faz com que o sistema identifique a moeda
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            AlteraMascara("00/00/0000");
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            AlteraMascara("(00) 00000-0000");
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            AlteraMascara("000000");
            mtbInput.UseSystemPasswordChar = true;
            mtbInput.Focus();
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            AlteraMascara("000,000,000-00");
        }

        private void btnValidaCPF_Click(object sender, EventArgs e)
        {
            ClsUtils valida = new ClsUtils();
            bool resultado = valida.ValidarCPF(mtbInput.Text);
            if (resultado)
            {
                lblValidaCPF.Text = "CPF Válido";
                lblValidaCPF.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblValidaCPF.Text = "CPF Inválido";
                lblValidaCPF.ForeColor = Color.DarkRed;
            }
            mtbInput.Focus();
        }
    }
}
