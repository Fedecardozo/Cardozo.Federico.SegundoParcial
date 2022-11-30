
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearSala));
            this.panelMas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJ2 = new System.Windows.Forms.Label();
            this.labelJ1 = new System.Windows.Forms.Label();
            this.labelSala = new System.Windows.Forms.Label();
            this.pictureBoxMas = new System.Windows.Forms.PictureBox();
            this.panelMas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMas
            // 
            this.panelMas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMas.Controls.Add(this.label2);
            this.panelMas.Controls.Add(this.label1);
            this.panelMas.Controls.Add(this.labelJ2);
            this.panelMas.Controls.Add(this.labelJ1);
            this.panelMas.Controls.Add(this.labelSala);
            this.panelMas.Location = new System.Drawing.Point(197, 12);
            this.panelMas.Name = "panelMas";
            this.panelMas.Size = new System.Drawing.Size(162, 135);
            this.panelMas.TabIndex = 0;
            this.panelMas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Esteban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Federico";
            // 
            // labelJ2
            // 
            this.labelJ2.AutoSize = true;
            this.labelJ2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJ2.Location = new System.Drawing.Point(13, 96);
            this.labelJ2.Name = "labelJ2";
            this.labelJ2.Size = new System.Drawing.Size(34, 28);
            this.labelJ2.TabIndex = 2;
            this.labelJ2.Text = "J2:";
            // 
            // labelJ1
            // 
            this.labelJ1.AutoSize = true;
            this.labelJ1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJ1.Location = new System.Drawing.Point(13, 53);
            this.labelJ1.Name = "labelJ1";
            this.labelJ1.Size = new System.Drawing.Size(34, 28);
            this.labelJ1.TabIndex = 1;
            this.labelJ1.Text = "J1:";
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelSala.Location = new System.Drawing.Point(57, 13);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(48, 28);
            this.labelSala.TabIndex = 0;
            this.labelSala.Text = "Sala";
            // 
            // pictureBoxMas
            // 
            this.pictureBoxMas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxMas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMas.Image")));
            this.pictureBoxMas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMas.Name = "pictureBoxMas";
            this.pictureBoxMas.Size = new System.Drawing.Size(162, 135);
            this.pictureBoxMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMas.TabIndex = 1;
            this.pictureBoxMas.TabStop = false;
            this.pictureBoxMas.Click += new System.EventHandler(this.pictureBoxMas_Click);
            // 
            // FrmCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 364);
            this.Controls.Add(this.pictureBoxMas);
            this.Controls.Add(this.panelMas);
            this.Name = "FrmCrearSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearSala";
            this.panelMas.ResumeLayout(false);
            this.panelMas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMas;
        private System.Windows.Forms.PictureBox pictureBoxMas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelJ2;
        private System.Windows.Forms.Label labelJ1;
        private System.Windows.Forms.Label labelSala;
    }
}