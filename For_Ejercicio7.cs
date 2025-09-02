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
    public partial class For_Ejercicio7 : Form
    {
        public For_Ejercicio7()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(textBoxHoras.Text) * Convert.ToInt32(textBoxTarifa.Text);
                labelRespuesta.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor numerico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxHoras.Text = string.Empty;
            textBoxTarifa.Text = string.Empty;
            labelRespuesta.Text = string.Empty;
        }
    }
}
