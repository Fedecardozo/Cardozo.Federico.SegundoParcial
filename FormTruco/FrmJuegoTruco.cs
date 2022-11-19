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
        #region Atributos

        private int conteoTime;
        private int minutos;
        private int ronda;
        private int rondaJ1;
        private int rondaJ2;
        private bool turnoJ1;
        private bool turnoJ2;
        #endregion

        #region Inicio Form

        public FrmJuegoTruco()
        {
            InitializeComponent();
        }
        private void FrmJuegoTruco_Load(object sender, EventArgs e)
        {
            this.conteoTime = 0;
            this.minutos = 0;
            this.ronda = 1;
            this.rondaJ1 = 1;
            this.rondaJ2 = 1;
            this.turnoJ1 = true;
            this.turnoJ2 = false;
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

        #region Funcionalidad de botones


        #endregion

        #region Picture cartas J1
        
        private void pictureBoxJ1C1_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C1);
        }

        private void pictureBoxJ1C2_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C2);
        }

        private void pictureBoxJ1C3_Click(object sender, EventArgs e)
        {
            this.MovientoJ1(this.pictureBoxJ1C3);
        }

        #endregion

        #region Picture cartas J2

        private void pictureBoxJ2C1_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C1);
        }

        private void pictureBoxJ2C2_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C2);
        }

        private void pictureBoxJ2C3_Click(object sender, EventArgs e)
        {
            this.MovientoJ2(this.pictureBoxJ2C3);
        }

        #endregion

        #region Metodos movimientos de cartas

        /// <summary>
        /// Si es el turno del jugador 1, dependiendo la ronda va a mover la carta que haya jugado
        /// a la mesa
        /// </summary>
        /// <param name="picture"></param>
        private void MovientoJ1(PictureBox picture)
        {
            //picture.Location = new Point(picture.Location.X, 420);
            if(this.turnoJ1)
            {
                this.rondaJ1++;

                switch(this.ronda)
                {
                    case 1: this.MoverImagen(picture,this.pictureBoxPrimeraJ1);  break;
                    case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ1); break;
                    case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ1); break;
                }

                this.turnoJ1 = false;
                this.turnoJ2 = true;
            }
        }

        /// <summary>
        /// Si es el turno del jugador 2, dependiendo la ronda va a mover la carta que haya jugado
        /// a la mesa
        /// </summary>
        /// <param name="picture"></param>
        private void MovientoJ2(PictureBox picture)
        {
            //picture.Location = new Point(picture.Location.X, 210);
            if (this.turnoJ2)
            {
                this.rondaJ2++;
                
                switch (this.ronda)
                {
                    case 1: this.MoverImagen(picture, this.pictureBoxPrimeraJ2); break;
                    case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ2); break;
                    case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ2); break;
                }

                this.turnoJ1 = true;
                this.turnoJ2 = false;
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
            
            if(this.rondaJ1 == this.rondaJ2)
            {
                this.ronda++;
            }
        }

        #endregion

    }
}
