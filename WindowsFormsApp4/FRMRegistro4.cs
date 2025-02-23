using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMRegistro4 : Form
    {
        public FRMRegistro4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMRegistro2 fRMRegistro2 = new FRMRegistro2();
            fRMRegistro2.Show();
            this.Hide();
        }

        private void BTSiguiiente_Click(object sender, EventArgs e)
        {
            DatosUsuario.Edad = textBox1.Text;
            DatosUsuario.Altura = textBox2.Text;
            DatosUsuario.Peso = textBox3.Text;
            DatosUsuario.Genero = checkBox1.Checked ? "Hombre" : checkBox2.Checked ? "Mujer" : "No especificado";

            FRMIniciarSesion frmInicio = new FRMIniciarSesion(); 
            FRMRegistro3 fRMRegistro3 = new FRMRegistro3(frmInicio);
            fRMRegistro3.Show();
            this.Hide();
        }
    }
}
