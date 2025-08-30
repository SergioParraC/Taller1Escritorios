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
    public partial class For_Ejercicio1 : Form
    {
        private void For_Ejercisio1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxOperador1;
        }
        public For_Ejercicio1()
        {
            InitializeComponent();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = Convert.ToString(Convert.ToInt16(textBoxOperador1.Text) * Convert.ToInt16(textBoxOperador2.Text));
            textBoxResultado.Text = resultado;
        }

        private void textBoxOperador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void textBoxOperador2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxOperador1.Text = string.Empty;
            textBoxOperador2.Text = string.Empty;
            textBoxResultado.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
