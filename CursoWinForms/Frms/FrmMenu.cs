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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaFormulario(new FrmHello2());

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaFormulario(new FrmValidaSenha());
        }

        private void demonstraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaFormulario(new FrmDemonstracao());
        }

        private void CarregaFormulario(object Form)
        {
            if (this.panelControle.Controls.Count > 0)
            {
                this.panelControle.Controls.RemoveAt(0);
            }

            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelControle.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaFormulario(new FrmMascara());
        }

        private void mascara2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregaFormulario(new FrmMascara2());
        }
    }
}
