﻿namespace WindowsFormsApp4
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
            this.CBNomuyactivo.Location = new System.Drawing.Point(146, 125);
            this.CBNomuyactivo.Name = "CBNomuyactivo";
            this.CBNomuyactivo.Size = new System.Drawing.Size(139, 22);
            this.CBNomuyactivo.TabIndex = 1;
            this.CBNomuyactivo.Text = "No muy activo";
            this.CBNomuyactivo.UseVisualStyleBackColor = false;
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.BackColor = System.Drawing.Color.Transparent;
            this.cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cajero.Location = new System.Drawing.Point(164, 147);
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(328, 40);
            this.cajero.TabIndex = 2;
            this.cajero.Text = "Pasa la mayor parte del dia sentado (p.ej.: es \r\ncajero o trabaja en una oficina)" +
    "";
            this.cajero.Click += new System.EventHandler(this.label2_Click);
            // 
            // CBLigeramenteactivo
            // 
            this.CBLigeramenteactivo.AutoSize = true;
            this.CBLigeramenteactivo.BackColor = System.Drawing.Color.Transparent;
            this.CBLigeramenteactivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLigeramenteactivo.Location = new System.Drawing.Point(146, 206);
            this.CBLigeramenteactivo.Name = "CBLigeramenteactivo";
            this.CBLigeramenteactivo.Size = new System.Drawing.Size(181, 22);
            this.CBLigeramenteactivo.TabIndex = 3;
            this.CBLigeramenteactivo.Text = "Ligeramente activo";
            this.CBLigeramenteactivo.UseVisualStyleBackColor = false;
            // 
            // profesor
            // 
            this.profesor.AutoSize = true;
            this.profesor.BackColor = System.Drawing.Color.Transparent;
            this.profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.profesor.Location = new System.Drawing.Point(165, 228);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(366, 40);
            this.profesor.TabIndex = 4;
            this.profesor.Text = "Pasa buena parte del dia de pie. (p. ej.: es profesor\r\no vendedor)";
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.BackColor = System.Drawing.Color.Transparent;
            this.CBActivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivo.Location = new System.Drawing.Point(146, 282);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(78, 22);
            this.CBActivo.TabIndex = 5;
            this.CBActivo.Text = "Activo";
            this.CBActivo.UseVisualStyleBackColor = false;
            // 
            // mesero
            // 
            this.mesero.AutoSize = true;
            this.mesero.BackColor = System.Drawing.Color.Transparent;
            this.mesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mesero.Location = new System.Drawing.Point(164, 307);
            this.mesero.Name = "mesero";
            this.mesero.Size = new System.Drawing.Size(310, 40);
            this.mesero.TabIndex = 6;
            this.mesero.Text = "Pasa buena parte del dia haciendo alguna \r\nactividad fisica (p. ej.: mesero carte" +
    "ro)";
            // 
            // CBMuyactivo
            // 
            this.CBMuyactivo.AutoSize = true;
            this.CBMuyactivo.BackColor = System.Drawing.Color.Transparent;
            this.CBMuyactivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMuyactivo.Location = new System.Drawing.Point(146, 369);
            this.CBMuyactivo.Name = "CBMuyactivo";
            this.CBMuyactivo.Size = new System.Drawing.Size(112, 22);
            this.CBMuyactivo.TabIndex = 7;
            this.CBMuyactivo.Text = "Muy activo";
            this.CBMuyactivo.UseVisualStyleBackColor = false;
            // 
            // mensajero
            // 
            this.mensajero.AutoSize = true;
            this.mensajero.BackColor = System.Drawing.Color.Transparent;
            this.mensajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mensajero.Location = new System.Drawing.Point(164, 390);
            this.mensajero.Name = "mensajero";
            this.mensajero.Size = new System.Drawing.Size(338, 60);
            this.mensajero.TabIndex = 8;
            this.mensajero.Text = "Pasa la mayor parte del dia haciendo actividad \r\nfisica intensa (p. ej.: es mensa" +
    "jero ciclista o\r\ncarpintero)";
            // 
            // BTSiguientee
            // 
            this.BTSiguientee.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTSiguientee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSiguientee.Location = new System.Drawing.Point(540, 463);
            this.BTSiguientee.Name = "BTSiguientee";
            this.BTSiguientee.Size = new System.Drawing.Size(100, 36);
            this.BTSiguientee.TabIndex = 9;
            this.BTSiguientee.Text = "Siguiente";
            this.BTSiguientee.UseVisualStyleBackColor = false;
            this.BTSiguientee.Click += new System.EventHandler(this.BTSiguientee_Click);
            // 
            // BTAtrass
            // 
            this.BTAtrass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTAtrass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtrass.Location = new System.Drawing.Point(402, 463);
            this.BTAtrass.Name = "BTAtrass";
            this.BTAtrass.Size = new System.Drawing.Size(100, 36);
            this.BTAtrass.TabIndex = 10;
            this.BTAtrass.Text = "Atrás";
            this.BTAtrass.UseVisualStyleBackColor = false;
            this.BTAtrass.Click += new System.EventHandler(this.BTAtrass_Click);
            // 
            // FRMRegistro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 560);
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
            this.Name = "FRMRegistro2";
            this.Text = "FRMRegistro2";
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