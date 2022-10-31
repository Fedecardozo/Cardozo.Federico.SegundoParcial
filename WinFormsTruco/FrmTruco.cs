using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTruco
{
    public partial class FrmTruco : Form
    {
        public FrmTruco()
        {
            InitializeComponent();
        }

        #region Labels click

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

            this.CentrarLabelEnMesa(this.label1);

        }

        #endregion

        #region Metodos
        private void CentrarLabelEnMesa(Label label)
        {
            this.panelMesa.Controls.Add(label);
            int alturaPanel = this.panelMesa.Height / 2;
            int anchuraPanel = this.panelMesa.Width - label.Width;
            label.Location = new Point(anchuraPanel / 2, alturaPanel);
        }

        #endregion
    }
}
