﻿namespace WindowsFormsApp4
{
    partial class FRMIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMIniciarSesion));
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.BTIniciar = new System.Windows.Forms.Button();
            this.BTATras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(194, 218);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(200, 25);
            this.Usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseña.Location = new System.Drawing.Point(194, 309);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.PasswordChar = '*';
            this.TBContraseña.Size = new System.Drawing.Size(200, 25);
            this.TBContraseña.TabIndex = 4;
            // 
            // BTIniciar
            // 
            this.BTIniciar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTIniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIniciar.Location = new System.Drawing.Point(395, 404);
            this.BTIniciar.Name = "BTIniciar";
            this.BTIniciar.Size = new System.Drawing.Size(120, 44);
            this.BTIniciar.TabIndex = 5;
            this.BTIniciar.Text = "Iniciar";
            this.BTIniciar.UseVisualStyleBackColor = false;
            this.BTIniciar.Click += new System.EventHandler(this.BTSGuiente_Click);
            // 
            // BTATras
            // 
            this.BTATras.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTATras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTATras.Location = new System.Drawing.Point(155, 404);
            this.BTATras.Name = "BTATras";
            this.BTATras.Size = new System.Drawing.Size(134, 44);
            this.BTATras.TabIndex = 6;
            this.BTATras.Text = "Atrás";
            this.BTATras.UseVisualStyleBackColor = false;
            this.BTATras.Click += new System.EventHandler(this.BTATras_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(360, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 18);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTATras);
            this.Controls.Add(this.BTIniciar);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "FRMIniciarSesion";
            this.Text = "FRMIniciarSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.Button BTIniciar;
        private System.Windows.Forms.Button BTATras;
        private System.Windows.Forms.Button button1;
    }
}