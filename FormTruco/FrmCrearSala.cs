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

        private int contSala;
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
            this.contSala = 0;
            this.trucos = new List<FrmJuegoTruco>();
            this.salas = new List<Sala>();
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
            this.trucos[indexFilaSeleccionada].Dispose();
        }

        #endregion

        #region Metodos

        private void CargarSalasEnJuego()
        {

        }

        private void AgregarSala(string j1, string j2, string sala)
        {
            Sala sala1 = new Sala(j1, j2, sala, this.usuario.Id, EestadoPartida.En_juego);
            //Agregar a la base de datos y de la base de datos al dataGrid
            if(Sala.AgregarSala_Sql(sala1))
            {
                MessageBox.Show($"Id generado: {sala1.Id}");
                this.dataGridViewSalas.Rows.Add(sala1.Id, sala1.NameSala,sala1.Estado,sala1.NameJ1,sala1.NameJ2);
                this.contSala++;
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
            //MessageBox.Show(nameJ1);

            //Agrego resultado a la base datos                                                                  //La relaciono con la Sala (update)
            if (Resultado.AgregarResultado_Sql(new Resultado(sala.NameJ1,sala.NameJ2,0,0,eResultado.Empatando)) && Sala.ModificarSala(sala.Id,4))
            {
                
                this.trucos.Add(new FrmJuegoTruco(sala.NameJ1, sala.NameJ2));
                this.trucos[indexFilaSeleccionada].Show();
            }
            else
            {
                MessageBox.Show("Error al crear la partida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        
    }
}
