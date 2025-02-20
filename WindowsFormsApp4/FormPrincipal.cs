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
        private UserControl5 userControl5;

        public FormPrincipal()
        {
            InitializeComponent();
            // Inicializa UserControl5
            userControl5 = new UserControl5();
            userControl5.Dock = DockStyle.Fill;
            this.Controls.Add(userControl5);
            userControl5.Visible = false; // Ocultarlo al inicio

            userControl11.Dock = DockStyle.Fill;
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            userControl21.BringToFront();
        }

        private void botonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            userControl11.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            // Muestra los objetivos seleccionados en el UserControl
            userControl31.MostrarObjetivos(Sesion.ObjetivosSeleccionados);

            // Trae el UserControl al frente
            userControl31.BringToFront();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            userControl41.BringToFront();
        }

        public void MostrarUserControl5()
        {
            SidePanel.Height = botonHome.Height; // Ajusta el panel lateral si es necesario
            SidePanel.Top = botonHome.Top;
            userControl5.Visible = true;
            userControl5.BringToFront();
        }
    }
}


