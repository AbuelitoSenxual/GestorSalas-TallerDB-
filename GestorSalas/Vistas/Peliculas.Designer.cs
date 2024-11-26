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
            this.gestionarBaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(509, 49);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(200, 50);
            this.btnCambiarUsuario.TabIndex = 1;
            this.btnCambiarUsuario.Text = "Cambiar Usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = false;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // gestionarBaseBtn
            // 

            this.gestionarBaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.gestionarBaseBtn.FlatAppearance.BorderSize = 0;
            this.gestionarBaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionarBaseBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gestionarBaseBtn.ForeColor = System.Drawing.Color.White;
            this.gestionarBaseBtn.Location = new System.Drawing.Point(509, 360);
            this.gestionarBaseBtn.Name = "gestionarBaseBtn";
            this.gestionarBaseBtn.Size = new System.Drawing.Size(200, 50);
            this.gestionarBaseBtn.TabIndex = 3;
            this.gestionarBaseBtn.Text = "Gestionar Base";
            this.gestionarBaseBtn.UseVisualStyleBackColor = false;
            this.gestionarBaseBtn.Click += new System.EventHandler(this.gestionarBaseBtn_Click);
            // 
            // Peliculas
            // 

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#201e1f");
            this.ClientSize = new System.Drawing.Size(732, 559);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Controls.Add(this.gestionarBaseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Peliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Películas";
            this.Activated += new System.EventHandler(this.Peliculas_Activated_1);
            this.Load += new System.EventHandler(this.Peliculas_Load_1);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Button gestionarBaseBtn;
    }
}