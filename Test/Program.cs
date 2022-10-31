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

            Harcodeo.Global();

            MazoCartas mazo = Harcodeo.MazoCartas;

            Console.WriteLine($"{mazo.ToString()}");

            Jugador jugador = new Jugador("Fede",3);
            Jugador jugador2 = new Jugador("Alan", 3);

            mazo.RepartirCartas(3,jugador);
            mazo.RepartirCartas(3, jugador2);

            Console.WriteLine(jugador.ToString());
            Console.WriteLine(jugador2.ToString());

        }
    }
}
