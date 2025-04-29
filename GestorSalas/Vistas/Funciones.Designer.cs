namespace GestorSalas
{
    partial class Funciones
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
            this.btnBuscarAsiento = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvpelicula = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarAsiento
            // 
            this.btnBuscarAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBuscarAsiento.FlatAppearance.BorderSize = 0;
            this.btnBuscarAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAsiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAsiento.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAsiento.Location = new System.Drawing.Point(580, 79);
            this.btnBuscarAsiento.Name = "btnBuscarAsiento";
            this.btnBuscarAsiento.Size = new System.Drawing.Size(182, 50);
            this.btnBuscarAsiento.TabIndex = 2;
            this.btnBuscarAsiento.Text = "Buscar Asiento";
            this.btnBuscarAsiento.UseVisualStyleBackColor = false;
            this.btnBuscarAsiento.Click += new System.EventHandler(this.btnBuscarAsiento_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(580, 262);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(182, 50);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvpelicula
            // 
            this.dgvpelicula.AllowUserToAddRows = false;
            this.dgvpelicula.AllowUserToDeleteRows = false;
            this.dgvpelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpelicula.Location = new System.Drawing.Point(23, 35);
            this.dgvpelicula.Name = "dgvpelicula";
            this.dgvpelicula.ReadOnly = true;
            this.dgvpelicula.Size = new System.Drawing.Size(527, 385);
            this.dgvpelicula.TabIndex = 4;
            this.dgvpelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpelicula_CellContentClick);
            // 
            // Funciones
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvpelicula);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscarAsiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Funciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Funciones";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Funciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarAsiento;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvpelicula;
    }
}
