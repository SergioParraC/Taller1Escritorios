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
    public partial class For_Ejercicio10 : Form
    {
        public For_Ejercicio10()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double absA = Convert.ToDouble(textBoxAbsA.Text);
                double absB = Convert.ToDouble(textBoxAbsB.Text);
                double ordA = Convert.ToDouble(textBoxOrdA.Text);
                double ordB = Convert.ToDouble(textBoxOrdB.Text);
                double resultado = Math.Pow(Math.Pow(absA - absB, 2.0) + Math.Pow(ordA - ordB, 2.0), 0.5);
                labelResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Inngrese valores numéricos");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNuevo_Click_1(object sender, EventArgs e)
        {
            textBoxAbsA.Text = string.Empty;
            textBoxAbsB.Text = string.Empty;
            textBoxOrdA.Text = string.Empty;
            textBoxOrdB.Text = string.Empty;
            labelResultado.Text = string.Empty;
        }
    }
}
