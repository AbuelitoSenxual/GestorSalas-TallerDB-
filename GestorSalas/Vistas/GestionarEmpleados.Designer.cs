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
            this.eliminarEmpBtn.Location = new System.Drawing.Point(586, 24);
            this.eliminarEmpBtn.Name = "eliminarEmpBtn";
            this.eliminarEmpBtn.Size = new System.Drawing.Size(180, 98);
            this.eliminarEmpBtn.TabIndex = 1;
            this.eliminarEmpBtn.Text = "Eliminar";
            this.eliminarEmpBtn.UseVisualStyleBackColor = true;
            this.eliminarEmpBtn.Click += new System.EventHandler(this.eliminarEmpBtn_Click);
            // 
            // modificarEmpBtn
            // 
            this.modificarEmpBtn.Location = new System.Drawing.Point(586, 128);
            this.modificarEmpBtn.Name = "modificarEmpBtn";
            this.modificarEmpBtn.Size = new System.Drawing.Size(180, 98);
            this.modificarEmpBtn.TabIndex = 2;
            this.modificarEmpBtn.Text = "Modificar";
            this.modificarEmpBtn.UseVisualStyleBackColor = true;
            this.modificarEmpBtn.Click += new System.EventHandler(this.modificarEmpBtn_Click);
            // 
            // empleadoDgv
            // 
            this.empleadoDgv.AllowUserToAddRows = false;
            this.empleadoDgv.AllowUserToDeleteRows = false;
            this.empleadoDgv.AllowUserToResizeColumns = false;
            this.empleadoDgv.AllowUserToResizeRows = false;
            this.empleadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDgv.Location = new System.Drawing.Point(3, 24);
            this.empleadoDgv.Name = "empleadoDgv";
            this.empleadoDgv.ReadOnly = true;
            this.empleadoDgv.Size = new System.Drawing.Size(530, 384);
            this.empleadoDgv.TabIndex = 5;
            // 
            // agregarEmbtn
            // 
            this.agregarEmbtn.Location = new System.Drawing.Point(586, 232);
            this.agregarEmbtn.Name = "agregarEmbtn";
            this.agregarEmbtn.Size = new System.Drawing.Size(180, 98);
            this.agregarEmbtn.TabIndex = 6;
            this.agregarEmbtn.Text = "Agregar";
            this.agregarEmbtn.UseVisualStyleBackColor = true;
            this.agregarEmbtn.Click += new System.EventHandler(this.agregarEmbtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(618, 377);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(120, 44);
            this.volverBtn.TabIndex = 7;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // GestionarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.agregarEmbtn);
            this.Controls.Add(this.empleadoDgv);
            this.Controls.Add(this.modificarEmpBtn);
            this.Controls.Add(this.eliminarEmpBtn);
            this.Name = "GestionarEmpleados";
            this.Text = "GestionarEmpleados";
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