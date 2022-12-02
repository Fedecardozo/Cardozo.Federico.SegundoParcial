using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Resultado
    {
        #region Atributos

        private static int ultimoId;
        private int id;
        private string nameJ1;
        private string nameJ2;
        private int puntosJ1;
        private int puntosJ2;
        private eResultado resultado;

        #endregion

        #region Constructores

        static Resultado()
        {
            Resultado.ultimoId = Resultado.ObtenerUltimoId_Sql();
        }

        public Resultado(string nameJ1, string nameJ2, int puntosJ1, int puntosJ2, eResultado resultado)
        {
            this.nameJ1 = nameJ1;
            this.nameJ2 = nameJ2;
            this.puntosJ1 = puntosJ1;
            this.puntosJ2 = puntosJ2;
            this.resultado = resultado;
        }

        public Resultado(int id, string nameJ1, string nameJ2, int puntosJ1, int puntosJ2, eResultado resultado) : this(nameJ1,nameJ2,puntosJ1,puntosJ2,resultado)
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

            switch(resultado)
            {
                case "Ganador_J1": eResultado = eResultado.Ganador_J1; break;
                case "Ganador_J2": eResultado = eResultado.Ganador_J2; break;
                case "Empate": eResultado = eResultado.Empate; break;
                case "Ganando_J1": eResultado = eResultado.Ganando_J1; break;
                case "Ganando_J2": eResultado = eResultado.Ganando_J2; break;
                case "Empatando": eResultado = eResultado.Empatando; break;
                default: eResultado = eResultado.Cancelada; break;
            }

            return eResultado;
        }

        #endregion

        #region Metodos Sql

        private static Resultado Select_Sql()
        {

            int id = (int)ControlSql.Lector["id"];
            string nameJ1 = ControlSql.Lector["name_j1"].ToString();
            string nameJ2 = ControlSql.Lector["name_j2"].ToString();
            int puntosJ1 = (int)ControlSql.Lector["puntos_j1"];
            int puntosJ2 = (int)ControlSql.Lector["puntos_j2"];
            eResultado resultado = Resultado.ObtenerResultado(ControlSql.Lector["resultado"].ToString());

            return new Resultado(id,nameJ1,nameJ2,puntosJ1,puntosJ2,resultado);
        }

        public static bool ObtenerResultadoId_Sql(int id, out Resultado resultado)
        {

            string select = $"select id, name_j1, name_j2, puntos_j1, puntos_j2, resultado from [Base_Truco].[dbo].[truco_resultado] where id = {id}";

            return ControlSql.RealizarConsultaSql(select, Resultado.Select_Sql, out resultado);
        }

        public static bool AgregarResultado_Sql(Resultado resultado)
        {
            string insert = $"insert into [Base_Truco].[dbo].[truco_resultado] (name_j1, name_j2, puntos_j1, puntos_j2, resultado) " +
                $"values ('{resultado.nameJ1}','{resultado.nameJ2}',{resultado.puntosJ1},{resultado.puntosJ2},'{resultado.resultado}')";

            bool retorno = ControlSql.RealizarConsultaSql(insert);

            if(retorno)
            {
                Resultado.ultimoId++;
                resultado.id = Resultado.ultimoId;
            }

            return retorno;
        }

        private static int ObtenerUltimoId_Sql()
        {
            string select = "select MAX(id) as id from [Base_Truco].[dbo].[truco_resultado]";

            if (!ControlSql.RealizarConsultaSql(select, () => { return (int)ControlSql.Lector["id"]; }, out int id))
            {
                id = 0;
            }

            return id;
        }

        public static bool ModificarResultado(int id, eResultado estado)
        {
            string update = $"update [Base_Truco].[dbo].[truco_resultado] set resultado = '{estado}'  where id = {id}";

            return ControlSql.RealizarConsultaSql(update);
        }

        public static bool ModificarResultado(Resultado resultado)
        {
            string update = $"update [Base_Truco].[dbo].[truco_resultado] " +
                $"set resultado = '{resultado.resultado}', puntos_j1 = {resultado.puntosJ1}, puntos_j2 = {resultado.puntosJ2}  where id = {resultado.id}";

            return ControlSql.RealizarConsultaSql(update);
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
