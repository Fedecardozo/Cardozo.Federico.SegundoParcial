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
    public partial class FrmSala : Form
    {
        public delegate void delegadoNuevasala(string j1, string j2, string sala);
        private delegadoNuevasala nuevaSala;
        // private string usuarioBorrado;

        #region Inicio form

        public FrmSala(delegadoNuevasala nuevaSala)
        {
            InitializeComponent();
            this.nuevaSala = nuevaSala;
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            this.CargarComboBox();
        }

        #endregion

        #region Boton

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Metodo

        private void CargarComboBox()
        {
            if (Usuario.ObtenerListaUsuarios(out List<Usuario> usuarios))
            {
                foreach (Usuario item in usuarios)
                {
                    this.comboBoxJ1.Items.Add(item.Nombre);
                    this.comboBoxJ2.Items.Add(item.Nombre);
                }
            }
        }

        #endregion

        #region Eventos combo box

        private void comboBoxJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.usuarioBorrado = this.comboBoxJ1.SelectedItem.ToString();
            this.comboBoxJ2.Items.Remove(this.comboBoxJ2.Items[this.comboBoxJ1.SelectedIndex]);
        }

        private void comboBoxJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.usuarioBorrado = this.comboBoxJ2.SelectedItem.ToString();
            this.comboBoxJ1.Items.Remove(this.comboBoxJ1.Items[this.comboBoxJ2.SelectedIndex]);
        }

        #endregion
    }
}
