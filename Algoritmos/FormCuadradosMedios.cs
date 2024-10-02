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
    public partial class FormCuadradosMedios : Form
    {
        public FormCuadradosMedios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int semilla = int.Parse(txtSemilla.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string resultados = "";

            for (int i = 0; i < cantidad; i++)
            {
                int cuadrado = semilla * semilla;
                string cuadradoStr = cuadrado.ToString().PadLeft(8, '0'); 
                string numeroMedio = cuadradoStr.Substring(2, 4);
                semilla = int.Parse(numeroMedio);

                double resultadoDecimal = semilla / 10000.0;
                resultados += resultadoDecimal.ToString("0.0000") + "\n";
            }

            txtResultados.Text = resultados;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtSemilla.Text = "";
            txtCantidad.Text = "";

            txtResultados.Clear();
        }
    }
}
