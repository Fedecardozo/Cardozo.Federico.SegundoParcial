using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Entidades
{
    public static class JuegoDeCartas
    {
        #region Atributos

        private static string path; 
        private static MazoCartas mazo;

        #endregion

        #region Constructor

        static JuegoDeCartas()
        {
            JuegoDeCartas.path = @"..\..\..\..\Archivos\MazoCartas40.json";
            JuegoDeCartas.CargarMazo40();
        }

        #endregion

        #region Propiedades

        public static MazoCartas Mazo { get { return JuegoDeCartas.mazo; } }

        #endregion

        #region Cargar Mazo

        private static void CargarMazo40()
        {
            //bool retorno = false;
            List<Carta> cartas;
            if(Serializacion.DeserializarJson<Carta>(JuegoDeCartas.path,out cartas))
            {
                JuegoDeCartas.mazo = new MazoCartas(cartas,ECantidadCartas.Cuarenta);
                //retorno = true;
            }
            //return retorno;
        }

        #endregion

        #region Logica del truco

        /// <summary>
        /// Valores de las cartas en el truco
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns> 1 si carta 1(c1) tiene mas valor que carta 2(c2). 0 si son iguales. 2 si carta 2(c2) tiene mas valor que carta 1(c1)</returns>
        public static int CartaGanadoraTruco(Carta c1, Carta c2)
        {
            int retorno = 2;

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
                        if (!(c2.Numero == 2 || c2.Numero == 3))
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
                    case 5:
                        if (c2.Numero == 4)
                        {
                            retorno = 1;
                        }
                        break;
                    case 6:
                        if (c2.Numero == 4 || c2.Numero == 5)
                        {
                            retorno = 1;
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

        /// <summary>
        /// Se fija quien gano en el envido
        /// </summary>
        /// <param name="cartasJ1"></param>
        /// <param name="cartasJ2"></param>
        /// <param name="mano"></param>
        /// <returns>(1) Gana jugador 1 (2) Gana jugador 2</returns>
        public static int GanadorEnvido(Carta[] cartasJ1, Carta[] cartasJ2, int mano)
        {
            //arranca ganando jugador 2
            int retorno = 2;

            int tantoJ1 = JuegoDeCartas.CalcularTantos(cartasJ1);
            int tantoJ2 = JuegoDeCartas.CalcularTantos(cartasJ2);

            //gana jugador 1
            if(tantoJ1 > tantoJ2)
            {
                retorno = 1;
            }
            //si son iguales gana quien es mano
            else if(tantoJ2 == tantoJ1)
            {
                retorno = mano;
            }

            return retorno;
        }

        /// <summary>
        /// Calcula los tantos de las cartas
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns>Devuelve el total de tantos</returns>
        public static int CalcularTantos(Carta[] cartas)
        {
            int retorno = 0;
            bool isFlor;
            
            if(cartas.Length == 3)
            {
                isFlor = JuegoDeCartas.IsFlor(cartas[0],cartas[1],cartas[2]);

                if(isFlor)
                {
                    retorno = (cartas[0].ValorCartaEnvido + cartas[1].ValorCartaEnvido + cartas[2].ValorCartaEnvido) + 20; 
                }
                else
                {
                    if(cartas[0] == cartas[1].Tipo)
                    {
                        retorno = (cartas[0].ValorCartaEnvido + cartas[1].ValorCartaEnvido) + 20;
                    }
                    else if(cartas[1] == cartas[2].Tipo)
                    {
                        retorno = (cartas[1].ValorCartaEnvido + cartas[2].ValorCartaEnvido) + 20;
                    }
                    else if (cartas[0] == cartas[2].Tipo)
                    {
                        retorno = (cartas[0].ValorCartaEnvido + cartas[2].ValorCartaEnvido) + 20;
                    }
                    else
                    {
                        retorno = JuegoDeCartas.BuscarMaximoValor(cartas);
                    }
                }

            }

            return retorno;
        }

        /// <summary>
        /// Busca la carta con mas valor para el envido
        /// </summary>
        /// <param name="cartas"></param>
        /// <returns>la carta con mas valor para el envido</returns>
        private static int BuscarMaximoValor(Carta[] cartas)
        {
            int retorno = 0;
            
            for(int i=0; i < cartas.Length; i++)
            {
                if(cartas[i].ValorCartaEnvido > retorno)
                {
                    retorno = cartas[i].ValorCartaEnvido;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si hay flor o no
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="c3"></param>
        /// <returns>true hay flor, false no hay</returns>
        public static bool IsFlor(Carta c1, Carta c2, Carta c3)
        {
            //No hay flor 
            bool retorno = false;

            //Entra si hay flor
            if (c1 == c2.Tipo && c1 == c3.Tipo)
            {
                //Hay flor
                retorno = true;
            }

            return retorno;
        }

        #endregion

    }
}
