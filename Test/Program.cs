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
            int cont = 0;
            Console.WriteLine("Lista usuarios: " + Usuario.ObtenerListaUsuarios(out List<Usuario> usuarios));

            foreach (Usuario item in usuarios)
            {
                if(item is not null)
                {
                    Console.WriteLine(item.ToString());
                }
                else if(item is null)
                {
                    cont++;
                }

            }

            Console.WriteLine("Fallo: " + cont);

        }

    }
}
