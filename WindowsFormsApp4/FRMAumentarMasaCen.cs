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
    public partial class FRMAumentarMasaCen : Form
    {
        private FormPrincipal principal;
        public FRMAumentarMasaCen(FormPrincipal principal)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas19 * int.Parse(textBox1.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos19 * int.Parse(textBox1.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias19 * int.Parse(textBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas20 * int.Parse(textBox2.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos20 * int.Parse(textBox2.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias20 * int.Parse(textBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas21 * int.Parse(textBox3.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos21 * int.Parse(textBox3.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias21 * int.Parse(textBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas22 * int.Parse(textBox4.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos22 * int.Parse(textBox4.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias22 * int.Parse(textBox4.Text);
                }

                if (checkBox5.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas23 * int.Parse(textBox5.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos23 * int.Parse(textBox5.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias23 * int.Parse(textBox5.Text);
                }
                if (checkBox6.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas24 * int.Parse(textBox6.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos24 * int.Parse(textBox6.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias24 * int.Parse(textBox6.Text);
                }
                if (checkBox7.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas25 * int.Parse(textBox7.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos25 * int.Parse(textBox7.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias25 * int.Parse(textBox7.Text);
                }
                if (checkBox8.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas26 * int.Parse(textBox8.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos26 * int.Parse(textBox8.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias26 * int.Parse(textBox8.Text);
                }
                if (checkBox9.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas27 * int.Parse(textBox9.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos27 * int.Parse(textBox9.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias27 * int.Parse(textBox9.Text);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ingrese la cantidad que va a consumir");
            }

            principal.AbrirObjetivos(new FRMCalculoDesayuno(principal));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMElegirComida(principal));
                this.Close();
            }
        }
    }
}
