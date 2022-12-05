
namespace FormTruco
{
    partial class FrmDataGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.btnCreador = new System.Windows.Forms.Button();
            this.btnPartida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.AllowUserToAddRows = false;
            this.dataGridViewSalas.AllowUserToDeleteRows = false;
            this.dataGridViewSalas.AllowUserToResizeRows = false;
            this.dataGridViewSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSalas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSalas.EnableHeadersVisualStyles = false;
            this.dataGridViewSalas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.ReadOnly = true;
            this.dataGridViewSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSalas.RowHeadersVisible = false;
            this.dataGridViewSalas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSalas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSalas.RowTemplate.Height = 29;
            this.dataGridViewSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalas.Size = new System.Drawing.Size(732, 275);
            this.dataGridViewSalas.TabIndex = 6;
            this.dataGridViewSalas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSalas_CellMouseClick);
            // 
            // btnCreador
            // 
            this.btnCreador.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreador.FlatAppearance.BorderSize = 0;
            this.btnCreador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreador.Location = new System.Drawing.Point(394, 299);
            this.btnCreador.Name = "btnCreador";
            this.btnCreador.Size = new System.Drawing.Size(159, 44);
            this.btnCreador.TabIndex = 16;
            this.btnCreador.Text = "Ver creador";
            this.btnCreador.UseVisualStyleBackColor = false;
            this.btnCreador.Click += new System.EventHandler(this.btnCreador_Click);
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPartida.FlatAppearance.BorderSize = 0;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPartida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPartida.Location = new System.Drawing.Point(181, 299);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(159, 44);
            this.btnPartida.TabIndex = 15;
            this.btnPartida.Text = "Ver partida";
            this.btnPartida.UseVisualStyleBackColor = false;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // FrmDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 364);
            this.Controls.Add(this.btnCreador);
            this.Controls.Add(this.btnPartida);
            this.Controls.Add(this.dataGridViewSalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(732, 364);
            this.MinimumSize = new System.Drawing.Size(732, 364);
            this.Name = "FrmDataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataGrid";
            this.Load += new System.EventHandler(this.FrmDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewSalas;
        protected internal System.Windows.Forms.Button btnCreador;
        protected internal System.Windows.Forms.Button btnPartida;
    }
}