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

        private int ContadorEnvidos;
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
        private Carta[] cartasJ1;
        private Carta[] cartasJ2;
        private Carta cartaJuagadaJ1;
        private Carta cartaJuagadaJ2;
        private int mano;
        private int puntoEnjuego;
        private int puntosEnvido;
        private EQueSeCanto QueSeCanto;
        private bool hayGanador;
        private int quienCantoTruco;
        private int puntosJ1;
        private int puntosJ2;
        #endregion

        #region Inicio Form

        public FrmJuegoTruco()
        {
            InitializeComponent();
        }
        private void FrmJuegoTruco_Load(object sender, EventArgs e)
        {
            Harcodeo.Global();
            this.hayGanador = false;
            this.ganadorPrimera = -1;
            this.ganadorSegunda = -1;
            this.ganadorTercera = -1;
            this.ContadorEnvidos = 0;
            this.puntoEnjuego = 1;
            this.puntosEnvido = 0;
            this.conteoTime = 0;
            this.minutos = 0;
            this.ronda = 1;
            this.rondaJ1 = 0;
            this.rondaJ2 = 0;
            this.mazo = Harcodeo.MazoCartas;
            this.RepartirCartas();
            this.mano = 1;
            this.puntosJ1 = 0;
            this.puntosJ2 = 0;
            this.InicioDelJuego();
            this.QueSeCanto = EQueSeCanto.Nada;
        }
        private void InicioDelJuego()
        {
            if(this.mano == 1)
            {
                this.turnoJ1 = true;
                this.turnoJ2 = false;
                this.pictureBoxMazo1.Visible = true;
                this.pictureBoxMazo2.Visible = false;
            }
            else
            {
                this.turnoJ1 = false;
                this.turnoJ2 = true;
                this.pictureBoxMazo1.Visible = false;
                this.pictureBoxMazo2.Visible = true;
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

        #region Mover imagenes

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

            //Habilitar botones
            this.HabilitarBotonesPorRonda();
        }

        #endregion

        #region Metodos ganadores

        /// <summary>
        /// Compara quien gano en cada ronda y anota que jugador gano en cada ronda
        /// </summary>
        private void GanadorRondas()
        {
            int ganador = JuegoDeCartas.CartaGanadoraTruco(this.cartaJuagadaJ1, this.cartaJuagadaJ2);

            switch (ganador)
            {
                case 1: this.IniciarHiloSecundario("Ganador jugador 1",this.labelCanto); this.turnoJ1 = true; this.turnoJ2 = false; break;
                case 2: this.IniciarHiloSecundario("Ganador jugador 2", this.labelCanto); this.turnoJ1 = false; this.turnoJ2 = true; break;
                case 0:

                    if (this.ronda == 1 || (this.ganadorPrimera == 0 && this.ronda == 2))
                    {
                        this.IniciarHiloSecundario("Parda!", this.labelCanto);
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

            if (this.ganadorPrimera == jugador && (this.ganadorSegunda == jugador || this.ganadorTercera == jugador || 
                this.ganadorSegunda == 0 || this.ganadorTercera == 0))
            {
                this.CambiarLabelPuntoParcialesTruco(jugador);
                this.MensajeGanador(ganadorJ1);
                this.CambiarDataGrid(jugador);
            }
            else if (this.ganadorPrimera == 0 && this.ganadorSegunda == jugador)
            {
                this.CambiarLabelPuntoParcialesTruco(jugador);
                this.MensajeGanador(ganadorJ1);
                this.CambiarDataGrid(jugador);
            }
            else if (this.ganadorPrimera == 0 && this.ganadorSegunda == 0 && this.ganadorTercera == jugador)
            {
                this.CambiarLabelPuntoParcialesTruco(jugador);
                this.MensajeGanador(ganadorJ1);
                this.CambiarDataGrid(jugador);
            }
            else if (this.ganadorPrimera == 0 && this.ganadorSegunda == 0 && this.ganadorTercera == 0 && this.mano == jugador)
            {
                this.CambiarLabelPuntoParcialesTruco(jugador);
                //MessageBox.Show("Entra aca!");
                this.MensajeGanador(ganadorJ1);
                this.CambiarDataGrid(jugador);
            }
            else if(this.ganadorPrimera == jugador && this.ganadorSegunda == this.CambiarJugador(jugador) && this.ganadorTercera == this.CambiarJugador(jugador))
            {
                ganadorJ1 = $"Ganador jugador {this.CambiarJugador(jugador)}";
                this.CambiarLabelPuntoParcialesTruco(this.CambiarJugador(jugador));
                this.MensajeGanador(ganadorJ1);
                this.CambiarDataGrid(jugador);
            }

        }

        /// <summary>
        /// Message box de quien gano el juego
        /// </summary>
        /// <param name="msj"></param>
        private void MensajeGanador(string msj)
        {           
            MessageBox.Show(msj, "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.hayGanador = true;
        }

        #endregion

        #region Metodos dataGridView

        private void CambiarDataGrid(int ganador)
        {
            this.dataGridViewAnotador.Rows.Add(this.puntosJ1, this.puntosJ2);
        }

        #endregion

        #region Labels

        private void CambiarLabelPuntoParcialesTruco(int ganador)
        {
            if(ganador == 1)
            {
                this.puntosJ1 += this.puntoEnjuego;
                this.labelJ1Puntos.Text = $"{this.puntoEnjuego} puntos";
            }
            else if(ganador == 2)
            {
                this.puntosJ2 += this.puntoEnjuego;
                this.labelJ2Puntos.Text = $"{this.puntoEnjuego} puntos";
            }
        }

        private void CambiarLabelYAsignarPuntoEnjuego()
        {
            this.labelPuntoJuego.Text = this.puntoEnjuego.ToString();
            this.labelPuntoEnvido.Text = this.puntosEnvido.ToString();
        }

        private void CambiarTextoLabel(string mensaje,Label label)
        {
            label.Text = mensaje;
            label.Visible = true;
        }

        #endregion

        #region Botones J1

        private void btnQuieroJ1_Click(object sender, EventArgs e)
        {
            this.ContestarQuiero(1);
            //this.IniciarHiloSecundario($"{JuegoDeCartas.CalcularTantos(this.cartasJ1)}");
        }

        private void btnNoQuieroJ1_Click(object sender, EventArgs e)
        {
            this.ContestarNoQuiero(1);
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
            this.CambiarTextoLabel("J1: Flor!",this.labelCanto);
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
            //Le paso el jugador contrario
            this.MeVoyAlMazo(1,2);
        }

        #endregion

        #region Botones J2

        private void btnQuieroJ2_Click(object sender, EventArgs e)
        {
            this.ContestarQuiero(2);
        }

        private void btnNoQuieroJ2_Click(object sender, EventArgs e)
        {
            this.ContestarNoQuiero(2);
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
            this.IniciarHiloSecundario("J2: Flor!", this.labelCanto);
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
            //Le paso el jugador contrario
            this.MeVoyAlMazo(2,1);
        }

        #endregion

        #region Metodos de que se canto

        /// <summary>
        /// Segun lo que este en juego, si quiso el truco se pone en juego 2 puntos.
        /// Si es el envido cada jugador tiene que cantar sus tantos y se pone en juego los puntos necesarios
        /// </summary>
        /// <param name="jugador">1 o 2</param>
        private void ContestarQuiero(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Quiero!", this.labelCanto);

            if(this.QueSeCanto == EQueSeCanto.Envido || this.QueSeCanto == EQueSeCanto.RealEnvido || this.QueSeCanto == EQueSeCanto.FaltaEnvido)
            {
                //Funcion que muestre los puntos de los 2 jugadores
                this.MostrarLosTantos();
                this.GanadorEnvido();
                this.HabilitarBotonesPorRonda();
            }

            if(this.QueSeCanto == EQueSeCanto.Truco || this.QueSeCanto == EQueSeCanto.ReTruco || this.QueSeCanto == EQueSeCanto.ValeCuatro)
            {
                this.CambiarLabelYAsignarPuntoEnjuego();

                this.HabilitarSoloBtnMazo();
            }
            else
            {
                switch (this.QueSeCanto)
                {
                    case EQueSeCanto.Envido: this.CambiarLabelYAsignarPuntoEnjuego(); break;
                    case EQueSeCanto.RealEnvido: this.CambiarLabelYAsignarPuntoEnjuego(); break;
                    case EQueSeCanto.FaltaEnvido: this.CambiarLabelYAsignarPuntoEnjuego(); break;
                }

            }

            this.HabilitarImagenes(true);
        }

        /// <summary>
        /// Segun lo que este en juego, se le asigana el punto al otro jugador. 
        /// Tambien se vuelve habilitar para mover las imagenes(continuar el juego)
        /// </summary>
        /// <param name="jugador"></param>
        private void ContestarNoQuiero(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: No quiero!", this.labelCanto);

            if (this.QueSeCanto == EQueSeCanto.Envido || this.QueSeCanto == EQueSeCanto.RealEnvido || this.QueSeCanto == EQueSeCanto.FaltaEnvido)
            {
                //Funcion que le de los puntos al otro jugador
                this.DarPuntosEnvido(this.CambiarJugador(jugador));
                this.HabilitarBotonesPorRonda();
            }

            if (this.QueSeCanto == EQueSeCanto.Truco || this.QueSeCanto == EQueSeCanto.ReTruco || this.QueSeCanto == EQueSeCanto.ValeCuatro)
            {
                int ganador = this.CambiarJugador(jugador);

                this.puntoEnjuego--;
                this.CambiarLabelYAsignarPuntoEnjuego();

                this.ganadorPrimera = ganador;
                this.ganadorSegunda = ganador;

                this.DesHabilitarBotones(this.groupBoxJ1);
                this.DesHabilitarBotones(this.groupBoxJ2);

                this.GanadorDelJuego(ganador);
            }

            this.HabilitarImagenes(true);
        }
        
        private void CantoTruco(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Truco!", this.labelCanto);

            this.HabilitarBotonesDelTruco(jugador);

            this.QueSeCanto = EQueSeCanto.Truco;
            this.puntoEnjuego ++;
            this.quienCantoTruco = jugador;

            this.HabilitarImagenes(false);
        }
        
        private void ReTruco(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Quiero re truco!", this.labelCanto);

            this.HabilitarBotonesReTruco(jugador);

            this.QueSeCanto = EQueSeCanto.ReTruco;
            this.puntoEnjuego++;
            this.quienCantoTruco = jugador;
            this.HabilitarImagenes(false);
        }

        private void ValeCuatro(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Quiero vale cuatro!", this.labelCanto);
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            this.puntoEnjuego++;
            this.QueSeCanto = EQueSeCanto.ValeCuatro;
            this.HabilitarImagenes(false);
        }

        private void CantoEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador} Envido!", this.labelCanto);
            this.ContadorEnvidos++;

            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnEnvidoJ1, this.btnRealEnvidoJ1, 
                    this.btnFaltaEnvidoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else if(jugador == 1)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2,this.btnEnvidoJ2, this.btnRealEnvidoJ2,
                    this.btnFaltaEnvidoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            if(this.ContadorEnvidos == 2)
            {
                this.btnEnvidoJ1.Enabled = false;
                this.btnEnvidoJ2.Enabled = false;
            }

            this.QueSeCanto = EQueSeCanto.Envido;
            this.HabilitarImagenes(false);
            this.puntosEnvido += 2;
            //MessageBox.Show($"{JuegoDeCartas.CalcularTantos(new Carta[] { this.cartas[0],this.cartas[1],this.cartas[2]})}");
        }

        private void RealEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Real envido!", this.labelCanto);
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnFaltaEnvidoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2,this.btnFaltaEnvidoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }
            this.QueSeCanto = EQueSeCanto.RealEnvido;
            this.puntosEnvido += 2;
            this.HabilitarImagenes(false);
        }

        private void FaltaEnvido(int jugador)
        {
            this.IniciarHiloSecundario($"J{jugador}: Falta envido!", this.labelCanto);
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }

            this.QueSeCanto = EQueSeCanto.FaltaEnvido;
            this.puntosEnvido += 10;
            this.HabilitarImagenes(false);
        }

        /// <summary>
        /// Gana el jugador que no apreto el boton
        /// </summary>
        /// <param name="jugador"></param>
        private void MeVoyAlMazo(int jugador, int jugador2)
        {
            this.ganadorPrimera = jugador2;
            this.ganadorSegunda = jugador2;
            this.GanadorDelJuego(jugador2);

            this.IniciarHiloSecundario($"J{jugador}: Me voy al mazo!", this.labelCanto);

        }

        #endregion

        #region Habilitación botones

        /// <summary>
        /// Inicia botones segun quien sea mano
        /// </summary>
        private void IniciarBotones()
        {
            bool isFlorJ1 = JuegoDeCartas.IsFlor(this.cartasJ1[0], this.cartasJ1[1], this.cartasJ1[2]);
            bool isFlorJ2 = JuegoDeCartas.IsFlor(this.cartasJ2[0], this.cartasJ2[1], this.cartasJ2[2]);

            if (this.turnoJ1)
            {
                if (!isFlorJ1)
                {
                    this.HabilitarBotones(new Button[] { this.btnMazoJ1,this.btnEnvidoJ1,this.btnFaltaEnvidoJ1,this.btnRealEnvidoJ1, this.btnTrucoJ1 },this.groupBoxJ2);
                }
                else if(isFlorJ1)
                {
                    this.HabilitarBotones(new Button[] { this.btnMazoJ1, this.btnFlorJ1, this.btnTrucoJ1 }, this.groupBoxJ2);
                }
            }
            else if(this.turnoJ2)
            {
                if(!isFlorJ2)
                {
                    this.HabilitarBotones(new Button[] { this.btnMazoJ2, this.btnEnvidoJ2, this.btnFaltaEnvidoJ2, this.btnRealEnvidoJ2, this.btnTrucoJ2}, this.groupBoxJ1);
                }
                else if(isFlorJ2)
                {
                    this.HabilitarBotones(new Button[] { this.btnMazoJ2, this.btnFlorJ2, this.btnTrucoJ2 }, this.groupBoxJ1);
                }

            }
        }
         
        /// <summary>
        /// Habilita los botones de un jugador y desahabilita el del otro jugador
        /// </summary>
        /// <param name="btns"></param>
        /// <param name="group"></param>
        private void HabilitarBotones(Button[] btns, GroupBox group)
        {
            this.DesHabilitarBotones(group);

            foreach (Button item in btns)
            {
                item.Enabled = true;
            }

            
        }

        /// <summary>
        /// Desahbilita los botones dentro del groupbox
        /// </summary>
        /// <param name="group"></param>
        private void DesHabilitarBotones(GroupBox group)
        {
            foreach (Button item in group.Controls)
            {
                item.Enabled = false;
            }
        }
        
        /// <summary>
        /// Habilita botones de la primera ronda, analizando todas las posibilidades 
        /// </summary>
        private void HabilitarBotonesSegunTruco()
        {
            //Ya se esta analizando que jugador que canto truco o re truco

            //Se analiza quien fue y se se habilita los botones correspondientes
            if (this.QueSeCanto == EQueSeCanto.Truco)
            {
                //Si fue el jugador 1 quien canto truco y el turno es del jugador 2
                if(this.quienCantoTruco == 1 && this.turnoJ2)
                {
                    //Habilito los botones del truco normal del jugador 2
                    this.HabilitarBotonesDelTruco(this.quienCantoTruco);
                    //Se deshabilita los botones del quiero y no quiero del jugador 2
                    this.btnQuieroJ2.Enabled = false;
                    this.btnNoQuieroJ2.Enabled = false;
                }
                //Si fue el jugador 2 quien canto truco y el turno es del jugador 1
                else if (this.quienCantoTruco == 2 && this.turnoJ1)
                {
                    //Habilito los botones del truco normal del jugador 1
                    this.HabilitarBotonesDelTruco(this.quienCantoTruco);
                    //Se deshabilita los botones del quiero y no quiero del jugador 1
                    this.btnQuieroJ1.Enabled = false;
                    this.btnNoQuieroJ1.Enabled = false;
                }
            }
            // Si lo que esta en juego es el retruco
            else if (this.QueSeCanto == EQueSeCanto.ReTruco)
            {
                // si el que canto re truco es el jugador 2 y el turno es de jugador 1
                if (this.quienCantoTruco == 2 && this.turnoJ1)
                {
                    //Habilito los botones del re truco normal del jugador 1
                    this.HabilitarBotonesReTruco(this.quienCantoTruco);
                    //Se deshabilita los botones del quiero y no quiero del jugador 1
                    this.btnQuieroJ1.Enabled = false;
                    this.btnNoQuieroJ1.Enabled = false;
                }
                // si el que canto re truco es el jugador 1 y el turno es de jugador 2
                else if (this.quienCantoTruco == 1 && this.turnoJ2)
                {
                    //Habilito los botones del re truco normal del jugador 2
                    this.HabilitarBotonesReTruco(this.quienCantoTruco);
                    //Se deshabilita los botones del quiero y no quiero del jugador 2
                    this.btnQuieroJ2.Enabled = false;
                    this.btnNoQuieroJ2.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Habilita los botones para la segunda ronda y deshabilita los que no se usan
        /// </summary>
        private void HabilitarBotones2ronda()
        {
            this.HabilitarSoloBtnMazo();

            //Si todavia no se canto el truco
            if (this.puntoEnjuego == 1)
            { 
                //A jugador 1 cuando sea su turno se la habilita los botones de truco y mazo y se desahbilita los botones al jugador 2
                if (this.turnoJ1)
                {
                    this.DesHabilitarBotones(this.groupBoxJ1);
                    this.HabilitarBotones(new Button[] { this.btnTrucoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
                }
                //A jugador 2 cuando sea su turno se la habilita los botones de truco y mazo y se desahbilita los botones al jugador 1
                else if (this.turnoJ2)
                {
                    this.DesHabilitarBotones(this.groupBoxJ2);
                    this.HabilitarBotones(new Button[] { this.btnTrucoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
                }
            
            }
            //Si ya esta en juego el truco o re truco
            else if(this.puntoEnjuego >= 2)
            {
                //Esta funcion analiza todas las posibilidades y asigna los botones segun corresponda
                this.HabilitarBotonesSegunTruco();
            }
        }

        /// <summary>
        /// Habilita el boton de mazo, dependiendo el turno de cada jugador
        /// </summary>
        private void HabilitarSoloBtnMazo()
        {
            this.DesHabilitarBotones(this.groupBoxJ1);
            this.DesHabilitarBotones(this.groupBoxJ2);

            if (this.turnoJ1)
            {
                this.HabilitarBotones(new Button[] { this.btnMazoJ1 },this.groupBoxJ1);
            }
            else if (this.turnoJ2)
            {
                this.HabilitarBotones(new Button[] { this.btnMazoJ2 }, this.groupBoxJ2);
            }
        }

        /// <summary>
        /// Segun en que ronda este va habilitando botones y deshabilitando otros
        /// </summary>
        private void HabilitarBotonesPorRonda()
        {
            switch(this.ronda)
            {
                case 1:
                    
                    if (this.puntoEnjuego >= 2 || this.puntosEnvido > 0)
                    {
                        this.HabilitarBotones2ronda();
                    }
                    else if (this.puntoEnjuego == 1)
                    {
                        this.IniciarBotones();
                    }
                    break;

                case 2: this.HabilitarBotones2ronda(); break;

                default:
                    this.HabilitarBotones2ronda();
                    if (this.hayGanador)
                    {
                        this.DesHabilitarBotones(this.groupBoxJ1);
                        this.DesHabilitarBotones(this.groupBoxJ2);
                    }
                    break;
            }
        }

        private void HabilitarBotonesDelTruco(int jugador)
        {
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnReTrucoJ1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else if (jugador == 1)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnReTrucoJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }
        }

        private void HabilitarBotonesReTruco(int jugador)
        {
            if (jugador == 2)
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ1, this.btnNoQuieroJ1, this.btnVale4J1, this.btnMazoJ1 }, this.groupBoxJ2);
            }
            else
            {
                this.HabilitarBotones(new Button[] { this.btnQuieroJ2, this.btnNoQuieroJ2, this.btnValeCuatroJ2, this.btnMazoJ2 }, this.groupBoxJ1);
            }
        }

        #endregion

        #region Inhabilitar imagenes
        
        /// <summary>
        /// Cambia el enabled de las imagenes segun lo pasado por parametro
        /// </summary>
        /// <param name="habiltacion"></param>
        private void HabilitarImagenes(bool habiltacion)
        {
            foreach (Control item in this.panelMesa.Controls)
            {
                if(item is PictureBox)
                {
                    ((PictureBox)item).Enabled = habiltacion;
                }
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
            //this.cartas[0] = new Carta(3, ETipoCarta.Oro);
            //this.cartas[1] = new Carta(1, ETipoCarta.Oro);
            //this.cartas[2] = new Carta(12, ETipoCarta.Espada);
            this.cartasJ1 = new Carta[] { this.cartas[0], this.cartas[1], this.cartas[2] };
            //this.cartas[3] = new Carta(3, ETipoCarta.Copa);
            //this.cartas[4] = new Carta(1, ETipoCarta.Copa);
            //this.cartas[5] = new Carta(2, ETipoCarta.Copa);
            this.cartasJ2 = new Carta[] { this.cartas[3], this.cartas[4], this.cartas[5] };

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
        
        private void IniciarHiloSecundario(string msj,Label label)
        {
            Task hilo = new Task(() => this.MostrarInformacionConPausa(msj,label));
            hilo.Start();
        }
        
        private void OcultarLabel(Label label)
        {
            label.Visible = false;
        }

        /// <summary>
        /// Muestro la inforamcion en un hilo secundario de manera recursiva
        /// </summary>
        /// <param name="numero"></param>
        private void MostrarInformacionConPausa(string msj, Label label)
        {
            //Pregunta si esta iniciando en un hilo distinto al formulario
            if (this.InvokeRequired)
            {
                Action ocultar = () => this.OcultarLabel(label);
                Action<string,Label> action = this.MostrarInformacionConPausa;
                //invoca el mismo metodo que lo esta llamando en el hilo principal
                this.Invoke(action,new object[] {msj,label});
                Thread.Sleep(3000);
                this.Invoke(ocultar);
            }
            else
            {
                this.CambiarTextoLabel(msj,label);
            }

        }

        #endregion

        #region Metodos Envido

        private void GanadorEnvido()
        {
            int ganadorEnvido = JuegoDeCartas.GanadorEnvido(this.cartasJ1, this.cartasJ2, this.mano);
            if(ganadorEnvido == 1)
            {
                this.puntosJ1 += this.puntosEnvido;
                this.labelJ1Puntos.Text = $"{this.puntosEnvido} puntos";
            }
            else if (ganadorEnvido == 2)
            {
                this.puntosJ2 += this.puntosEnvido;
                this.labelJ2Puntos.Text = $"{this.puntosEnvido} puntos";
            }
            this.MensajeGanador($"Gano los tantos jugador {ganadorEnvido}");
        }

        private void MostrarLosTantos()
        {
            int tantoJ1 = JuegoDeCartas.CalcularTantos(this.cartasJ1);
            int tantoJ2 = JuegoDeCartas.CalcularTantos(this.cartasJ2);

            this.IniciarHiloSecundario($"Tantos J1: {tantoJ1}", this.labelTantoJ1);
            this.IniciarHiloSecundario($"Tantos J2: {tantoJ2}", this.labelTantosJ2);

        }

        private void DarPuntosEnvido(int jugador)
        {
            if (jugador == 1)
            {
                this.puntosJ1 += this.puntosEnvido;
            }
            else if(jugador == 2)
            {
                this.puntosJ2 += this.puntosEnvido;
            }

        }

        #endregion

        #region Metodos generales

        private int CambiarJugador(int jugador)
        {
            int retorno = 2;
            
            if (jugador == 2)
            {
                retorno = 1;
            }

            return retorno;
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
