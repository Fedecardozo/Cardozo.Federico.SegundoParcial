
namespace WinFormsTruco
{
    partial class FrmTruco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.labelCantoJugador1 = new System.Windows.Forms.Label();
            this.labelJugador1C3 = new System.Windows.Forms.Label();
            this.labelJugador1C2 = new System.Windows.Forms.Label();
            this.labelJugador1C1 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelCantojugador2 = new System.Windows.Forms.Label();
            this.labelJugador2C3 = new System.Windows.Forms.Label();
            this.labelJugador2C2 = new System.Windows.Forms.Label();
            this.labelJugador2C1 = new System.Windows.Forms.Label();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMesa = new System.Windows.Forms.Panel();
            this.panelInferior.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelInferior.Controls.Add(this.labelCantoJugador1);
            this.panelInferior.Controls.Add(this.labelJugador1C3);
            this.panelInferior.Controls.Add(this.labelJugador1C2);
            this.panelInferior.Controls.Add(this.labelJugador1C1);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 389);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1015, 129);
            this.panelInferior.TabIndex = 0;
            // 
            // labelCantoJugador1
            // 
            this.labelCantoJugador1.AutoSize = true;
            this.labelCantoJugador1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantoJugador1.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelCantoJugador1.Location = new System.Drawing.Point(804, 16);
            this.labelCantoJugador1.Name = "labelCantoJugador1";
            this.labelCantoJugador1.Size = new System.Drawing.Size(173, 31);
            this.labelCantoJugador1.TabIndex = 7;
            this.labelCantoJugador1.Text = "Lo que se canta";
            // 
            // labelJugador1C3
            // 
            this.labelJugador1C3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJugador1C3.AutoSize = true;
            this.labelJugador1C3.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador1C3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador1C3.Location = new System.Drawing.Point(624, 38);
            this.labelJugador1C3.Name = "labelJugador1C3";
            this.labelJugador1C3.Size = new System.Drawing.Size(87, 38);
            this.labelJugador1C3.TabIndex = 2;
            this.labelJugador1C3.Text = "3 Oro";
            this.labelJugador1C3.Click += new System.EventHandler(this.labelJugador1C3_Click);
            // 
            // labelJugador1C2
            // 
            this.labelJugador1C2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelJugador1C2.AutoSize = true;
            this.labelJugador1C2.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador1C2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador1C2.Location = new System.Drawing.Point(463, 82);
            this.labelJugador1C2.Name = "labelJugador1C2";
            this.labelJugador1C2.Size = new System.Drawing.Size(103, 38);
            this.labelJugador1C2.TabIndex = 1;
            this.labelJugador1C2.Text = "7 Copa";
            this.labelJugador1C2.Click += new System.EventHandler(this.labelJugador1C2_Click);
            // 
            // labelJugador1C1
            // 
            this.labelJugador1C1.AutoSize = true;
            this.labelJugador1C1.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador1C1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador1C1.Location = new System.Drawing.Point(295, 38);
            this.labelJugador1C1.Name = "labelJugador1C1";
            this.labelJugador1C1.Size = new System.Drawing.Size(126, 38);
            this.labelJugador1C1.TabIndex = 0;
            this.labelJugador1C1.Text = "1 Espada";
            this.labelJugador1C1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Red;
            this.panelSuperior.Controls.Add(this.labelCantojugador2);
            this.panelSuperior.Controls.Add(this.labelJugador2C3);
            this.panelSuperior.Controls.Add(this.labelJugador2C2);
            this.panelSuperior.Controls.Add(this.labelJugador2C1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1015, 128);
            this.panelSuperior.TabIndex = 1;
            // 
            // labelCantojugador2
            // 
            this.labelCantojugador2.AutoSize = true;
            this.labelCantojugador2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCantojugador2.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelCantojugador2.Location = new System.Drawing.Point(35, 90);
            this.labelCantojugador2.Name = "labelCantojugador2";
            this.labelCantojugador2.Size = new System.Drawing.Size(173, 31);
            this.labelCantojugador2.TabIndex = 6;
            this.labelCantojugador2.Text = "Lo que se canta";
            // 
            // labelJugador2C3
            // 
            this.labelJugador2C3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJugador2C3.AutoSize = true;
            this.labelJugador2C3.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador2C3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador2C3.Location = new System.Drawing.Point(620, 23);
            this.labelJugador2C3.Name = "labelJugador2C3";
            this.labelJugador2C3.Size = new System.Drawing.Size(87, 38);
            this.labelJugador2C3.TabIndex = 5;
            this.labelJugador2C3.Text = "7 Oro";
            this.labelJugador2C3.Click += new System.EventHandler(this.labelJugador3C3_Click);
            // 
            // labelJugador2C2
            // 
            this.labelJugador2C2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelJugador2C2.AutoSize = true;
            this.labelJugador2C2.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador2C2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador2C2.Location = new System.Drawing.Point(459, 67);
            this.labelJugador2C2.Name = "labelJugador2C2";
            this.labelJugador2C2.Size = new System.Drawing.Size(107, 38);
            this.labelJugador2C2.TabIndex = 4;
            this.labelJugador2C2.Text = "1 Basto";
            this.labelJugador2C2.Click += new System.EventHandler(this.labelJugador2C2_Click);
            // 
            // labelJugador2C1
            // 
            this.labelJugador2C1.AutoSize = true;
            this.labelJugador2C1.BackColor = System.Drawing.Color.AliceBlue;
            this.labelJugador2C1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugador2C1.Location = new System.Drawing.Point(291, 23);
            this.labelJugador2C1.Name = "labelJugador2C1";
            this.labelJugador2C1.Size = new System.Drawing.Size(87, 38);
            this.labelJugador2C1.TabIndex = 3;
            this.labelJugador2C1.Text = "6 Oro";
            this.labelJugador2C1.Click += new System.EventHandler(this.labelJugador2C1_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDerecho.Controls.Add(this.dataGridView1);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(740, 128);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(275, 261);
            this.panelDerecho.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jugador1,
            this.jugador2});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(275, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // jugador1
            // 
            this.jugador1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jugador1.HeaderText = "Jugador 1";
            this.jugador1.MinimumWidth = 6;
            this.jugador1.Name = "jugador1";
            this.jugador1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jugador1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jugador2
            // 
            this.jugador2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jugador2.HeaderText = "Jugador 2";
            this.jugador2.MinimumWidth = 6;
            this.jugador2.Name = "jugador2";
            this.jugador2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jugador2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.AliceBlue;
            this.panelIzquierdo.Controls.Add(this.button7);
            this.panelIzquierdo.Controls.Add(this.button6);
            this.panelIzquierdo.Controls.Add(this.button5);
            this.panelIzquierdo.Controls.Add(this.button4);
            this.panelIzquierdo.Controls.Add(this.button3);
            this.panelIzquierdo.Controls.Add(this.button2);
            this.panelIzquierdo.Controls.Add(this.button1);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 128);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(282, 261);
            this.panelIzquierdo.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.Location = new System.Drawing.Point(145, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Flor";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(77, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Vale cuatro";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(145, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Re truco";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(12, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Truco";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(12, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Falta envido";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(145, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Real envido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Envido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelMesa
            // 
            this.panelMesa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesa.Location = new System.Drawing.Point(282, 128);
            this.panelMesa.Name = "panelMesa";
            this.panelMesa.Size = new System.Drawing.Size(458, 261);
            this.panelMesa.TabIndex = 4;
            // 
            // FrmTruco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 518);
            this.Controls.Add(this.panelMesa);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelInferior);
            this.Name = "FrmTruco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truco";
            this.Load += new System.EventHandler(this.FrmTruco_Load);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMesa;
        private System.Windows.Forms.Label labelJugador1C3;
        private System.Windows.Forms.Label labelJugador1C2;
        private System.Windows.Forms.Label labelJugador1C1;
        private System.Windows.Forms.Label labelJugador2C3;
        private System.Windows.Forms.Label labelJugador2C2;
        private System.Windows.Forms.Label labelJugador2C1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugador2;
        private System.Windows.Forms.Label labelCantoJugador1;
        private System.Windows.Forms.Label labelCantojugador2;
    }
}

