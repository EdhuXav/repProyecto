﻿using System;
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
            // Cargar datos almacenados en la clase Sesion
            label7.Text = DatosUsuario.Nombre; // Si tienes un campo de nombre
            label10.Text = DatosUsuario.Edad;
            label11.Text = DatosUsuario.Altura;
            label12.Text = DatosUsuario.Peso;
            label13.Text = DatosUsuario.Genero;
        }
        public static class Globales
        {
            public static Image ImagenPerfil { get; set; }
        }

    }
}
