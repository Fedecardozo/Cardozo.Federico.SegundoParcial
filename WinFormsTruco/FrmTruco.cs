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

namespace WinFormsTruco
{
    public partial class FrmTruco : Form
    {
        #region Delegado

        public delegate bool JugarCarta(Label label); 

        #endregion

        #region Atributos

        private int contJugador1;
        private int contJugador2;
        private int turno;
        private MazoCartas mazo;
        //private Jugador jugador01;
        //private Jugador jugador02;
        private Carta[] cartaJugadaJ1;
        private Carta[] cartaJugadaJ2;
        private Carta cartaEnJuegoJ1; 
        private Carta cartaEnJuegoJ2;

        #endregion

        #region Incio del form

        public FrmTruco()
        {
            InitializeComponent();
        }
        /*public FrmTruco(Jugador jugador1, Jugador jugador2) : this()
        {
            this.jugador01 = jugador1;
            this.jugador02 = jugador2;
        }*/

        private void FrmTruco_Load(object sender, EventArgs e)
        {
            Harcodeo.Global();
            this.contJugador1 = 0;
            this.contJugador2 = 0;
            this.turno = 1;
            this.Botones(true,false,false,true,true,true,true,false,false);
            this.mazo = Harcodeo.MazoCartas;
            //this.jugador01 = new Jugador("Fede",3);
            //this.jugador02 = new Jugador("Alan",3);
            this.RepartirCartas();
            this.CargarLabels();
        }

        #endregion

        #region Labels click

