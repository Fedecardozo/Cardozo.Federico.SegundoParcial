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

        public JuegoDeCartas(MazoCartas mazo)
        {
            this.mazo = mazo;
        }

        public JuegoDeCartas(Jugador jugador1, Jugador jugador2, MazoCartas mazo) : this(mazo)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
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
                switch (i)
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

        #region Logica del truco

        /// <summary>
        /// Valores de las cartas en el truco
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns> 1 si c1 tiene mas valor que c2. 0 si son iguales. -1 si c2 tiene mas valor que c1</returns>
        public static int CartaGanadoraTruco(Carta c1, Carta c2)
        {
            int retorno = -1;

            Carta[] cartasGanadoras =
            {
                new Carta(1,ETipoCarta.Espada),
                new Carta(1,ETipoCarta.Basto),
                new Carta(7,ETipoCarta.Espada),
                new Carta(7,ETipoCarta.Oro),
            };

            bool c2IgualCartaGanadoras = c2 != cartasGanadoras[0] && c2 != cartasGanadoras[1] && c2 != cartasGanadoras[2] && c2 != cartasGanadoras[3];

            //Verifico si c1 es el uno de espada
            if (c1 == cartasGanadoras[0])
            {
                retorno = 1;
            }
            //c1 es el uno de basto y c2 no es el uno de espada. 
            else if(c1 == cartasGanadoras[1] && c2 != cartasGanadoras[0])
            {
                retorno = 1;
            }
            //c1 es el siete espada y c2 no es el uno de espada, ni el uno de basto. 
            else if (c1 == cartasGanadoras[2] && c2 != cartasGanadoras[0] && c2 != cartasGanadoras[1])
            {
                retorno = 1;
            }
            //c1 es el siete oro y c2 no es el uno de espada, ni el uno de basto, ni el 7 de espada.
            else if (c1 == cartasGanadoras[3] && c2IgualCartaGanadoras)
            {
                retorno = 1;
            }
            //Sino si los numeros son iguales retorna 0
            else if(c2IgualCartaGanadoras && c1.Numero == c2.Numero)
            {
                retorno = 0;
            }
            else if(c2IgualCartaGanadoras)
            {
                switch (c1.Numero)
                {
                    case 1:
                        if (!(c2.Numero > 1 && c2.Numero <= 3))
                        {
                            retorno = 1;
                        }
                        break;
                    case 2:
                        if (!(c2.Numero == 3))
                        {
                            retorno = 1;
                        }
                        break;
                    case 3:
                        retorno = 1;
                        break;
                    case 4:
                        if(c2.Numero != 4)
                        {
                            retorno = -1;
                        }
                        break;
                    case 5:
                        if (c2.Numero != 4 && c2.Numero != 5)
                        {
                            retorno = -1;
                        }
                        break;
                    case 6:
                        if (c2.Numero != 4 && c2.Numero != 5 && c2.Numero != 6)
                        {
                            retorno = -1;
                        }
                        break;
                    case 7:
                        if (c2.Numero == 4 || c2.Numero == 5 || c2.Numero == 6)
                        {
                            retorno = 1;
                        }
                        break;
                    case 10:
                        if (c2.Numero == 4 || c2.Numero == 5 || c2.Numero == 6 || c2.Numero == 7)
                        {
                            retorno = 1;
                        }
                        break;
                    case 11:
                        if (c2.Numero == 4 || c2.Numero == 5 || c2.Numero == 6 || c2.Numero == 7 || c2.Numero == 10)
                        {
                            retorno = 1;
                        }
                        break;
                    case 12:
                        if (c2.Numero == 4 || c2.Numero == 5 || c2.Numero == 6 || c2.Numero == 7 || c2.Numero == 10 || c2.Numero == 11)
                        {
                            retorno = 1;
                        }
                        break;
                }
            }

            return retorno;
        }

        #endregion

    }
}
