using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWinForms
{
    public partial class FrmHello : Form
    {
        public FrmHello()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AlteraTexto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbNovoTexto.Text))
            {
                this.lblTitulo.Text = this.tbNovoTexto.Text;
                this.tbNovoTexto.Text = string.Empty;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tbNovoTexto.Text = string.Empty;
        }
    }
}
