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
    
    public partial class FRMRegistro3 : Form
    {
        private FRMIniciarSesion IniciarSesion1;
        public FRMRegistro3(FRMIniciarSesion IniciarSesion2)
        {
            InitializeComponent();
            IniciarSesion1 = IniciarSesion2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMRegistro4 fRMRegistro4 = new FRMRegistro4();
            fRMRegistro4.Show();
            this.Hide();
        }

        private void BTREGISTRO2_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;
            IniciarSesion1.datos.Add(usuario);
            IniciarSesion1.datos.Add(contraseña);

            IniciarSesion1.Show();
            this.Hide();
        }

        private void TBContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
