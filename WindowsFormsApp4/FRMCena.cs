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
    public partial class FRMCena : Form
    {
        private FormPrincipal principal;
        public FRMCena(FormPrincipal principal)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.BackColor = Color.Transparent;
            checkBox4.BackColor = Color.Transparent;
            checkBox5.BackColor = Color.Transparent;
            checkBox6.BackColor = Color.Transparent;
            checkBox7.BackColor = Color.Transparent;
            checkBox8.BackColor = Color.Transparent;
            checkBox9.BackColor = Color.Transparent;
            this.principal = principal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMElegirComida(principal));
            }
        }

        public void AbrirObjetivos(object abrirObjetivos)
        {
            FormPrincipal principal = new FormPrincipal();

            principal.panelContenedor.Visible = true;

            if (principal.panelContenedor.Controls.Count > 0)
            {
                principal.panelContenedor.Controls.RemoveAt(0);
            }
            Form fo = abrirObjetivos as Form;
            fo.TopLevel = false;
            fo.Dock = DockStyle.Fill;
            principal.Controls.Add(fo);
            principal.panelContenedor.Tag = fo;
            fo.Show();
        }
    }
}
