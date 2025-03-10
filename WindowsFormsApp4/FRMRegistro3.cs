using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            button1.BackColor = Color.Transparent;
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

            DatosUsuario.usuario = TBUsuario.Text;
            DatosUsuario.contraseña = TBContraseña.Text;

            if (DatosUsuario.usuario == "" && DatosUsuario.contraseña == "")
            {
                MessageBox.Show("Ingrese su usuario y contraseña");
            }
            else if (DatosUsuario.usuario == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario");
            }
            else if (DatosUsuario.contraseña == "")
            {
                MessageBox.Show("Ingrese su contraseña");
            }
            else
            {
                IniciarSesion1.datos.Add(DatosUsuario.usuario);
                IniciarSesion1.datos2.Add(DatosUsuario.contraseña);
                IniciarSesion1.Show();
                this.Hide();
            }
        }

        private void TBContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBContraseña.PasswordChar == '*')
            {
                TBContraseña.PasswordChar = '\0';
            }
            else
            {
                TBContraseña.PasswordChar = '*';
            }
        }
    }
}
