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
    
    public partial class FRMCalculoDesayuno : Form
    {
        private FormPrincipal principal;
        public FRMCalculoDesayuno(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void FRMCalculoDesayuno_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true || DatosUsuario.a == true || DatosUsuario.b == true)
            {
                label1.Text = string.Join("\n", CalculosComida2.sumaProetina);
                label2.Text = string.Join("\n", CalculosComida2.sumaCalorias);
                label3.Text = string.Join("\n", CalculosComida2.sumaCarbohidratos);
            }
            else if (DatosUsuario.y == true || DatosUsuario.c == true)
            {
                label1.Text = string.Join("\n", CalculosComida.sumaProetina);
                label2.Text = string.Join("\n", CalculosComida.sumaCalorias);
                label3.Text = string.Join("\n", CalculosComida.sumaCarbohidratos);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMElegirComida(principal));
        }
    }
}
