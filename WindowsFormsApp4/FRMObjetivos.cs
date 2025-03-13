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
            pictureBox1.BackColor = Color.Transparent;
        }

        private void FRMObjetivos_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.PerderPeso != null) button2.Text = DatosUsuario.PerderPeso;
            if (DatosUsuario.AumentarPeso != null) button2.Text = DatosUsuario.AumentarPeso;
            if (DatosUsuario.MantenerPeso != null) button2.Text = DatosUsuario.MantenerPeso;
            if (DatosUsuario.ManejoEstres != null) button3.Text = DatosUsuario.ManejoEstres;
            if (DatosUsuario.AlimentacionSana != null) button4.Text = DatosUsuario.AlimentacionSana;

            // Usar los valores de DatosUsuario para establecer visibilidad
            button2.Visible = !DatosUsuario.Boton2Oculto;
            button3.Visible = !DatosUsuario.Boton3Oculto;
            button4.Visible = !DatosUsuario.Boton4Oculto;
        }

        private void MoverBotonesHaciaArriba(Button botonSeleccionado)
        {
            int alturaBoton = botonSeleccionado.Height + 5;
            botonSeleccionado.Visible = false;

            // Guardar en DatosUsuario
            if (botonSeleccionado == button2) DatosUsuario.Boton2Oculto = true;
            if (botonSeleccionado == button3) DatosUsuario.Boton3Oculto = true;
            if (botonSeleccionado == button4) DatosUsuario.Boton4Oculto = true;

            // Reposicionar botones
            foreach (Control control in this.Controls)
            {
                if (control is Button boton && boton.Visible && boton.Top > botonSeleccionado.Top)
                {
                    boton.Top -= alturaBoton;
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
