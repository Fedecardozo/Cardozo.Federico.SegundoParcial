using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTruco
{
    public partial class FrmSala : Form
    {
        public delegate void delegadoNuevasala(string j1, string j2, string sala);
        private delegadoNuevasala nuevaSala;

        public FrmSala(delegadoNuevasala nuevaSala)
        {
            InitializeComponent();
            this.nuevaSala = nuevaSala;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //this.nuevaSala(this.textBoxJ1.Text,this.textBoxJ2.Text,this.textBoxSala.Text);
            this.nuevaSala.Invoke(this.textBoxJ1.Text, this.textBoxJ2.Text, this.textBoxSala.Text);
            this.Close();
        }
    }
}
