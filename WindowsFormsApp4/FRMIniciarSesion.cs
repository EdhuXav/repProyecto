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
    public partial class FRMIniciarSesion : Form
    {
        public List<string> datos = new List<string>();
        public FRMIniciarSesion()
        {
            InitializeComponent();
            FRMRegistro3 Registro3 = new FRMRegistro3(this);
        }

        bool x = false; 
        private void BTSGuiente_Click(object sender, EventArgs e)
        {
            foreach (string s in datos)
            {
                if (s == Usuario.Text && s == TBContraseña.Text)
                {
                    x = true;
                }

            }
            if (x == true)
            {
                FormPrincipal FormPrincipal = new FormPrincipal();
                FormPrincipal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usario o contraseña incorrecta");
            }
        }

        private void BTATras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proyecto form1 = new Proyecto();
            form1.Show();
        }
    }
}
