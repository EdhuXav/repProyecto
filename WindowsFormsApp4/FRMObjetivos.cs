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
    public partial class FRMObjetivos : Form
    {
        public FRMObjetivos()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;  
        }

        public void MostrarObjetivos()
        {
            if (Sesion.ObjetivosSeleccionados.Count > 0)
            {
                button2.Text = string.Join("\n\n", Sesion.ObjetivosSeleccionados);
            }
            else
            {
                button2.Text = "No se han seleccionado objetivos.";
            }
        }

        private void FRMObjetivos_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.PerderPeso != null ) button2.Text = DatosUsuario.PerderPeso;
            if (DatosUsuario.AumentarPeso != null) button2.Text = DatosUsuario.AumentarPeso;
            if (DatosUsuario.MantenerPeso != null) button2.Text = DatosUsuario.MantenerPeso;
            if (DatosUsuario.ManejoEstres != null) button3.Text = DatosUsuario.ManejoEstres;
            if (DatosUsuario.AlimentacionSana != null) button4.Text = DatosUsuario.AlimentacionSana;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            DatosUsuario.logro1 = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            DatosUsuario.logro2 = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            DatosUsuario.logro3 = button4.Text;
        }
    }
}
