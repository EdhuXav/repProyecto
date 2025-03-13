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
    public partial class FRMElegirComida : Form
    { 
        private FormPrincipal principal;
        public FRMElegirComida(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            this.principal = principal;
        }

        private void btnCena_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true || DatosUsuario.a == true || DatosUsuario.b == true)
            {
                principal.AbrirObjetivos(new FRMAumentarMasaCen(principal));
            }
            else if (DatosUsuario.y == true || DatosUsuario.c == true)
            {
                principal.AbrirObjetivos(new FRMCena(principal));
            }
        }



        private void btnDesayuno_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true ||DatosUsuario.a == true ||DatosUsuario.b == true)
            {
                principal.AbrirObjetivos(new FRMAumentarMasaD(principal));
            }
            else if (DatosUsuario.y ||DatosUsuario.c == true)
            {
                principal.AbrirObjetivos(new FRMDesayuno(principal));
            }
        }

        private void btnAlmuerzo_Click(object sender, EventArgs e)
        {
            if (DatosUsuario.x == true || DatosUsuario.a == true || DatosUsuario.b == true)
            {
                principal.AbrirObjetivos(new FRMAumentarMasaAl(principal));
            }
            else if (DatosUsuario.y == true || DatosUsuario.c == true)
                principal.AbrirObjetivos(new FRMAlmuerzo(principal)); 
            }
        }
    }
    
