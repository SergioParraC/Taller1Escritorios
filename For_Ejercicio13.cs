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
    public partial class For_Ejercicio13 : Form
    {
        public For_Ejercicio13()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double cantLunes = Convert.ToDouble(textBoxLunes.Text);
                double cantMasrtes = Convert.ToDouble(textBoxMartes.Text);
                double cantMiercoles = Convert.ToDouble(textBoxMiercoles.Text);
                double cantJueves = Convert.ToDouble(textBoxJueves.Text);
                double cantViernes = Convert.ToDouble(textBoxViernes.Text);
                double cantSabado = Convert.ToDouble(textBoxSabado.Text);
                double promedio = (cantLunes + cantMasrtes + cantMiercoles + cantJueves + cantViernes + cantSabado) / 6;
                if (promedio > 100.0)
                {
                    labelResultado.Text = "Recibirá\nincentivos";
                }
                else
                {
                    labelResultado.Text = "NO recibirá\nincentivos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese solo valores númericos");
            }
        }
    }
}
