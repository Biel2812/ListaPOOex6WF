using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ05
{
    public partial class frmQuilometragem : Form
    {
        public frmQuilometragem()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Quilometragem q;
            q = new Quilometragem();
            q.setMilhas(int.Parse(txtMilhas.Text));
            q.calcularQuilometros();
            lblResultado.Text = q.getQuilometros().ToString();
        }
    }
}
