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
    public partial class FRMAlmuerzo : Form
    {
        private FormPrincipal principal;
        public FRMAlmuerzo(FormPrincipal principal)
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMElegirComida(principal));
                this.Close(); 
            }
        }

        private void FRMAlmuerzo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas10 * int.Parse(textBox1.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos10 * int.Parse(textBox1.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias10 * int.Parse(textBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas11 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos11 * int.Parse(textBox2.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias11 * int.Parse(textBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas12 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos12 * int.Parse(textBox3.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias12 * int.Parse(textBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas13 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos13 * int.Parse(textBox4.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias13 * int.Parse(textBox4.Text);
                }

                if (checkBox5.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas14 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos14 * int.Parse(textBox5.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias14 * int.Parse(textBox5.Text);
                }
                if (checkBox6.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas15 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos15 * int.Parse(textBox6.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias15 * int.Parse(textBox6.Text);
                }
                if (checkBox7.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas16 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos16 * int.Parse(textBox7.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias16 * int.Parse(textBox7.Text);
                }
                if (checkBox8.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas17 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos17 * int.Parse(textBox8.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias17 * int.Parse(textBox8.Text);
                }
                if (checkBox9.Checked)
                {
                    CalculosComida.sumaProetina += CalculosComida.proteinas18 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCarbohidratos += CalculosComida.carbohidratos18 * int.Parse(textBox9.Text);
                    CalculosComida.sumaCalorias += CalculosComida.calorias18 * int.Parse(textBox9.Text);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ingrese la cantidad que va a consumir");
            }


            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMCalculoDesayuno(principal));
            }

            
        }
    }
}