        //Jugador 1
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ1, this.labelJugador1C1, this.cartaJugadaJ1[0],1);
        }
        private void labelJugador1C2_Click(object sender, EventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ1, this.labelJugador1C2, this.cartaJugadaJ1[1],1);
        }
        private void labelJugador1C3_Click(object sender, EventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ1, this.labelJugador1C3, this.cartaJugadaJ1[2],1);
        }

        //Jugador 2
        private void labelJugador2C1_Click(object sender, EventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ2, this.labelJugador2C1, this.cartaJugadaJ2[0],2);
        }
        private void labelJugador2C2_Click(object sender, EventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ2, this.labelJugador2C2, this.cartaJugadaJ2[1],2);
        }
        private void labelJugador3C3_Click(object sender, EventArgs e)
        {
            this.CartaJugada(this.CentrarLabelEnMesaJ2, this.labelJugador2C3, this.cartaJugadaJ2[2],2);
        }

        #endregion

        #region Metodos
        private bool CentrarLabelEnMesaJ1(Label label)
        {
            bool retorno = false;
            int alturaPanel = (this.panelMesa.Height / 2)+10;
            int anchuraPanel = this.panelMesa.Width - label.Width;

            int alturaLabel = label.Size.Height;

            if(this.turno == 1)
            {
                this.panelMesa.Controls.Add(label);
                this.turno = 2;
                switch(this.contJugador1)
                {
                    case 1: alturaPanel += alturaLabel + 2; break;

                    case 2: alturaPanel += alturaLabel*2 + 5; break;

                }

                label.Location = new Point(anchuraPanel / 2, alturaPanel);
                this.contJugador1++;
                retorno = true;
            }

            return retorno;
        }

        private bool CentrarLabelEnMesaJ2(Label label)
        {
            bool retorno = false;
            int alturaPanel = (this.panelMesa.Height / 2)-40;
            int anchuraPanel = this.panelMesa.Width - label.Width;
            int alturaLabel = label.Size.Height;

            if(this.turno == 2)
            {
                this.panelMesa.Controls.Add(label);
                this.turno = 1;

                switch (this.contJugador2)
                {
                    case 1: alturaPanel -= alturaLabel + 2; break;

                    case 2: alturaPanel -= alturaLabel * 2 + 5; break;

                }

                label.Location = new Point(anchuraPanel / 2, alturaPanel);
                this.contJugador2++;
                retorno = true;
            }

            return retorno;
           // return new Carta(label.Text);

        }

        private void CartaJugada(JugarCarta jugarCarta, Label label,Carta carta, int jugador)
        {
            //Verifica si se pudo jugar la carta
            if (jugarCarta(label))
            {
                //Dependiendo del jugador pasado por parametro cargo la carta jugada
                if(jugador == 1)
                {
                    this.cartaEnJuegoJ1 = carta;
                    //MessageBox.Show($"{this.panelMesa.Controls.Count}");
                }
                else if(jugador == 2)
                {
                    this.cartaEnJuegoJ2 = carta;
                    //MessageBox.Show($"{this.panelMesa.Controls.Count}");
                }


                switch (this.panelMesa.Controls.Count)
                {
                    case 2: this.GanadorPrimera(this.cartaEnJuegoJ1, this.cartaEnJuegoJ2); break;
                    case 4: this.GanadorPrimera(this.cartaEnJuegoJ1, this.cartaEnJuegoJ2); break;
                    case 6: this.GanadorPrimera(this.cartaEnJuegoJ1, this.cartaEnJuegoJ2); break;
                }
            }
        }

        private void GanadorPrimera(Carta c1, Carta c2)
        {
            int resultado = JuegoDeCartas.CartaGanadoraTruco(c1, c2);

            if (resultado == 1)
            {
                MessageBox.Show("Mas grande carta 1");
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Son iguales ");
            }
            else if (resultado == -1)
            {
                MessageBox.Show("Mas grande carta 2");
            }
            else
            {
                MessageBox.Show("Algo fallo");
            }
        }

        #endregion

        #region Botones
        
        private void CambiarLabelJugador(string msj)
        {
            switch (this.turno)
            {
                case 1: this.labelCantoJugador1.Text = msj; this.labelCantoJugador1.Visible = true; this.turno = 2; break;
                case 2: this.labelCantoJugador2.Text = msj; this.labelCantoJugador2.Visible = true; this.turno = 1; break;
            }
        }
        private void btnEnvido_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Envido!");
        }

        private void btnRealEnvido_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Real envido!");
        }

        private void btnFaltaEnvido_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Falta envido!");
        }

        private void btnFlor_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Flor!");
        }

        private void btnQuiero_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Quiero!");
        }

        private void btnNoQuiero_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("No quiero!");
        }

        private void btnTruco_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Truco!");
        }

        private void btnReTruco_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Quiero re truco!");
        }

        private void btnValeCuatro_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Quiero vale cuatro!");
        }

        private void btnAlMazo_Click(object sender, EventArgs e)
        {
            this.CambiarLabelJugador("Me voy al mazo");
        }


        #endregion

        #region Inahabilitar botones, Logica del truco

        private void Botones(bool flor,bool quiero,bool noQuiero, bool envido, bool faltaEnvido, 
            bool realEnvido, bool truco, bool reTruco, bool valeCuatro)
        {

            //Flor
            this.btnFlor.Enabled = flor;

            //Quiero - No quiero
            this.btnQuiero.Enabled = quiero;
            this.btnNoQuiero.Enabled = noQuiero ;

            //Envidos
            this.btnEnvido.Enabled = envido;
            this.btnFaltaEnvido.Enabled = faltaEnvido;
            this.btnRealEnvido.Enabled = realEnvido;

            //Trucos
            this.btnTruco.Enabled = truco;
            this.btnReTruco.Enabled = reTruco;
            this.btnValeCuatro.Enabled = valeCuatro;
        }


        #endregion

        #region Cargar cartas

        /*private void RepartirCartas()
        {
            JuegoDeCartas truco = new JuegoDeCartas(this.jugador01,this.jugador02,this.mazo);
            truco.EmpezarTruco();

            this.labelJugador1C1.Text = this.jugador01[0].ToString();
            this.labelJugador1C2.Text = this.jugador01[1].ToString();
            this.labelJugador1C3.Text = this.jugador01[2].ToString();

            this.labelJugador2C1.Text = this.jugador02[0].ToString();
            this.labelJugador2C2.Text = this.jugador02[1].ToString();
            this.labelJugador2C3.Text = this.jugador02[2].ToString();
        }*/

        private void RepartirCartas()
        {
            //Doy 6 cartas sin repetir
            Carta[] cartas = this.mazo.RepartirCartasSinRepetir(6);

            this.cartaJugadaJ1 = new Carta[3];

            //Cargo las cartas al jugador 1
            this.cartaJugadaJ1[0] = cartas[0];
            this.cartaJugadaJ1[1] = cartas[1];
            this.cartaJugadaJ1[2] = cartas[2];

            this.cartaJugadaJ2 = new Carta[3];

            //Cargo las cartas al jugador 2
            this.cartaJugadaJ2[0] = cartas[3];
            this.cartaJugadaJ2[1] = cartas[4];
            this.cartaJugadaJ2[2] = cartas[5];

        }

        private void CargarLabels()
        {
            this.labelJugador1C1.Text = this.cartaJugadaJ1[0].ToString();
            this.labelJugador1C2.Text = this.cartaJugadaJ1[1].ToString();
            this.labelJugador1C3.Text = this.cartaJugadaJ1[2].ToString();

            this.labelJugador2C1.Text = this.cartaJugadaJ2[0].ToString();
            this.labelJugador2C2.Text = this.cartaJugadaJ2[1].ToString();
            this.labelJugador2C3.Text = this.cartaJugadaJ2[2].ToString();

        }

        #endregion

    }
}
