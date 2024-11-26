namespace GestorSalas.Vistas
{
    partial class ModificarPelicula
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
            this.agregarPbtn = new System.Windows.Forms.Button();
            this.duracionPud = new System.Windows.Forms.NumericUpDown();
            this.generoCbx = new System.Windows.Forms.ComboBox();
            this.DuracionP = new System.Windows.Forms.Label();
            this.GeneroP = new System.Windows.Forms.Label();
            this.NombreP = new System.Windows.Forms.Label();
            this.nombrepTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarPbtn
            // 
            this.agregarPbtn.Location = new System.Drawing.Point(28, 157);
            this.agregarPbtn.Name = "agregarPbtn";
            this.agregarPbtn.Size = new System.Drawing.Size(81, 31);
            this.agregarPbtn.TabIndex = 17;
            this.agregarPbtn.Text = "Agregar";
            this.agregarPbtn.UseVisualStyleBackColor = true;
            this.agregarPbtn.Click += new System.EventHandler(this.agregarPbtn_Click);
            // 
            // duracionPud
            // 
            this.duracionPud.Location = new System.Drawing.Point(28, 101);
            this.duracionPud.Name = "duracionPud";
            this.duracionPud.Size = new System.Drawing.Size(126, 20);
            this.duracionPud.TabIndex = 16;
            // 
            // generoCbx
            // 
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Location = new System.Drawing.Point(27, 64);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(127, 21);
            this.generoCbx.TabIndex = 15;
            // 
            // DuracionP
            // 
            this.DuracionP.AutoSize = true;
            this.DuracionP.Location = new System.Drawing.Point(189, 103);
            this.DuracionP.Name = "DuracionP";
            this.DuracionP.Size = new System.Drawing.Size(89, 13);
            this.DuracionP.TabIndex = 14;
            this.DuracionP.Text = "Duracion minutos";
            // 
            // GeneroP
            // 
            this.GeneroP.AutoSize = true;
            this.GeneroP.Location = new System.Drawing.Point(189, 64);
            this.GeneroP.Name = "GeneroP";
            this.GeneroP.Size = new System.Drawing.Size(42, 13);
            this.GeneroP.TabIndex = 13;
            this.GeneroP.Text = "Genero";
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Location = new System.Drawing.Point(189, 26);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(44, 13);
            this.NombreP.TabIndex = 12;
            this.NombreP.Text = "Nombre";
            // 
            // nombrepTxb
            // 
            this.nombrepTxb.Location = new System.Drawing.Point(27, 23);
            this.nombrepTxb.Name = "nombrepTxb";
            this.nombrepTxb.Size = new System.Drawing.Size(127, 20);
            this.nombrepTxb.TabIndex = 11;
            // 
            // ModificarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 286);
            this.Controls.Add(this.agregarPbtn);
            this.Controls.Add(this.duracionPud);
            this.Controls.Add(this.generoCbx);
            this.Controls.Add(this.DuracionP);
            this.Controls.Add(this.GeneroP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.nombrepTxb);
            this.Name = "ModificarPelicula";
            this.Text = "ModificarPelicula";
            this.Load += new System.EventHandler(this.ModificarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarPbtn;
        private System.Windows.Forms.NumericUpDown duracionPud;
        private System.Windows.Forms.ComboBox generoCbx;
        private System.Windows.Forms.Label DuracionP;
        private System.Windows.Forms.Label GeneroP;
        private System.Windows.Forms.Label NombreP;
        private System.Windows.Forms.TextBox nombrepTxb;
    }
}