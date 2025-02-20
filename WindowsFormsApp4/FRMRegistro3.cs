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

                if (usuario == "" || contraseña == "")
                {
                    MessageBox.Show("No puede dejar el campo del usario o contraseña vacios");
                }
                else
                {
                    IniciarSesion1.Show();
                    this.Hide();
                }

            IniciarSesion1.datos.Add(usuario);
            IniciarSesion1.datos.Add(contraseña);

        }

        private void TBContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
