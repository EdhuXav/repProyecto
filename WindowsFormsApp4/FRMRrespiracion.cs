using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMRrespiracion : Form
    {
        private FormPrincipal principal;
        int contador = 0;
        int tiempoTranscurrido = 0; 
        int segundosRestantes = 3; 

        string[] mensajes = { "Inhala", "Mantén la respiración", "Exhala" };
        Color[] colores = { Color.Red, Color.Orange, Color.Green }; 
        string[] imagenes = { "Inhala.jpeg" , "manten.jpeg", "exhala.jpeg" };

        public FRMRrespiracion(FormPrincipal principal)
        {
            InitializeComponent();
            timer1.Interval = 1000; 
            timer1.Enabled = false;
            this.principal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador = 0;
            tiempoTranscurrido = 0;
            segundosRestantes = 3;

            ActualizarUI();
            timer1.Start();

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido++;

            if (segundosRestantes > 1)
            {
                segundosRestantes--;
            }
            else
            {
                contador = (contador + 1) % mensajes.Length;
                segundosRestantes = 3;
            }

            ActualizarUI();
        }

        private void ActualizarUI()
        {
            label1.Text = mensajes[contador];
            label2.Text = segundosRestantes.ToString();
            label2.ForeColor = colores[contador];

            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, imagenes[contador]);

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox1.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen: " + rutaImagen);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Sesión detenida";
            label2.Text = "";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void FRMRrespiracion_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMOpcionesSaludMental(principal));
        }
    }
}
