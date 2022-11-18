
namespace FormTruco
{
    partial class FrmJuegoTruco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMesa = new System.Windows.Forms.Panel();
            this.labelCanto = new System.Windows.Forms.Label();
            this.pictureBoxMazo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMazo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ2C3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ2C2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ2C1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ1C3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ1C2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJ1C1 = new System.Windows.Forms.PictureBox();
            this.panelLateralDer = new System.Windows.Forms.Panel();
            this.dataGridViewAnotador = new System.Windows.Forms.DataGridView();
            this.J1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxJ1 = new System.Windows.Forms.GroupBox();
            this.panelLateralIzq = new System.Windows.Forms.Panel();
            this.groupBoxJ2 = new System.Windows.Forms.GroupBox();
            this.panelContenedor.SuspendLayout();
            this.panelMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C1)).BeginInit();
            this.panelLateralDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnotador)).BeginInit();
            this.panelLateralIzq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.panelMesa);
            this.panelContenedor.Controls.Add(this.panelLateralDer);
            this.panelContenedor.Controls.Add(this.panelLateralIzq);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1360, 628);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelMesa
            // 
            this.panelMesa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMesa.Controls.Add(this.labelCanto);
            this.panelMesa.Controls.Add(this.pictureBoxMazo1);
            this.panelMesa.Controls.Add(this.pictureBoxMazo2);
            this.panelMesa.Controls.Add(this.pictureBoxJ2C3);
            this.panelMesa.Controls.Add(this.pictureBoxJ2C2);
            this.panelMesa.Controls.Add(this.pictureBoxJ2C1);
            this.panelMesa.Controls.Add(this.pictureBoxJ1C3);
            this.panelMesa.Controls.Add(this.pictureBoxJ1C2);
            this.panelMesa.Controls.Add(this.pictureBoxJ1C1);
            this.panelMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesa.Location = new System.Drawing.Point(294, 0);
            this.panelMesa.Name = "panelMesa";
            this.panelMesa.Size = new System.Drawing.Size(772, 628);
            this.panelMesa.TabIndex = 3;
            // 
            // labelCanto
            // 
            this.labelCanto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCanto.AutoSize = true;
            this.labelCanto.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCanto.Location = new System.Drawing.Point(221, 287);
            this.labelCanto.Name = "labelCanto";
            this.labelCanto.Size = new System.Drawing.Size(332, 57);
            this.labelCanto.TabIndex = 19;
            this.labelCanto.Text = "Jugador 1: Truco";
            this.labelCanto.Visible = false;
            // 
            // pictureBoxMazo1
            // 
            this.pictureBoxMazo1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxMazo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMazo1.Location = new System.Drawing.Point(30, 238);
            this.pictureBoxMazo1.Name = "pictureBoxMazo1";
            this.pictureBoxMazo1.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxMazo1.TabIndex = 18;
            this.pictureBoxMazo1.TabStop = false;
            // 
            // pictureBoxMazo2
            // 
            this.pictureBoxMazo2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxMazo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMazo2.Image = global::FormTruco.Properties.Resources.mazo;
            this.pictureBoxMazo2.Location = new System.Drawing.Point(643, 238);
            this.pictureBoxMazo2.Name = "pictureBoxMazo2";
            this.pictureBoxMazo2.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxMazo2.TabIndex = 17;
            this.pictureBoxMazo2.TabStop = false;
            // 
            // pictureBoxJ2C3
            // 
            this.pictureBoxJ2C3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxJ2C3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ2C3.Image = global::FormTruco.Properties.Resources._2copa;
            this.pictureBoxJ2C3.Location = new System.Drawing.Point(493, 24);
            this.pictureBoxJ2C3.Name = "pictureBoxJ2C3";
            this.pictureBoxJ2C3.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ2C3.TabIndex = 16;
            this.pictureBoxJ2C3.TabStop = false;
            // 
            // pictureBoxJ2C2
            // 
            this.pictureBoxJ2C2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxJ2C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ2C2.Image = global::FormTruco.Properties.Resources._1oro;
            this.pictureBoxJ2C2.Location = new System.Drawing.Point(344, 24);
            this.pictureBoxJ2C2.Name = "pictureBoxJ2C2";
            this.pictureBoxJ2C2.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ2C2.TabIndex = 15;
            this.pictureBoxJ2C2.TabStop = false;
            // 
            // pictureBoxJ2C1
            // 
            this.pictureBoxJ2C1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxJ2C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ2C1.Image = global::FormTruco.Properties.Resources._7oro;
            this.pictureBoxJ2C1.Location = new System.Drawing.Point(192, 24);
            this.pictureBoxJ2C1.Name = "pictureBoxJ2C1";
            this.pictureBoxJ2C1.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ2C1.TabIndex = 14;
            this.pictureBoxJ2C1.TabStop = false;
            // 
            // pictureBoxJ1C3
            // 
            this.pictureBoxJ1C3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxJ1C3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ1C3.Image = global::FormTruco.Properties.Resources._1espada;
            this.pictureBoxJ1C3.Location = new System.Drawing.Point(493, 452);
            this.pictureBoxJ1C3.Name = "pictureBoxJ1C3";
            this.pictureBoxJ1C3.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ1C3.TabIndex = 13;
            this.pictureBoxJ1C3.TabStop = false;
            // 
            // pictureBoxJ1C2
            // 
            this.pictureBoxJ1C2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxJ1C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ1C2.Image = global::FormTruco.Properties.Resources._10oro;
            this.pictureBoxJ1C2.Location = new System.Drawing.Point(344, 452);
            this.pictureBoxJ1C2.Name = "pictureBoxJ1C2";
            this.pictureBoxJ1C2.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ1C2.TabIndex = 12;
            this.pictureBoxJ1C2.TabStop = false;
            // 
            // pictureBoxJ1C1
            // 
            this.pictureBoxJ1C1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxJ1C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJ1C1.Image = global::FormTruco.Properties.Resources._11basto;
            this.pictureBoxJ1C1.Location = new System.Drawing.Point(192, 452);
            this.pictureBoxJ1C1.Name = "pictureBoxJ1C1";
            this.pictureBoxJ1C1.Size = new System.Drawing.Size(100, 153);
            this.pictureBoxJ1C1.TabIndex = 11;
            this.pictureBoxJ1C1.TabStop = false;
            // 
            // panelLateralDer
            // 
            this.panelLateralDer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLateralDer.Controls.Add(this.dataGridViewAnotador);
            this.panelLateralDer.Controls.Add(this.groupBoxJ1);
            this.panelLateralDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateralDer.Location = new System.Drawing.Point(1066, 0);
            this.panelLateralDer.Name = "panelLateralDer";
            this.panelLateralDer.Size = new System.Drawing.Size(294, 628);
            this.panelLateralDer.TabIndex = 2;
            // 
            // dataGridViewAnotador
            // 
            this.dataGridViewAnotador.AllowUserToDeleteRows = false;
            this.dataGridViewAnotador.AllowUserToResizeColumns = false;
            this.dataGridViewAnotador.AllowUserToResizeRows = false;
            this.dataGridViewAnotador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnotador.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAnotador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAnotador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnotador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAnotador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnotador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.J1,
            this.J2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnotador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAnotador.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAnotador.Enabled = false;
            this.dataGridViewAnotador.EnableHeadersVisualStyles = false;
            this.dataGridViewAnotador.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAnotador.Name = "dataGridViewAnotador";
            this.dataGridViewAnotador.ReadOnly = true;
            this.dataGridViewAnotador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnotador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAnotador.RowHeadersVisible = false;
            this.dataGridViewAnotador.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewAnotador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAnotador.RowTemplate.Height = 29;
            this.dataGridViewAnotador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnotador.Size = new System.Drawing.Size(294, 217);
            this.dataGridViewAnotador.TabIndex = 2;
            // 
            // J1
            // 
            this.J1.HeaderText = "Jugador 1";
            this.J1.MinimumWidth = 6;
            this.J1.Name = "J1";
            this.J1.ReadOnly = true;
            // 
            // J2
            // 
            this.J2.HeaderText = "Jugador 2";
            this.J2.MinimumWidth = 6;
            this.J2.Name = "J2";
            this.J2.ReadOnly = true;
            // 
            // groupBoxJ1
            // 
            this.groupBoxJ1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxJ1.Location = new System.Drawing.Point(0, 352);
            this.groupBoxJ1.Name = "groupBoxJ1";
            this.groupBoxJ1.Size = new System.Drawing.Size(294, 276);
            this.groupBoxJ1.TabIndex = 1;
            this.groupBoxJ1.TabStop = false;
            this.groupBoxJ1.Text = "Botones Jugador 1";
            // 
            // panelLateralIzq
            // 
            this.panelLateralIzq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLateralIzq.Controls.Add(this.groupBoxJ2);
            this.panelLateralIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralIzq.Location = new System.Drawing.Point(0, 0);
            this.panelLateralIzq.Name = "panelLateralIzq";
            this.panelLateralIzq.Size = new System.Drawing.Size(294, 628);
            this.panelLateralIzq.TabIndex = 1;
            // 
            // groupBoxJ2
            // 
            this.groupBoxJ2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJ2.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJ2.Name = "groupBoxJ2";
            this.groupBoxJ2.Size = new System.Drawing.Size(294, 276);
            this.groupBoxJ2.TabIndex = 0;
            this.groupBoxJ2.TabStop = false;
            this.groupBoxJ2.Text = "Botones Jugador 2";
            // 
            // FrmJuegoTruco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 628);
            this.Controls.Add(this.panelContenedor);
            this.MinimumSize = new System.Drawing.Size(1378, 675);
            this.Name = "FrmJuegoTruco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelContenedor.ResumeLayout(false);
            this.panelMesa.ResumeLayout(false);
            this.panelMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ2C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJ1C1)).EndInit();
            this.panelLateralDer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnotador)).EndInit();
            this.panelLateralIzq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelLateralDer;
        private System.Windows.Forms.Panel panelLateralIzq;
        private System.Windows.Forms.GroupBox groupBoxJ2;
        private System.Windows.Forms.Panel panelMesa;
        private System.Windows.Forms.PictureBox pictureBoxMazo1;
        private System.Windows.Forms.PictureBox pictureBoxMazo2;
        private System.Windows.Forms.PictureBox pictureBoxJ2C3;
        private System.Windows.Forms.PictureBox pictureBoxJ2C2;
        private System.Windows.Forms.PictureBox pictureBoxJ2C1;
        private System.Windows.Forms.PictureBox pictureBoxJ1C3;
        private System.Windows.Forms.PictureBox pictureBoxJ1C2;
        private System.Windows.Forms.PictureBox pictureBoxJ1C1;
        private System.Windows.Forms.GroupBox groupBoxJ1;
        private System.Windows.Forms.Label labelCanto;
        private System.Windows.Forms.DataGridView dataGridViewAnotador;
        private System.Windows.Forms.DataGridViewTextBoxColumn J1;
        private System.Windows.Forms.DataGridViewTextBoxColumn J2;
    }
}

