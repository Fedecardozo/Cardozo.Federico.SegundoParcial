using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JuegoDeCartas
    {
        #region Atributos

        private Jugador jugador1;
        private Jugador jugador2;
        private MazoCartas mazo;

        #endregion

        #region Constructor
        public JuegoDeCartas(Jugador jugador1, Jugador jugador2, MazoCartas mazo)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.mazo = mazo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Reparte las cartas a 2 jugadore sin que se repitan las cartas
        /// </summary>
        public void EmpezarTruco()
        {
            int cantidadCartas = 3;
            List<Carta> cartasSacadasDelmazo = new List<Carta>();
            Carta[] cartas = new Carta[cantidadCartas];

            //Repartir cartas a cada jugador sacando las cartas del mazo
            for (int i = 0; i < 2; i++)
            {
                //Obtener cartas
                cartas = this.mazo.RepartirCartas(cantidadCartas);

                for (int j = 0; j < cantidadCartas; j++)
                {
                    //Saco las cartas del mazo
                    this.mazo.QuitarCarta(cartas[j]);

                    //Guardo las cartas sacadas del mazo
                    cartasSacadasDelmazo.Add(cartas[j]);
                }

                //Agrego las cartas a cada jugador
                switch(i)
                {
                    case 0: this.jugador1.AgregarCarta(cartas); break;
                    case 1: this.jugador2.AgregarCarta(cartas); break;
                }

            }

            //Devuelvo al mazo las cartas quitadas
            foreach (Carta item in cartasSacadasDelmazo)
            {
                this.mazo.AgregarCarta(item);
            }
        }

        #endregion

    }
}
