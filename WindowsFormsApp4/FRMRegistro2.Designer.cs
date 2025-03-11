namespace WindowsFormsApp4
{
    partial class FRMRegistro2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRegistro2));
            this.CBNomuyactivo = new System.Windows.Forms.CheckBox();
            this.cajero = new System.Windows.Forms.Label();
            this.CBLigeramenteactivo = new System.Windows.Forms.CheckBox();
            this.profesor = new System.Windows.Forms.Label();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.mesero = new System.Windows.Forms.Label();
            this.CBMuyactivo = new System.Windows.Forms.CheckBox();
            this.mensajero = new System.Windows.Forms.Label();
            this.BTSiguientee = new System.Windows.Forms.Button();
            this.BTAtrass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBNomuyactivo
            // 
            this.CBNomuyactivo.AutoSize = true;
            this.CBNomuyactivo.BackColor = System.Drawing.Color.Transparent;
            this.CBNomuyactivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNomuyactivo.Location = new System.Drawing.Point(195, 154);
            this.CBNomuyactivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBNomuyactivo.Name = "CBNomuyactivo";
            this.CBNomuyactivo.Size = new System.Drawing.Size(169, 27);
            this.CBNomuyactivo.TabIndex = 1;
            this.CBNomuyactivo.Text = "No muy activo";
            this.CBNomuyactivo.UseVisualStyleBackColor = false;
            this.CBNomuyactivo.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.BackColor = System.Drawing.Color.Transparent;
            this.cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cajero.Location = new System.Drawing.Point(219, 181);
            this.cajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(407, 50);
            this.cajero.TabIndex = 2;
            this.cajero.Text = "Pasa la mayor parte del dia sentado (p.ej.: es \r\ncajero o trabaja en una oficina)" +
    "";
            // 
            // CBLigeramenteactivo
            // 
            this.CBLigeramenteactivo.AutoSize = true;
            this.CBLigeramenteactivo.BackColor = System.Drawing.Color.Transparent;
            this.CBLigeramenteactivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLigeramenteactivo.Location = new System.Drawing.Point(195, 254);
            this.CBLigeramenteactivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBLigeramenteactivo.Name = "CBLigeramenteactivo";
            this.CBLigeramenteactivo.Size = new System.Drawing.Size(220, 27);
            this.CBLigeramenteactivo.TabIndex = 3;
            this.CBLigeramenteactivo.Text = "Ligeramente activo";
            this.CBLigeramenteactivo.UseVisualStyleBackColor = false;
            this.CBLigeramenteactivo.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // profesor
            // 
            this.profesor.AutoSize = true;
            this.profesor.BackColor = System.Drawing.Color.Transparent;
            this.profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.profesor.Location = new System.Drawing.Point(220, 281);
            this.profesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(452, 50);
            this.profesor.TabIndex = 4;
            this.profesor.Text = "Pasa buena parte del dia de pie. (p. ej.: es profesor\r\no vendedor)";
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.BackColor = System.Drawing.Color.Transparent;
            this.CBActivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivo.Location = new System.Drawing.Point(195, 347);
            this.CBActivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(93, 27);
            this.CBActivo.TabIndex = 5;
            this.CBActivo.Text = "Activo";
            this.CBActivo.UseVisualStyleBackColor = false;
            this.CBActivo.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // mesero
            // 
            this.mesero.AutoSize = true;
            this.mesero.BackColor = System.Drawing.Color.Transparent;
            this.mesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mesero.Location = new System.Drawing.Point(219, 378);
            this.mesero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mesero.Name = "mesero";
            this.mesero.Size = new System.Drawing.Size(382, 50);
            this.mesero.TabIndex = 6;
            this.mesero.Text = "Pasa buena parte del dia haciendo alguna \r\nactividad fisica (p. ej.: mesero carte" +
    "ro)";
            // 
            // CBMuyactivo
            // 
            this.CBMuyactivo.AutoSize = true;
            this.CBMuyactivo.BackColor = System.Drawing.Color.Transparent;
            this.CBMuyactivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMuyactivo.Location = new System.Drawing.Point(195, 454);
            this.CBMuyactivo.Margin = new System.Windows.Forms.Padding(4);
            this.CBMuyactivo.Name = "CBMuyactivo";
            this.CBMuyactivo.Size = new System.Drawing.Size(136, 27);
            this.CBMuyactivo.TabIndex = 7;
            this.CBMuyactivo.Text = "Muy activo";
            this.CBMuyactivo.UseVisualStyleBackColor = false;
            this.CBMuyactivo.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // mensajero
            // 
            this.mensajero.AutoSize = true;
            this.mensajero.BackColor = System.Drawing.Color.Transparent;
            this.mensajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mensajero.Location = new System.Drawing.Point(219, 480);
            this.mensajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mensajero.Name = "mensajero";
            this.mensajero.Size = new System.Drawing.Size(419, 75);
            this.mensajero.TabIndex = 8;
            this.mensajero.Text = "Pasa la mayor parte del dia haciendo actividad \r\nfisica intensa (p. ej.: es mensa" +
    "jero ciclista o\r\ncarpintero)";
            // 
            // BTSiguientee
            // 
            this.BTSiguientee.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTSiguientee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSiguientee.Location = new System.Drawing.Point(720, 570);
            this.BTSiguientee.Margin = new System.Windows.Forms.Padding(4);
            this.BTSiguientee.Name = "BTSiguientee";
            this.BTSiguientee.Size = new System.Drawing.Size(133, 44);
            this.BTSiguientee.TabIndex = 9;
            this.BTSiguientee.Text = "Siguiente";
            this.BTSiguientee.UseVisualStyleBackColor = false;
            this.BTSiguientee.Click += new System.EventHandler(this.BTSiguientee_Click);
            // 
            // BTAtrass
            // 
            this.BTAtrass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTAtrass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtrass.Location = new System.Drawing.Point(536, 570);
            this.BTAtrass.Margin = new System.Windows.Forms.Padding(4);
            this.BTAtrass.Name = "BTAtrass";
            this.BTAtrass.Size = new System.Drawing.Size(133, 44);
            this.BTAtrass.TabIndex = 10;
            this.BTAtrass.Text = "Atrás";
            this.BTAtrass.UseVisualStyleBackColor = false;
            this.BTAtrass.Click += new System.EventHandler(this.BTAtrass_Click);
            // 
            // FRMRegistro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 689);
            this.Controls.Add(this.BTAtrass);
            this.Controls.Add(this.BTSiguientee);
            this.Controls.Add(this.mensajero);
            this.Controls.Add(this.CBMuyactivo);
            this.Controls.Add(this.mesero);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.CBLigeramenteactivo);
            this.Controls.Add(this.cajero);
            this.Controls.Add(this.CBNomuyactivo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMRegistro2";
            this.Text = "FRMRegistro2";
            this.Load += new System.EventHandler(this.FRMRegistro2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CBNomuyactivo;
        private System.Windows.Forms.Label cajero;
        private System.Windows.Forms.CheckBox CBLigeramenteactivo;
        private System.Windows.Forms.Label profesor;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label mesero;
        private System.Windows.Forms.CheckBox CBMuyactivo;
        private System.Windows.Forms.Label mensajero;
        private System.Windows.Forms.Button BTSiguientee;
        private System.Windows.Forms.Button BTAtrass;
    }
}