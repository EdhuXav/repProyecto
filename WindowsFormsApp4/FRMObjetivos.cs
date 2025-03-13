using System;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApp4.FRMRegistro;

namespace WindowsFormsApp4
{
    public partial class FRMObjetivos : Form
    {
        private Button objetivoSeleccionado = null; 

        public FRMObjetivos()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            button1.Visible = true;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void FRMObjetivos_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.PerderPeso != null) button2.Text = DatosUsuario.PerderPeso;
            if (DatosUsuario.AumentarPeso != null) button2.Text = DatosUsuario.AumentarPeso;
            if (DatosUsuario.MantenerPeso != null) button2.Text = DatosUsuario.MantenerPeso;
            if (DatosUsuario.ManejoEstres != null) button3.Text = DatosUsuario.ManejoEstres;
            if (DatosUsuario.AlimentacionSana != null) button4.Text = DatosUsuario.AlimentacionSana;

            // Restaurar visibilidad de botones
            button2.Visible = !DatosUsuario.Boton2Oculto;
            button3.Visible = !DatosUsuario.Boton3Oculto;
            button4.Visible = !DatosUsuario.Boton4Oculto;

            // Restaurar posiciones
            if (DatosUsuario.PosicionButton2 > 0) button2.Top = DatosUsuario.PosicionButton2;
            if (DatosUsuario.PosicionButton3 > 0) button3.Top = DatosUsuario.PosicionButton3;
            if (DatosUsuario.PosicionButton4 > 0) button4.Top = DatosUsuario.PosicionButton4;

            // Asegurar orden correcto
            ReposicionarBotones();

            // Restaurar estado de objetivos completados
            if (DatosUsuario.ObjetivosCompletos)
            {
                button1.Visible = false;
                label2.Visible = true;
                label2.Text = "¡Muy bien cumpliste con todos los objetivos!";
                pictureBox3.Visible = true;
            }
        }

        public void MoverBotonesHaciaArriba(Button botonSeleccionado)
        {
            int alturaBoton = botonSeleccionado.Height + 5;

            // Guardar estado antes de ocultar
            if (botonSeleccionado == button2)
            {
                DatosUsuario.Boton2Oculto = true;
                DatosUsuario.PosicionButton2 = button2.Top;
            }
            if (botonSeleccionado == button3)
            {
                DatosUsuario.Boton3Oculto = true;
                DatosUsuario.PosicionButton3 = button3.Top;
            }
            if (botonSeleccionado == button4)
            {
                DatosUsuario.Boton4Oculto = true;
                DatosUsuario.PosicionButton4 = button4.Top;
            }

            botonSeleccionado.Visible = false;

            // Reposicionar los botones restantes
            ReposicionarBotones();

            // Verificar si todos los botones están ocultos
            if (DatosUsuario.Boton2Oculto && DatosUsuario.Boton3Oculto && DatosUsuario.Boton4Oculto)
            {
                button1.Visible = false;
                label2.Visible = true;
                label2.Text = "¡Muy bien cumpliste con todos los objetivos!";
                pictureBox3.Visible = true;

                // Guardar estado en DatosUsuario
                DatosUsuario.ObjetivosCompletos = true;
            }
        }

        private void ReposicionarBotones()
        {
            int posicionY = 200; // Ajusta según la posición inicial de los botones
            int espacio = 30;

            foreach (Control control in this.Controls)
            {
                if (control is Button boton && boton.Visible)
                {
                    boton.Top = posicionY;
                    posicionY += boton.Height + espacio;
                }
            }

            // Guardar las posiciones actuales en DatosUsuario
            if (button2.Visible) DatosUsuario.PosicionButton2 = button2.Top;
            if (button3.Visible) DatosUsuario.PosicionButton3 = button3.Top;
            if (button4.Visible) DatosUsuario.PosicionButton4 = button4.Top;
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
