using System;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Carta carta = new Carta(1,ETipoCarta.Espada);
            MazoCartas mazoCartas = new MazoCartas(ECantidadCartas.Cuarenta);

            bool flag = mazoCartas.AgregarCarta(carta);

            Console.WriteLine(flag);

            Console.WriteLine(carta.ToString());*/

            /*Harcodeo.Global();

            MazoCartas mazo = Harcodeo.MazoCartas;

            Console.WriteLine($"{mazo.ToString()}");

            Jugador jugador = new Jugador("Fede",3);
            Jugador jugador2 = new Jugador("Alan", 3);

            //mazo.RepartirCartas(3,jugador);
            //mazo.RepartirCartas(3, jugador2);

            JuegoDeCartas truco = new JuegoDeCartas(jugador,jugador2,mazo);

            truco.EmpezarTruco();

            Console.WriteLine(jugador.ToString());
            Console.WriteLine(jugador2.ToString());*/

            /*for (int i = 1; i < 13; i++)
            {

                Carta c1 = new Carta(i, ETipoCarta.Oro);
                Carta c2 = new Carta(i, ETipoCarta.Copa);

                Console.WriteLine("Carta 1: " + c1.ToString());
                Console.WriteLine("Carta 2: " + c2.ToString());

                int resultado = JuegoDeCartas.CartaGanadoraTruco(c1, c2);

                if (resultado == 1)
                {
                    Console.WriteLine("Mas grande carta 1");
                }
                else if (resultado == 0)
                {
                    Console.WriteLine("Son iguales ");
                }
                else if (resultado == -1)
                {
                    Console.WriteLine("Mas grande carta 2");
                }
                else
                {
                    Console.WriteLine("Algo fallo");
                }
            }*/

            Carta c1 = new Carta(5, ETipoCarta.Oro);
            Carta c2 = new Carta(6, ETipoCarta.Copa);

            int resultado = JuegoDeCartas.CartaGanadoraTruco(c1, c2);

            if (resultado == 1)
            {
                Console.WriteLine("Mas grande carta 1");
            }
            else if (resultado == 0)
            {
                Console.WriteLine("Son iguales ");
            }
            else if (resultado == -1)
            {
                Console.WriteLine("Mas grande carta 2");
            }
            else
            {
                Console.WriteLine("Algo fallo");
            }

        }
    }
}
