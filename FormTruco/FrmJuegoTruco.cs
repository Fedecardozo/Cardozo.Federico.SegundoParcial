using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace FormTruco
{
    public partial class FrmJuegoTruco : Form
    {

        #region Atributos

        private int conteoTime;
        private int minutos;
        private int ronda;
        private int ganadorPrimera;
        private int ganadorSegunda;
        private int ganadorTercera;
        private int rondaJ1;
        private int rondaJ2;
        private bool turnoJ1;
        private bool turnoJ2;
        private MazoCartas mazo;
        private Carta[] cartas;
        private Carta cartaJuagadaJ1;
        private Carta cartaJuagadaJ2;
        private int mano;
        private int quienCantoTruco;
        private int quienCantoRetruco;
        private int quienCantoVale4;
        #endregion

        #region Inicio Form

        public FrmJuegoTruco()
        {
            InitializeComponent();
        }
        private void FrmJuegoTruco_Load(object sender, EventArgs e)
        {
            Harcodeo.Global();
            this.conteoTime = 0;
            this.minutos = 0;
            this.ronda = 1;
            this.rondaJ1 = 0;
            this.rondaJ2 = 0;
            this.mazo = Harcodeo.MazoCartas;
            this.cartas = new Carta[6];
            this.RepartirCartas();
            this.mano = 1;
            this.InicioDelJuego();
            this.dataGridViewAnotador.Rows.Add(0,0);
            this.dataGridViewAnotador.Rows.Add(0,0);
            this.dataGridViewAnotador.Rows.Add(0,0);
            this.dataGridViewAnotador.Rows.Add(0,0);
            this.dataGridViewAnotador.Rows.Add(0,0);
        }
        private void InicioDelJuego()
        {
            if(this.mano == 1)
            {
                this.turnoJ1 = true;
                this.turnoJ2 = false;
            }
            else
            {
                this.turnoJ1 = false;
                this.turnoJ2 = true;
            }

            this.IniciarBotones();
        }

        #endregion

        #region Tiempo de juego
        
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

        #endregion

        #region Picture cartas J1
        
        private void pictureBoxJ1C1_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C1,0);
        }

        private void pictureBoxJ1C2_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C2,1);
        }

        private void pictureBoxJ1C3_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C3,2);
        }

        #endregion

        #region Picture cartas J2

        private void pictureBoxJ2C1_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C1,3);
        }

        private void pictureBoxJ2C2_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C2,4);
        }

        private void pictureBoxJ2C3_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C3,5);
        }

        #endregion

        #region Metodos movimientos de cartas

        /// <summary>
        /// Si es el turno del jugador 1, dependiendo la ronda va a mover la carta que haya jugado
        /// a la mesa
        /// </summary>
        /// <param name="picture"></param>
        private void MovientoJ1(PictureBox picture,int numeroCarta)
        {
            //picture.Location = new Point(picture.Location.X, 420);
            if(this.turnoJ1)
            {
                this.rondaJ1++;
                this.cartaJuagadaJ1 = this.cartas[numeroCarta];
                this.turnoJ1 = false;
                this.turnoJ2 = true;

                switch(this.ronda)
                {
                    case 1: this.MoverImagen(picture,this.pictureBoxPrimeraJ1);  break;
                    case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ1); break;
                    case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ1); break;
                }

            }
        }

        /// <summary>
        /// Si es el turno del jugador 2, dependiendo la ronda va a mover la carta que haya jugado
        /// a la mesa
        /// </summary>
        /// <param name="picture"></param>
        private void MovientoJ2(PictureBox picture, int numeroCarta)
        {
            //picture.Location = new Point(picture.Location.X, 210);
            if (this.turnoJ2)
            {
                this.rondaJ2++;
                this.cartaJuagadaJ2 = this.cartas[numeroCarta];
                this.turnoJ1 = true;
                this.turnoJ2 = false;

                switch (this.ronda)
                {
                    case 1: this.MoverImagen(picture, this.pictureBoxPrimeraJ2); break;
                    case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ2); break;
                    case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ2); break;
                }

            }

        }

        /// <summary>
        /// Cambia de lugar la imagen y pone invisible el lugar anterior de la imagen y si
        /// las rondas de cada jugador son iguales suma 1 a la ronda general
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="pictureMesa"></param>
        private void MoverImagen(PictureBox picture, PictureBox pictureMesa)
        {
            pictureMesa.Image = picture.Image;
            pictureMesa.Visible = true;
            picture.Visible = false;

            //Verifica que los 2 jugadores ya hayan tirado las cartas 
            if (this.rondaJ1 == this.rondaJ2 && this.rondaJ1 > 0 && this.rondaJ2 > 0)
            {
                //Verifico quien gano las rondas y se anota
                this.GanadorRondas();

                //Verifico si el jugador 1 ya gano el juego
                this.GanadorDelJuego(1);

                //Verifico si el jugador 2 ya gano el juego
                this.GanadorDelJuego(2);

                //Sumo en uno la ronda
                this.ronda++;
            }
        }

        /// <summary>
        /// Compara quien gano en cada ronda y anota que jugador gano en cada ronda
        /// </summary>
        private void GanadorRondas()
        {
            int ganador = JuegoDeCartas.CartaGanadoraTruco(this.cartaJuagadaJ1, this.cartaJuagadaJ2);

            switch (ganador)
            {
                case 1: this.IniciarHiloSecundario("Ganador jugador 1"); this.turnoJ1 = true; this.turnoJ2 = false; break;
                case 2: this.IniciarHiloSecundario("Ganador jugador 2"); this.turnoJ1 = false; this.turnoJ2 = true; break;
                case 0:

                    if (this.ronda == 1 || (this.ganadorPrimera == 0 && this.ronda < 3))
                    {
                        this.IniciarHiloSecundario("Parda!");
                        if(this.mano == 1)
                        {
                            this.turnoJ1 = true;
                            this.turnoJ2 = false;
                        }
                        else
                        {
                            this.turnoJ1 = false;
                            this.turnoJ2 = true;
                        }
                    }

                    break;
            }

            switch (this.ronda)
            {
                case 1: this.ganadorPrimera = ganador; break;
                case 2: this.ganadorSegunda = ganador; break;
                case 3: this.ganadorTercera = ganador; break;
            }

        }

        /// <summary>
        /// En cada ronda comprueba si ya hay un ganador del juego
        /// </summary>
        private void GanadorDelJuego(int jugador)
        {
            string ganadorJ1 = $"Ganador jugador {jugador}";

            if (this.ganadorPrimera == jugador && this.ganadorSegunda == jugador)
            {
                this.MensajeGanador(ganadorJ1);
            }
            else if(this.ganadorPrimera == jugador && this.ganadorTercera == jugador)
            {
                this.MensajeGanador(ganadorJ1);
            }
            else if(this.ganadorPrimera == 0 && this.ganadorSegunda == jugador)
            {
                this.MensajeGanador(ganadorJ1);
            }
            else if (this.ganadorPrimera == 0 && this.ganadorSegunda == 0 && this.ganadorTercera == jugador)
            {
                this.MensajeGanador(ganadorJ1);
            }
            else if (this.ganadorPrimera == 0 && this.ganadorSegunda == 0 && this.ganadorTercera == 0 && this.mano == jugador)
            {
                this.MensajeGanador(ganadorJ1);
            }

        }

        /// <summary>
        /// Message box de quien gano el juego
        /// </summary>
        /// <param name="msj"></param>
        private void MensajeGanador(string msj)
        {
            MessageBox.Show(msj, "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Label de lo que se canto
     
        private void CambiarTextoLabel(string mensaje)
        {
            this.labelCanto.Text = mensaje;
            this.labelCanto.Visible = true;
        }

        #endregion

        #region Botones J1

        private void btnQuieroJ1_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J1: Quiero!");
            this.IniciarHiloSecundario($"{JuegoDeCartas.CalcularTantos(new Carta[] { this.cartas[0], this.cartas[1], this.cartas[2]})}");
        }

        private void btnNoQuieroJ1_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J1: No quiero!");
        }

        private void btnEnvidoJ1_Click(object sender, EventArgs e)
        {
            this.CantoEnvido(1);
        }

        private void btnRealEnvidoJ1_Click(object sender, EventArgs e)
        {
            this.RealEnvido(1);
        }

        private void btnFaltaEnvidoJ1_Click(object sender, EventArgs e)
        {
            this.FaltaEnvido(1);
        }

        private void btnFlorJ1_Click(object sender, EventArgs e)
        {
            this.CambiarTextoLabel("J1: Flor!");
        }

        private void btnTrucoJ1_Click(object sender, EventArgs e)
        {
            this.CantoTruco(1);
        }

        private void btnReTrucoJ1_Click(object sender, EventArgs e)
        {
            this.ReTruco(1);
        }

        private void btnVale4J1_Click(object sender, EventArgs e)
        {
            this.ValeCuatro(1);
        }

        private void btnMazoJ1_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J1: Me voy al mazo!");
        }

        #endregion

        #region Botones J2

        private void btnQuieroJ2_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J2: Quiero!");
            this.IniciarHiloSecundario($"{JuegoDeCartas.CalcularTantos(new Carta[] { this.cartas[3], this.cartas[4], this.cartas[5]})}");
        }

        private void btnNoQuieroJ2_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J2: No quiero!");
        }

        private void btnEnvidoJ2_Click(object sender, EventArgs e)
        {
            this.CantoEnvido(2);
        }

        private void btnRealEnvidoJ2_Click(object sender, EventArgs e)
        {
            this.RealEnvido(2);
        }

        private void btnFaltaEnvidoJ2_Click(object sender, EventArgs e)
        {
            this.FaltaEnvido(2);
        }

        private void btnFlorJ2_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J2: Flor!");
        }

        private void btnTrucoJ2_Click(object sender, EventArgs e)
        {
            this.CantoTruco(2);
        }

        private void btnReTrucoJ2_Click(object sender, EventArgs e)
        {
            this.ReTruco(2);
        }

        private void btnValeCuatroJ2_Click(object sender, EventArgs e)
        {
            this.ValeCuatro(2);
        }

        private void btnMazoJ2_Click(object sender, EventArgs e)
        {
            this.IniciarHiloSecundario("J2: Me voy al mazo!");
        }

        #endregion

        #region Habilitación botones

        private void CantoTruco(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Truco!");

            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnReTrucoJ1, this.btnMazoJ1},this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnReTrucoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            this.quienCantoTruco = jugador;
        }
        
        private void ReTruco(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Quiero re truco!");
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnVale4J1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnValeCuatroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            this.quienCantoRetruco = jugador;
        }

        private void ValeCuatro(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Quiero vale cuatro!");
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            this.quienCantoVale4 = jugador;
        }

        private void CantoEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador} Envido!");
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnEnvidoJ1, this.btnRealEnvidoJ1, 
                    this.btnFaltaEnvidoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2,this.btnEnvidoJ2, this.btnRealEnvidoJ2,
                    this.btnFaltaEnvidoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            //MessageBox.Show($"{JuegoDeCartas.CalcularTantos(new Carta[] { this.cartas[0],this.cartas[1],this.cartas[2]})}");
        }

        private void RealEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Real envido!");
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnFaltaEnvidoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2,this.btnFaltaEnvidoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }
        }

        private void FaltaEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Falta envido!");
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }
        }

        /// <summary>
        /// Inicia botones segun quien sea mano
        /// </summary>
        private void IniciarBotones()
        {
            if (this.mano == 1)
            {
                this.HabilitarBotones(new Button[] { this.btnMazoJ1,this.btnEnvidoJ1,this.btnFaltaEnvidoJ1,this.btnRealEnvidoJ1, this.btnTrucoJ1 },this.groupBoxJ2);
            }
            else if(this.mano == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnMazoJ2, this.btnEnvidoJ2, this.btnFaltaEnvidoJ2, this.btnRealEnvidoJ2, this.btnTrucoJ2}, this.groupBoxJ1);
            }
        }
         
        /// <summary>
        /// Habilita los botones de un jugador y desahabilita el del otro jugador
        /// </summary>
        /// <param name="btns"></param>
        /// <param name="group"></param>
        private void HabilitarBotones(Button[] btns, GroupBox group)
        {
            foreach (Button item in btns)
            {
                item.Enabled = true;
            }

            foreach (Button item in group.Controls)
            {
                item.Enabled = false;
            }
        }

        #endregion

        #region Repartir cartas

        /// <summary>
        /// Reparte 3 cartas para cada jugador de manera aleatoria
        /// </summary>
        private void RepartirCartas()
        {
            this.cartas = this.mazo.RepartirCartasSinRepetir(6);

            this.pictureBoxJ1C1.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[0].ToString()}.png");
            this.pictureBoxJ1C2.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[1].ToString()}.png");
            this.pictureBoxJ1C3.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[2].ToString()}.png");
            this.pictureBoxJ2C1.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[3].ToString()}.png");
            this.pictureBoxJ2C2.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[4].ToString()}.png");
            this.pictureBoxJ2C3.Image = Image.FromFile($@"..\..\..\Resources\{this.cartas[5].ToString()}.png");
            //this.pictureBoxPrimeraJ1.Visible = true;

        }

        #endregion

        #region Hilos
        
        private void IniciarHiloSecundario(string msj)
        {
            Task hilo = new Task(() => this.MostrarInformacionConPausa(msj));
            hilo.Start();
        }
        
        private void OcultarLabel()
        {
            this.labelCanto.Visible = false;
        }

        /// <summary>
        /// Muestro la inforamcion en un hilo secundario de manera recursiva
        /// </summary>
        /// <param name="numero"></param>
        private void MostrarInformacionConPausa(string msj)
        {
            //Pregunta si esta iniciando en un hilo distinto al formulario
            if (this.InvokeRequired)
            {
                Action ocultar = this.OcultarLabel;
                Action<string> action = this.MostrarInformacionConPausa;
                //invoca el mismo metodo que lo esta llamando en el hilo principal
                this.Invoke(action,new object[] {msj});
                Thread.Sleep(3000);
                this.Invoke(ocultar);
            }
            else
            {
                this.CambiarTextoLabel(msj);
            }

        }

        #endregion

        #region Cerrar Programa

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
