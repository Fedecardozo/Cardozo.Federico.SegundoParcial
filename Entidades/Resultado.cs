using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Resultado : ISql
    {
        #region Atributos

        private const string nameTableSql = "[Base_Truco].[dbo].[truco_resultado]";
        private int id;
        private string nameJ1;
        private string nameJ2;
        private int puntosJ1;
        private int puntosJ2;
        private eResultado resultado;

        #endregion

        #region Constructores

        public Resultado(string nameJ1, string nameJ2, int puntosJ1, int puntosJ2, eResultado resultado)
        {
            this.nameJ1 = nameJ1;
            this.nameJ2 = nameJ2;
            this.puntosJ1 = puntosJ1;
            this.puntosJ2 = puntosJ2;
            this.resultado = resultado;
        }

        public Resultado(int id, string nameJ1, string nameJ2, int puntosJ1, int puntosJ2, eResultado resultado) : this(nameJ1, nameJ2, puntosJ1, puntosJ2, resultado)
        {
            this.id = id;
        }

        #endregion

        #region Propiedades

        public int Id { get { return this.id; } }

        public eResultado Estado { get { return this.resultado; } set { this.resultado = value; } }

        public int PuntosJ1 { get { return this.puntosJ1; } set { this.puntosJ1 = value; } }

        public int PuntosJ2 { get { return this.puntosJ2; } set { this.puntosJ2 = value; } }

        public string NameJ1 { get { return this.nameJ1; } }

        public string NameJ2 { get { return this.nameJ2; } }

        #endregion

        #region Metodos

        public static eResultado ObtenerResultado(string resultado)
        {
            eResultado eResultado;

            switch (resultado)
            {
                case "Ganador_J1": eResultado = eResultado.Ganador_J1; break;
                case "Ganador_J2": eResultado = eResultado.Ganador_J2; break;
                case "Empate": eResultado = eResultado.Empate; break;
                case "Ganando_J1": eResultado = eResultado.Ganando_J1; break;
                case "Ganando_J2": eResultado = eResultado.Ganando_J2; break;
                case "Empatando": eResultado = eResultado.Empatando; break;
                case "Sin_Iniciar": eResultado = eResultado.Sin_Iniciar; break;
                default: eResultado = eResultado.Cancelada; break;
            }

            return eResultado;
        }

        #endregion

        #region Metodos Sql Select

        private static Resultado Select_Sql()
        {
            Resultado objResultado;

            if (ControlSql.Lector.Read())
            {
                int id = (int)ControlSql.Lector["id"];
                string nameJ1 = ControlSql.Lector["name_j1"].ToString();
                string nameJ2 = ControlSql.Lector["name_j2"].ToString();
                int puntosJ1 = (int)ControlSql.Lector["puntos_j1"];
                int puntosJ2 = (int)ControlSql.Lector["puntos_j2"];
                eResultado resultado = Resultado.ObtenerResultado(ControlSql.Lector["resultado"].ToString());
                objResultado = new Resultado(id, nameJ1, nameJ2, puntosJ1, puntosJ2, resultado);
            }
            else
            {
                objResultado = null;
            }

            return objResultado;

        }

        public static bool ObtenerResultadoId_Sql(int id, out Resultado resultado)
        {

            string select = $"select id, name_j1, name_j2, puntos_j1, puntos_j2, resultado from {nameTableSql} where id = {id}";

            return ControlSql.RealizarConsultaSelectSql<Resultado>(select, Resultado.Select_Sql, out resultado);
        }

        private static int ObtenerId_Sql()
        {
            string select = $"select MAX(id) as id from {nameTableSql}";
            
            if (!ControlSql.RealizarConsultaSelectSql<int>(select, 
                () => { if (ControlSql.Lector.Read()) return (int)ControlSql.Lector["id"]; else return 0; }, out int id))
            {
                id = 0;
            }

            return id;
        }

        #endregion

        #region Interfaz Update - Delete - Insert

        /// <summary>
        /// Por el Id del Resultado, Modifica el estado de la partida. Como esta actualmente en la instancia de Resultado
        /// </summary>
        /// <returns>true se modifico con exito, false sino</returns>
        public bool Update_Sql()
        {
            string update = $"update {nameTableSql} " +
                $"set resultado = '{this.resultado}', puntos_j1 = {this.puntosJ1}, puntos_j2 = {this.puntosJ2}  where id = {this.id}";

            return ControlSql.RealizarAccionSql(update);
        }

        /// <summary>
        /// Agrega un Resultado a la base de datos. name_j1, name_j2, puntos_j1, puntos_j2, estado_resultado.
        /// A la instancia del objeto se le asigna el id de la base de datos
        /// </summary>
        /// <returns>true si se pudo agregar, false sino</returns>
        public bool Insert_Sql()
        {
            string insert = $"insert into {nameTableSql} (name_j1, name_j2, puntos_j1, puntos_j2, resultado) " +
                $"values ('{this.nameJ1}','{this.nameJ2}',{this.puntosJ1},{this.puntosJ2},'{this.resultado}')";

            bool retorno = ControlSql.RealizarAccionSql(insert);

            if (retorno)
            {
                this.id = Resultado.ObtenerId_Sql();
            }

            return retorno;
        }

        /// <summary>
        /// Elimina un Resultado de la base de datos por id
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

            sb.AppendLine($"Nombre jugador 1: {this.nameJ1}");
            sb.AppendLine($"Nombre jugador 2: {this.nameJ2}");
            sb.AppendLine($"Puntos jugador 1: {this.puntosJ1}");
            sb.AppendLine($"Puntos jugador 2: {this.puntosJ2}");
            sb.AppendLine($"Resultado: {this.resultado}");

            return sb.ToString();
        }

        #endregion

    }
}
