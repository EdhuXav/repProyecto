using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FRMAumentarMasaD : Form
    {
        private FormPrincipal principal;
        public FRMAumentarMasaD(FormPrincipal principal)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas1 * double.Parse(textBox1.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos1 * double.Parse(textBox1.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias1 * double.Parse(textBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas2 * int.Parse(textBox2.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos2 * int.Parse(textBox2.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias2 * int.Parse(textBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas3 * int.Parse(textBox3.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos3 * int.Parse(textBox3.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias3 * int.Parse(textBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas4 * int.Parse(textBox4.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos4 * int.Parse(textBox4.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias4 * int.Parse(textBox4.Text);
                }

                if (checkBox5.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas5 * int.Parse(textBox5.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos5 * int.Parse(textBox5.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias5 * int.Parse(textBox5.Text);
                }
                if (checkBox6.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas6 * int.Parse(textBox6.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos6 * int.Parse(textBox6.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias6 * int.Parse(textBox6.Text);
                }
                if (checkBox7.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas7 * int.Parse(textBox7.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos7 * int.Parse(textBox7.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias7 * int.Parse(textBox7.Text);
                }
                if (checkBox8.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas8 * int.Parse(textBox8.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos8 * int.Parse(textBox8.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias8 * int.Parse(textBox8.Text);
                }
                if (checkBox9.Checked)
                {
                    CalculosComida2.sumaProetina += CalculosComida2.proteinas9 * int.Parse(textBox9.Text);
                    CalculosComida2.sumaCarbohidratos += CalculosComida2.carbohidratos9 * int.Parse(textBox9.Text);
                    CalculosComida2.sumaCalorias += CalculosComida2.calorias9 * int.Parse(textBox9.Text);
                }
            } catch (FormatException ex)
            {
                MessageBox.Show("Ingrese la cantidad que va a consumir");
            }

            principal.AbrirObjetivos(new FRMCalculoDesayuno(principal));
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
