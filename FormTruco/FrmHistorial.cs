﻿using System;
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
    public partial class FrmHistorial : FrmPadre
    {
        #region Atributos

        private List<Sala> salas;

        #endregion

        #region Inicio

        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            this.salas = new List<Sala>();
            this.CargarHistorial();
        }

        #endregion

        #region Metodos

        private void CargarHistorial()
        {
            if(Sala.ObtenerListaSala_Sql(this.salas))
            {
                foreach (Sala item in this.salas)
                {
                    this.dataGridViewSalas.Rows.Add(item.Id,item.NameSala,item.NameJ1,item.NameJ2,item.Fk_Usuario,item.Estado, item.Fecha, item.Fk_Resultado);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el historial", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //MessageBox.Show($"Respuesta: {rta}");
        }

        private void MostrarCreador()
        {
        
            if(Usuario.ObtenerUsuarioId_Sql((int)this.dataGridViewSalas.CurrentRow.Cells["fk_usuario"].Value,out Usuario usuario))
            {
                MessageBox.Show(usuario.ToString(), "Información creador",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al obtener información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarResultado()
        {

            if (Resultado.ObtenerResultadoId_Sql((int)this.dataGridViewSalas.CurrentRow.Cells["fk_juego"].Value, out Resultado resultado))
            {
                MessageBox.Show(resultado.ToString(), "Información resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al obtener información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones

        private void btnCreador_Click(object sender, EventArgs e)
        {
            this.MostrarCreador();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            this.MostrarResultado();
        }

        #endregion
    }
}
