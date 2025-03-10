namespace WindowsFormsApp4
{
    partial class Alarma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarma));
            this.lbNombreCancion = new System.Windows.Forms.Label();
            this.btSeleccionarCancion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDom = new System.Windows.Forms.CheckBox();
            this.cbSab = new System.Windows.Forms.CheckBox();
            this.cbVier = new System.Windows.Forms.CheckBox();
            this.cbJue = new System.Windows.Forms.CheckBox();
            this.cbMier = new System.Windows.Forms.CheckBox();
            this.cbMar = new System.Windows.Forms.CheckBox();
            this.cbLun = new System.Windows.Forms.CheckBox();
            this.cbSL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNombreCancion
            // 
            this.lbNombreCancion.AutoSize = true;
            this.lbNombreCancion.Location = new System.Drawing.Point(159, 470);
            this.lbNombreCancion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombreCancion.Name = "lbNombreCancion";
            this.lbNombreCancion.Size = new System.Drawing.Size(46, 13);
            this.lbNombreCancion.TabIndex = 44;
            this.lbNombreCancion.Text = "Cancion";
            // 
            // btSeleccionarCancion
            // 
            this.btSeleccionarCancion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSeleccionarCancion.Location = new System.Drawing.Point(434, 270);
            this.btSeleccionarCancion.Margin = new System.Windows.Forms.Padding(2);
            this.btSeleccionarCancion.Name = "btSeleccionarCancion";
            this.btSeleccionarCancion.Size = new System.Drawing.Size(112, 21);
            this.btSeleccionarCancion.TabIndex = 43;
            this.btSeleccionarCancion.Text = "Seleccionar cancion";
            this.btSeleccionarCancion.UseVisualStyleBackColor = false;
            this.btSeleccionarCancion.Click += new System.EventHandler(this.btSeleccionarCancion_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = ":";
            // 
            // cbDom
            // 
            this.cbDom.AutoSize = true;
            this.cbDom.Location = new System.Drawing.Point(105, 417);
            this.cbDom.Margin = new System.Windows.Forms.Padding(2);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(68, 17);
            this.cbDom.TabIndex = 41;
            this.cbDom.Text = "Domingo";
            this.cbDom.UseVisualStyleBackColor = true;
            // 
            // cbSab
            // 
            this.cbSab.AutoSize = true;
            this.cbSab.Location = new System.Drawing.Point(105, 383);
            this.cbSab.Margin = new System.Windows.Forms.Padding(2);
            this.cbSab.Name = "cbSab";
            this.cbSab.Size = new System.Drawing.Size(63, 17);
            this.cbSab.TabIndex = 40;
            this.cbSab.Text = "Sabado";
            this.cbSab.UseVisualStyleBackColor = true;
            // 
            // cbVier
            // 
            this.cbVier.AutoSize = true;
            this.cbVier.Location = new System.Drawing.Point(105, 351);
            this.cbVier.Margin = new System.Windows.Forms.Padding(2);
            this.cbVier.Name = "cbVier";
            this.cbVier.Size = new System.Drawing.Size(61, 17);
            this.cbVier.TabIndex = 39;
            this.cbVier.Text = "Viernes";
            this.cbVier.UseVisualStyleBackColor = true;
            // 
            // cbJue
            // 
            this.cbJue.AutoSize = true;
            this.cbJue.Location = new System.Drawing.Point(105, 319);
            this.cbJue.Margin = new System.Windows.Forms.Padding(2);
            this.cbJue.Name = "cbJue";
            this.cbJue.Size = new System.Drawing.Size(60, 17);
            this.cbJue.TabIndex = 38;
            this.cbJue.Text = "Jueves";
            this.cbJue.UseVisualStyleBackColor = true;
            // 
            // cbMier
            // 
            this.cbMier.AutoSize = true;
            this.cbMier.Location = new System.Drawing.Point(105, 288);
            this.cbMier.Margin = new System.Windows.Forms.Padding(2);
            this.cbMier.Name = "cbMier";
            this.cbMier.Size = new System.Drawing.Size(71, 17);
            this.cbMier.TabIndex = 37;
            this.cbMier.Text = "Miercoles";
            this.cbMier.UseVisualStyleBackColor = true;
            // 
            // cbMar
            // 
            this.cbMar.AutoSize = true;
            this.cbMar.Location = new System.Drawing.Point(105, 258);
            this.cbMar.Margin = new System.Windows.Forms.Padding(2);
            this.cbMar.Name = "cbMar";
            this.cbMar.Size = new System.Drawing.Size(58, 17);
            this.cbMar.TabIndex = 36;
            this.cbMar.Text = "Martes";
            this.cbMar.UseVisualStyleBackColor = true;
            // 
            // cbLun
            // 
            this.cbLun.AutoSize = true;
            this.cbLun.Location = new System.Drawing.Point(105, 227);
            this.cbLun.Margin = new System.Windows.Forms.Padding(2);
            this.cbLun.Name = "cbLun";
            this.cbLun.Size = new System.Drawing.Size(55, 17);
            this.cbLun.TabIndex = 35;
            this.cbLun.Text = "Lunes";
            this.cbLun.UseVisualStyleBackColor = true;
            // 
            // cbSL
            // 
            this.cbSL.AutoSize = true;
            this.cbSL.Location = new System.Drawing.Point(105, 197);
            this.cbSL.Margin = new System.Windows.Forms.Padding(2);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(115, 17);
            this.cbSL.TabIndex = 34;
            this.cbSL.Text = "Seleccionar Todos";
            this.cbSL.UseVisualStyleBackColor = true;
            this.cbSL.CheckedChanged += new System.EventHandler(this.cbSL_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hora";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(183, 158);
            this.tbMin.Margin = new System.Windows.Forms.Padding(2);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(36, 20);
            this.tbMin.TabIndex = 32;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(137, 158);
            this.tbHora.Margin = new System.Windows.Forms.Padding(2);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(36, 20);
            this.tbHora.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 42);
            this.panel1.TabIndex = 45;
            // 
            // Alarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNombreCancion);
            this.Controls.Add(this.btSeleccionarCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDom);
            this.Controls.Add(this.cbSab);
            this.Controls.Add(this.cbVier);
            this.Controls.Add(this.cbJue);
            this.Controls.Add(this.cbMier);
            this.Controls.Add(this.cbMar);
            this.Controls.Add(this.cbLun);
            this.Controls.Add(this.cbSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarma";
            this.Text = "Alarma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreCancion;
        private System.Windows.Forms.Button btSeleccionarCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDom;
        private System.Windows.Forms.CheckBox cbSab;
        private System.Windows.Forms.CheckBox cbVier;
        private System.Windows.Forms.CheckBox cbJue;
        private System.Windows.Forms.CheckBox cbMier;
        private System.Windows.Forms.CheckBox cbMar;
        private System.Windows.Forms.CheckBox cbLun;
        private System.Windows.Forms.CheckBox cbSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}