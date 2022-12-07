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
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.VerificarDatosTextBox())
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                Usuario user = new Usuario(this.textBoxCorreo.Text, this.textBoxNombre.Text, this.textBoxApellido.Text, 
                    this.textBoxPasswd.Text,this.textBoxUsuario.Text);
                if(user.Insert_Sql())
                {
                    MessageBox.Show("Se registro con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerificarDatosTextBox()
        {
            bool retorno = false;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox itemText && string.IsNullOrWhiteSpace(itemText.Text))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

    }
}
