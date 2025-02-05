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
    public partial class FRMInicioDeSesion : Form
    {
        public FRMInicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTContinuar_Click(object sender, EventArgs e)
        {
            FRMRegistro registro = new FRMRegistro();
            registro.Show();
            this.Hide();
        }

        private void BTAtrass_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.Show();
            this.Hide();
        }
    }
}
