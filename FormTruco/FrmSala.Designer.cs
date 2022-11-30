
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
            this.textBoxJ2 = new System.Windows.Forms.TextBox();
            this.textBoxJ1 = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxSala = new System.Windows.Forms.TextBox();
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
            this.btnAceptar.Size = new System.Drawing.Size(398, 50);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBoxJ2
            // 
            this.textBoxJ2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJ2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJ2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxJ2.Location = new System.Drawing.Point(25, 259);
            this.textBoxJ2.Name = "textBoxJ2";
            this.textBoxJ2.PlaceholderText = "Nombre/alias jugador 2";
            this.textBoxJ2.Size = new System.Drawing.Size(398, 33);
            this.textBoxJ2.TabIndex = 16;
            // 
            // textBoxJ1
            // 
            this.textBoxJ1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJ1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJ1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxJ1.Location = new System.Drawing.Point(25, 188);
            this.textBoxJ1.Name = "textBoxJ1";
            this.textBoxJ1.PlaceholderText = "Nombre/alias jugador 1";
            this.textBoxJ1.Size = new System.Drawing.Size(398, 33);
            this.textBoxJ1.TabIndex = 15;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(160, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(124, 53);
            this.labelTitulo.TabIndex = 14;
            this.labelTitulo.Text = "DATOS";
            // 
            // textBoxSala
            // 
            this.textBoxSala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSala.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSala.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSala.Location = new System.Drawing.Point(25, 111);
            this.textBoxSala.Name = "textBoxSala";
            this.textBoxSala.PlaceholderText = "Nombre de la sala";
            this.textBoxSala.Size = new System.Drawing.Size(398, 33);
            this.textBoxSala.TabIndex = 18;
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 418);
            this.Controls.Add(this.textBoxSala);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxJ2);
            this.Controls.Add(this.textBoxJ1);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textBoxJ2;
        private System.Windows.Forms.TextBox textBoxJ1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxSala;
    }
}