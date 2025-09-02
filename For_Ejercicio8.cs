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
    public partial class For_Ejercicio8 : Form
    {
        public For_Ejercicio8()
        {
            InitializeComponent();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(textBoxLadoA.Text);
                double ladoB = Convert.ToDouble(textBoxLadoB.Text);
                double ladoC = Convert.ToDouble(textBoxLadoC.Text);
                double perimetro = (ladoA + ladoB + ladoC) / 2;
                double baseNum = perimetro * (perimetro - ladoA) * (perimetro - ladoB) * (perimetro - ladoC);
                double resultado = Math.Pow(baseNum, 0.5);
                labelRespuesta.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numérico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxLadoA.Text = string.Empty;
            textBoxLadoB.Text = string.Empty;
            textBoxLadoC.Text = string.Empty;
            labelRespuesta.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
