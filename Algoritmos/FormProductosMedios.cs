using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class FormProductosMedios : Form
    {
        public FormProductosMedios()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int semilla1 = int.Parse(txtSemilla1.Text);
            int semilla2 = int.Parse(txtSemilla2.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string resultados = "";

            for (int i = 0; i < cantidad; i++)
            {
                int producto = semilla1 * semilla2;
                string productoStr = producto.ToString().PadLeft(8, '0');
                string numeroMedio = productoStr.Substring(2, 4);
                semilla1 = semilla2;
                semilla2 = int.Parse(numeroMedio);

                double resultadoDecimal = semilla2 / 10000.0;
                resultados += resultadoDecimal.ToString("0.0000") + "\n";
            }

            txtResultados.Text = resultados;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtSemilla1.Text = "";
            txtSemilla2.Text = "";
            txtCantidad.Text = "";

            txtResultados.Clear();
        }
    }
}
