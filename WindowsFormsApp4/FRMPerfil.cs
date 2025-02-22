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
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
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
    public static class Globales
        {
            public static Image ImagenPerfil { get; set; }
        }

    }
}
