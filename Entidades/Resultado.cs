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

        private int id;
        private string nameJ1;
        private string nameJ2;
        private int puntosJ1;
        private int puntosJ2;
        private string resultado;

        #endregion

        #region Constructores

        public Resultado(int id, string nameJ1, string nameJ2, int puntosJ1, int puntosJ2, string resultado)
        {
            this.id = id;
            this.nameJ1 = nameJ1;
            this.nameJ2 = nameJ2;
            this.puntosJ1 = puntosJ1;
            this.puntosJ2 = puntosJ2;
            this.resultado = resultado;
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
            string resultado = ControlSql.Lector["resultado"].ToString();

            return new Resultado(id,nameJ1,nameJ2,puntosJ1,puntosJ2,resultado);
        }

        public static bool ObtenerResultadoId_Sql(int id, out Resultado resultado)
        {

            string select = $"select id, name_j1, name_j2, puntos_j1, puntos_j2, resultado from [Base_Truco].[dbo].[truco_resultado] where id = {id}";

            return ControlSql.RealizarConsultaSql(select, Resultado.Select_Sql, out resultado);
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
