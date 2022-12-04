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

        private void AgregarSala(string j1, string j2, string sala)
        {
       

        }

        private void IniciarPartida()
        {

        }

        private void CancelarPartida()
        {

        }

        private void MostrarMsj(bool rta, DataGridViewRow seleccion)
        {

        }

        #endregion

    }
}
