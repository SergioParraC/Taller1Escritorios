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
    public partial class For_Ejercicio12 : Form
    {
        public For_Ejercicio12()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int edadHerUno = Convert.ToInt16(textBoxHer1.Text);
                int edadHerDos = Convert.ToInt16(textBoxHer2.Text);
                if (edadHerUno > edadHerDos)
                {
                    int diferecia = edadHerUno - edadHerDos;
                    labelResultado.Text = "El segundo hermamo \nes mayor por " + diferecia + " años";
                }
                else
                {
                    int diferecia = edadHerDos - edadHerUno;
                    labelResultado.Text = "El primer hermamo \nes mayor por " + diferecia + " años";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor numerico");
            }
        }
    }
}
