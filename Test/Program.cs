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
            //Console.WriteLine("Mazo completo de cartas: ");

            //Harcodeo.Global();


            //for (int i = 0; i < 40; i++)
            //{
            //    Console.WriteLine(JuegoDeCartas.Mazo.Cartas[i].ToString());
            //}


            #region Serializar Json cartas 50
            /*
            string path2 = @"..\..\..\..\Archivos\MazoCartas50.json";

            Harcodeo.CargarCartas50(ETipoCarta.Espada);
            Harcodeo.CargarCartas50(ETipoCarta.Basto);
            Harcodeo.CargarCartas50(ETipoCarta.Oro);
            Harcodeo.CargarCartas50(ETipoCarta.Copa);
            Harcodeo.mazoCartas2.AgregarCarta(new Carta(13,ETipoCarta.Comodin));
            Harcodeo.mazoCartas2.AgregarCarta(new Carta(14, ETipoCarta.Comodin));

            foreach (Carta item in Harcodeo.mazoCartas2.Cartas)
            {
                Console.WriteLine(item.ToString());
            }


            if(Serializacion.SerializarJson<Carta>(path2, Harcodeo.mazoCartas2.Cartas))
            {
                Console.WriteLine("Un exito!");
            }
            */
            #endregion

            #region Deserializar Json
            /*
            string path = @"..\..\..\..\Archivos\MazoCartas40.json";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            List<Carta> listCartasJson;

            if(Serializacion.DeserializarJson<Carta>(path,out listCartasJson))
            {
                Console.WriteLine("Un Exito!");

                foreach (Carta item in listCartasJson)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            */

            #endregion

            if(ControlSql.ProbarConexion())
            {
                Console.WriteLine("Un exito!");
            }

            #region Sql

            #region Select

            //string select = " select id, correo, nombre, apellido from [Base_Truco].[dbo].[usuarios]";

            //List<Usuario> usuarios = new List<Usuario>();

            //ControlSql.RealizarConsultaSql(select,Usuario.ConsultaSql, usuarios);

            //foreach (Usuario item in usuarios)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            #endregion

            #region Select 2

            //Console.WriteLine("Se encontro usuario: " + 
            //    ControlSql.RealizarConsultaSql("select id, correo, nombre, apellido from [Base_Truco].[dbo].[usuarios] where correo = 'fff@gmail.com'"));

            #endregion

            #endregion

           //Console.WriteLine(" ultimo id: " + Sala.ultimoId);
        }
        //private static List<Usuario> usuarios;

    }
}
