using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : ISql
    {
        #region Atributos

        private const string nameTableSql = "[Base_Truco].[dbo].[truco_usuarios]";
        private string correo;
        private string nombre;
        private string apellido;
        private string password;
        private int id;

        #endregion

        #region Constructor

        public Usuario(string correo, string nombre, string apellido,string password)
        {
            this.correo = correo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = password;
        }

        public Usuario(string correo, string nombre, string apellido, int id)
        {
            this.correo = correo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public Usuario(string correo, string nombre, string apellido, int id, string password) : this(correo,nombre,apellido,id)
        {
            this.password = password;
        }

        #endregion

        #region Propiedades

        public string Correo{ get { return this.correo; } set { this.correo = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Id { get { return this.id; } }
        public string Password {set { this.correo = value; } }

        #endregion

        #region Consultas Select SQL

        /// <summary>
        /// Obtener Lista de usuarios de la base de datos
        /// </summary>
        /// <returns>Una lista de usuarios</returns>
        private static List<Usuario> SelectListaUsuarios_Sql()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario user;
            do
            {
                user = Usuario.Select_Sql();

                if (user is not null)
                {
                    usuarios.Add(user);
                }

            } while (user is not null);

            return usuarios;
        }

        /// <summary>
        /// Obtener de la base de datos un Usuario
        /// </summary>
        /// <returns>Usuario</returns>
        private static Usuario Select_Sql()
        {
            Usuario usuario;

            if(ControlSql.Lector.Read())
            {
                int id = (int)ControlSql.Lector["id"];
                string correo = ControlSql.Lector[1].ToString();
                string nombre = ControlSql.Lector[2].ToString();
                string apellido = ControlSql.Lector[3].ToString();
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
            string select = $"select id, correo, nombre, apellido from {nameTableSql} where correo = '{correo}' and password = '{password}'";
            bool retorno = ControlSql.RealizarConsultaSelectSql(select, Usuario.Select_Sql, out user);
            
            return retorno && user is not null;
        } 

        /// <summary>
        /// Obtener usuario por el id, de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool ObtenerUsuarioId_Sql(int id,out Usuario user)
        {
            string select = $"select id, correo, nombre, apellido from {nameTableSql} where id = {id}";
            return ControlSql.RealizarConsultaSelectSql(select, Usuario.Select_Sql, out user);
        }

        /// <summary>
       /// Obtiene una lista de usuarios 
       /// </summary>
       /// <param name="users"></param>
       /// <returns>true si obtuvo la lista, false sino</returns>
        public static bool ObtenerListaUsuarios(out List<Usuario> users)
        {
            string select = $"select id, correo, nombre, apellido from {nameTableSql} ";

            return ControlSql.RealizarConsultaSelectSql<List<Usuario>>(select, Usuario.SelectListaUsuarios_Sql, out users);
        }

        #endregion

        #region Interfaz Update - Delete - Insert

        /// <summary>
        /// Por el Id del Usuario, Modifica el correo, nombre, usuario. Como esta actualmente en la instancia de Usuario
        /// </summary>
        /// <returns>true se modifico con exito, false sino</returns>
        public bool Update_Sql()
        {
            string update = $"update {nameTableSql} set correo = '{this.correo}', " +
                $"nombre = '{this.nombre}',apellido = '{this.apellido}' where id = {this.id}";

            return ControlSql.RealizarAccionSql(update);
        }

        /// <summary>
        /// Agrega un Usuario a la base de datos
        /// </summary>
        /// <returns>true si se pudo agregar, false sino</returns>
        public bool Insert_Sql()
        {
            string comando = $"insert into {nameTableSql} " +
                $"(correo,nombre,apellido,password)" +
                $"values('{this.correo}', '{this.nombre}', '{this.apellido}', '{this.password}')";

            bool retorno = ControlSql.RealizarAccionSql(comando);

            return retorno;
        }

        /// <summary>
        /// Elimina una Usuario de la base de datos por correo
        /// </summary>
        /// <returns>true si se pudo eliminar, false sino</returns>
        public bool Delete_Sql()
        {
            string comando = $"delete from {nameTableSql} where id = {this.correo}";

            return ControlSql.RealizarAccionSql(comando);
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return $"Correo: {this.correo} \nNombre: {this.nombre} \nApellido: {this.apellido}";
        }

        #endregion

    }
}
