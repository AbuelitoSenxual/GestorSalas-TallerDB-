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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.Location = new System.Drawing.Point(585, 395);
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
            this.btnBuscarFuncion.Location = new System.Drawing.Point(585, 111);
            this.btnBuscarFuncion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.Size = new System.Drawing.Size(182, 100);
            this.btnBuscarFuncion.TabIndex = 1;
            this.btnBuscarFuncion.Text = "Buscar Funcion";
            this.btnBuscarFuncion.UseVisualStyleBackColor = true;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.btnBuscarFuncion_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(39, 111);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 379);
            this.listBox1.TabIndex = 2;
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 607);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuscarFuncion);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Button btnBuscarFuncion;
        private System.Windows.Forms.ListBox listBox1;
    }
}