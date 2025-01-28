namespace WindowsFormsApp4
{
    partial class FRMRegistro3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRegistro3));
            this.creacuenta = new System.Windows.Forms.Label();
            this.ingresanombre = new System.Windows.Forms.Label();
            this.nombrep = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // creacuenta
            // 
            this.creacuenta.AutoSize = true;
            this.creacuenta.BackColor = System.Drawing.Color.Transparent;
            this.creacuenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creacuenta.Location = new System.Drawing.Point(60, 63);
            this.creacuenta.Name = "creacuenta";
            this.creacuenta.Size = new System.Drawing.Size(342, 22);
            this.creacuenta.TabIndex = 0;
            this.creacuenta.Text = "¡Ya casi terminamos! Cree su cuenta";
            // 
            // ingresanombre
            // 
            this.ingresanombre.AutoSize = true;
            this.ingresanombre.BackColor = System.Drawing.Color.Transparent;
            this.ingresanombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresanombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ingresanombre.Location = new System.Drawing.Point(84, 98);
            this.ingresanombre.Name = "ingresanombre";
            this.ingresanombre.Size = new System.Drawing.Size(193, 14);
            this.ingresanombre.TabIndex = 1;
            this.ingresanombre.Text = "Ingresa un usuario y contraseña";
            // 
            // nombrep
            // 
            this.nombrep.AutoSize = true;
            this.nombrep.BackColor = System.Drawing.Color.Transparent;
            this.nombrep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrep.Location = new System.Drawing.Point(72, 140);
            this.nombrep.Name = "nombrep";
            this.nombrep.Size = new System.Drawing.Size(56, 14);
            this.nombrep.TabIndex = 2;
            this.nombrep.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.Location = new System.Drawing.Point(75, 157);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(202, 23);
            this.TBUsuario.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(329, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña:";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseña.Location = new System.Drawing.Point(75, 210);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(202, 23);
            this.TBContraseña.TabIndex = 7;
            // 
            // FRMRegistro3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 361);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.nombrep);
            this.Controls.Add(this.ingresanombre);
            this.Controls.Add(this.creacuenta);
            this.DoubleBuffered = true;
            this.Name = "FRMRegistro3";
            this.Text = "FRMRegistro3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creacuenta;
        private System.Windows.Forms.Label ingresanombre;
        private System.Windows.Forms.Label nombrep;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBContraseña;
    }
}