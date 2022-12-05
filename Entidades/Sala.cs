using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sala : ISql
    {

        #region Atributos

        private const string nameTableSql = "[Base_Truco].[dbo].[truco_salas]";
        //private static int ultimoId;
        private int id;
        private string nameJ1;
        private string nameJ2;
        private string nameSala;
        private int fk_Usuario;
        private EestadoPartida estado;
        private int fk_resultado;
        private DateTime fecha;
        
        #endregion

        #region Constructores

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

        public string Nombre_J1 { get { return this.nameJ1; } set { this.nameJ1 = value; } }
        public string Nombre_J2 { get { return this.nameJ2; } set { this.nameJ2 = value; } }
        public string Nombre_Sala { get { return this.nameSala; } set { this.nameSala = value; } }
        public int Id { get { return this.id; } /*set { this.id = value; } */}
        public int Fk_Usuario { get { return this.fk_Usuario; } set { this.fk_Usuario = value; } }
        public int Fk_Resultado { get { return this.fk_resultado; } set { this.fk_resultado = value; } }
        public DateTime Fecha { get { return this.fecha; } }
        public EestadoPartida Estado { get { return this.estado; } set { this.estado = value; } }

        #endregion

        #region Metodos

        public static EestadoPartida ObtenerEstado(string estado)
        {
            EestadoPartida estadoPartida;
            
            switch (estado)
            {
                case "Finalizada": estadoPartida = EestadoPartida.Finalizada; break;
                case "En_juego": estadoPartida = EestadoPartida.En_juego; break;
                case "Disponible": estadoPartida = EestadoPartida.Disponible; break;
                default: estadoPartida = EestadoPartida.Cancelada; break;
            }

            return estadoPartida;
        }

        #endregion

        #region Metodos Sql Select

        private static List<Sala> Select_Sql()
        {
            List<Sala> salas = new List<Sala>();

            while(ControlSql.Lector.Read())
            {
                int id = (int)ControlSql.Lector["id"];
                string nameSala = ControlSql.Lector[1].ToString();
                string nameJ1 = ControlSql.Lector[2].ToString();
                string nameJ2 = ControlSql.Lector[3].ToString();
                int fk_Usuario = (int)ControlSql.Lector["fk_usuario"];
                EestadoPartida estado = Sala.ObtenerEstado(ControlSql.Lector[5].ToString());
                DateTime fecha = (DateTime)ControlSql.Lector["fecha"];
                int fk_resultado = 0;
                string readResultado = ControlSql.Lector["fk_juego"].ToString();

                if (readResultado != "")
                {
                    fk_resultado = int.Parse(readResultado);
                }

                salas.Add(new Sala(id,nameJ1, nameJ2, nameSala, fk_Usuario, estado, fk_resultado, fecha));
            }

            return salas;
        }

        public static bool ObtenerListaSala_Sql(out List<Sala> salas)
        {
            
            string select = $"select id,name_sala,name_j1,name_j2,fk_usuario,estado,fecha,fk_juego from {nameTableSql}";

            return ControlSql.RealizarConsultaSelectSql<List<Sala>>(select,Sala.Select_Sql, out salas);

        }

        /// <summary>
        /// Obtiene de la base de datos una lista de salas con el estado 'En juego' o 'Disponible'
        /// </summary>
        /// <param name="salas"></param>
        /// <returns>true o false</returns>
        public static bool ObtenerListaSalaEstado_Sql(out List<Sala> salas)
        {

            string select = $"select id,name_sala,name_j1,name_j2,fk_usuario,estado,fecha,fk_juego from {nameTableSql}" +
                $" where estado = '{EestadoPartida.Disponible}' or estado = '{EestadoPartida.En_juego}'";

            return ControlSql.RealizarConsultaSelectSql<List<Sala>>(select, Sala.Select_Sql, out salas);

        }

        private static int ObtenerUltimoId_Sql()
        {
            string select = $"select MAX(id) as id from {nameTableSql}";

            if(!ControlSql.RealizarConsultaSelectSql(select,() => { return (int)ControlSql.Lector["id"]; }, out int id))
            {
                id = 0;
            }

            return id;
        }

        #endregion

        #region Interfaz - Update - Delete - Insert

        /// <summary>
        /// Por el Id de la Sala, Modifica la foreign key de resultado, y el estado de la sala. Como esta actualmente en la instancia de Sala
        /// </summary>
        /// <returns>true se modifico con exito, false sino</returns>
        public bool Update_Sql()
        {
            string update = $"update {nameTableSql} set fk_juego = {this.fk_resultado}, estado = '{this.estado}' where id = {this.id}";

            if (this.fk_resultado <= 0)
            {
                update = $"update {nameTableSql} set fk_juego = null, estado = '{this.estado}' where id = {this.id}";
            }

            return ControlSql.RealizarAccionSql(update);
        }

        /// <summary>
        /// Agrega una sala a la base de datos. nameSala, nameJ1, nameJ2, fk_Usuario, estado, fk_Juego
        /// Y guarda el id generado en el objeto sala
        /// </summary>
        /// <returns>true si se pudo agregar, false sino</returns>
        public bool Insert_Sql()
        {
            string comando = $"insert into {nameTableSql} " +
                $"(name_sala, name_j1, name_j2, fk_usuario, fecha, estado, fk_juego)" +
                $"values('{this.nameSala}', '{this.nameJ1}', '{this.nameJ2}', {this.fk_Usuario}, GETDATE(), '{this.estado}', {this.fk_resultado})";

            bool retorno = ControlSql.RealizarAccionSql(comando);

            if (retorno)
            {
                //Guardo en la sala el id
                this.id = Sala.ObtenerUltimoId_Sql();
            }

            return retorno;
        }

        /// <summary>
        /// Elimna una Sala de la base de datos por Id
        /// </summary>
        /// <returns>true si se pudo eliminar, false sino</returns>
        public bool Delete_Sql()
        {
            string comando = $"delete from {nameTableSql} where id = {this.id}";

            return ControlSql.RealizarAccionSql(comando);
        }


        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Id: {this.id}");
            sb.AppendLine($"Name J1: {this.nameJ1}");
            sb.AppendLine($"Name J2: {this.nameJ2}");
            sb.AppendLine($"Name sala: {this.nameSala}");
            sb.AppendLine($"Fk usuario: {this.fk_Usuario}");
            sb.AppendLine($"Estado: {this.estado}");
            sb.AppendLine($"Fk resultado: {this.fk_resultado}");
            sb.AppendLine($"Fecha: {this.fecha}");

            return sb.ToString();
        }

        #endregion

    }
}
