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
    public partial class FRMEmociones : Form
    {
        private FormPrincipal principal;
        public FRMEmociones(FormPrincipal principal)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            this.principal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirObjetivos(new FRMPregunta1(principal));
        }

        private void AbrirObjetivos(Form abrirObjetivos)
        {
            if (principal == null) return;

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
