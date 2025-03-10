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
            this.Bienvenida.Location = new System.Drawing.Point(127, 224);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(328, 36);
            this.Bienvenida.TabIndex = 0;
            this.Bienvenida.Text = "Personalicemos EquilibrioDeVida segun \r\nsus objetivos.";
            this.Bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTContinuar
            // 
            this.BTContinuar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTContinuar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTContinuar.Location = new System.Drawing.Point(344, 378);
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
            this.BTAtrass.Location = new System.Drawing.Point(130, 378);
            this.BTAtrass.Name = "BTAtrass";
            this.BTAtrass.Size = new System.Drawing.Size(141, 47);
            this.BTAtrass.TabIndex = 3;
            this.BTAtrass.Text = "Atrás";
            this.BTAtrass.UseVisualStyleBackColor = false;
            this.BTAtrass.Click += new System.EventHandler(this.BTAtrass_Click);
            // 
            // FRMInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.BTAtrass);
            this.Controls.Add(this.BTContinuar);
            this.Controls.Add(this.Bienvenida);
            this.DoubleBuffered = true;
            this.Name = "FRMInicioDeSesion";
            this.Text = "FRMInicioDeSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button BTContinuar;
        private System.Windows.Forms.Button BTAtrass;
    }
}