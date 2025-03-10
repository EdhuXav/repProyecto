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

            Console.WriteLine($"Día: {dia}, Hora: {hora}, Minutos: {minutos}"); // Depuración

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && dia == c.Text.ToLower() && minutos == tbMin.Text && hora == tbHora.Text && !notificacionMostrada)
                {
                    try
                    {
                        song.Ctlcontrols.play();
                        notificacionMostrada = true;

                        // 🔹 Mostrar el "1" en la notificación y ocultar el panel de "No hay notificaciones"
                        principal.MostrarNotificacion(true);
                        principal.OcultarPanelNoNotificaciones();

                        using (Notificacion notificacion = new Notificacion(song, this))
                        {
                            notificacion.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
        }
    }

    public partial class Notificacion : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer song;
        private Alarma alarma;
        private Button btStop;

        public Notificacion(AxWMPLib.AxWindowsMediaPlayer player, Alarma form)
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
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            alarma.DetenerAlarma(); // Detener la alarma y el temporizador
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cerrar el formulario de notificación
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            song.Ctlcontrols.stop(); // Detener la canción al cerrar
            alarma.ResetNotificacion(); // Reiniciar la notificación
        }
    }
}