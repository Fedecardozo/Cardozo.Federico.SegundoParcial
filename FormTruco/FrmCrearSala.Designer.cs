
namespace FormTruco
{
    partial class FrmCrearSala
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPartida = new System.Windows.Forms.Button();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCreador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIniciar.Location = new System.Drawing.Point(561, 231);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(159, 44);
            this.btnIniciar.TabIndex = 19;
            this.btnIniciar.Text = "Iniciar partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartida.FlatAppearance.BorderSize = 0;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPartida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPartida.Location = new System.Drawing.Point(561, 23);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(159, 44);
            this.btnPartida.TabIndex = 18;
            this.btnPartida.Text = "Ver partida";
            this.btnPartida.UseVisualStyleBackColor = false;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.AllowUserToAddRows = false;
            this.dataGridViewSalas.AllowUserToDeleteRows = false;
            this.dataGridViewSalas.AllowUserToResizeRows = false;
            this.dataGridViewSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSalas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSalas.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSalas.EnableHeadersVisualStyles = false;
            this.dataGridViewSalas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.ReadOnly = true;
            this.dataGridViewSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSalas.RowHeadersVisible = false;
            this.dataGridViewSalas.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSalas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSalas.RowTemplate.Height = 29;
            this.dataGridViewSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalas.Size = new System.Drawing.Size(543, 364);
            this.dataGridViewSalas.TabIndex = 17;
            this.dataGridViewSalas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSalas_CellMouseClick);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCrear.Location = new System.Drawing.Point(561, 161);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(159, 44);
            this.btnCrear.TabIndex = 20;
            this.btnCrear.Text = "Crear sala";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(561, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 44);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar sala";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCreador
            // 
            this.btnCreador.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreador.FlatAppearance.BorderSize = 0;
            this.btnCreador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreador.Location = new System.Drawing.Point(561, 93);
            this.btnCreador.Name = "btnCreador";
            this.btnCreador.Size = new System.Drawing.Size(159, 44);
            this.btnCreador.TabIndex = 22;
            this.btnCreador.Text = "Ver creador";
            this.btnCreador.UseVisualStyleBackColor = false;
            this.btnCreador.Click += new System.EventHandler(this.btnCreador_Click);
            // 
            // FrmCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 364);
            this.Controls.Add(this.btnCreador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPartida);
            this.Controls.Add(this.dataGridViewSalas);
            this.Name = "FrmCrearSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearSala";
            this.Load += new System.EventHandler(this.FrmCrearSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        protected internal System.Windows.Forms.Button btnPartida;
        protected internal System.Windows.Forms.DataGridView dataGridViewSalas;
        protected internal System.Windows.Forms.Button btnCrear;
        protected internal System.Windows.Forms.Button btnCancelar;
        protected internal System.Windows.Forms.Button btnCreador;
    }
}