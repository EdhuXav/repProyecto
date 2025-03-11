using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMRrespiracion : Form
    {
        private FormPrincipal principal;
        int contador = 0; // Contador para las fases
        int tiempoTranscurrido = 0; // Tiempo transcurrido en la fase actual
        int segundosRestantes = 3; // Inicializa en 3 segundos

        string[] mensajes = { "Inhala", "Mantén la respiración", "Exhala" }; // Mensajes de cada fase
        Color[] colores = { Color.Red, Color.Yellow, Color.Green }; // Colores de cada fase

        public FRMRrespiracion(FormPrincipal principal)
        {
            InitializeComponent();
            timer1.Interval = 1000; // Intervalo de 1 segundo
            timer1.Enabled = false;
            this.principal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador = 0;
            tiempoTranscurrido = 0;
            segundosRestantes = 3;

            label1.Text = mensajes[contador];
            label2.Text = segundosRestantes.ToString();
            label2.ForeColor = colores[contador];

            timer1.Start();

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido++;

            // Solo cambiar el número cada 2 segundos
            if (tiempoTranscurrido % 2 == 0)
            {
                segundosRestantes--;

                if (segundosRestantes > 0)
                {
                    label2.Text = segundosRestantes.ToString();
                }
                else
                {
                    // Cambiar de fase
                    contador = (contador + 1) % mensajes.Length;
                    label1.Text = mensajes[contador];
                    label2.ForeColor = colores[contador];

                    // Reiniciar cuenta regresiva
                    segundosRestantes = 3;
                    label2.Text = segundosRestantes.ToString();
                }
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
