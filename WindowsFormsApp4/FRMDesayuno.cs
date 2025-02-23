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
    public partial class FRMDesayuno : Form
    {
        private FormPrincipal formPrincipal;

        public FRMDesayuno(FormPrincipal formPrincipalRef)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            formPrincipal = formPrincipalRef;
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
            formPrincipal.panelContenedor.Visible = false;

            if (formPrincipal.panelContenedor.Controls.Count > 0)
            {
                formPrincipal.panelContenedor.Controls.RemoveAt(0);
            }
            FormPrincipal fo = new FormPrincipal();
            fo.TopLevel = false;
            fo.Dock = DockStyle.Fill;
            this.formPrincipal.panelContenedor.Controls.Add(fo);
            this.formPrincipal.panelContenedor.Tag = fo;
            fo.Show();
        }





    }
}
