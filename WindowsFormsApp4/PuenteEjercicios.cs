using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class PuenteEjercicios : Form
    {
        private FormPrincipal principal;
        public PuenteEjercicios(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void PuenteEjercicios_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true)
            {
                label1.Text = DatosUsuario.opc1;
            }
            else if (DatosUsuario.y == true)
            {
                label1.Text = DatosUsuario.opc2;
            }
            else if (DatosUsuario.a == true)
            {
                label1.Text = DatosUsuario.opc3;
            }
            else if (DatosUsuario.b == true)
            {
                label1.Text = DatosUsuario.opc4;
            }
            else if (DatosUsuario.c == true)
            {
                label1.Text = DatosUsuario.opc5;
            }
            else
            {
                label1.Text = "Al no seleccionar un objetivo para su alimentación, a continuación nuestras recomendaciones";
            }

            if (DatosUsuario.aa == true)
            {
                label5.Text = DatosUsuario.opc6;
            }
            else if (DatosUsuario.bb == true)
            {
                label5.Text= DatosUsuario.opc7;
            }
            else if (DatosUsuario.cc == true)
            {
                label5.Text = DatosUsuario.opc8;
            }
            else if (DatosUsuario.dd  == true)
            {
                label5.Text = DatosUsuario.opc9;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDiasSemana(principal));
        }
    }
}
