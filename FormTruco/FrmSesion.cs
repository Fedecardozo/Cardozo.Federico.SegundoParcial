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
    public partial class FrmSesion : Form
    {

        #region Constructor 

        public FrmSesion()
        {
            InitializeComponent();
        }

        #endregion

        #region Boton

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.InicioSesion();
        }

        #endregion

        #region Login

        private void InicioSesion()
        {
            Usuario user;

            //MessageBox.Show(Validacion.ValidarUsuario(user).ToString());
            if (Usuario.ConsultarCorreo(this.textBoxUser.Text,this.textBoxPassword.Text, out user))
            {
                //Nuevo formulario con el menu de opciones 
                this.AbrirMenuUsuario(user);
            }
            else
            {
                MessageBox.Show("Usuario o password incorrectos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AbrirMenuUsuario(Usuario user)
        {
            this.Hide();

            FormPrincipal frmMenuUsuario = new FormPrincipal(user);
            //frmMenuUsuario.Show();

            frmMenuUsuario.ShowDialog();

            this.textBoxPassword.Clear();
            this.textBoxUser.Clear();

            this.Show();

        }


        private void TeclaEnterAbreMenu(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.InicioSesion();
            }
        }

        #endregion

        #region Textbox evento enter

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.TeclaEnterAbreMenu(e);
        }

        #endregion
    }
}
