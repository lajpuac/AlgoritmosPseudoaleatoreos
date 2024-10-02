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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            FormCuadradosMedios formCuadrados = new FormCuadradosMedios();
            formCuadrados.Show();
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            FormProductosMedios formProductos = new FormProductosMedios();
            formProductos.Show();
        }

        private void btnMulConstante_Click(object sender, EventArgs e)
        {
            FormMultiConstante formMultiplicador = new FormMultiConstante();
            formMultiplicador.Show();
        }
    }
}
