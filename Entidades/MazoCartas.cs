using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MazoCartas
    {

        #region Atributos

        private ECantidadCartas cantidad;
        private List<Carta> cartas;

        #endregion

        #region Constructor
        public MazoCartas(ECantidadCartas cantidad)
        {
            this.cantidad = cantidad;
            this.cartas = new List<Carta>();
        }

        #endregion

        #region Propiedades

        public bool MazoCompleto 
        { 
            get 
            {
                bool retorno = false;

                if(this.cartas.Count == (int)this)
                {
                    retorno = true;
                }

                return retorno;
            } 
        }

        public Carta this[int index]
        {
            get 
            {
                Carta carta;

                if (index >= 0 && index < this.cartas.Count)
                {
                    carta = this.cartas[index];
                }
                else
                    carta = null;

                return carta;
            } 
        }

        #endregion

        #region Sobrecarga operadores

        /// <summary>
        /// Si no se encuentra la carta la agrega al mazo
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="mazo"></param>
        /// <returns>true si se pudo agregar. False sino</returns>
        public static bool operator +(MazoCartas mazo, Carta c1)
        {
            bool retorno = false;
            int indice = mazo.BuscarCarta(c1);

            if (indice < 0)
            {
                mazo.cartas.Add(c1);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sino se encuentra la carta la quita al mazo
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="mazo"></param>
        /// <returns>true si se pudo quitar. False sino</returns>
        public static bool operator -(MazoCartas mazo, Carta c1)
        {
            bool retorno = false;

            int indice = mazo.BuscarCarta(c1);

            if (indice >= 0)
            {
                mazo.cartas.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve de cuantas cartas es el mazo
        /// </summary>
        /// <param name="mazo"></param>
        public static implicit operator int(MazoCartas mazo)
        {
            return (int)mazo.cantidad;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Busca si la carta pasada por parametro esta dentro del mazo
        /// </summary>
        /// <param name="carta"></param>
        /// <returns>mayor a 0 si encuentra la carta. -1 sino la encuentra</returns>
        private int BuscarCarta(Carta carta)
        {
            int retorno = -1;

            for (int i = 0; i < this.cartas.Count; i++)
            {
                if(this[i] == carta)
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;
        }
        
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
        /// Quita una carta del mazo
        /// </summary>
        /// <param name="carta"></param>
        /// <returns>true si puedo quitar la carta. false sino</returns>
        public bool QuitarCarta(Carta carta)
        {
            return this - carta;
        }

        /// <summary>
        /// Reparte cartas del mazo sin quitarlas
        /// </summary>
        /// <param name="cantidadCartas"></param>
        /// <returns>Un array de cartas</returns>
        public Carta[] RepartirCartas(int cantidadCartas)
        {
            Random random = new Random();
            int index;
            Carta[] retorno;

            if (cantidadCartas > 0)
            {
                retorno = new Carta[cantidadCartas];

                for (int i = 0; i < cantidadCartas; i++)
                {
                    index = random.Next(0, (int)this - 1);

                    retorno[i] = this[index];
                }
            }
            else
            {
                //Lanzar exepcion
                retorno = null;
            }

            return retorno;

        }

        /// <summary>
        /// Reparte cartas del mazo a un jugador sin quitarlas
        /// </summary>
        /// <param name="cantidadCartas"></param>
        /// <param name="jugador"></param>
        /// <returns> true si le pudo repartir cartas al jugador. false sino</returns>
        public Carta[] RepartirCartas(int cantidadCartas, Jugador jugador)
        {
            Random random = new Random();
            Carta[] retorno;

            if(jugador is not null && cantidadCartas > 0)
            {
                retorno = this.RepartirCartas(cantidadCartas);
                jugador.AgregarCarta(retorno); 
            }
            else
            {
                retorno = null;
            }

            return retorno;

        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de cartas: {(int)this}");
            sb.AppendLine("Cartas del mazo: ");

            foreach (Carta item in this.cartas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

    }
}
