using System;
using Entidades;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sala> salas;

            Sala sala = new Sala("Jugador 1", "Jugador 2","Verde",2,EestadoPartida.En_juego);

            sala.Id = 35;

            Console.WriteLine("Se elimino: " + sala.Delete_Sql());

            sala.Id = 36;

            Console.WriteLine("Se elimino: " + sala.Delete_Sql());


            if (Sala.ObtenerListaSala_Sql(out salas))
            {
                Console.WriteLine("Salas: ");

                foreach (Sala item in salas)
                {
                    Console.WriteLine(item.ToString());
                }

            }

        }

    }
}
