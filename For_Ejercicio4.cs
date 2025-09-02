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
    public partial class For_Ejercicio4 : Form
    {
        public For_Ejercicio4()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(textBoxNota1.Text);
                double nota2 = Convert.ToDouble(textBoxNota2.Text);
                double nota3 = Convert.ToDouble(textBoxNota3.Text);
                double resultado = (nota1 + nota2 + nota3) / 3;
                labelPromedio.Text = resultado.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Por favor, ingrese un valor numerico");
            }
        }
    }
}
