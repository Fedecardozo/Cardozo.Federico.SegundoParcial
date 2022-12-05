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

        private Usuario usuario;
        private Sala salaSeleccionada;
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
            FormPrincipal.AvisoCambiosSql += this.CargarDataGrid;
            this.CargarDataGrid();
            if (this.dataGridViewSalas.Rows.Count > 0)
            {
                this.indexSeleccionadoDtvg = 0;
                this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
            }
        }

        #endregion

        #region Botones

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSala frmSala = new FrmSala(this.AgregarSala);
            frmSala.ShowDialog();
        }

        #endregion

        #region Metodos


        /// <summary>
        /// Carga la lista de salas en el data grid y oculta el id y las forenkeys.
        /// </summary>
        private void CargarDataGrid()
        {
            if (Sala.ObtenerListaSalaEstado_Sql(out List<Sala> salas))
            {
                this.dataGridViewSalas.DataSource = salas;
                if (this.dataGridViewSalas.DataSource is not null)
                {
                    this.dataGridViewSalas.Columns["Id"].Visible = false;
                    this.dataGridViewSalas.Columns["Fk_Usuario"].Visible = false;
                    this.dataGridViewSalas.Columns["Fk_Resultado"].Visible = false;
                    this.dataGridViewSalas.Columns["Fecha"].Visible = false;
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


        /// <summary>
        /// Inicia las partidas que esta disponibles
        /// </summary>
        private void IniciarPartida()
        {
            try
            {
                if(this.salaSeleccionada.Estado == EestadoPartida.Disponible)
                {
                    //Inicia una partida, mostrando el form del truco 
                    FrmJuegoTruco truco = new FrmJuegoTruco();

                    //Cambiar estado de la partida en la base de datos
                    this.salaSeleccionada.Estado = EestadoPartida.En_juego;
                    if(this.salaSeleccionada.Update_Sql())
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


        /// <summary>
        /// Obtiene la sala seleccionada del data grid.
        /// </summary>
        /// <returns>true si no rompio, false si rompio</returns>
        private bool ObtenerSalaDataGrid()
        {
            bool retorno = true;

            try
            {
                this.salaSeleccionada = (Sala)this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].DataBoundItem;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        #endregion

        #region Evento click dataGrid

        private void dataGridViewSalas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.indexSeleccionadoDtvg = this.dataGridViewSalas.CurrentRow.Index;
            this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
            this.ObtenerSalaDataGrid();
            //MessageBox.Show(["estado"].Value.ToString());
        }


        #endregion

        
    }
}
