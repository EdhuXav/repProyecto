using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp4
{
    public partial class FRMRegistro : Form
    {
        public FRMRegistro()
        {
            InitializeComponent();
        }

        public static class Sesion
        {
            public static List<string> ObjetivosSeleccionados { get; set; } = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> objetivos = new List<string>();

            if (CBPerder.Checked) Sesion.ObjetivosSeleccionados.Add(" * Perder Peso");
            if (CBMantenerPeso.Checked) Sesion.ObjetivosSeleccionados.Add(" * Mantener Peso");
            if (CBAumentar.Checked) Sesion.ObjetivosSeleccionados.Add(" * Aumentar Peso");
            if (CBManejarEstres.Checked) Sesion.ObjetivosSeleccionados.Add(" * Manejar el Estrés");
            if (CBAlimentacion.Checked) Sesion.ObjetivosSeleccionados.Add(" * Alimentación Sana");


            FRMRegistro2 fRMRegistro2 = new FRMRegistro2();
            fRMRegistro2.Show();
            this.Hide();
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            FRMInicioDeSesion fRMInicioDeSesion = new FRMInicioDeSesion();
            fRMInicioDeSesion.Show();
            this.Hide();
        }
    }
}
