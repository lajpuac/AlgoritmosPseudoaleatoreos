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
    public partial class FormCongruencialMixto : Form
    {
        public FormCongruencialMixto()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtSemilla.Text = "";
            txtMultiplicativa.Text = "";
            txtAditiva.Text = "";
            txtModulo.Text = "";
            txtCantidad.Text = "";

            txtResultados.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int semilla = int.Parse(txtSemilla.Text);
            int a = int.Parse(txtMultiplicativa.Text);
            int c = int.Parse(txtAditiva.Text);
            int modulo = int.Parse(txtModulo.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string resultados = "";

            for (int i = 0; i < cantidad; i++)
            {
                int nuevoNumero = (a * semilla + c) % modulo;
                semilla = nuevoNumero;

                double resultadoDecimal = nuevoNumero / (double)modulo;
                resultados += resultadoDecimal.ToString("0.0000") + "\n";
            }

            txtResultados.Text = resultados;
        }
    }
}
