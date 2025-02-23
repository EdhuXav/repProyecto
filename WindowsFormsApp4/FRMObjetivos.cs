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
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;  
        }

        public void MostrarObjetivos()
        {
            if (Sesion.ObjetivosSeleccionados.Count > 0)
            {
                label2.Text = string.Join("\n", Sesion.ObjetivosSeleccionados);
            }
            else
            {
                label2.Text = "No se han seleccionado objetivos.";
            }
        }

        private void FRMObjetivos_Load(object sender, EventArgs e)
        {
            MostrarObjetivos();
        }
    }
}
