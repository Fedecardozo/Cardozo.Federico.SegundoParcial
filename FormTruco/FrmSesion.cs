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
    
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void FrmSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.InicioSesion();
        }

        private void InicioSesion()
        {
            Usuario user;

            //MessageBox.Show(Validacion.ValidarUsuario(user).ToString());
            if (Usuario.ConsultarCorreo(this.textBoxUser.Text, out user))
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

    }
}
