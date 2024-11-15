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
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarEmpBtn
            // 
            this.eliminarEmpBtn.Location = new System.Drawing.Point(548, 33);
            this.eliminarEmpBtn.Name = "eliminarEmpBtn";
            this.eliminarEmpBtn.Size = new System.Drawing.Size(180, 98);
            this.eliminarEmpBtn.TabIndex = 1;
            this.eliminarEmpBtn.Text = "Eliminar";
            this.eliminarEmpBtn.UseVisualStyleBackColor = true;
            this.eliminarEmpBtn.Click += new System.EventHandler(this.eliminarEmpBtn_Click);
            // 
            // modificarEmpBtn
            // 
            this.modificarEmpBtn.Location = new System.Drawing.Point(548, 169);
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
            this.empleadoDgv.Location = new System.Drawing.Point(12, 12);
            this.empleadoDgv.Name = "empleadoDgv";
            this.empleadoDgv.ReadOnly = true;
            this.empleadoDgv.Size = new System.Drawing.Size(440, 384);
            this.empleadoDgv.TabIndex = 5;
            // 
            // GestionarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}