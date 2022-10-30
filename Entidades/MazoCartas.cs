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

                if(this.cartas.Count == this)
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
                Carta carta = null;

                if(index > 0 && index <= this.cartas.Count)
                {
                    carta = this.cartas[index];
                }

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
            }

            return retorno;
        }

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

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de cartas: " + this);
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
