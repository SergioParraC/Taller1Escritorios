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
    public partial class For_Ejercicio3 : Form
    {
        public For_Ejercicio3()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(textBoxVelocidad.Text);
                double tiempo = Convert.ToDouble(textBoxTiempo.Text);
                double distancia = velocidad * tiempo;
                richTextBoxResultado.Text = distancia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese un valor adecuado");
            }
        }
    }
}
