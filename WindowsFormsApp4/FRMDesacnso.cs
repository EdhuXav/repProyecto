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
    public partial class FRMDesacnso : Form
    {
        private FormPrincipal principal;
        public FRMDesacnso(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDiasSemana(principal));
        }
    }
}
