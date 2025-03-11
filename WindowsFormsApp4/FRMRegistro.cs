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
            bool x = true;

            if (CBMantenerPeso.Checked && CBPerder.Checked && CBAumentar.Checked)
            {
                MessageBox.Show("No puede el objetivo de manetener peso, aumentar peso y perder peso a la vez", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x = false;
            }
            else if (CBPerder.Checked && CBAumentar.Checked)
            {
                MessageBox.Show("No puede el objetivo de aumentar peso y perder peso a la vez", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x = false;
            }
            else if (CBMantenerPeso.Checked && CBAumentar.Checked)
            {
                MessageBox.Show("No puede el objetivo de manetener peso y aumentar peso a la vez", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x = false;
            }
            else if (CBMantenerPeso.Checked && CBPerder.Checked)
            {
                MessageBox.Show("No puede el objetivo de mantener peso y perder peso a la vez", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x = false;
            }


            if (CBPerder.Checked)
            {
                DatosUsuario.x = true;
            }
            else if (CBAumentar.Checked)
            {
                DatosUsuario.y = true;
            }
            else if (CBPerder.Checked && CBMantenerPeso.Checked)
            {
                DatosUsuario.a = true;
            }
            else if (CBAumentar.Checked && CBMantenerPeso.Checked)
            {
                DatosUsuario.b = true;
            }
            else if (CBMantenerPeso.Checked)
            {
                DatosUsuario.c = true;
            }
            else
            {
                MessageBox.Show("Seleccione al menos un objetivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x = false;
            }

            List<string> objetivos = new List<string>();



            if (x == true)
            {
                if (CBPerder.Checked) DatosUsuario.PerderPeso = " * Perder Peso";
                if (CBMantenerPeso.Checked) DatosUsuario.MantenerPeso = " * Mantener Peso";
                if (CBAumentar.Checked) DatosUsuario.AumentarPeso = " * Aumentar Peso";
                if (CBManejarEstres.Checked) DatosUsuario.ManejoEstres = " * Manejar el Estrés";
                if (CBAlimentacion.Checked) DatosUsuario.AlimentacionSana = " * Alimentación Sana";

                FRMRegistro2 fRMRegistro2 = new FRMRegistro2();
                fRMRegistro2.Show();
                this.Hide();
            }
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            FRMInicioDeSesion fRMInicioDeSesion = new FRMInicioDeSesion();
            fRMInicioDeSesion.Show();
            this.Hide();
        }
    }
}
