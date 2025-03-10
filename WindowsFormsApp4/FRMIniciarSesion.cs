using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMIniciarSesion : Form
    {
        public List<string> datos = new List<string>();
        public List<string> datos2 = new List<string>();
        public FRMIniciarSesion()
        {
            InitializeComponent();
            FRMRegistro3 Registro3 = new FRMRegistro3(this);
        }

        bool x = false;
        bool y = false;

        private void BTSGuiente_Click(object sender, EventArgs e)
        {
                    if (DatosUsuario.usuario != Usuario.Text && DatosUsuario.contraseña != TBContraseña.Text)
                    {
                        MessageBox.Show("Usuario y contraseña no coinciden");
                    }
                    else if (DatosUsuario.usuario != Usuario.Text)
                    {
                        MessageBox.Show("Usuarios no coinciden");
                        x = false;
                    }
                    else if (DatosUsuario.contraseña != TBContraseña.Text)
                    {
                        MessageBox.Show("Contraseñas no coinciden");
                        y = false;
                    }
                    else 
                    {
                        x = true;
                        y = true;
                    }

            if (x == true && y == true)
            {
                MessageBox.Show("Ha iniciado sesión correctamente");
                FormPrincipal FormPrincipal = new FormPrincipal();
                FormPrincipal.Show();
                this.Hide();
                FormPrincipal.panelContenedor.Hide();
                
                
            }
        }

        private void BTATras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proyecto form1 = new Proyecto();
            form1.Show();
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
