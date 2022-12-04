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

        private List<FrmJuegoTruco> trucos;
        private List<Sala> salas;
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
            this.trucos = new List<FrmJuegoTruco>();
            this.salas = new List<Sala>();
            this.CargarSalasEnJuego();
        }

        #endregion

        #region Botones

        private void pictureBoxMas_Click(object sender, EventArgs e)
        {
            //this.panelMas.Visible = true;
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
            this.salas.Clear();
            this.dataGridViewSalas.Rows.Clear();
            this.CargarSalasEnJuego();
        }

        #endregion

        #region Metodos

        private void CargarSalasEnJuego()
        {
            if (this.ObtenerSalas())
            {
                foreach (Sala item in this.salas)
                {
                    this.dataGridViewSalas.Rows.Add(item.Id, item.NameSala, item.Estado, item.NameJ1, item.NameJ2,0,item.Fk_Resultado);
                }
            }
        }

        private bool ObtenerSalas()
        {
            List<Sala> salaAux;
            bool retorno = false;

            if (Sala.ObtenerListaSala_Sql(out salaAux))
            {
                foreach (Sala item in salaAux)
                {
                    if (item.Estado == EestadoPartida.Disponible || item.Estado == EestadoPartida.En_juego)
                    {
                        this.salas.Add(item);
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        private void AgregarSala(string j1, string j2, string sala)
        {
            Sala sala1 = new Sala(j1, j2, sala, this.usuario.Id, EestadoPartida.Disponible);
            //Agregar a la base de datos y de la base de datos al dataGrid
            if (sala1.Insert_Sql())
            {
                //MessageBox.Show($"Id generado: {sala1.Id}");
                this.dataGridViewSalas.Rows.Add(sala1.Id, sala1.NameSala, sala1.Estado, sala1.NameJ1, sala1.NameJ2,0,0);
                this.salas.Add(sala1);
            }
            else
            {
                MessageBox.Show("Error al crear la sala", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IniciarPartida()
        {
            //Sala sala = (Sala)this.dataGridViewSalas.CurrentRow.DataBoundItem; //obtener sala seleccionada
            int indexFilaSeleccionada = this.dataGridViewSalas.CurrentRow.Index;
            Sala sala = this.salas[indexFilaSeleccionada];
            Resultado resultado = new Resultado(sala.NameJ1, sala.NameJ2, 0, 0, eResultado.Empatando);
            bool esDisponible = (EestadoPartida)this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["estado"].Value == EestadoPartida.Disponible;
            //MessageBox.Show($"{esDisponible}");

                                //Agrego resultado a la base datos           //La relaciono con la Sala (update)
            if (esDisponible && resultado.Insert_Sql() && sala.Update_Sql())
            {
                FrmJuegoTruco truco = new FrmJuegoTruco(resultado,sala);
                this.trucos.Add(truco);
                //this.trucos[indexFilaSeleccionada].Show();
                this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["estado"].Value = EestadoPartida.En_juego;
                truco.Show();
                this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["id_truco"].Value = truco.Id;
                this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["id_resultado"].Value = resultado.Id;
            }
            else
            {
                MessageBox.Show("No se pudo crear la partida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarPartida()
        {
            int indexFilaSeleccionada = this.dataGridViewSalas.CurrentRow.Index;
            DataGridViewRow seleccion = this.dataGridViewSalas.Rows[indexFilaSeleccionada];
            int id_obtenido = (int)this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["id_truco"].Value;
            EestadoPartida estado = (EestadoPartida)this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["estado"].Value;

            bool rta = false;

            if (id_obtenido > 0)
            {
                foreach (FrmJuegoTruco item in this.trucos)
                {
                    if (item.Id == id_obtenido)
                    {
                        this.trucos.Remove(item);
                        item.Dispose();
                        rta = true;
                        break;
                    }
                }
            }
            else if(id_obtenido == 0 && (estado == EestadoPartida.Disponible || estado == EestadoPartida.En_juego))
            {                
                //rta = Sala.ModificarSala((int)seleccion.Cells["id"].Value, (int)seleccion.Cells["id_resultado"].Value, EestadoPartida.Cancelada);
            }

            this.MostrarMsj(rta,seleccion);

        }

        private void MostrarMsj(bool rta, DataGridViewRow seleccion)
        {
            EestadoPartida estado = (EestadoPartida)seleccion.Cells["estado"].Value;

            if (rta)
            {
                seleccion.Cells["estado"].Value = EestadoPartida.Cancelada;
                MessageBox.Show("Se cancelo con exito", "Cancelar sala", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //if(!Resultado.ModificarResultado((int)seleccion.Cells["id_resultado"].Value, eResultado.Cancelada))
                //{
                //    MessageBox.Show("No hay resultado a cancelar", "Cancelar resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
            else if(!rta && (estado == EestadoPartida.Cancelada || estado == EestadoPartida.Finalizada))
            {
                MessageBox.Show($"No se puede cancelar una sala {estado}", "Cancelar sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!rta)
            {
                MessageBox.Show("Error al cancelar la sala", "Cancelar sala", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

       
    }
}
