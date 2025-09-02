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
    public partial class For_Ejercicio6 : Form
    {
        public For_Ejercicio6()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = Convert.ToInt32(textBoxGanados.Text) * 3 + Convert.ToInt32(textBoxEmpatados.Text) * 1;
                labelRespuesta.Text = resultado.ToString();
            }
            catch 
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxGanados.Text = string.Empty;
            textBoxEmpatados.Text = string.Empty;
            textBoxPerdidos.Text = string.Empty;
            labelRespuesta.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
