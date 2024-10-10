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
    public partial class FormCongruencialMulcs : Form
    {
        public FormCongruencialMulcs()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int semilla = int.Parse(txtSemilla.Text);
            int a = int.Parse(txtMultiplicativa.Text);
            int modulo = int.Parse(txtModulo.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string resultados = "";

            for (int i = 0; i < cantidad; i++)
            {
                int nuevoNumero = (a * semilla) % modulo;
                semilla = nuevoNumero;

                double resultadoDecimal = nuevoNumero / (double)modulo;
                resultados += resultadoDecimal.ToString("0.0000") + "\n";
            }

            txtResultados.Text = resultados;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtSemilla.Text = "";
            txtModulo.Text = "";
            txtMultiplicativa.Text = "";
            txtCantidad.Text = "";

            txtResultados.Clear();
        }
    }
}
