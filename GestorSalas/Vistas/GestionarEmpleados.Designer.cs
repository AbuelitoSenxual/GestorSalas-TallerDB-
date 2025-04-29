namespace GestorSalas.Vistas
{
    partial class GestionarEmpleados
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
            this.eliminarEmpBtn = new System.Windows.Forms.Button();
            this.modificarEmpBtn = new System.Windows.Forms.Button();
            this.empleadoDgv = new System.Windows.Forms.DataGridView();
            this.agregarEmbtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarEmpBtn
            // 
            this.eliminarEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.eliminarEmpBtn.FlatAppearance.BorderSize = 0;
            this.eliminarEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarEmpBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.eliminarEmpBtn.ForeColor = System.Drawing.Color.White;
            this.eliminarEmpBtn.Location = new System.Drawing.Point(586, 24);
            this.eliminarEmpBtn.Name = "eliminarEmpBtn";
            this.eliminarEmpBtn.Size = new System.Drawing.Size(180, 50);
            this.eliminarEmpBtn.TabIndex = 1;
            this.eliminarEmpBtn.Text = "Eliminar";
            this.eliminarEmpBtn.UseVisualStyleBackColor = false;
            this.eliminarEmpBtn.Click += new System.EventHandler(this.eliminarEmpBtn_Click);
            // 
            // modificarEmpBtn
            // 
            this.modificarEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.modificarEmpBtn.FlatAppearance.BorderSize = 0;
            this.modificarEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarEmpBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.modificarEmpBtn.ForeColor = System.Drawing.Color.White;
            this.modificarEmpBtn.Location = new System.Drawing.Point(586, 100);
            this.modificarEmpBtn.Name = "modificarEmpBtn";
            this.modificarEmpBtn.Size = new System.Drawing.Size(180, 50);
            this.modificarEmpBtn.TabIndex = 2;
            this.modificarEmpBtn.Text = "Modificar";
            this.modificarEmpBtn.UseVisualStyleBackColor = false;
            this.modificarEmpBtn.Click += new System.EventHandler(this.modificarEmpBtn_Click);
            // 
            // empleadoDgv
            // 
            this.empleadoDgv.AllowUserToAddRows = false;
            this.empleadoDgv.AllowUserToDeleteRows = false;
            this.empleadoDgv.AllowUserToResizeColumns = false;
            this.empleadoDgv.AllowUserToResizeRows = false;
            this.empleadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDgv.Location = new System.Drawing.Point(23, 24);
            this.empleadoDgv.Name = "empleadoDgv";
            this.empleadoDgv.ReadOnly = true;
            this.empleadoDgv.Size = new System.Drawing.Size(530, 384);
            this.empleadoDgv.TabIndex = 5;
            // 
            // agregarEmbtn
            // 
            this.agregarEmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.agregarEmbtn.FlatAppearance.BorderSize = 0;
            this.agregarEmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarEmbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.agregarEmbtn.ForeColor = System.Drawing.Color.White;
            this.agregarEmbtn.Location = new System.Drawing.Point(586, 176);
            this.agregarEmbtn.Name = "agregarEmbtn";
            this.agregarEmbtn.Size = new System.Drawing.Size(180, 50);
            this.agregarEmbtn.TabIndex = 6;
            this.agregarEmbtn.Text = "Agregar";
            this.agregarEmbtn.UseVisualStyleBackColor = false;
            this.agregarEmbtn.Click += new System.EventHandler(this.agregarEmbtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.volverBtn.FlatAppearance.BorderSize = 0;
            this.volverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.volverBtn.ForeColor = System.Drawing.Color.White;
            this.volverBtn.Location = new System.Drawing.Point(618, 377);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(120, 44);
            this.volverBtn.TabIndex = 7;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // GestionarEmpleados
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.agregarEmbtn);
            this.Controls.Add(this.empleadoDgv);
            this.Controls.Add(this.modificarEmpBtn);
            this.Controls.Add(this.eliminarEmpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Empleados";
            this.Activated += new System.EventHandler(this.GestionarEmpleados_Activated);
            this.Load += new System.EventHandler(this.GestionarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eliminarEmpBtn;
        private System.Windows.Forms.Button modificarEmpBtn;
        private System.Windows.Forms.DataGridView empleadoDgv;
        private System.Windows.Forms.Button agregarEmbtn;
        private System.Windows.Forms.Button volverBtn;
    }
}
