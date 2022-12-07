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
        // private string usuarioBorrado;

        #region Atributos

        private Func<string, string, string,bool> nuevaSala;

        #endregion

        #region Inicio form

        public FrmSala(Func<string, string, string,bool> funcion)
        {
            InitializeComponent();
            this.nuevaSala = funcion;
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            this.CargarComboBox();
        }

        #endregion

        #region Boton Aceptar

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.comboBoxJ1.SelectedIndex >=0 && this.comboBoxJ2.SelectedIndex >=0 && !string.IsNullOrWhiteSpace(this.textBoxSala.Text))
            {
                if(this.nuevaSala.Invoke(this.comboBoxJ1.Text, this.comboBoxJ2.Text, this.textBoxSala.Text))
                {
                    FormPrincipal.EnviarAvisoCambioSql();
                    MessageBox.Show("Se creo con exito la sala!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar la sala a la base de datos. \nIntente más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodo

        private void CargarComboBox()
        {
            if (Usuario.ObtenerListaUsuarios(out List<Usuario> usuarios))
            {
                foreach (Usuario item in usuarios)
                {
                    this.comboBoxJ1.Items.Add(item.Name_User);
                    this.comboBoxJ2.Items.Add(item.Name_User);
                }
            }
        }

        #endregion

        #region Eventos combo box

        private void comboBoxJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxJ1.SelectedIndex == this.comboBoxJ2.SelectedIndex)
            {
                this.comboBoxJ1.Items.RemoveAt(this.comboBoxJ1.SelectedIndex);   
            }
        }

        private void comboBoxJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxJ1.SelectedIndex == this.comboBoxJ2.SelectedIndex)
            {
                this.comboBoxJ2.Items.RemoveAt(this.comboBoxJ2.SelectedIndex);
            }
        }

        #endregion

    }
}
