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
    public partial class FRMRutina1 : Form
    {
        private FormPrincipal principal;
        public FRMRutina1(FormPrincipal principal)
        {

            InitializeComponent();
            this.principal = principal;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMDiasSemana(principal));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                label28.Text = textBox1.Text;
                
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                label29.Text = textBox2.Text;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                label30.Text = textBox3.Text;
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                label31.Text = textBox4.Text;
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                label32.Text = textBox5.Text;
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                label33.Text = textBox6.Text;
            }
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                label34.Text = textBox7.Text;
            }
            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                label35.Text = textBox8.Text;
            }
            if (!string.IsNullOrEmpty(textBox9.Text))
            {
                label36.Text = textBox9.Text;
            }
            if (!string.IsNullOrEmpty(textBox10.Text))
            {
                label37.Text = textBox10.Text;
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                label38.Text = textBox11.Text;
            }
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                label39.Text = textBox12.Text;
            }
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                label40.Text = textBox13.Text;
            }
            if (!string.IsNullOrEmpty(textBox14.Text))
            {
                label41.Text = textBox14.Text;
            }
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                label42.Text = textBox15.Text;
            }
            if (!string.IsNullOrEmpty(textBox16.Text))
            {
                label43.Text = textBox16.Text;
            }


            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
        }

        private void FRMRutina1_Load(object sender, EventArgs e)
        {

        }
    }
}
