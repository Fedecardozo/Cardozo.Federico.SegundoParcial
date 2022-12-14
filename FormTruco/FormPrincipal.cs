using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormTruco
{
    public partial class FormPrincipal : Form
    {

        #region Evento propio

        public delegate void AvisarCambios_BaseDeDatos();

        public static event AvisarCambios_BaseDeDatos AvisoCambiosSql;

        #endregion

        #region Atributos

        private Usuario usuario;
        private FrmInicio formInicio;
        private FrmCrearSala formSala;
        private Form formActivo;
        private FrmDataGrid frmDataHistorial;
        private FrmEstadisticas frmEstadisticas;

        #endregion

        #region Inicio Form

        public FormPrincipal()
        {
            InitializeComponent();
        }
        public FormPrincipal(Usuario user) : this()
        {
            this.usuario = user;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.IniciarHilo();
            this.formInicio = new FrmInicio(this.usuario);
            this.formSala = new FrmCrearSala(this.usuario);
            this.frmDataHistorial = new FrmDataGrid();
            this.frmEstadisticas = new FrmEstadisticas();
            this.formActivo = this.formInicio;
            this.MostrarFormulario(this.formInicio);
        }


        #endregion

        #region Botones

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.MostrarFormulario(this.formInicio);
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            //FrmJuegoTruco truco = new FrmJuegoTruco();
            //truco.Show();
            this.MostrarFormulario(this.formSala);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //this.frmHistorial.CargarHistorial();
            this.MostrarFormulario(this.frmDataHistorial);
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            this.MostrarFormulario(this.frmEstadisticas);
        }

        #endregion

        #region Hilo Fecha

        private void ActualizarFecha()
        {
            this.lblFecha.Text = DateTime.Now.ToLongDateString();

            this.lblTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void IniciarHilo()
        {
            //Task hilo = new Task();
            Task.Run(this.InvocarHilo);
            
        }

        private void InvocarHilo()
        {

            if (this.InvokeRequired)
            {
                Action action = this.ActualizarFecha;
                try
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        this.Invoke(action);
                    }
                }
                catch(Exception)
                {
                    //No hago nada jajaja
                }
            }
            else
            {
                this.ActualizarFecha();
            }
        }


        #endregion

        #region Metodos

        private void MostrarFormulario(Form form)
        {
            this.formActivo.Visible = false;
            form.MdiParent = this;
            form.Show();
            this.formActivo = form;
        }

        #endregion

        #region Metodos eventos propios

        public static void EnviarAvisoCambioSql()
        {
            if (FormPrincipal.AvisoCambiosSql is not null)
            {
                FormPrincipal.AvisoCambiosSql.Invoke();
            }
        }

        #endregion

    }
}
