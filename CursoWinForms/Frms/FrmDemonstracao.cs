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
    public partial class FrmDemonstracao : Form
    {
        public FrmDemonstracao()
        {
            InitializeComponent();
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            tbMsg.AppendText("\r\n" + $"Pressionei uma tecla: {e.KeyCode}" + "\r\n");
            tbMsg.AppendText("\t" + $"Código da tecla: {(int)e.KeyCode}" + "\r\n");
            lblUpper.Text = e.KeyCode.ToString().ToUpper();
            lblLower.Text = e.KeyCode.ToString().ToLower();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMsg.Text = string.Empty;
            tbInput.Text = string.Empty;
            lblUpper.Text = string.Empty;
            lblLower.Text = string.Empty;
        }
    }
}
