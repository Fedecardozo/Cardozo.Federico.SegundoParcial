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
    public partial class FrmDataGrid : Form
    {
        #region Atributos

        //private List<Sala> salas;
        private Sala salaDataGridSeleccionada;
        private int indexSeleccionadoDtvg;
        //private DataGridViewCellCollection filaSeleccionada;

        #endregion

        #region Inicio form

        public FrmDataGrid()
        {
            InitializeComponent();
        }

        private void FrmDataGrid_Load(object sender, EventArgs e)
        {
            FormPrincipal.AvisoCambiosSql += this.CargarDataGrid;
            this.CargarDataGrid();

            if (this.dataGridViewSalas.Rows.Count > 0)
            {
                this.indexSeleccionadoDtvg = 0;
                //this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
                this.ObtenerSalaDataGrid();
            }

        }

        #endregion

        #region Acciones DataGrid

      /// <summary>
        /// Carga la lista de salas en el data grid y oculta el id y las forenkeys.
        /// </summary>
        private void CargarDataGrid()
        {
            if (Sala.ObtenerListaSala_Sql(out List<Sala> salas))
            {
                this.dataGridViewSalas.DataSource = salas;
                if (this.dataGridViewSalas.DataSource is not null)
                {
                    this.dataGridViewSalas.Columns["Id"].Visible = false;
                    this.dataGridViewSalas.Columns["Fk_Usuario"].Visible = false;
                    this.dataGridViewSalas.Columns["Fk_Resultado"].Visible = false;
                }

            }
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
                this.salaDataGridSeleccionada = (Sala)this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].DataBoundItem;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        private void dataGridViewSalas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.indexSeleccionadoDtvg = this.dataGridViewSalas.CurrentRow.Index;
            //this.filaSeleccionada = this.dataGridViewSalas.Rows[this.indexSeleccionadoDtvg].Cells;
            this.ObtenerSalaDataGrid(); 
        }

        #endregion

        #region Botones

        private void btnPartida_Click(object sender, EventArgs e)
        {
            if (Resultado.ObtenerResultadoId_Sql(this.salaDataGridSeleccionada.Fk_Resultado, out Resultado resultado))
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
            if (Usuario.ObtenerUsuarioId_Sql(this.salaDataGridSeleccionada.Fk_Usuario, out Usuario usuario))
            {
                MessageBox.Show($"*** Creador de la sala *** \n{usuario}", "Creador sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show($"No se pudo obtener el creador", "Error creador sala seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
