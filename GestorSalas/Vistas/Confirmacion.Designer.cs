namespace GestorSalas
{
    partial class Confirmacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarReservacion = new System.Windows.Forms.Button();
            this.btnDeclinarReservacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar reservacion ?";
            // 
            // btnAceptarReservacion
            // 
            this.btnAceptarReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReservacion.Location = new System.Drawing.Point(97, 132);
            this.btnAceptarReservacion.Name = "btnAceptarReservacion";
            this.btnAceptarReservacion.Size = new System.Drawing.Size(110, 52);
            this.btnAceptarReservacion.TabIndex = 1;
            this.btnAceptarReservacion.Text = "Aceptar";
            this.btnAceptarReservacion.UseVisualStyleBackColor = true;
            // 
            // btnDeclinarReservacion
            // 
            this.btnDeclinarReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclinarReservacion.Location = new System.Drawing.Point(230, 132);
            this.btnDeclinarReservacion.Name = "btnDeclinarReservacion";
            this.btnDeclinarReservacion.Size = new System.Drawing.Size(118, 52);
            this.btnDeclinarReservacion.TabIndex = 2;
            this.btnDeclinarReservacion.Text = "Declinar Reservacion";
            this.btnDeclinarReservacion.UseVisualStyleBackColor = true;
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 212);
            this.Controls.Add(this.btnDeclinarReservacion);
            this.Controls.Add(this.btnAceptarReservacion);
            this.Controls.Add(this.label1);
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarReservacion;
        private System.Windows.Forms.Button btnDeclinarReservacion;
    }
}