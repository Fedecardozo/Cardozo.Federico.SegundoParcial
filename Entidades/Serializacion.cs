using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Entidades
{
    public static class Serializacion 
    {
        //private string path = @"..\..\..\..\Archivos\MazoCartas40.json";

        #region Deserializar Json

        /// <summary>
        /// Deserializa una lista de objetos genericos
        /// </summary>
        /// <param name="path"></param>
        /// <param name="listJson"></param>
        /// <returns>true o false</returns>
        public static bool DeserializarJson<T>(string path,out List<T> listJson)
        {
            bool retorno = true;
            StreamReader leerJson;
            listJson = new List<T>();

            try
            {
                using (leerJson = new StreamReader(path))
                {
                    string json = leerJson.ReadToEnd();

                    listJson = JsonSerializer.Deserialize<List<T>>(json);
                }
            }
            catch (Exception)
            {
                //Lanzar una expecion propia
                Console.WriteLine("Fallo");
                retorno = false;
            }

            return retorno;
        }

        #endregion

        #region Serializar Json

        /// <summary>
        /// Serializar una lista de objetos en json de forma generica
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="listaJson"></param>
        /// <returns>true o false</returns>
        public static bool SerializarJson<T>(string path,List<T> listaJson)
        {
            bool retorno = true;
            StreamWriter escribirJson;

            try
            {
                using (escribirJson = new StreamWriter(path))
                {
                    string objJson = JsonSerializer.Serialize(listaJson);
                    escribirJson.Write(objJson);
                }
            }
            catch (Exception e)
            {
                retorno = false;
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        #endregion
    }
}
