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
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMCena(principal));
            }
        }



        private void btnDesayuno_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMDesayuno(principal));
            }
        }

        private void btnAlmuerzo_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMAlmuerzo(principal));
            }
        }

        private void AbrirObjetivos(Form abrirObjetivos)
        {
            if (principal == null) return; // Asegurar que principal no sea nulo

            principal.panelContenedor.Visible = true;

            if (principal.panelContenedor.Controls.Count > 0)
            {
                principal.panelContenedor.Controls.RemoveAt(0);
            }

            abrirObjetivos.TopLevel = false;
            abrirObjetivos.Dock = DockStyle.Fill;
            principal.panelContenedor.Controls.Add(abrirObjetivos);
            principal.panelContenedor.Tag = abrirObjetivos;
            abrirObjetivos.Show();
        }


    }
    }
