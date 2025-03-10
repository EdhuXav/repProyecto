using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp4.FRMRegistro;

namespace WindowsFormsApp4
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;

        }

        public void MostrarNotificacion(bool mostrar)
        {
            lbNotificacion.Text = mostrar ? "1" : "";
            lbNotificacion.Visible = mostrar;
        }

        public void OcultarPanelNoNotificaciones()
        {
            panel12.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            AbrirObjetivos(new FRMPerfil());
        }

        private void botonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            panelContenedor.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            AbrirObjetivos(new FRMObjetivos());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            AbrirObjetivos(new FRMLogros());
        }

        private void botonSaludAlimentaria_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMPuente(this));
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = false;
        }
        public void AbrirObjetivos(object abrirObjetivos)
        {
            
            panelContenedor.Visible = true;

            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fo = abrirObjetivos as Form;
            fo.TopLevel = false;
            fo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fo);
            this.panelContenedor.Tag = fo;
            fo.Show();
        }

        private void botonNotificaciones_Click(object sender, EventArgs e)
        {
            // Si los paneles ya están abiertos, se cierran al hacer clic nuevamente
            if (panel11.Visible || panel12.Visible)
            {
                panel11.Visible = false;
                panel12.Visible = false;
                return; // Salir de la función para evitar abrirlos de nuevo
            }

            // Si hay notificación, mostrar panel11
            if (!string.IsNullOrEmpty(lbNotificacion.Text))
            {
                panel11.Visible = true;  // 🔹 Mostrar "Es hora de hacer ejercicio"
                panel12.Visible = false; // 🔹 Ocultar "No hay notificaciones"
                lbNotificacion.Text = ""; // 🔹 Borrar el "1" al ver la notificación
                lbNotificacion.Visible = false;
            }
            else
            {
                panel12.Visible = true;  // 🔹 Mostrar "No hay notificaciones"
                panel11.Visible = false; // 🔹 Ocultar "Es hora de hacer ejercicio"
            }

            panel11.BringToFront();
            panel12.BringToFront();
        }

        public void botonSaludMental_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMOpcionesSaludMental(this));
        }

        private void botonSaludFisica_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new Alarma(this));
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonConfiguracion_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel9.Visible = !panel9.Visible;
            panel9.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Estás seguro que deseas salir del programa?", "Salir del programa", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new Proyecto();
            this.Hide();
            proyecto.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel8.Visible = !panel8.Visible;
            panel8.BringToFront();
        }

        private void link_label_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/equi.libriodevida/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel10.Visible = !panel10.Visible;
            panel10.BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=61573776968415");
        }
    }
}


