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

        #endregion
        
        #region Constructores

        static ControlSql()
        {
            // CREO UN OBJETO SQLCONECTION
            ControlSql.conexion = new SqlConnection(ControlSql.cadena_conexion);
        }

        #endregion

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

        #region Realizar conexion

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

        #endregion

        #region Propiedad
        
        public static SqlDataReader Lector { get { return ControlSql.lector; } }

        #endregion

        #region Update - Delete - Insert

        /// <summary>
        /// Realiza consultas Update, delete, insert
        /// </summary>
        /// <param name="comandoSql"></param>
        /// <param name="metodoSql"></param>
        /// <returns>true sin fallas, false fallo</returns>
        public static bool RealizarAccionSql(string comandoSql)
        {
            bool rta = true;

            try
            {
                ControlSql.RelizarConexion(comandoSql);

                rta = ControlSql.comando.ExecuteNonQuery() > 0;

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

        #region Select

        /// <summary>
        /// Realiza consultas Select
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comandoSql"></param>
        /// <param name="action"></param>
        /// <param name="listaGenerica"></param>
        /// <returns>true sin fallas, false fallo</returns>
        public static bool RealizarConsultaSelectSql<T>(string comandoSql, Func<T> select, out T obj)
        {
            bool rta = true;
            obj = default;

            try
            {
                ControlSql.RelizarConexion(comandoSql);

                ControlSql.lector = comando.ExecuteReader();

                obj = select.Invoke();

                rta = obj is not null; 

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

        #endregion

    }
}
