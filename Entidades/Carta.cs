using System;

namespace Entidades
{
    public class Carta
    {
        #region Atributos

        private int numero;
        private ETipoCarta tipo;

        #endregion

        #region Propiedades

        public int Numero { get { return this.numero; } }

        public ETipoCarta Tipo { get { return this.tipo; } }

        #endregion

        #region Constructores

        public Carta(int numero, ETipoCarta tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Carta c1, Carta c2)
        {
            if(c1 is not null && c2 is not null)
            {
                return c1.tipo == c2.tipo && c1.numero == c2.numero;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Carta c1, Carta c2)
        {
            return !(c1 == c2);
        }

        #endregion

        #region Polimorfismo

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Carta)
            {
                retorno = ((Carta)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            return $"{this.numero} {this.tipo.ToString()}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}
