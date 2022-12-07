using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormTruco
{
    public partial class FrmEstadisticas : FrmPadre
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Maximo creador de salas Fefede");
            sb.AppendLine();
            sb.AppendLine($"Mayor ganador de partidas Chanito98");
            sb.AppendLine();
            sb.AppendLine($"Cantidad de salas cancelas 20");
            sb.AppendLine();
            sb.AppendLine($"Cantidad de partidas finalizadas 12");

            this.textBoxInfo.Text = sb.ToString();

        }
    }
}
