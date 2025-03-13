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
    public partial class FRMPerfil : Form
    {
        public FRMPerfil()
        {
            InitializeComponent();
            this.Load += new EventHandler(FRMPerfil_Load);
            if (Globales.ImagenPerfil != null)
            {
                pictureBox3.Image = Globales.ImagenPerfil;
            }

            label1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de imagen (*.png; *.jpg) | *.png; *.jpg";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                Globales.ImagenPerfil = Image.FromFile(archivo.FileName);

                pictureBox3.Image = Globales.ImagenPerfil;
            }
        }

        private void FRMPerfil_Load(object sender, EventArgs e)
        {
            string nombre = DatosUsuario.usuario;
            string edad = DatosUsuario.Edad;
            string altura = DatosUsuario.Altura;
            string peso = DatosUsuario.Peso;
            string genero = DatosUsuario.Genero;

            if (DatosUsuario.conf == true)
            {
                if (!string.IsNullOrWhiteSpace(DatosUsuario.Nombre2))
                {
                    nombre = DatosUsuario.Nombre2;
                }
                if (!string.IsNullOrWhiteSpace(DatosUsuario.Edad2))
                {
                    edad = DatosUsuario.Edad2;
                }
                if (!string.IsNullOrWhiteSpace(DatosUsuario.Altura2))
                {
                    altura = DatosUsuario.Altura2;
                }
                if (!string.IsNullOrWhiteSpace(DatosUsuario.Peso2))
                {
                    peso = DatosUsuario.Peso2;
                }
            }

            label7.Text = nombre;
            label10.Text = edad;
            label11.Text = altura;
            label12.Text = peso;
            label13.Text = genero;
        }
        
        public static class Globales
        {
            public static Image ImagenPerfil { get; set; }
        }


    }
}
