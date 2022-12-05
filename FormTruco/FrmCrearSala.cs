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

        #region Atributos

        //private List<Sala> salas;
        private Usuario usuario;
        private int indexSeleccionadoDtvg;
        private DataGridViewCellCollection filaSeleccionada;

        #endregion

        #region Inicio Form

        public FrmCrearSala(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmCrearSala_Load(object sender, EventArgs e)
        {
            //FormPrincipal.AvisoCambiosSql += () => this.btnActualizar_Click(sender,e);
            //this.CargarSalas();
            //if(this.dataGridViewSalas.Rows.Count > 0)
            //{
            //    this.indexSeleccionadoDtvg = 0;
            //    this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
            //}
        }

        #endregion

        #region Botones

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSala nuevaSala = new FrmSala(AgregarSala);
            nuevaSala.ShowDialog();
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
            //this.dataGridViewSalas.Rows.Clear();
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
                        //this.dataGridViewSalas.Rows.Add(item.Id,item.Fk_Usuario,item.NameSala, item.Estado, item.NameJ1, item.NameJ2,0,item.Fk_Resultado,item.Fecha);
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
            try
            {
                if(this.ObtenerSalaDataGrid(out Sala sala) && sala.Estado == EestadoPartida.Disponible)
                {
                    //Inicia una partida, mostrando el form del truco 
                    FrmJuegoTruco truco = new FrmJuegoTruco();

                    //Cambiar estado de la partida en la base de datos
                    sala.Estado = EestadoPartida.En_juego;
                    if(sala.Update_Sql())
                    {
                        FormPrincipal.EnviarAvisoCambioSql();
                    }

                    //Se deberia crear en un hilo secundario, asi despues se puede cancelar
                    truco.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay salas creadas para jugar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void CancelarPartida()
        {

        }

        private void MostrarMsj(bool rta, DataGridViewRow seleccion)
        {

        }

        private bool ObtenerSalaDataGrid(out Sala sala)
        {
            bool retorno = true;

            try
            {
                int id = (int)this.filaSeleccionada["id"].Value;
                string nameJ1 = (string)this.filaSeleccionada["J1"].Value;
                string nameJ2 = (string)this.filaSeleccionada["J2"].Value;
                string nameSala = (string)this.filaSeleccionada["nameSala"].Value;
                int fk_juego = (int)this.filaSeleccionada["id_resultado"].Value;
                int fk_usuario = (int)this.filaSeleccionada["fk_usuario"].Value;
                EestadoPartida estado = (EestadoPartida)this.filaSeleccionada["estado"].Value;
                DateTime fecha = (DateTime)this.filaSeleccionada["fecha"].Value;

                sala = new Sala(id,nameJ1,nameJ2,nameSala,fk_usuario,estado,fk_juego,fecha);
            }
            catch (Exception)
            {
                retorno = false;
                sala = null;
            }

            return retorno;
        }

        #endregion

        #region Evento click dataGrid

        private void dataGridViewSalas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this.indexSeleccionadoDtvg = this.dataGridViewSalas.CurrentRow.Index;
            //this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
            //MessageBox.Show(["estado"].Value.ToString());
        }

        #endregion
    }
}
