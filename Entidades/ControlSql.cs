using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class ControlSql
    {
        #region Atributos

        private const string cadena_conexion = @"Server=.;Database=test;Trusted_Connection=True;";
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;
        public delegate bool delegateSql();
        public delegate void delegateSelect<T>(List<T> lista);
        public delegate T delegateSelectObj<T>();

        #endregion
        
        #region Constructores

        static ControlSql()
        {
            // CREO UN OBJETO SQLCONECTION
            ControlSql.conexion = new SqlConnection(ControlSql.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public static bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                ControlSql.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (ControlSql.conexion.State == ConnectionState.Open)
                {
                    ControlSql.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion

        #region Abrir conexion, realizar la consulta 

        /// <summary>
        /// Conexion a la base de datos
        /// </summary>
        /// <param name="comandoSql"></param>
        private static void RelizarConexion(string comandoSql)
        {
            ControlSql.comando = new SqlCommand();
            ControlSql.comando.CommandType = CommandType.Text;
            ControlSql.comando.CommandText = comandoSql;
            ControlSql.comando.Connection = ControlSql.conexion;

            ControlSql.conexion.Open();
        }

        /// <summary>
        /// Realiza consultas Update, delete, insert
        /// </summary>
        /// <param name="comandoSql"></param>
        /// <param name="metodoSql"></param>
        /// <returns></returns>
        public static bool RealizarConsultaSql(string comandoSql)
        {
            bool rta = true;

            try
            {

                ControlSql.RelizarConexion(comandoSql);

                rta = ControlSql.ConsultarExecuteNonQuery();

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (ControlSql.conexion.State == ConnectionState.Open)
                {
                    ControlSql.conexion.Close();
                }
            }

            return rta;
        }

        /// <summary>
        /// Realiza consultas Select, guardando en una lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comandoSql"></param>
        /// <param name="action"></param>
        /// <param name="listaGenerica"></param>
        /// <returns></returns>
        public static bool RealizarConsultaSql<T>(string comandoSql, delegateSelect<T> select, List<T> listaGenerica)
        {
            bool rta = true;

            try
            {
                ControlSql.RelizarConexion(comandoSql);
                ControlSql.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //Datos a recibir y guardar
                    select.Invoke(listaGenerica);
                }

                lector.Close();

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (ControlSql.conexion.State == ConnectionState.Open)
                {
                    ControlSql.conexion.Close();
                }
            }

            return rta;
        }

        /// <summary>
        /// Realiza consulta SELECT, por parametro recibe una funcion para obtener la informacion, 
        /// el otro parametro devuelve el objeto que guardo la funcion generica
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comandoSql"></param>
        /// <param name="selectObj">Metodo generico, que retorne T y recibe nada</param>
        /// <param name="obj"></param>
        /// <returns>true si encontro el dato, false sino</returns>
        public static bool RealizarConsultaSql<T>(string comandoSql,delegateSelectObj<T> selectObj, out T obj)
        {
            bool rta = true;
            T t = default(T);
            obj = t;
      
            try
            {
                ControlSql.RelizarConexion(comandoSql);
                ControlSql.lector = comando.ExecuteReader();

                rta = Lector.Read();

                if(rta)
                {
                    obj = selectObj.Invoke();
                }

                lector.Close();

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (ControlSql.conexion.State == ConnectionState.Open)
                {
                    ControlSql.conexion.Close();
                }
            }

            return rta;
        }

        /// <summary>
        /// Metodo para Update, Delete, Insert
        /// </summary>
        /// <returns></returns>
        public static bool ConsultarExecuteNonQuery()
        {
            bool retorno = true;

            int filasAfectadas = ControlSql.comando.ExecuteNonQuery();

            if (filasAfectadas == 0)
            {
                retorno = false;
            }

            return retorno;
        }

        public static SqlDataReader Lector { get { return ControlSql.lector; } }

        #endregion

    }
}
