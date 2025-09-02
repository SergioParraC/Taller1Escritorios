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
    public partial class For_Ejercicio14 : Form
    {
        public For_Ejercicio14()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroUno = Convert.ToInt32(textBoxN1.Text);
                int numeroDos = Convert.ToInt32(textBoxN2.Text);
                int numeroTres = Convert.ToInt32(textBoxN3.Text);
                int numeroMayor;
                if ((numeroUno > numeroDos) && (numeroUno > numeroTres))
                {
                    numeroMayor = numeroUno;
                }
                else
                {
                    numeroMayor = numeroDos > numeroTres ? numeroDos : numeroTres;
                }
                labelResultado.Text = "El número mayor es " + numeroMayor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresar valore snumeriicos");
            }

        }
    }
}
