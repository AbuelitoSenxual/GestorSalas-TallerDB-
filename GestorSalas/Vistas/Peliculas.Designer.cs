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
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.Location = new System.Drawing.Point(519, 308);
            this.btnCambiarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(182, 100);
            this.btnCambiarUsuario.TabIndex = 0;
            this.btnCambiarUsuario.Text = "Cambiar Usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncion.Location = new System.Drawing.Point(519, 24);
            this.btnBuscarFuncion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.Size = new System.Drawing.Size(182, 100);
            this.btnBuscarFuncion.TabIndex = 1;
            this.btnBuscarFuncion.Text = "Buscar Funcion";
            this.btnBuscarFuncion.UseVisualStyleBackColor = true;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.btnBuscarFuncion_Click);
            // 
            // gestionarBaseBtn
            // 
            this.gestionarBaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarBaseBtn.Location = new System.Drawing.Point(519, 172);
            this.gestionarBaseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gestionarBaseBtn.Name = "gestionarBaseBtn";
            this.gestionarBaseBtn.Size = new System.Drawing.Size(182, 100);
            this.gestionarBaseBtn.TabIndex = 3;
            this.gestionarBaseBtn.Text = "Gestionar Base";
            this.gestionarBaseBtn.UseVisualStyleBackColor = true;
            this.gestionarBaseBtn.Click += new System.EventHandler(this.gestionarBaseBtn_Click);
            // 
            // peliculasDgv
            // 
            this.peliculasDgv.AllowUserToAddRows = false;
            this.peliculasDgv.AllowUserToDeleteRows = false;
            this.peliculasDgv.AllowUserToResizeColumns = false;
            this.peliculasDgv.AllowUserToResizeRows = false;
            this.peliculasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasDgv.Location = new System.Drawing.Point(31, 24);
            this.peliculasDgv.Name = "peliculasDgv";
            this.peliculasDgv.ReadOnly = true;
            this.peliculasDgv.Size = new System.Drawing.Size(440, 384);
            this.peliculasDgv.TabIndex = 4;
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 489);
            this.Controls.Add(this.peliculasDgv);
            this.Controls.Add(this.gestionarBaseBtn);
            this.Controls.Add(this.btnBuscarFuncion);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.Activated += new System.EventHandler(this.Peliculas_Activated);
            this.Load += new System.EventHandler(this.Peliculas_Load);
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