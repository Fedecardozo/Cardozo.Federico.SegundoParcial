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
    public partial class FrmInicio : FrmPadre
    {
        private Usuario usuario;
        public FrmInicio(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.labelCorreo.Text = this.usuario.Correo;
            this.labelNombre.Text = this.usuario.Nombre;
            this.labelApellido.Text = this.usuario.Apellido;
            this.labelNameUser.Text = this.usuario.Name_User;
        }
    }
}
