using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp4.FRMRegistro;

namespace WindowsFormsApp4
{
    public partial class FormPrincipal : Form
    {


        public FormPrincipal()
        {
            InitializeComponent();

            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            AbrirObjetivos(new FRMPerfil());
        }

        private void botonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            panelContenedor.Hide();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            AbrirObjetivos(new FRMObjetivos());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            AbrirObjetivos(new FRMLogros());
        }

        private void botonSaludAlimentaria_Click(object sender, EventArgs e)
        {
            FRMElegirComida frmElegirComida = new FRMElegirComida(this);  

            panelContenedor.Visible = true;

            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            frmElegirComida.TopLevel = false;
            frmElegirComida.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmElegirComida);
            this.panelContenedor.Tag = frmElegirComida;
            frmElegirComida.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
    
        }
        private void AbrirObjetivos(object abrirObjetivos)
        {
            
            panelContenedor.Visible = true;

            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fo = abrirObjetivos as Form;
            fo.TopLevel = false;
            fo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fo);
            this.panelContenedor.Tag = fo;
            fo.Show();
        }
    }
}


