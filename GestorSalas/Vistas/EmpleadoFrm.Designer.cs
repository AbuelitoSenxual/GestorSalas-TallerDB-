namespace GestorSalas.Vistas
{
    partial class EmpleadoFrm
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
            this.nombreEmtxt = new System.Windows.Forms.TextBox();
            this.nombreEmlbl = new System.Windows.Forms.Label();
            this.puestoEmlbl = new System.Windows.Forms.Label();
            this.usuarioEmlbl = new System.Windows.Forms.Label();
            this.usuarioEmtxt = new System.Windows.Forms.TextBox();
            this.puestoEmcbx = new System.Windows.Forms.ComboBox();
            this.contraseñaEmlbl = new System.Windows.Forms.Label();
            this.contraseñaEmtxt = new System.Windows.Forms.TextBox();
            this.cargarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreEmtxt
            // 
            this.nombreEmtxt.Location = new System.Drawing.Point(28, 44);
            this.nombreEmtxt.Name = "nombreEmtxt";
            this.nombreEmtxt.Size = new System.Drawing.Size(121, 20);
            this.nombreEmtxt.TabIndex = 0;
            // 
            // nombreEmlbl
            // 
            this.nombreEmlbl.AutoSize = true;
            this.nombreEmlbl.Location = new System.Drawing.Point(192, 51);
            this.nombreEmlbl.Name = "nombreEmlbl";
            this.nombreEmlbl.Size = new System.Drawing.Size(44, 13);
            this.nombreEmlbl.TabIndex = 1;
            this.nombreEmlbl.Text = "Nombre";
            // 
            // puestoEmlbl
            // 
            this.puestoEmlbl.AutoSize = true;
            this.puestoEmlbl.Location = new System.Drawing.Point(192, 107);
            this.puestoEmlbl.Name = "puestoEmlbl";
            this.puestoEmlbl.Size = new System.Drawing.Size(40, 13);
            this.puestoEmlbl.TabIndex = 3;
            this.puestoEmlbl.Text = "Puesto";
            // 
            // usuarioEmlbl
            // 
            this.usuarioEmlbl.AutoSize = true;
            this.usuarioEmlbl.Location = new System.Drawing.Point(192, 168);
            this.usuarioEmlbl.Name = "usuarioEmlbl";
            this.usuarioEmlbl.Size = new System.Drawing.Size(43, 13);
            this.usuarioEmlbl.TabIndex = 7;
            this.usuarioEmlbl.Text = "Usuario";
            // 
            // usuarioEmtxt
            // 
            this.usuarioEmtxt.Location = new System.Drawing.Point(28, 161);
            this.usuarioEmtxt.Name = "usuarioEmtxt";
            this.usuarioEmtxt.Size = new System.Drawing.Size(121, 20);
            this.usuarioEmtxt.TabIndex = 6;
            // 
            // puestoEmcbx
            // 
            this.puestoEmcbx.FormattingEnabled = true;
            this.puestoEmcbx.Location = new System.Drawing.Point(28, 104);
            this.puestoEmcbx.Name = "puestoEmcbx";
            this.puestoEmcbx.Size = new System.Drawing.Size(121, 21);
            this.puestoEmcbx.TabIndex = 8;
            // 
            // contraseñaEmlbl
            // 
            this.contraseñaEmlbl.AutoSize = true;
            this.contraseñaEmlbl.Location = new System.Drawing.Point(192, 213);
            this.contraseñaEmlbl.Name = "contraseñaEmlbl";
            this.contraseñaEmlbl.Size = new System.Drawing.Size(61, 13);
            this.contraseñaEmlbl.TabIndex = 10;
            this.contraseñaEmlbl.Text = "Contraseña";
            // 
            // contraseñaEmtxt
            // 
            this.contraseñaEmtxt.Location = new System.Drawing.Point(28, 206);
            this.contraseñaEmtxt.Name = "contraseñaEmtxt";
            this.contraseñaEmtxt.Size = new System.Drawing.Size(121, 20);
            this.contraseñaEmtxt.TabIndex = 9;
            // 
            // cargarEmpleado
            // 
            this.cargarEmpleado.Location = new System.Drawing.Point(86, 273);
            this.cargarEmpleado.Name = "cargarEmpleado";
            this.cargarEmpleado.Size = new System.Drawing.Size(146, 59);
            this.cargarEmpleado.TabIndex = 11;
            this.cargarEmpleado.Text = "Cargar Datos";
            this.cargarEmpleado.UseVisualStyleBackColor = true;
            this.cargarEmpleado.Click += new System.EventHandler(this.cargarEmpleado_Click);
            // 
            // EmpleadoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 384);
            this.Controls.Add(this.cargarEmpleado);
            this.Controls.Add(this.contraseñaEmlbl);
            this.Controls.Add(this.contraseñaEmtxt);
            this.Controls.Add(this.puestoEmcbx);
            this.Controls.Add(this.usuarioEmlbl);
            this.Controls.Add(this.usuarioEmtxt);
            this.Controls.Add(this.puestoEmlbl);
            this.Controls.Add(this.nombreEmlbl);
            this.Controls.Add(this.nombreEmtxt);
            this.Name = "EmpleadoFrm";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.EmpleadoFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreEmtxt;
        private System.Windows.Forms.Label nombreEmlbl;
        private System.Windows.Forms.Label puestoEmlbl;
        private System.Windows.Forms.Label usuarioEmlbl;
        private System.Windows.Forms.TextBox usuarioEmtxt;
        private System.Windows.Forms.ComboBox puestoEmcbx;
        private System.Windows.Forms.Label contraseñaEmlbl;
        private System.Windows.Forms.TextBox contraseñaEmtxt;
        private System.Windows.Forms.Button cargarEmpleado;
    }
}