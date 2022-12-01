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
        ///private Point posicionPanel;

        #endregion

        #region Inicio Form

        public FrmCrearSala()
        {
            InitializeComponent();
            // this.posicionPanel = new Point(197, 12);
        }

        private void FrmCrearSala_Load(object sender, EventArgs e)
        {
            this.contSala = 0;
            this.trucos = new List<FrmJuegoTruco>();
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

        private void AgregarSala(string j1, string j2, string sala)
        {
            //Agregar a la base de datos y de la base de datos al dataGrid
            bool rta = Sala.AgregarSala_Sql(new Sala(j1,j2,sala,1,EestadoPartida.Finalizada,3));

            MessageBox.Show($"REspuesta: {rta}");

            this.dataGridViewSalas.Rows.Add(1, sala, "En juego", j1, j2);
            this.contSala++;
        }

        private void IniciarPartida()
        {
            //Sala sala = (Sala)this.dataGridViewSalas.CurrentRow.DataBoundItem; //obtener sala seleccionada
            int indexFilaSeleccionada = this.dataGridViewSalas.CurrentRow.Index;
            string nameJ1 = (string)this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells[3].Value;
            string nameJ2 = (string)this.dataGridViewSalas.Rows[indexFilaSeleccionada].Cells[4].Value;
            //MessageBox.Show(nameJ1);

            this.trucos.Add(new FrmJuegoTruco(nameJ1, nameJ2));
            this.trucos[indexFilaSeleccionada].Show();
        }

        #endregion

        #region Idea mala

        /*private void AgregarSala(string j1, string j2, string sala)
        {
            //this.labelNombreJ1.Text = j1;
            //this.labelNombreJ2.Text = j2;
            //this.labelSala.Text = sala;
            //this.panelMas.Visible = true;

            this.contSala++;

            this.Controls.Add(this.CrearPanelSala(j1,j2,sala));
        }

        #region Crear controles

        private Panel CrearPanelSala(string j1, string j2,string nombreSala)
        {
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel.Controls.Add(this.CrearLabel($"labelNombreJ{2}_{this.contSala}",$"J2:  {j2}",96));
            panel.Controls.Add(this.CrearLabel($"labelNombreJ{1}_{this.contSala}", $"J1:  {j1}",53));
            panel.Controls.Add(this.CrearLabel(nombreSala,nombreSala,13));
            panel.Location = this.posicionPanel;
            panel.Name = $"panelMas{this.contSala}";
            panel.Size = new System.Drawing.Size(162, 135);
            panel.TabIndex = 0;
            panel.Visible = true;

            if(this.contSala == 3)
            {
                this.posicionPanel.Y += 150;
                this.posicionPanel.X = -165;
            }

           this.posicionPanel.X += 180;

            return panel;
        }

        private Label CrearLabel(string name,string msj, int posicion)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(13, posicion);
            label.Name = name;
            label.Size = new System.Drawing.Size(80, 28);
            label.Text = msj;

            return label;
        }


        #endregion

        */

        #endregion

        
    }
}
