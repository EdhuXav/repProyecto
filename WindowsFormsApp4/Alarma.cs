using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Alarma : Form
    {
        private bool notificacionMostrada = false;
        private FormPrincipal principal;
        public Alarma(FormPrincipal principal)
        {
            InitializeComponent();
            this.Controls.Add(song); // Agregar el control al formulario
            song.CreateControl();
            timer1.Enabled = true; // Habilitar el Timer
            timer1.Interval = 1000; // Configurar el intervalo (1 segundo)
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            cbLun.BackColor = Color.Transparent;
            cbMar.BackColor = Color.Transparent;
            cbMier.BackColor = Color.Transparent;
            cbJue.BackColor = Color.Transparent;
            cbVier.BackColor = Color.Transparent;
            cbSab.BackColor = Color.Transparent;
            cbDom.BackColor = Color.Transparent;
            cbSL.BackColor = Color.Transparent;
            this.principal = principal;
        }

        AxWMPLib.AxWindowsMediaPlayer song = new AxWMPLib.AxWindowsMediaPlayer();
        string ruta = string.Empty;
        string archivo = string.Empty;

        private void btSeleccionarCancion_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.SafeFileName;
                ruta = ofd.FileName;
                song.URL = ruta;
                song.settings.setMode("loop", true);
                song.Ctlcontrols.stop();
                lbNombreCancion.Text = archivo;
                lbNombreCancion.Location = new Point(this.ClientSize.Width / 2 - lbNombreCancion.Width / 2, lbNombreCancion.Location.Y);
            }
        }

        private void cbSL_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = cbSL.Checked;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToLower();
            string hora = DateTime.Now.Hour.ToString("00");
            string minutos = DateTime.Now.Minute.ToString("00");


            if (minutos == tbMin.Text && hora == tbHora.Text && notificacionMostrada == false)
            {
                try
                {
                    song.Ctlcontrols.play();
                    notificacionMostrada = true;

                    // Mostrar la notificación
                    principal.MostrarNotificacion(true);
                    principal.OcultarPanelNoNotificaciones();

                    using (Notificacion notificacion = new Notificacion(song, this, principal))
                    {
                        notificacion.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // Mostrar el mensaje de error
                }
                }
            }
        

        private void btStop_Click(object sender, EventArgs e)
        {
            DetenerAlarma();
        }

        public void DetenerAlarma()
        {
            timer1.Enabled = false; // Detener el temporizador
            song.Ctlcontrols.stop(); // Detener la canción
            notificacionMostrada = false; // Reiniciar la notificación

        }

        public void ResetNotificacion()
        {
            notificacionMostrada = false;
            principal.MostrarNotificacion(false); // Asegurarse de que la notificación se oculte
            Console.WriteLine("Notificación reiniciada"); // Verificación
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;

            while (cont <= 0)
            {
                if (cont == 0)
                {
                    principal.AbrirObjetivos(new PuenteEjercicios(principal));
                    cont++;
                }
                else
                {
                    principal.AbrirObjetivos(new FRMDiasSemana(principal));
                }
                
            }
        }
    }

    public partial class Notificacion : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer song;
        private Alarma alarma;
        private Button btStop;
        private FormPrincipal principal1;

        public Notificacion(AxWMPLib.AxWindowsMediaPlayer player, Alarma form, FormPrincipal principal1)
        {
            song = player;
            alarma = form;
            this.Text = "Alarma";
            this.Size = new Size(200, 100);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.TopMost = true;

            btStop = new Button() { Text = "Detener", Dock = DockStyle.Fill };
            btStop.Click += BtStop_Click;
            this.Controls.Add(btStop);
            this.principal1 = principal1;
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            alarma.DetenerAlarma();
            principal1.MostrarNotificacion(true);
            song.close(); // Asegurar que el audio se detiene
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Console.WriteLine("Cerrando formulario de notificación");
            song.Ctlcontrols.stop();
            alarma.ResetNotificacion();
        }
    }
}
