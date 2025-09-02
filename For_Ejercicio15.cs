using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class For_Ejercicio15 : Form
    {
        public For_Ejercicio15()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int ladoUno = Convert.ToInt32(textBoxLado1.Text);
                int ladoDos = Convert.ToInt32(textBoxLado2.Text);
                int ladoTres = Convert.ToInt32(textBoxLado3.Text);
                string tipoTriangulo = string.Empty;
                if ((ladoUno != ladoDos) && (ladoDos != ladoTres) && (ladoTres != ladoDos))
                {
                    tipoTriangulo = "Escaleno";
                }
                else
                tipoTriangulo = ((ladoUno == ladoDos) && (ladoDos == ladoTres)) ? "Equilatero" : "Isóceles";
                labelResultado.Text = tipoTriangulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores numericos");
            }
        }
    }
}
