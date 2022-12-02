using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sala
    {
        #region Atributos

        private static int ultimoId;
        private int id;
        private string nameJ1;
        private string nameJ2;
        private string nameSala;
        private int fk_Usuario;
        private EestadoPartida estado;
        private int fk_resultado;
        private DateTime fecha;
        
        #endregion

        #region Constructor

        static Sala()
        {
            Sala.ultimoId = Sala.ObtenerUltimoId_Sql();
        }

        public Sala(string nameJ1,string nameJ2, string nameSala)
        {
            this.nameJ1 = nameJ1;
            this.nameJ2 = nameJ2;
            this.nameSala = nameSala;
        }

        public Sala(string nameJ1, string nameJ2, string nameSala, int fk_Usuario, EestadoPartida estado) : this(nameJ1, nameJ2, nameSala)
        {
            this.fk_Usuario = fk_Usuario;
            this.estado = estado;
        }

        public Sala(string nameJ1, string nameJ2, string nameSala, int fk_Usuario, EestadoPartida estado, int fk_resultado) 
            : this(nameJ1, nameJ2, nameSala, fk_Usuario, estado)
        {

            this.fk_resultado = fk_resultado;
        }

        public Sala(int id,string nameJ1, string nameJ2, string nameSala, int fk_Usuario,EestadoPartida estado, int fk_resultado,DateTime fecha)
            : this(nameJ1,nameJ2,nameSala, fk_Usuario, estado, fk_resultado)
        { 
            this.id = id;
            this.fecha = fecha;
        }

        #endregion

        #region Propiedades

        public string NameJ1 { get { return this.nameJ1; } set { this.nameJ1 = value; } }
        public string NameJ2 { get { return this.nameJ2; } set { this.nameJ2 = value; } }
        public string NameSala { get { return this.nameSala; } set { this.nameSala = value; } }
        public int Id { get { return this.id; } set { this.id = value; } }
        public int Fk_Usuario { get { return this.fk_Usuario; } set { this.fk_Usuario = value; } }
        public int Fk_Resultado { get { return this.fk_resultado; } set { this.fk_resultado = value; } }
        public DateTime Fecha { get { return this.fecha; } }
        public EestadoPartida Estado { get { return this.estado; } }

        #endregion

        #region Metodos

        public static EestadoPartida ObtenerEstado(string estado)
        {
            EestadoPartida estadoPartida;
            
            switch (estado)
            {
                case "Finalizada": estadoPartida = EestadoPartida.Finalizada; break;
                case "En_juego": estadoPartida = EestadoPartida.En_juego; break;
                default: estadoPartida = EestadoPartida.Cancelada; break;
            }

            return estadoPartida;
        }

        #endregion

        #region Comando Sql

        /// <summary>
        /// Inserta una sala a la base de datos y guarda el id en la sala pasada por parametro
        /// </summary>
        /// <param name="sala"></param>
        /// <returns></returns>
        public static bool AgregarSala_Sql(Sala sala)
        {

            string comando = $"insert into [Base_Truco].[dbo].[truco_salas] " +
                $"(name_sala, name_j1, name_j2, fk_usuario, fecha, estado)" +
                $"values('{sala.nameSala}', '{sala.nameJ1}', '{sala.nameJ2}', {sala.fk_Usuario}, GETDATE(), '{sala.estado}')";

            bool retorno = ControlSql.RealizarConsultaSql(comando);

            if (retorno)
            {
                //Sumo uno mas al ultimoId
                Sala.ultimoId++;
                //Guardo en la sala el id
                sala.id = Sala.ultimoId;
            }

            return retorno;
        }

        private static void Select_Sql(List<Sala> salas)
        {
            int id = (int)ControlSql.Lector["id"];
            string nameSala = ControlSql.Lector[1].ToString();
            string nameJ1 = ControlSql.Lector[2].ToString();
            string nameJ2 = ControlSql.Lector[3].ToString();
            int fk_Usuario = (int)ControlSql.Lector["fk_usuario"];
            EestadoPartida estado = Sala.ObtenerEstado(ControlSql.Lector[5].ToString());
            DateTime fecha = (DateTime)ControlSql.Lector["fecha"];
            int fk_resultado = (int)ControlSql.Lector["fk_juego"];

            salas.Add(new Sala(id,nameJ1, nameJ2, nameSala, fk_Usuario, estado, fk_resultado, fecha));
        }

        public static bool ObtenerListaSala_Sql(List<Sala> salas)
        {
            
            string select = "select id,name_sala,name_j1,name_j2,fk_usuario,estado,fecha,fk_juego from [Base_Truco].[dbo].[truco_salas]";

            return ControlSql.RealizarConsultaSql(select,Sala.Select_Sql, salas);

        }

        public static bool ModificarSala(int id, int fk_juego)
        {
            string update = $"update [Base_Truco].[dbo].[truco_salas] set fk_juego = {fk_juego} where id = {id}";

            return ControlSql.RealizarConsultaSql(update);
        }

        private static int ObtenerUltimoId_Sql()
        {
            string select = "select MAX(id) as id from [Base_Truco].[dbo].[truco_salas]";

            if(!ControlSql.RealizarConsultaSql(select,() => { return (int)ControlSql.Lector["id"]; }, out int id))
            {
                id = 0;
            }

            return id;
        }

        #endregion

    }
}
