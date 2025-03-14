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
    public partial class FRMOpcionesSaludMental : Form
    {
        private FormPrincipal principal;
        public FRMOpcionesSaludMental(FormPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (principal != null)
            {
                principal.AbrirObjetivos(new FRMRompe(principal));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMEmociones(principal));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.AbrirObjetivos(new FRMRrespiracion(principal));
        }
    }
}
