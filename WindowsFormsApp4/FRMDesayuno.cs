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
    public partial class FRMDesayuno : Form
    {
        private FormPrincipal principal;    
        public FRMDesayuno(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMElegirComida(principal)); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = true;
            try
            {
                if (checkBox1.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas1 * double.Parse(textBox1.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos1 * double.Parse(textBox1.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias1 * double.Parse(textBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas2 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos2 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias2 * int.Parse(textBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas3 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos3 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias3 * int.Parse(textBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas4 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos4 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias4 * int.Parse(textBox4.Text);
                }

                if (checkBox5.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas5 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos5 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias5 * int.Parse(textBox5.Text);
                }
                if (checkBox6.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas6 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos6 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias6 * int.Parse(textBox6.Text);
                }
                if (checkBox7.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas7 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos7 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias7 * int.Parse(textBox7.Text);
                }
                if (checkBox8.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas8 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos8 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias8 * int.Parse(textBox8.Text);
                }
                if (checkBox9.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas9 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos9 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias9 * int.Parse(textBox9.Text);
                }
            } catch (FormatException ex)
            {
                MessageBox.Show("Ingrese la cantidad que va a consumir");
                x = false;
            }

            if (x == true)
            {
                principal.AbrirObjetivos(new FRMCalculoDesayuno(principal));
            }
        }
    }
}
