using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTruco
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            FrmJuegoTruco truco = new FrmJuegoTruco();
            truco.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
