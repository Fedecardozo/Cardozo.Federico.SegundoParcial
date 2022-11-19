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
    public partial class FrmJuegoTruco : Form
    {
        private int conteoTime;
        private int minutos;

        public FrmJuegoTruco()
        {
            InitializeComponent();
            this.conteoTime = 0;
            this.minutos = 0;
        }

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            this.conteoTime++;
            string minutosCadena = $"0{this.minutos}";
            string segundosCadena = $"0{this.conteoTime}";

            if (this.conteoTime %60 == 0)
            {
                this.minutos++;
                this.conteoTime = 0;
            }
            
            if(this.minutos >= 10)
            {
                minutosCadena = $"{this.minutos}"; 
            }

            if(this.conteoTime >= 10)
            {
                segundosCadena = $"{this.conteoTime}";
            }

            this.labelSegundos.Text = $"{minutosCadena} : {segundosCadena}";
        }
    }
}
