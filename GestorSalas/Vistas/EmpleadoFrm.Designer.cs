namespace GestorSalas.Vistas
{
    partial class EmpleadoFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.nombreEmtxt.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.nombreEmtxt.ForeColor = System.Drawing.Color.White;
            this.nombreEmtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreEmtxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nombreEmtxt.Location = new System.Drawing.Point(28, 44);
            this.nombreEmtxt.Name = "nombreEmtxt";
            this.nombreEmtxt.Size = new System.Drawing.Size(121, 25);
            this.nombreEmtxt.TabIndex = 0;
            // 
            // nombreEmlbl
            // 
            this.nombreEmlbl.AutoSize = true;
            this.nombreEmlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nombreEmlbl.ForeColor = System.Drawing.Color.White;
            this.nombreEmlbl.Location = new System.Drawing.Point(192, 48);
            this.nombreEmlbl.Name = "nombreEmlbl";
            this.nombreEmlbl.Size = new System.Drawing.Size(61, 19);
            this.nombreEmlbl.TabIndex = 1;
            this.nombreEmlbl.Text = "Nombre";
            // 
            // puestoEmlbl
            // 
            this.puestoEmlbl.AutoSize = true;
            this.puestoEmlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.puestoEmlbl.ForeColor = System.Drawing.Color.White;
            this.puestoEmlbl.Location = new System.Drawing.Point(192, 107);
            this.puestoEmlbl.Name = "puestoEmlbl";
            this.puestoEmlbl.Size = new System.Drawing.Size(52, 19);
            this.puestoEmlbl.TabIndex = 3;
            this.puestoEmlbl.Text = "Puesto";
            // 
            // usuarioEmlbl
            // 
            this.usuarioEmlbl.AutoSize = true;
            this.usuarioEmlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usuarioEmlbl.ForeColor = System.Drawing.Color.White;
            this.usuarioEmlbl.Location = new System.Drawing.Point(192, 164);
            this.usuarioEmlbl.Name = "usuarioEmlbl";
            this.usuarioEmlbl.Size = new System.Drawing.Size(58, 19);
            this.usuarioEmlbl.TabIndex = 7;
            this.usuarioEmlbl.Text = "Usuario";
            // 
            // usuarioEmtxt
            // 
            this.usuarioEmtxt.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.usuarioEmtxt.ForeColor = System.Drawing.Color.White;
            this.usuarioEmtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioEmtxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usuarioEmtxt.Location = new System.Drawing.Point(28, 161);
            this.usuarioEmtxt.Name = "usuarioEmtxt";
            this.usuarioEmtxt.Size = new System.Drawing.Size(121, 25);
            this.usuarioEmtxt.TabIndex = 6;
            // 
            // puestoEmcbx
            // 
            this.puestoEmcbx.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.puestoEmcbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puestoEmcbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.puestoEmcbx.ForeColor = System.Drawing.Color.White;
            this.puestoEmcbx.FormattingEnabled = true;
            this.puestoEmcbx.Location = new System.Drawing.Point(28, 104);
            this.puestoEmcbx.Name = "puestoEmcbx";
            this.puestoEmcbx.Size = new System.Drawing.Size(121, 25);
            this.puestoEmcbx.TabIndex = 8;
            this.puestoEmcbx.SelectedIndexChanged += new System.EventHandler(this.puestoEmcbx_SelectedIndexChanged);
            // 
            // contraseñaEmlbl
            // 
            this.contraseñaEmlbl.AutoSize = true;
            this.contraseñaEmlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.contraseñaEmlbl.ForeColor = System.Drawing.Color.White;
            this.contraseñaEmlbl.Location = new System.Drawing.Point(192, 209);
            this.contraseñaEmlbl.Name = "contraseñaEmlbl";
            this.contraseñaEmlbl.Size = new System.Drawing.Size(79, 19);
            this.contraseñaEmlbl.TabIndex = 10;
            this.contraseñaEmlbl.Text = "Contraseña";
            // 
            // contraseñaEmtxt
            // 
            this.contraseñaEmtxt.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.contraseñaEmtxt.ForeColor = System.Drawing.Color.White;
            this.contraseñaEmtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseñaEmtxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contraseñaEmtxt.Location = new System.Drawing.Point(28, 206);
            this.contraseñaEmtxt.Name = "contraseñaEmtxt";
            this.contraseñaEmtxt.Size = new System.Drawing.Size(121, 25);
            this.contraseñaEmtxt.TabIndex = 9;
            // 
            // cargarEmpleado
            // 
            this.cargarEmpleado.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.cargarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarEmpleado.FlatAppearance.BorderSize = 0;
            this.cargarEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cargarEmpleado.ForeColor = System.Drawing.Color.White;
            this.cargarEmpleado.Location = new System.Drawing.Point(72, 273);
            this.cargarEmpleado.Name = "cargarEmpleado";
            this.cargarEmpleado.Size = new System.Drawing.Size(160, 50);
            this.cargarEmpleado.TabIndex = 11;
            this.cargarEmpleado.Text = "Cargar Datos";
            this.cargarEmpleado.UseVisualStyleBackColor = false;
            this.cargarEmpleado.Click += new System.EventHandler(this.cargarEmpleado_Click);
            // 
            // EmpleadoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(32, 30, 31);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmpleadoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
