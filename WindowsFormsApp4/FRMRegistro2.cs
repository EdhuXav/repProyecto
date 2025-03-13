using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMRegistro2 : Form
    {
        public FRMRegistro2()
        {
            InitializeComponent();
            this.Load += FRMRegistro2_Load; // Asignar el evento Load al formulario
        }

        private void FRMRegistro2_Load(object sender, EventArgs e)
        {
            // Asignar el evento CheckedChanged a todos los CheckBox dentro del formulario
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += checkBox_CheckedChanged;
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox seleccionado = sender as CheckBox;

            if (seleccionado.Checked)
            {
                // Desmarcar los otros CheckBox
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != seleccionado)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void BTSiguientee_Click(object sender, EventArgs e)
        {
            bool y = false;
            foreach (Control c in this.Controls) {
                if (c is CheckBox checkBox && checkBox.Checked)
                {
                    y = true;
                }
            }
            if (y == true)
            {
                FRMRegistro4 fRMRegistro4 = new FRMRegistro4();
                fRMRegistro4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese su nivel de actividad", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (CBNomuyactivo.Checked) DatosUsuario.aa = true;
            else if (CBLigeramenteactivo.Checked) DatosUsuario.bb = true;
            else if (CBActivo.Checked) DatosUsuario.cc = true;
            else if (CBMuyactivo.Checked) DatosUsuario.dd = true;
        }

        private void BTAtrass_Click(object sender, EventArgs e)
        {
            FRMRegistro fRMRegistro = new FRMRegistro();
            fRMRegistro.Show();
            this.Hide();
        }
    }
}

