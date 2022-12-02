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

        //private List<FrmJuegoTruco> trucos;
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
            //this.trucos = new List<FrmJuegoTruco>();
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
            int indexFilaSeleccionada = this.dataGridViewSalas.CurrentRow.Index;
            //this.trucos[indexFilaSeleccionada].Dispose();
        }

        #endregion

        #region Metodos

        private void CargarSalasEnJuego()
        {
            if (this.ObtenerSalas())
            {
                foreach (Sala item in this.salas)
                {
                    this.dataGridViewSalas.Rows.Add(item.Id, item.NameSala, item.Estado, item.NameJ1, item.NameJ2);
                }
            }
        }

        private bool ObtenerSalas()
        {
            List<Sala> salaAux = new List<Sala>();
            bool retorno = false;

            if (Sala.ObtenerListaSala_Sql(salaAux))
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
            if (Sala.AgregarSala_Sql(sala1))
            {
                //MessageBox.Show($"Id generado: {sala1.Id}");
                this.dataGridViewSalas.Rows.Add(sala1.Id, sala1.NameSala, sala1.Estado, sala1.NameJ1, sala1.NameJ2);
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
            if (esDisponible && Resultado.AgregarResultado_Sql(resultado) && Sala.ModificarSala(sala.Id,resultado.Id, EestadoPartida.En_juego))
            {
                //this.trucos.Add(new FrmJuegoTruco(sala.NameJ1, sala.NameJ2));
                //this.trucos[indexFilaSeleccionada].Show();
                this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells["estado"].Value = EestadoPartida.En_juego;
                new FrmJuegoTruco(sala.NameJ1, sala.NameJ2).Show();
            }
            else
            {
                MessageBox.Show("No se pudo crear la partida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        
    }
}
