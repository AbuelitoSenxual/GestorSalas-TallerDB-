namespace GestorSalas
{
    partial class Peliculas
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
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarFuncion = new System.Windows.Forms.Button();
            this.gestionarBaseBtn = new System.Windows.Forms.Button();
            this.peliculasDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(550, 320);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(200, 50);
            this.btnCambiarUsuario.TabIndex = 1;
            this.btnCambiarUsuario.Text = "Cambiar Usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = false;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnBuscarFuncion.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.Location = new System.Drawing.Point(550, 50);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.Size = new System.Drawing.Size(200, 50);
            this.btnBuscarFuncion.TabIndex = 2;
            this.btnBuscarFuncion.Text = "Buscar Función";
            this.btnBuscarFuncion.UseVisualStyleBackColor = false;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.btnBuscarFuncion_Click);
            // 
            // gestionarBaseBtn
            // 
            this.gestionarBaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.gestionarBaseBtn.FlatAppearance.BorderSize = 0;
            this.gestionarBaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionarBaseBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gestionarBaseBtn.ForeColor = System.Drawing.Color.White;
            this.gestionarBaseBtn.Location = new System.Drawing.Point(550, 180);
            this.gestionarBaseBtn.Name = "gestionarBaseBtn";
            this.gestionarBaseBtn.Size = new System.Drawing.Size(200, 50);
            this.gestionarBaseBtn.TabIndex = 3;
            this.gestionarBaseBtn.Text = "Gestionar Base";
            this.gestionarBaseBtn.UseVisualStyleBackColor = false;
            this.gestionarBaseBtn.Click += new System.EventHandler(this.gestionarBaseBtn_Click);
            // 
            // peliculasDgv
            // 
            this.peliculasDgv.AllowUserToAddRows = false;
            this.peliculasDgv.AllowUserToDeleteRows = false;
            this.peliculasDgv.AllowUserToResizeColumns = false;
            this.peliculasDgv.AllowUserToResizeRows = false;
            this.peliculasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peliculasDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.peliculasDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.peliculasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasDgv.Location = new System.Drawing.Point(20, 20);
            this.peliculasDgv.Name = "peliculasDgv";
            this.peliculasDgv.ReadOnly = true;
            this.peliculasDgv.RowHeadersWidth = 51;
            this.peliculasDgv.Size = new System.Drawing.Size(500, 400);
            this.peliculasDgv.TabIndex = 0;
            // 
            // Peliculas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.peliculasDgv);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Controls.Add(this.btnBuscarFuncion);
            this.Controls.Add(this.gestionarBaseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Peliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Películas";
            this.Activated += new System.EventHandler(this.Peliculas_Activated_1);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDgv)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.Button gestionarBaseBtn;
        private System.Windows.Forms.DataGridView peliculasDgv;
    }
}