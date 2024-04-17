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
    public partial class FrmHello2 : Form
    {
        public FrmHello2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Dispose();
        }

        private void btnAlteraTexto_Click(object sender, EventArgs e)
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
