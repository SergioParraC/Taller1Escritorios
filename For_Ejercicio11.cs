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
    public partial class For_Ejercicio11 : Form
    {
        public For_Ejercicio11()
        {
            InitializeComponent();
        }
        private void For_Ejercicio11_Load(object sender, EventArgs e)
        {
            textBoxAgno.Text = DateTime.Now.Year.ToString();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int agnoNac = Convert.ToInt32(textBoxAgnoNacimiento.Text);
                int edad = DateTime.Now.Year - agnoNac;
                if (edad > 17)
                {
                    textBoxRespuesta.Text = "Debe de inscribirse en el SMO";
                }
                else
                {
                    textBoxRespuesta.Text = "NO debe de inscribirse en el SMO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor numérico");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxAgnoNacimiento.Text = string.Empty;
            textBoxRespuesta.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
