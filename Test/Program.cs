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
            List<Usuario> usuarios;

            if (!Usuario.DeserializarJson(out usuarios))
            {
                Console.WriteLine("Un exito!");

                foreach (Usuario item in usuarios)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            if (Sala.DeserializarJson(out List<Sala> salas))
            {
                Console.WriteLine("Un exito!");

                foreach (Sala item in salas)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }

    }
}
