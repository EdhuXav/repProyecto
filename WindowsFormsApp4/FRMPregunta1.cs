﻿using System;
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
    public partial class FRMPregunta1 : Form
    {
        private FormPrincipal principal;
        public FRMPregunta1(FormPrincipal principal)
        {
            InitializeComponent();
            label3.BackColor = Color.Transparent;
            this.principal = principal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                principal.AbrirObjetivos(new FRMPregunta2(principal));
            }
            else
            {
                MessageBox.Show("Seleccione una respuesta", "Pregunta sin respuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            label3.Text = string.Join("(\n", Preguntas.P1Opcn1);
            button2.Enabled = false;
            button3.Enabled = false;
            FRMContadorRespuestas.Excelente++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            label3.Text = string.Join("(\n", Preguntas.P1Opcn2);
            button1.Enabled = false;
            button3.Enabled = false;
            FRMContadorRespuestas.Bueno++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            label3.Text = string.Join("(\n", Preguntas.P1Opcn3);
            button1.Enabled = false;
            button2.Enabled = false;
            FRMContadorRespuestas.Malo++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
