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
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.");
                    return;
                }

                int estatura = int.Parse(textBox1.Text);
                int peso = int.Parse(textBox2.Text);
                int edad = int.Parse(textBox3.Text);
                bool x = true;
                bool y = true;
                bool z = true;

                DatosUsuario.Edad = textBox3.Text;
                DatosUsuario.Altura = textBox1.Text;
                DatosUsuario.Peso = textBox2.Text;
                DatosUsuario.Genero = checkBox1.Checked ? "Hombre" : checkBox2.Checked ? "Mujer" : "No especificado";

                if (estatura > 280)
                {
                    MessageBox.Show("Ingrese una estatura real");
                    x = false;
                }
                if (peso > 300)
                {
                    MessageBox.Show("Ingrese un peso real");
                    y = false;
                }
                if (edad > 120)
                {
                    MessageBox.Show("Ingrese una edad real");
                    z = false;
                }

                if (x && y && z)
                {
                    FRMIniciarSesion frmInicio = new FRMIniciarSesion();
                    FRMRegistro3 fRMRegistro3 = new FRMRegistro3(frmInicio);
                    fRMRegistro3.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese solo números en los campos de estatura, peso y edad.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

        }
    }
}
