﻿namespace GestorSalas.Vistas
{
    partial class GestionarBase
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
            this.gesPeliculaBtn = new System.Windows.Forms.Button();
            this.gestionarEmplBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gesPeliculaBtn
            // 
            this.gesPeliculaBtn.Location = new System.Drawing.Point(30, 61);
            this.gesPeliculaBtn.Name = "gesPeliculaBtn";
            this.gesPeliculaBtn.Size = new System.Drawing.Size(130, 96);
            this.gesPeliculaBtn.TabIndex = 0;
            this.gesPeliculaBtn.Text = "Gestionar Peliculas";
            this.gesPeliculaBtn.UseVisualStyleBackColor = true;
            // 
            // gestionarEmplBtn
            // 
            this.gestionarEmplBtn.Location = new System.Drawing.Point(227, 61);
            this.gestionarEmplBtn.Name = "gestionarEmplBtn";
            this.gestionarEmplBtn.Size = new System.Drawing.Size(130, 96);
            this.gestionarEmplBtn.TabIndex = 1;
            this.gestionarEmplBtn.Text = "Gestionar Empleados";
            this.gestionarEmplBtn.UseVisualStyleBackColor = true;
            // 
            // GestionarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 213);
            this.Controls.Add(this.gestionarEmplBtn);
            this.Controls.Add(this.gesPeliculaBtn);
            this.Name = "GestionarBase";
            this.Text = "GestionarBase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gesPeliculaBtn;
        private System.Windows.Forms.Button gestionarEmplBtn;
    }
}