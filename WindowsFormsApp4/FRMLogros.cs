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
    public partial class FRMLogros : Form
    {
        public FRMLogros()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void FRMLogros_Load(object sender, EventArgs e)
        {
            label2.Text = DatosUsuario.logro1 + "\n" + DatosUsuario.logro2 + "\n" + DatosUsuario.logro3;
        }
    }
}
