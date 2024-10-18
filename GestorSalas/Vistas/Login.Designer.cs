namespace GestorSalas
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.ptxOjoContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxOjoContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(103, 242);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(88, 57);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(91, 87);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(91, 162);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(88, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // ptxOjoContraseña
            // 
            this.ptxOjoContraseña.Image = global::GestorSalas.Properties.Resources.Ocultoo;
            this.ptxOjoContraseña.Location = new System.Drawing.Point(211, 162);
            this.ptxOjoContraseña.Name = "ptxOjoContraseña";
            this.ptxOjoContraseña.Size = new System.Drawing.Size(28, 20);
            this.ptxOjoContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxOjoContraseña.TabIndex = 5;
            this.ptxOjoContraseña.TabStop = false;
            this.ptxOjoContraseña.Click += new System.EventHandler(this.ptxOjoContraseña_Click);
            this.ptxOjoContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptxOjoContraseña_MouseDown);
            this.ptxOjoContraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptxOjoContraseña_MouseUp);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 360);
            this.Controls.Add(this.ptxOjoContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ptxOjoContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox ptxOjoContraseña;
    }
}

