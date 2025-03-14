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
    public partial class FRMPregunta5 : Form
    {
        private FormPrincipal principal;
        public FRMPregunta5(FormPrincipal principal)
        {
            InitializeComponent();
            label3.BackColor = Color.Transparent;
            this.principal = principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosUsuario.siguiente = true;
            button1.BackColor = Color.Yellow; 
            label3.Text = string.Join("(\n", Preguntas.P5Opcn1);
            button2.Enabled = false;
            button3.Enabled = false;
            FRMContadorRespuestas.Bueno++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosUsuario.siguiente = true;
            button2.BackColor = Color.Green;
            label3.Text = string.Join("(\n", Preguntas.P5Opcn2);
            button1.Enabled = false;
            button3.Enabled = false;
            FRMContadorRespuestas.Excelente++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatosUsuario.siguiente = true;
            button3.BackColor = Color.Red;
            label3.Text = string.Join("(\n", Preguntas.P5Opcn3);
            button1.Enabled = false;
            button2 .Enabled = false;
            FRMContadorRespuestas.Malo++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                if (FRMContadorRespuestas.Excelente > FRMContadorRespuestas.Bueno && FRMContadorRespuestas.Excelente > FRMContadorRespuestas.Malo)
                {
                    principal.AbrirObjetivos(new FRMExcelente());
                }
                else if (FRMContadorRespuestas.Bueno > FRMContadorRespuestas.Excelente && FRMContadorRespuestas.Bueno > FRMContadorRespuestas.Malo)
                {
                    principal.AbrirObjetivos(new FRMBueno());
                }
                else
                {
                    principal.AbrirObjetivos(new FRMMalo());
                }
            }
            else
            {
                MessageBox.Show("Seleccione una respuesta", "Pregunta sin respuesta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FRMPregunta5_Load(object sender, EventArgs e)
        {



        }
    }
}
