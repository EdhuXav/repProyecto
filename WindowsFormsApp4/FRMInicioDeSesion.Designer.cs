namespace WindowsFormsApp4
{
    partial class FRMInicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMInicioDeSesion));
            this.Bienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTContinuar = new System.Windows.Forms.Button();
            this.BTAtrass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.Bienvenida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bienvenida.Location = new System.Drawing.Point(51, 140);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(330, 36);
            this.Bienvenida.TabIndex = 0;
            this.Bienvenida.Text = "Personalicemos SincroniaDeVida segun \r\nsus objetivos.";
            this.Bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Le damos la bienvenida!";
            // 
            // BTContinuar
            // 
            this.BTContinuar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTContinuar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTContinuar.Location = new System.Drawing.Point(240, 247);
            this.BTContinuar.Name = "BTContinuar";
            this.BTContinuar.Size = new System.Drawing.Size(141, 47);
            this.BTContinuar.TabIndex = 2;
            this.BTContinuar.Text = "Continuar";
            this.BTContinuar.UseVisualStyleBackColor = false;
            this.BTContinuar.Click += new System.EventHandler(this.BTContinuar_Click);
            // 
            // BTAtrass
            // 
            this.BTAtrass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTAtrass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtrass.Location = new System.Drawing.Point(82, 247);
            this.BTAtrass.Name = "BTAtrass";
            this.BTAtrass.Size = new System.Drawing.Size(141, 47);
            this.BTAtrass.TabIndex = 3;
            this.BTAtrass.Text = "Atrás";
            this.BTAtrass.UseVisualStyleBackColor = false;
            // 
            // FRMInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 361);
            this.Controls.Add(this.BTAtrass);
            this.Controls.Add(this.BTContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenida);
            this.DoubleBuffered = true;
            this.Name = "FRMInicioDeSesion";
            this.Text = "FRMInicioDeSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTContinuar;
        private System.Windows.Forms.Button BTAtrass;
    }
}