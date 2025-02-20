using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        public void MostrarObjetivos(List<string> objetivos)
        {
            label2.Text = objetivos.Count > 0
                ? string.Join(Environment.NewLine, objetivos)
                : "No se seleccionó ningún objetivo.";
        }
    }
}
