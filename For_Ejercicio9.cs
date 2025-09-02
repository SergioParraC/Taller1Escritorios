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
    public partial class For_Ejercicio9 : Form
    {
        public For_Ejercicio9()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double discoDuro = Convert.ToDouble(textBoxDiscoDuro.Text);
                double megaByteDiscoDuro = discoDuro * 1024.0;
                double microDiscos = megaByteDiscoDuro / 1.44;
                labelRespuesta.Text = microDiscos.ToString();
            }
            catch
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxDiscoDuro.Text = string.Empty;
            labelRespuesta.Text = string.Empty;
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}