using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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


        public static bool DeserializarJson2<T>(string path, out T listJson)
        {
            bool retorno = true;
            listJson = default;

            try
            {

                string json = File.ReadAllText(path);

                listJson = JsonSerializer.Deserialize<T>(json);
                
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

        #region Serializar XML

        /// <summary>
        /// Serializa una lista generica en el xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="listXML"></param>
        /// <returns>true o false</returns>
        public static bool SerializarXML<T>(string path, List<T> listXML)
        {
            StreamWriter writer;
            //StreamReader reader;
            XmlSerializer serializer;
            bool retorno = true;
            //string path2 = @"..\..\..\..\Archivos\MazoCartasCuarenta.xml";

            try
            {
                using (writer = new StreamWriter(path))
                {
                    serializer = new XmlSerializer(typeof(List<T>));

                    serializer.Serialize(writer, listXML);
                }

            }
            catch (Exception e)
            {
                //Lanzar exepciones propias
                Console.WriteLine(e.Message);
                retorno = false;
            }

            return retorno;
        }

        #endregion

        #region Deserializar XML

        /// <summary>
        /// Deserializa un archivo xml y lo guarda en la lista pasada por parametro de salida
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="listaXML"></param>
        /// <returns>true: salio correctamente, false: Falló</returns>
        public static bool DeserializarXML<T>(string path ,out List<T> listaXML)
        {
            listaXML  = new List<T>();
            StreamReader reader;
            XmlSerializer serializer;
            bool retorno = true;

            try
            {
                using (reader = new StreamReader(path))
                {
                    serializer = new XmlSerializer(typeof(List<T>));

                    listaXML = (List<T>)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(e.Message);
                retorno = false;
            }

            return retorno;
        }

        #endregion
    }
}
