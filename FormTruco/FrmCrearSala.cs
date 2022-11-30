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
    public partial class FrmCrearSala : FrmPadre
    {
        public FrmCrearSala()
        {
            InitializeComponent();
        }

        private void pictureBoxMas_Click(object sender, EventArgs e)
        {
            this.panelMas.Visible = true;
        }
    }
}
