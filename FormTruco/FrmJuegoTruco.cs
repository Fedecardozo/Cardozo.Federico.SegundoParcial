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

        private void MovientoJ1(PictureBox picture)
        {
            //picture.Location = new Point(picture.Location.X, 420);
            switch(this.ronda)
            {
                case 1: this.MoverImagen(picture,this.pictureBoxPrimeraJ1);  break;
                case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ1); break;
                case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ1); break;
            }
            
        }
        private void MovientoJ2(PictureBox picture)
        {
            //picture.Location = new Point(picture.Location.X, 210);
            switch (this.ronda)
            {
                case 1: this.MoverImagen(picture, this.pictureBoxPrimeraJ2); break;
                case 2: this.MoverImagen(picture, this.pictureBoxSegundaJ2); break;
                case 3: this.MoverImagen(picture, this.pictureBoxTerceraJ2); break;
            }
        }

        private void MoverImagen(PictureBox picture, PictureBox pictureMesa)
        {
            pictureMesa.Image = picture.Image;
            pictureMesa.Visible = true;
            picture.Visible = false;
            //this.ronda++;
        }

        #endregion

    }
}
