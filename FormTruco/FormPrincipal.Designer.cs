
namespace FormTruco
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelizq = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.panelHora = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelizq.SuspendLayout();
            this.panelHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(254, 80);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelizq
            // 
            this.panelizq.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelizq.Controls.Add(this.btnSalir);
            this.panelizq.Controls.Add(this.btnHistorial);
            this.panelizq.Controls.Add(this.btnEstadistica);
            this.panelizq.Controls.Add(this.btnCrearSala);
            this.panelizq.Controls.Add(this.btnInicio);
            this.panelizq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelizq.Location = new System.Drawing.Point(0, 0);
            this.panelizq.Name = "panelizq";
            this.panelizq.Size = new System.Drawing.Size(254, 413);
            this.panelizq.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(0, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(254, 80);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistorial.Location = new System.Drawing.Point(0, 240);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(254, 80);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadistica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadistica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 160);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(254, 80);
            this.btnEstadistica.TabIndex = 2;
            this.btnEstadistica.Text = "Estadistica";
            this.btnEstadistica.UseVisualStyleBackColor = false;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCrearSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearSala.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCrearSala.FlatAppearance.BorderSize = 0;
            this.btnCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearSala.Location = new System.Drawing.Point(0, 80);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(254, 80);
            this.btnCrearSala.TabIndex = 1;
            this.btnCrearSala.Text = "Salas";
            this.btnCrearSala.UseVisualStyleBackColor = false;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHora.Controls.Add(this.lblTime);
            this.panelHora.Controls.Add(this.lblFecha);
            this.panelHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHora.Location = new System.Drawing.Point(254, 369);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(737, 44);
            this.panelHora.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(510, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 31);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "    ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(133, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 31);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "    ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 413);
            this.Controls.Add(this.panelHora);
            this.Controls.Add(this.panelizq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1009, 460);
            this.MinimumSize = new System.Drawing.Size(1009, 460);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelizq.ResumeLayout(false);
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelizq;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnCrearSala;
        protected System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTime;
    }
}