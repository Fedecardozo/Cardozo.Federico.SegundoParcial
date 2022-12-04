using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos

        private string correo;
        private string nombre;
        private string apellido;
        private int id;

        #endregion

        #region Constructor

        public Usuario(string correo, string nombre, string apellido, int id)
        {
            this.correo = correo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        #endregion

        #region Propiedades

        public string Correo{ get { return this.correo; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Id { get { return this.id; } }

        #endregion

        #region Consultas SQL

        #region Select

        /// <summary>
        /// Obtener de la base de datos un Usuario
        /// </summary>
        /// <returns>Usuario</returns>
        private static Usuario Select_Sql()
        {
            Usuario usuario;

            int id = (int)ControlSql.Lector["id"];
            string correo = ControlSql.Lector[1].ToString();
            string nombre = ControlSql.Lector[2].ToString();
            string apellido = ControlSql.Lector[3].ToString();

            if(ControlSql.Lector.Read())
            {
                usuario = new Usuario(correo, nombre, apellido, id);
            }
            else
            {
                usuario = null;
            }

            return usuario;

        }

        /// <summary>
        /// Verifica en la base de datos si esta el usuario pasado por parametro. Por parametro devuelve el usuario
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="user"></param>
        /// <returns>true si esta, false sino</returns>
        public static bool ConsultarCorreo(string correo,string password, out Usuario user)
        {

            string select = $"select id, correo, nombre, apellido from [Base_Truco].[dbo].[truco_usuarios] where correo = '{correo}' and password = '{password}'";

            return ControlSql.RealizarConsultaSelectSql(select, Usuario.Select_Sql,out user);
        } 

        /// <summary>
        /// Obtener usuario por el id, de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool ObtenerUsuarioId_Sql(int id,out Usuario user)
        {
            string select = $"select id, correo, nombre, apellido from [Base_Truco].[dbo].[truco_usuarios] where id = {id}";
            return ControlSql.RealizarConsultaSelectSql(select, Usuario.Select_Sql, out user);
        }

        #endregion

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return $"Correo: {this.correo} \nNombre: {this.nombre} \nApellido: {this.apellido}";
        }

        #endregion
    
    }
}
