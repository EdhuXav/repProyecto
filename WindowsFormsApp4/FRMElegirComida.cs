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
        private FormPrincipal formPrincipal;
        public FRMElegirComida(FormPrincipal formPrincipalRef)
        {
            InitializeComponent();
            formPrincipal = formPrincipalRef;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void btnCena_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMCena());
        }



        private void btnDesayuno_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMDesayuno(formPrincipal));
        }

        private void btnAlmuerzo_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMAlmuerzo());
        }

        private void AbrirObjetivos(object abrirObjetivos)
        {
            formPrincipal.panelContenedor.Visible = true;

            if (formPrincipal.panelContenedor.Controls.Count > 0)
            {
                formPrincipal.panelContenedor.Controls.RemoveAt(0);
            }

            Form fo = abrirObjetivos as Form;
            fo.TopLevel = false;
            fo.Dock = DockStyle.Fill;
            this.formPrincipal.panelContenedor.Controls.Add(fo);
            this.formPrincipal.panelContenedor.Tag = fo;
            fo.Show();
        }

 
    }
    }
