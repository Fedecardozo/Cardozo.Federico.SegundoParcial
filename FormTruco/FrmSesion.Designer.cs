
namespace FormTruco
{
    partial class FrmSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContenedorImage = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelContenedorImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.BtnRegistrarse);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.panelContenedorImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 354);
            this.panel1.TabIndex = 0;
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegistrarse.Location = new System.Drawing.Point(320, 249);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(177, 50);
            this.BtnRegistrarse.TabIndex = 14;
            this.BtnRegistrarse.Text = "REGISTRARSE";
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(541, 249);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 50);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(320, 177);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "CONTRASEÑA";
            this.textBoxPassword.Size = new System.Drawing.Size(398, 33);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.Location = new System.Drawing.Point(320, 98);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PlaceholderText = "USUARIO";
            this.textBoxUser.Size = new System.Drawing.Size(398, 33);
            this.textBoxUser.TabIndex = 11;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(455, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(103, 53);
            this.labelTitulo.TabIndex = 10;
            this.labelTitulo.Text = "Login";
            // 
            // panelContenedorImage
            // 
            this.panelContenedorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelContenedorImage.Controls.Add(this.pictureBoxIcon);
            this.panelContenedorImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedorImage.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorImage.Name = "panelContenedorImage";
            this.panelContenedorImage.Size = new System.Drawing.Size(244, 354);
            this.panelContenedorImage.TabIndex = 9;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(26, 66);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(183, 216);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // FrmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 401);
            this.MinimumSize = new System.Drawing.Size(818, 401);
            this.Name = "FrmSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContenedorImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelContenedorImage;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button BtnRegistrarse;
    }
}