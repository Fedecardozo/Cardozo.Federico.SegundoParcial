using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormTruco
{
    public partial class FormPrincipal : Form
    {
        private Usuario usuario;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        public FormPrincipal(Usuario user) : this()
        {
            this.usuario = user;
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            FrmJuegoTruco truco = new FrmJuegoTruco();
            truco.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.usuario.ToString());
        }
    }
}
