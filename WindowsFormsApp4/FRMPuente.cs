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
    public partial class FRMPuente : Form
    {
        private FormPrincipal principal;
        public FRMPuente(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void FRMPuente_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMElegirComida(principal));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
