using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        #region Atributos

        private string nick;
        private int cantidadCartas;
        private List<Carta> cartas;

        #endregion

        #region Constructor

        public Jugador(string nick, int cantidaCartas)
        {
            this.nick = nick;
            this.cantidadCartas = cantidaCartas;
            this.cartas = new List<Carta>();
        }

        #endregion

        #region Propiedades

        public Carta this[int index]
        {
            get 
            {
                Carta carta;
                //Despues intentar hacer con exepciones
                if(index >= 0 && index < this.cartas.Count)
                {
                    carta = this.cartas[index];
                }
                else
                {
                    carta = null;
                }

                return carta;
            }
        }

        public string Nick { get { return this.nick; } }

        #endregion

        #region Sobrecarga operadores

        /// <summary>
        /// Si no se encuentra la carta la agrega a la mano del jugador
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="jugador"></param>
        /// <returns>true si se pudo agregar. False sino</returns>
        public static bool operator +(Jugador jugador, Carta c1)
        {
            bool retorno = false;

            if(jugador.cartas.Count < jugador.cantidadCartas)
            {
                jugador.cartas.Add(c1);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Agrega una carta al mazo
        /// </summary>
        /// <param name="carta"></param>
        /// <returns> true si puedo agregar la carta. false sino</returns>
        public bool AgregarCarta(Carta carta)
        {
            return this + carta;
        }

        /// <summary>
        /// Agrega una carta al mazo
        /// </summary>
        /// <param name="carta"></param>
        /// <returns> true si puedo agregar la carta. false sino</returns>
        public bool AgregarCarta(Carta[] carta)
        {
            bool retorno = false;

            foreach (Carta item in carta)
            {
                retorno = this + item;
            }

            return retorno;
        }
        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nick: " + this.nick);
            sb.AppendLine("Cantidad de cartas: " + this.cantidadCartas);

            foreach (Carta item in this.cartas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

    }
}
