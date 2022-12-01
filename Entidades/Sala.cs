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

        private int id;
        private string nameJ1;
        private string nameJ2;
        private string nameSala;
        private int fk_Usuario;
        private EestadoPartida estado;
        private int fk_resultado;
        
        #endregion

        #region Constructor

        public Sala(string nameJ1,string nameJ2, string nameSala)
        {
            this.nameJ1 = nameJ1;
            this.nameJ2 = nameJ2;
            this.nameSala = nameSala;
        }

        public Sala(string nameJ1, string nameJ2, string nameSala, int fk_Usuario,EestadoPartida estado, int fk_resultado) : this(nameJ1,nameJ2,nameSala)
        { 
            //this.id = id;
            this.fk_Usuario = fk_Usuario;
            this.estado = estado;
            this.fk_resultado = fk_resultado;
        }

        #endregion

        #region Propiedades

        public string NameJ1 { get { return this.nameJ1; } set { this.nameJ1 = value; } }
        public string NameJ2 { get { return this.nameJ2; } set { this.nameJ2 = value; } }
        public string NameSala { get { return this.nameSala; } set { this.nameSala = value; } }
        public int Id { get { return this.id; } set { this.id = value; } }
        public int Fk_Usuario { get { return this.fk_Usuario; } set { this.fk_Usuario = value; } }

        #endregion

        #region Comando Sql

        public static bool AgregarSala_Sql(Sala sala)
        {

            string comando = $"insert into [Base_Truco].[dbo].[truco_salas] " +
                $"(name_sala, name_j1, name_j2, fk_usuario, fecha, estado, fk_juego)" +
                $"values('{sala.nameSala}', '{sala.nameJ1}', '{sala.nameJ2}', {sala.fk_Usuario}, GETDATE(), '{sala.estado.ToString()}', {sala.fk_resultado})";

            return ControlSql.RealizarConsultaSql(comando);
        }


        #endregion

    }
}
