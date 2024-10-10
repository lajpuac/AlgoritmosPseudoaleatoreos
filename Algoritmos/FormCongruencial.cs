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
    public partial class FormCongruencial : Form
    {
        public FormCongruencial()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string[] semillasTexto = txtSemillas.Text.Split(' ');
            int[] semillas = Array.ConvertAll(semillasTexto, int.Parse);

            if (semillas.Length < 2)
            {
                MessageBox.Show("Debes ingresar al menos dos semillas.");
                return;
            }

            int modulo = int.Parse(txtModulo.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string resultados = "";

            int semilla1 = semillas[0];
            int semilla2 = semillas[1];

            for (int i = 0; i < cantidad; i++)
            {
                int nuevoNumero = (semilla1 + semilla2) % modulo;
                semilla1 = semilla2;
                semilla2 = nuevoNumero; 

                double resultadoDecimal = nuevoNumero / (double)modulo;
                resultados += resultadoDecimal.ToString("0.0000") + "\n";
            }

            txtResultados.Text = resultados;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtSemillas.Text = "";
            txtModulo.Text = "";
            txtCantidad.Text = "";

            txtResultados.Clear();
        }
    }
}
