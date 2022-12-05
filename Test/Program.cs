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

            Resultado resultado = new Resultado("Fede", "Lea", 0, 0, eResultado.Sin_Iniciar);

            if(!resultado.Insert_Sql())
            {
                Console.WriteLine("Fallo!");
            }
            else
            {
                Console.WriteLine(resultado.ToString() + "\nId: " + resultado.Id);
            }

        }

    }
}
