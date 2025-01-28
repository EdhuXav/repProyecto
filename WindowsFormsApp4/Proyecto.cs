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
    public partial class Proyecto : Form
    {
        public Proyecto()
        {
            InitializeComponent();
        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            FRMInicioDeSesion inicioDeSesion = new FRMInicioDeSesion();
            inicioDeSesion.Show();
            this.Hide();
        }

        private void BTIniciarSesion_Click(object sender, EventArgs e)
        {
            FRMInicioSesion fRMInicioSesion = new FRMInicioSesion();
            fRMInicioSesion.Show();
            this.Hide();
        }
    }
}
