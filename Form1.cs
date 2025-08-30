namespace Taller
{
    public partial class For_VentanaPrincipal : Form
    {
        public For_VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonEjercisio1_Click(object sender, EventArgs e)
        {
            For_Ejercicio1 ventana = new For_Ejercicio1();
            ventana.ShowDialog();
        }

        private void buttonEjercicio2_Click(object sender, EventArgs e)
        {
            For_Ejercicio2 ventana = new For_Ejercicio2();
            ventana.ShowDialog();
        }

        private void buttonEjercisio3_Click(object sender, EventArgs e)
        {
            For_Ejercicio3 ventana = new For_Ejercicio3();
            ventana.ShowDialog();
        }

        private void buttonEjercicio4_Click(object sender, EventArgs e)
        {
            For_Ejercicio4 ventana = new For_Ejercicio4();
            ventana.ShowDialog();
        }
    }
}
