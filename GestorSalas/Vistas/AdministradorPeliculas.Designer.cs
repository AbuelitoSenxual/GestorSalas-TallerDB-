namespace GestorSalas.Vistas
{
    partial class AdministradorPeliculas
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
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.gesPeliculaBtn = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarPelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Location = new System.Drawing.Point(30, 30);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.Size = new System.Drawing.Size(348, 270);
            this.dgvPelicula.TabIndex = 0;
            this.dgvPelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPelicula_CellContentClick);
            // 
            // gesPeliculaBtn
            // 
            this.gesPeliculaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gesPeliculaBtn.FlatAppearance.BorderSize = 0;
            this.gesPeliculaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gesPeliculaBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gesPeliculaBtn.ForeColor = System.Drawing.Color.White;
            this.gesPeliculaBtn.Location = new System.Drawing.Point(450, 44);
            this.gesPeliculaBtn.Name = "gesPeliculaBtn";
            this.gesPeliculaBtn.Size = new System.Drawing.Size(150, 50);
            this.gesPeliculaBtn.TabIndex = 1;
            this.gesPeliculaBtn.Text = "Añadir Películas";
            this.gesPeliculaBtn.UseVisualStyleBackColor = false;
            this.gesPeliculaBtn.Click += new System.EventHandler(this.gesPeliculaBtn_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(450, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 50);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Películas";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarPelicula
            // 
            this.btnEliminarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarPelicula.FlatAppearance.BorderSize = 0;
            this.btnEliminarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPelicula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPelicula.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPelicula.Location = new System.Drawing.Point(450, 244);
            this.btnEliminarPelicula.Name = "btnEliminarPelicula";
            this.btnEliminarPelicula.Size = new System.Drawing.Size(150, 50);
            this.btnEliminarPelicula.TabIndex = 3;
            this.btnEliminarPelicula.Text = "Eliminar Películas";
            this.btnEliminarPelicula.UseVisualStyleBackColor = false;
            this.btnEliminarPelicula.Click += new System.EventHandler(this.btnEliminarPelicula_Click);
            // 
            // AdministradorPeliculas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.btnEliminarPelicula);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gesPeliculaBtn);
            this.Controls.Add(this.dgvPelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministradorPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Películas";
            this.Activated += new System.EventHandler(this.AdministradorPeliculas_Activated);
            this.Load += new System.EventHandler(this.AdministradorPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPelicula;
        private System.Windows.Forms.Button gesPeliculaBtn;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarPelicula;
    }
}
