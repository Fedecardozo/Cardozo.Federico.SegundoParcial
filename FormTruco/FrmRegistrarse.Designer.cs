
namespace FormTruco
{
    partial class FrmRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarse));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.textBoxRepetirPasswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsuario.Location = new System.Drawing.Point(46, 117);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PlaceholderText = "Nombre de usuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(398, 33);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(272, 388);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 50);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellido.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxApellido.Location = new System.Drawing.Point(46, 224);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.PlaceholderText = "Apellido";
            this.textBoxApellido.Size = new System.Drawing.Size(398, 33);
            this.textBoxApellido.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNombre.Location = new System.Drawing.Point(46, 170);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(398, 33);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(172, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(124, 53);
            this.labelTitulo.TabIndex = 19;
            this.labelTitulo.Text = "DATOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(46, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 50);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCorreo.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCorreo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCorreo.Location = new System.Drawing.Point(46, 65);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.PlaceholderText = "Correo";
            this.textBoxCorreo.Size = new System.Drawing.Size(398, 33);
            this.textBoxCorreo.TabIndex = 1;
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPasswd.Location = new System.Drawing.Point(46, 277);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PlaceholderText = "Contraseña";
            this.textBoxPasswd.Size = new System.Drawing.Size(398, 33);
            this.textBoxPasswd.TabIndex = 5;
            // 
            // textBoxRepetirPasswd
            // 
            this.textBoxRepetirPasswd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRepetirPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRepetirPasswd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRepetirPasswd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRepetirPasswd.Location = new System.Drawing.Point(46, 328);
            this.textBoxRepetirPasswd.Name = "textBoxRepetirPasswd";
            this.textBoxRepetirPasswd.PlaceholderText = "Repetir contraseña";
            this.textBoxRepetirPasswd.Size = new System.Drawing.Size(398, 33);
            this.textBoxRepetirPasswd.TabIndex = 6;
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.textBoxRepetirPasswd);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.TextBox textBoxRepetirPasswd;
    }
}