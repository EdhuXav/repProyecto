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
    public partial class FRMDiasSemana : Form
    {
        private FormPrincipal principal;
        public FRMDiasSemana(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true)
            {
                principal.AbrirObjetivos(new FRMRutina1(principal));
            }
            else if (DatosUsuario.y == true)
            {
                principal.AbrirObjetivos(new FRMRutina2(principal));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDesacnso(principal));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true)
            {
                principal.AbrirObjetivos(new FRMRutina1(principal));
            }
            else if (DatosUsuario.y == true)
            {
                principal.AbrirObjetivos(new FRMRutina2(principal));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true)
            {
                principal.AbrirObjetivos(new FRMRutina1(principal));
            }
            else if (DatosUsuario.y == true)
            {
                principal.AbrirObjetivos(new FRMRutina2(principal));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true)
            {
                principal.AbrirObjetivos(new FRMRutina1(principal));
            }
            else if (DatosUsuario.y == true)
            {
                principal.AbrirObjetivos(new FRMRutina2(principal));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDesacnso(principal));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDesacnso(principal));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new Alarma(principal));
        }
    }
}
