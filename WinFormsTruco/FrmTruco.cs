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
        #region Atributos

        private int contJugador1;
        private int contJugador2;

        #endregion

        #region Incio del form

        public FrmTruco()
        {
            InitializeComponent();
        }

        private void FrmTruco_Load(object sender, EventArgs e)
        {
            this.contJugador1 = 0;
            this.contJugador2 = 0;
        }

        #endregion

        #region Labels click

        //Jugador 1
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.CentrarLabelEnMesaJ1(this.labelJugador1C1);
        }
        private void labelJugador1C2_Click(object sender, EventArgs e)
        {
            this.CentrarLabelEnMesaJ1(this.labelJugador1C2);
        }
        private void labelJugador1C3_Click(object sender, EventArgs e)
        {
            this.CentrarLabelEnMesaJ1(this.labelJugador1C3);
        }

        //Jugador 2
        private void labelJugador2C1_Click(object sender, EventArgs e)
        {
            this.CentrarLabelEnMesaJ2(this.labelJugador2C1);
        }
        private void labelJugador2C2_Click(object sender, EventArgs e)
        {
            this.CentrarLabelEnMesaJ2(this.labelJugador2C2);
        }
        private void labelJugador3C3_Click(object sender, EventArgs e)
        {
            this.CentrarLabelEnMesaJ2(this.labelJugador2C3);
        }

        #endregion

        #region Metodos
        private void CentrarLabelEnMesaJ1(Label label)
        {
            int alturaPanel = (this.panelMesa.Height / 2)+10;
            int anchuraPanel = this.panelMesa.Width - label.Width;

            int alturaLabel = label.Size.Height;
            this.panelMesa.Controls.Add(label);

            switch(this.contJugador1)
            {
                case 1: alturaPanel += alturaLabel + 2; break;

                case 2: alturaPanel += alturaLabel*2 + 5; break;

            }

            label.Location = new Point(anchuraPanel / 2, alturaPanel);
            this.contJugador1++;
        }

        private void CentrarLabelEnMesaJ2(Label label)
        {
            this.panelMesa.Controls.Add(label);
            int alturaPanel = (this.panelMesa.Height / 2)-40;
            int anchuraPanel = this.panelMesa.Width - label.Width;
            int alturaLabel = label.Size.Height;

            switch (this.contJugador2)
            {
                case 1: alturaPanel -= alturaLabel + 2; break;

                case 2: alturaPanel -= alturaLabel * 2 + 5; break;

            }

            label.Location = new Point(anchuraPanel / 2, alturaPanel);
            this.contJugador2++;
        }





        #endregion

        
    }
}
