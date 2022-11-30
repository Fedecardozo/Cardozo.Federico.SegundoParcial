﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTruco
{
    public partial class FrmCrearSala : FrmPadre
    {
        //private int contSala;
        ///private Point posicionPanel;

        public FrmCrearSala()
        {
            InitializeComponent();
            //this.contSala = 0;
           // this.posicionPanel = new Point(197, 12);
        }

        private void pictureBoxMas_Click(object sender, EventArgs e)
        {
            //this.panelMas.Visible = true;
            FrmSala nuevaSala = new FrmSala(AgregarSala);
            nuevaSala.ShowDialog();
        }

        private void AgregarSala(string j1, string j2, string sala)
        {
            this.dataGridViewSalas.Rows.Add(1,sala,"En juego",j1,j2);
        }


        private void btnJugar_Click(object sender, EventArgs e)
        {
            FrmJuegoTruco frmJuego = new FrmJuegoTruco();
            frmJuego.Show();
        }

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
