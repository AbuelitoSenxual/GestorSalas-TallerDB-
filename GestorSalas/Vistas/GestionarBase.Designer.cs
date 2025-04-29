namespace GestorSalas.Vistas
{
    partial class GestionarBase
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
            this.gesPeliculaBtn = new System.Windows.Forms.Button();
            this.gestionarEmplBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gesPeliculaBtn
            // 
            this.gesPeliculaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gesPeliculaBtn.FlatAppearance.BorderSize = 0;
            this.gesPeliculaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gesPeliculaBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gesPeliculaBtn.ForeColor = System.Drawing.Color.White;
            this.gesPeliculaBtn.Location = new System.Drawing.Point(100, 50);
            this.gesPeliculaBtn.Name = "gesPeliculaBtn";
            this.gesPeliculaBtn.Size = new System.Drawing.Size(200, 50);
            this.gesPeliculaBtn.TabIndex = 0;
            this.gesPeliculaBtn.Text = "Gestionar Películas";
            this.gesPeliculaBtn.UseVisualStyleBackColor = false;
            this.gesPeliculaBtn.Click += new System.EventHandler(this.gesPeliculaBtn_Click);
            // 
            // gestionarEmplBtn
            // 
            this.gestionarEmplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.gestionarEmplBtn.FlatAppearance.BorderSize = 0;
            this.gestionarEmplBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionarEmplBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gestionarEmplBtn.ForeColor = System.Drawing.Color.White;
            this.gestionarEmplBtn.Location = new System.Drawing.Point(100, 130);
            this.gestionarEmplBtn.Name = "gestionarEmplBtn";
            this.gestionarEmplBtn.Size = new System.Drawing.Size(200, 50);
            this.gestionarEmplBtn.TabIndex = 1;
            this.gestionarEmplBtn.Text = "Gestionar Empleados";
            this.gestionarEmplBtn.UseVisualStyleBackColor = false;
            this.gestionarEmplBtn.Click += new System.EventHandler(this.gestionarEmplBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.volverBtn.FlatAppearance.BorderSize = 0;
            this.volverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.volverBtn.ForeColor = System.Drawing.Color.White;
            this.volverBtn.Location = new System.Drawing.Point(150, 210);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(100, 40);
            this.volverBtn.TabIndex = 2;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // GestionarBase
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.gestionarEmplBtn);
            this.Controls.Add(this.gesPeliculaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Recursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gesPeliculaBtn;
        private System.Windows.Forms.Button gestionarEmplBtn;
        private System.Windows.Forms.Button volverBtn;
    }
}
