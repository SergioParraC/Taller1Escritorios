using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class For_Ejercicio16 : Form
    {
        public For_Ejercicio16()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int nuumero = Convert.ToInt32(textBoxInput.Text);
                string romano = string.Empty;
                switch (nuumero)
                {
                    case 1:
                        romano = "I";
                    break;
                    case 2:
                        romano = "II";
                    break;
                    case 3:
                        romano = "III";
                    break;
                    case 4:
                        romano = "IV";
                    break;
                    case 5:
                        romano = "V";
                    break;
                    case 6:
                        romano = "VI";
                    break;
                    case 7:
                        romano = "VII";
                    break;
                    case 8:
                        romano = "VIII";
                    break;
                    case 9:
                        romano = "IX";
                    break;
                    case 10:
                        romano = "X";
                    break;
                    default:
                        MessageBox.Show("Número no admitido, ingresa un número adecuado");
                    break;
                }
                labelResultado.Text = romano.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor entero");
            }
        }
    }
}
