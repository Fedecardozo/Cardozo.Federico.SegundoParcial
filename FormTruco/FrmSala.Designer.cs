
namespace FormTruco
{
    partial class FrmSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSala));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxSala = new System.Windows.Forms.TextBox();
            this.comboBoxJ1 = new System.Windows.Forms.ComboBox();
            this.comboBoxJ2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(25, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(294, 50);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(108, 28);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(124, 53);
            this.labelTitulo.TabIndex = 14;
            this.labelTitulo.Text = "DATOS";
            // 
            // textBoxSala
            // 
            this.textBoxSala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSala.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSala.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSala.Location = new System.Drawing.Point(25, 111);
            this.textBoxSala.Name = "textBoxSala";
            this.textBoxSala.PlaceholderText = "Nombre de la sala";
            this.textBoxSala.Size = new System.Drawing.Size(294, 36);
            this.textBoxSala.TabIndex = 1;
            // 
            // comboBoxJ1
            // 
            this.comboBoxJ1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxJ1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxJ1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxJ1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxJ1.FormattingEnabled = true;
            this.comboBoxJ1.Location = new System.Drawing.Point(25, 183);
            this.comboBoxJ1.Name = "comboBoxJ1";
            this.comboBoxJ1.Size = new System.Drawing.Size(294, 36);
            this.comboBoxJ1.TabIndex = 2;
            this.comboBoxJ1.Text = "Elegir Jugador 1";
            this.comboBoxJ1.SelectedIndexChanged += new System.EventHandler(this.comboBoxJ1_SelectedIndexChanged);
            // 
            // comboBoxJ2
            // 
            this.comboBoxJ2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxJ2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxJ2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxJ2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxJ2.FormattingEnabled = true;
            this.comboBoxJ2.Location = new System.Drawing.Point(25, 255);
            this.comboBoxJ2.Name = "comboBoxJ2";
            this.comboBoxJ2.Size = new System.Drawing.Size(294, 36);
            this.comboBoxJ2.TabIndex = 18;
            this.comboBoxJ2.Text = "Elegir Jugador 2";
            this.comboBoxJ2.SelectedIndexChanged += new System.EventHandler(this.comboBoxJ2_SelectedIndexChanged);
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(346, 418);
            this.Controls.Add(this.comboBoxJ2);
            this.Controls.Add(this.comboBoxJ1);
            this.Controls.Add(this.textBoxSala);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FrmSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxSala;
        private System.Windows.Forms.ComboBox comboBoxJ1;
        private System.Windows.Forms.ComboBox comboBoxJ2;
    }
}