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
    public partial class For_Ejercicio5 : Form
    {
        public For_Ejercicio5()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int valorCorrectas = Convert.ToInt32(textBoxCorrectas.Text);
                int valorIncorrectas = Convert.ToInt32(textBoxIncorrectas.Text);
                int puntaje = valorCorrectas * 4 + valorIncorrectas * -1;
                labelRespuesta.Text = puntaje.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxCorrectas.Text = string.Empty;
            textBoxIncorrectas.Text = string.Empty;
            textBoxBlanco.Text = string.Empty;
            labelRespuesta.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
