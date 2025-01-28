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
    public partial class FRMRegistro : Form
    {
        public FRMRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMRegistro2 fRMRegistro2 = new FRMRegistro2();
            fRMRegistro2.Show();
            this.Hide();
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            FRMInicioDeSesion fRMInicioDeSesion = new FRMInicioDeSesion();
            fRMInicioDeSesion.Show();
            this.Hide();
        }
    }
}
