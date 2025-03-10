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
            principal.AbrirObjetivos(new FRMElegirComida(principal));
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas19 * int.Parse(textBox1.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos19 * int.Parse(textBox1.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias19 * int.Parse(textBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas20 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos20 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias20 * int.Parse(textBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas21 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos21 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias21 * int.Parse(textBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas22 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos22 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias22 * int.Parse(textBox4.Text);
                }

                if (checkBox5.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas23 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos23 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias23 * int.Parse(textBox5.Text);
                }
                if (checkBox6.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas24 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos24 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias24 * int.Parse(textBox6.Text);
                }
                if (checkBox7.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas25 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos25 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias25 * int.Parse(textBox7.Text);
                }
                if (checkBox8.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas26 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos26 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias26 * int.Parse(textBox8.Text);
                }
                if (checkBox9.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas27 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos27 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias27 * int.Parse(textBox9.Text);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ingrese la cantidad que va a consumir");
            }

            principal.AbrirObjetivos(new FRMCalculoDesayuno(principal));

        }
    }
}
