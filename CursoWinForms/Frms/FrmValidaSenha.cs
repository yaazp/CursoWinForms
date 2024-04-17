using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  CursoWinFormsBiblioteca;


namespace CursoWinForms.Frms
{
    public partial class FrmValidaSenha : Form
    {
        public FrmValidaSenha()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbSenha.Text = string.Empty;
            lbResultado.Text = string.Empty;
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            ClsUtils.ChecaForcaSenha verifica = new ClsUtils.ChecaForcaSenha();
            ClsUtils.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(tbSenha.Text);
            lbResultado.Text = forca.ToString();

            switch (forca.ToString()) {

                case "Inaceitavel" :
                    lbResultado.ForeColor = Color.DarkRed;
                    break;

                case "Fraca":
                    lbResultado.ForeColor = Color.Red;
                    break;

                case "Aceitavel":
                    lbResultado.ForeColor = Color.DarkOrange;
                    break;

                case "Forte":
                    lbResultado.ForeColor = Color.Blue;
                    break;

                case "Segura":
                    lbResultado.ForeColor = Color.DarkGreen;
                    break;

                default:
                    lbResultado.ForeColor = Color.LightGray; 
                    break;
            }
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            tbSenha.UseSystemPasswordChar = !tbSenha.UseSystemPasswordChar;
            if (tbSenha.UseSystemPasswordChar)
            {
                btnVerSenha.Text = "Ver Senha";
            }
            else
            {
                btnVerSenha.Text = "Esconder Senha";
            }
            
        }
    }
}
