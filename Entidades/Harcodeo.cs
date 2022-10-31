using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Harcodeo
    {
        private static MazoCartas mazoCartas;

        static Harcodeo()
        {
            //Harcodeo.mazoCartas = new MazoCartas(ECantidadCartas.Cuarenta);
        }

        public static void Global()
        {
            Harcodeo.mazoCartas = new MazoCartas(ECantidadCartas.Cuarenta);
            Harcodeo.LlenarMazo();
        }

        public static MazoCartas MazoCartas { get { return Harcodeo.mazoCartas; } }

        public static void LlenarMazo()
        {
            Harcodeo.CargarCartas(10, ETipoCarta.Espada);
            Harcodeo.CargarCartas(10, ETipoCarta.Basto);
            Harcodeo.CargarCartas(10, ETipoCarta.Oro);
            Harcodeo.CargarCartas(10, ETipoCarta.Copa);
        }

        public static void CargarCartas(int cantidad, ETipoCarta tipoCarta)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                if(i <= 7)
                {
                    Harcodeo.mazoCartas.AgregarCarta(new Carta(i, tipoCarta));
                }
                else if(i > 7 && i <= 10)
                {
                    Harcodeo.mazoCartas.AgregarCarta(new Carta(i+2, tipoCarta));
                }

            }
        }

    }
}
