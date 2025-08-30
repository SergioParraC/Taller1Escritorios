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
    public partial class For_Ejercicio2 : Form
    {
        public For_Ejercicio2()
        {
            InitializeComponent();
        }

        private void textBoxIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIngreso.Text = string.Empty;
            textBoxRespuesta.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCaF_Click(object sender, EventArgs e)
        {
            double temperatura = Convert.ToDouble(textBoxIngreso.Text) * 9.0 / 5.0 + 32.0;
            textBoxRespuesta.Text = Convert.ToString(temperatura);
        }

        private void buttonFsC_Click(object sender, EventArgs e)
        {
            double temperatura = (Convert.ToDouble(textBoxIngreso.Text) - 32.0) / 1.8;
            textBoxRespuesta.Text = Convert.ToString(temperatura);
        }

        private void For_Ejercisio2_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxIngreso;
        }
    }
}
