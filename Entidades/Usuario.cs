﻿using System;
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

        //public Usuario() { }

        public Usuario(string correo, string nombre, string apellido, int id)
        {
            this.correo = correo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        #endregion

        //#region Sobrecarga operadores

        //public static bool operator ==(Usuario usuario, Usuario usuario1)
        //{
        //    return usuario == usuario1.correo;
        //}

        //public static bool operator !=(Usuario usuario, Usuario usuario1)
        //{
        //    return !(usuario == usuario1);
        //}

        //public static bool operator ==(Usuario usuario, string correo)
        //{
        //    return usuario.correo == correo;
        //}

        //public static bool operator !=(Usuario usuario, string correo)
        //{
        //    return !(usuario == correo);
        //}

        //#endregion

        #region Consultas SQL

        public static void ObtenerListaUsuarios_Sql(List<Usuario> usuarios)
        {
            int id = (int)ControlSql.Lector["id"];
            string correo = ControlSql.Lector[1].ToString();
            string nombre = ControlSql.Lector[2].ToString();
            string apellido = ControlSql.Lector[3].ToString();

            usuarios.Add(new Usuario(correo, nombre, apellido, id));

        }

        public static Usuario ObtenerUsuario_Sql()
        {
            int id = (int)ControlSql.Lector["id"];
            string correo = ControlSql.Lector[1].ToString();
            string nombre = ControlSql.Lector[2].ToString();
            string apellido = ControlSql.Lector[3].ToString();

            return new Usuario(correo, nombre, apellido, id);

        }

        public static bool ConsultarCorreo(string correo, out Usuario user)
        {

            string select = $"select id, correo, nombre, apellido from [Base_Truco].[dbo].[usuarios] where correo = '{correo}'";

            return ControlSql.RealizarConsultaSql(select, Usuario.ObtenerUsuario_Sql,out user);
        } 

        #endregion
        
        #region Polimorfismo

        public override string ToString()
        {
            return $"Correo: {this.correo} - Nombre: {this.nombre} - Apellido: {this.apellido} - Id: {this.id}";
        }

        #endregion
    
    }
}
