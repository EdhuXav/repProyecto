using System;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApp4.FRMRegistro;

namespace WindowsFormsApp4
{
    public partial class FRMObjetivos : Form
    {
        private Button objetivoSeleccionado = null; // Variable para almacenar el objetivo seleccionado

        public FRMObjetivos()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void FRMObjetivos_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.PerderPeso != null) button2.Text = DatosUsuario.PerderPeso;
            if (DatosUsuario.AumentarPeso != null) button2.Text = DatosUsuario.AumentarPeso;
            if (DatosUsuario.MantenerPeso != null) button2.Text = DatosUsuario.MantenerPeso;
            if (DatosUsuario.ManejoEstres != null) button3.Text = DatosUsuario.ManejoEstres;
            if (DatosUsuario.AlimentacionSana != null) button4.Text = DatosUsuario.AlimentacionSana;
        }

        private void MoverBotonesHaciaArriba(Button botonSeleccionado)
        {
            int alturaBoton = botonSeleccionado.Height + 5; // Espacio que ocupará el botón oculto

            botonSeleccionado.Visible = false; // Oculta el botón seleccionado

            // Reposiciona los botones restantes
            foreach (Control control in this.Controls)
            {
                if (control is Button boton && boton.Visible && boton.Top > botonSeleccionado.Top)
                {
                    boton.Top -= alturaBoton; // Mueve hacia arriba los botones que estaban debajo
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            DatosUsuario.logro1 = button2.Text;
            objetivoSeleccionado = button2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            DatosUsuario.logro2 = button3.Text;
            objetivoSeleccionado = button3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            DatosUsuario.logro3 = button4.Text;
            objetivoSeleccionado = button4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objetivoSeleccionado != null)
            {
                MoverBotonesHaciaArriba(objetivoSeleccionado);
                objetivoSeleccionado = null;
            }
        }
    }
}
