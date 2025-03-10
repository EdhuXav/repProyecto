namespace WindowsFormsApp4
{
    partial class Proyecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyecto));
            this.BTIniciarSesion = new System.Windows.Forms.Button();
            this.BTRegistrar = new System.Windows.Forms.Button();
            this.letrao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTIniciarSesion
            // 
            this.BTIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTIniciarSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIniciarSesion.Location = new System.Drawing.Point(487, 150);
            this.BTIniciarSesion.Name = "BTIniciarSesion";
            this.BTIniciarSesion.Size = new System.Drawing.Size(250, 75);
            this.BTIniciarSesion.TabIndex = 0;
            this.BTIniciarSesion.Text = "Iniciar Sesión";
            this.BTIniciarSesion.UseVisualStyleBackColor = false;
            this.BTIniciarSesion.Click += new System.EventHandler(this.BTIniciarSesion_Click);
            // 
            // BTRegistrar
            // 
            this.BTRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrar.Location = new System.Drawing.Point(487, 320);
            this.BTRegistrar.Name = "BTRegistrar";
            this.BTRegistrar.Size = new System.Drawing.Size(250, 77);
            this.BTRegistrar.TabIndex = 1;
            this.BTRegistrar.Text = "Registrarse";
            this.BTRegistrar.UseVisualStyleBackColor = false;
            this.BTRegistrar.Click += new System.EventHandler(this.BTRegistrar_Click);
            // 
            // letrao
            // 
            this.letrao.AutoSize = true;
            this.letrao.BackColor = System.Drawing.Color.Transparent;
            this.letrao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letrao.Location = new System.Drawing.Point(603, 261);
            this.letrao.Name = "letrao";
            this.letrao.Size = new System.Drawing.Size(25, 22);
            this.letrao.TabIndex = 2;
            this.letrao.Text = "O";
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.letrao);
            this.Controls.Add(this.BTRegistrar);
            this.Controls.Add(this.BTIniciarSesion);
            this.DoubleBuffered = true;
            this.Name = "Proyecto";
            this.Text = "Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTIniciarSesion;
        private System.Windows.Forms.Button BTRegistrar;
        private System.Windows.Forms.Label letrao;
    }
}

