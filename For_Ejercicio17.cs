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
    public partial class For_Ejercicio17 : Form
    {
        public For_Ejercicio17()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(textBoxMonto.Text);
                double beneficio;
                string casoImplementado = string.Empty;
                switch (monto)
                {
                    case double n when n < 1000 && n > 0:
                        beneficio = (0 * monto) / 100;
                        casoImplementado = "Caso 1";
                    break;
                    case double n when n >= 1000 && n < 5000:
                        beneficio = (3 * monto) / 100;
                        casoImplementado = "Caso 2";
                        break;
                    case double n when n >= 5000 && n < 20000:
                        beneficio = (5 * monto) / 100;
                        casoImplementado = "Caso 3";
                        break;
                    case double n when n >= 20000:
                        beneficio = (8 * monto) / 100;
                        casoImplementado = "Caso 4";
                        break;
                    default:
                        beneficio = 0;
                        casoImplementado = "Ninguno";
                        MessageBox.Show("Valor no adecuado");
                        break;
                }
                textBoxRespuesta.Text = beneficio.ToString();
                textBoxOpc.Text = casoImplementado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor entero");
            }
        }
    }
}
