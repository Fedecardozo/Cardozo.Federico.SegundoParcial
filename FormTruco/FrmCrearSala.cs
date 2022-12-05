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
        private Resultado resultadoSeleccionado;
        private int indexSeleccionadoDtvg;

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
                this.ObtenerSalaDataGrid();
            }
        }

        #endregion

        #region Botones

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSala frmSala = new FrmSala(this.AgregarSala);
            frmSala.ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.IniciarPartida();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            if (Resultado.ObtenerResultadoId_Sql(this.salaSeleccionada.Fk_Resultado, out Resultado resultado))
            {
                MessageBox.Show($"*** Resultado *** \n{resultado}", "Resultado sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show($"No se pudo obtener resultado", "Error resultado sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreador_Click(object sender, EventArgs e)
        {
            if (Usuario.ObtenerUsuarioId_Sql(this.salaSeleccionada.Fk_Usuario, out Usuario usuario))
            {
                MessageBox.Show($"*** Creador de la sala *** \n{usuario}", "Creador sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show($"No se pudo obtener el creador", "Error creador sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    FrmJuegoTruco truco = new FrmJuegoTruco(this.resultadoSeleccionado, this.salaSeleccionada);

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

        #endregion

        #region Obtener sala y resultado

        /// <summary>
        /// Obtiene la sala seleccionada del data grid.
        /// </summary>
        /// <returns>true si no rompio, false si rompio</returns>
        private bool ObtenerSalaDataGrid()
        {
            bool retorno;

            try
            {
                this.salaSeleccionada = (Sala)this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].DataBoundItem;
                retorno = this.ObtenerResultado();
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }
        

        /// <summary>
        /// Obtengo el resultado seleccionado del data Grid por medio de la base de datos
        /// </summary>
        /// <returns>True ok, false fallo</returns>
        private bool ObtenerResultado()
        {
            return Resultado.ObtenerResultadoId_Sql(this.salaSeleccionada.Fk_Resultado,out this.resultadoSeleccionado);
        }

        #endregion

        #region Evento click dataGrid

        private void dataGridViewSalas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.indexSeleccionadoDtvg = this.dataGridViewSalas.CurrentRow.Index;
            this.ObtenerSalaDataGrid();
        }

        #endregion

    }
}
