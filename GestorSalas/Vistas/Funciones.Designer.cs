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
            this.btnBuscarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsiento.Location = new System.Drawing.Point(580, 79);
            this.btnBuscarAsiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarAsiento.Name = "btnBuscarAsiento";
            this.btnBuscarAsiento.Size = new System.Drawing.Size(182, 100);
            this.btnBuscarAsiento.TabIndex = 2;
            this.btnBuscarAsiento.Text = "Buscar Asiento";
            this.btnBuscarAsiento.UseVisualStyleBackColor = true;
            this.btnBuscarAsiento.Click += new System.EventHandler(this.btnBuscarAsiento_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(580, 262);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(182, 100);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvpelicula
            // 
            this.dgvpelicula.AllowUserToAddRows = false;
            this.dgvpelicula.AllowUserToDeleteRows = false;
            this.dgvpelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpelicula.Location = new System.Drawing.Point(23, 35);
            this.dgvpelicula.Name = "dgvpelicula";
            this.dgvpelicula.Size = new System.Drawing.Size(527, 385);
            this.dgvpelicula.TabIndex = 4;
            this.dgvpelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpelicula_CellContentClick);
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvpelicula);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscarAsiento);
            this.Name = "Funciones";
            this.Text = "Funciones";
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