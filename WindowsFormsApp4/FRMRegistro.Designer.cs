﻿namespace WindowsFormsApp4
{
    partial class FRMRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRegistro));
            this.CBPerder = new System.Windows.Forms.CheckBox();
            this.CBMantenerPeso = new System.Windows.Forms.CheckBox();
            this.CBAumentar = new System.Windows.Forms.CheckBox();
            this.CBManejarEstres = new System.Windows.Forms.CheckBox();
            this.CBAlimentacion = new System.Windows.Forms.CheckBox();
            this.BTSiguiente = new System.Windows.Forms.Button();
            this.BTAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBPerder
            // 
            this.CBPerder.AutoSize = true;
            this.CBPerder.BackColor = System.Drawing.Color.Transparent;
            this.CBPerder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerder.Location = new System.Drawing.Point(187, 173);
            this.CBPerder.Name = "CBPerder";
            this.CBPerder.Size = new System.Drawing.Size(142, 26);
            this.CBPerder.TabIndex = 1;
            this.CBPerder.Text = "Perder Peso";
            this.CBPerder.UseVisualStyleBackColor = false;
            // 
            // CBMantenerPeso
            // 
            this.CBMantenerPeso.AutoSize = true;
            this.CBMantenerPeso.BackColor = System.Drawing.Color.Transparent;
            this.CBMantenerPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMantenerPeso.Location = new System.Drawing.Point(187, 226);
            this.CBMantenerPeso.Name = "CBMantenerPeso";
            this.CBMantenerPeso.Size = new System.Drawing.Size(165, 26);
            this.CBMantenerPeso.TabIndex = 2;
            this.CBMantenerPeso.Text = "Mantener Peso";
            this.CBMantenerPeso.UseVisualStyleBackColor = false;
            // 
            // CBAumentar
            // 
            this.CBAumentar.AutoSize = true;
            this.CBAumentar.BackColor = System.Drawing.Color.Transparent;
            this.CBAumentar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAumentar.Location = new System.Drawing.Point(187, 277);
            this.CBAumentar.Name = "CBAumentar";
            this.CBAumentar.Size = new System.Drawing.Size(169, 26);
            this.CBAumentar.TabIndex = 3;
            this.CBAumentar.Text = "Aumentar Peso";
            this.CBAumentar.UseVisualStyleBackColor = false;
            // 
            // CBManejarEstres
            // 
            this.CBManejarEstres.AutoSize = true;
            this.CBManejarEstres.BackColor = System.Drawing.Color.Transparent;
            this.CBManejarEstres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBManejarEstres.Location = new System.Drawing.Point(187, 335);
            this.CBManejarEstres.Name = "CBManejarEstres";
            this.CBManejarEstres.Size = new System.Drawing.Size(187, 26);
            this.CBManejarEstres.TabIndex = 4;
            this.CBManejarEstres.Text = "Manejar el Estrés";
            this.CBManejarEstres.UseVisualStyleBackColor = false;
            // 
            // CBAlimentacion
            // 
            this.CBAlimentacion.AutoSize = true;
            this.CBAlimentacion.BackColor = System.Drawing.Color.Transparent;
            this.CBAlimentacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAlimentacion.Location = new System.Drawing.Point(187, 394);
            this.CBAlimentacion.Name = "CBAlimentacion";
            this.CBAlimentacion.Size = new System.Drawing.Size(199, 26);
            this.CBAlimentacion.TabIndex = 5;
            this.CBAlimentacion.Text = "Alimentación Sana";
            this.CBAlimentacion.UseVisualStyleBackColor = false;
            // 
            // BTSiguiente
            // 
            this.BTSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTSiguiente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSiguiente.Location = new System.Drawing.Point(399, 470);
            this.BTSiguiente.Name = "BTSiguiente";
            this.BTSiguiente.Size = new System.Drawing.Size(112, 38);
            this.BTSiguiente.TabIndex = 6;
            this.BTSiguiente.Text = "Siguiente";
            this.BTSiguiente.UseVisualStyleBackColor = false;
            this.BTSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAtras
            // 
            this.BTAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtras.Location = new System.Drawing.Point(257, 470);
            this.BTAtras.Name = "BTAtras";
            this.BTAtras.Size = new System.Drawing.Size(117, 38);
            this.BTAtras.TabIndex = 7;
            this.BTAtras.Text = "Atrás";
            this.BTAtras.UseVisualStyleBackColor = false;
            this.BTAtras.Click += new System.EventHandler(this.BTAtras_Click);
            // 
            // FRMRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.BTAtras);
            this.Controls.Add(this.BTSiguiente);
            this.Controls.Add(this.CBAlimentacion);
            this.Controls.Add(this.CBManejarEstres);
            this.Controls.Add(this.CBAumentar);
            this.Controls.Add(this.CBMantenerPeso);
            this.Controls.Add(this.CBPerder);
            this.DoubleBuffered = true;
            this.Name = "FRMRegistro";
            this.Text = "FRMRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CBPerder;
        private System.Windows.Forms.CheckBox CBMantenerPeso;
        private System.Windows.Forms.CheckBox CBAumentar;
        private System.Windows.Forms.CheckBox CBManejarEstres;
        private System.Windows.Forms.CheckBox CBAlimentacion;
        private System.Windows.Forms.Button BTSiguiente;
        private System.Windows.Forms.Button BTAtras;
    }
}