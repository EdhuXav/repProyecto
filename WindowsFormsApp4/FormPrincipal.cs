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
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            userControl11.Dock = DockStyle.Fill;
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            userControl21.BringToFront();
        }

        private void botonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = botonHome.Height;
            SidePanel.Top = botonHome.Top;
            userControl11.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            userControl31.BringToFront();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            userControl41.BringToFront();
        }
    }
}
