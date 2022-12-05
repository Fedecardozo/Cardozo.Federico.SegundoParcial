using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormTruco
{
    public partial class FrmCrearSala : FrmPadre
    {

        #region Evento propio

        public delegate void AvisarCambios_BaseDeDatos();

        public event AvisarCambios_BaseDeDatos AvisoCambiosSql;

        #endregion

        #region Atributos

        //private List<Sala> salas;
        private Usuario usuario;

        #endregion

        #region Inicio Form

        public FrmCrearSala(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmCrearSala_Load(object sender, EventArgs e)
        {
            this.CargarSalas();
        }

        #endregion

        #region Botones

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSala nuevaSala = new FrmSala(AgregarSala);
            if(nuevaSala.ShowDialog() == DialogResult.Cancel)
            {
                this.AvisoCambiosSql += this.IniciarPartida;
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.IniciarPartida();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CancelarPartida();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dataGridViewSalas.Rows.Clear();
            this.CargarSalas();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Carga en el data grid las salas que estan disponibles o en juego
        /// </summary>
        private void CargarSalas()
        {
            //Verifico si obtuvo la lista
            if (Sala.ObtenerListaSala_Sql(out List<Sala> salas))
            {
                foreach (Sala item in salas)
                {
                    //Solo se muestran las que estan disponibles o en juego
                    if(item.Estado == EestadoPartida.Disponible || item.Estado == EestadoPartida.En_juego)
                    {
                        this.dataGridViewSalas.Rows.Add(item.Id, item.NameSala, item.Estado, item.NameJ1, item.NameJ2,0,item.Fk_Resultado);
                    }
                }
            }
        }

        /// <summary>
        /// Agrega una sala y un resultado a la base de datos.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <param name="nameSala"></param>
        /// <returns>true si subio los datos, false sino</returns>
        private bool AgregarSala(string j1, string j2, string nameSala)
        {
            //Crear objeto resultado
            Resultado resultado = new Resultado(j1,j2,0,0,eResultado.Sin_Iniciar);

            //Agregar(Insert) resultado a la base de datos y asi obtener el id.
            bool retorno = resultado.Insert_Sql();

            if (retorno)
            {
                //Creo el objeto sala con sus correspondieste argumentos.
                Sala sala = new Sala(j1,j2,nameSala,this.usuario.Id,EestadoPartida.Disponible,resultado.Id);
                //Lo inserto en la base de datos y obtengo el id de la nueva sala.
                retorno = sala.Insert_Sql();

            }

            return retorno;
        }

        private void IniciarPartida()
        {
            MessageBox.Show("Hola");
        }

        private void CancelarPartida()
        {

        }

        private void MostrarMsj(bool rta, DataGridViewRow seleccion)
        {

        }

        #endregion

        #region Metodos eventos propios

        public void EnviarAvisoCambioSql()
        {
            if (this.AvisoCambiosSql is not null)
            {
                this.AvisoCambiosSql.Invoke();
            }
        }

        #endregion

    }
}
