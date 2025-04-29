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
            this.agregarPbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.agregarPbtn.FlatAppearance.BorderSize = 0;
            this.agregarPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarPbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.agregarPbtn.ForeColor = System.Drawing.Color.White;
            this.agregarPbtn.Location = new System.Drawing.Point(27, 157);
            this.agregarPbtn.Name = "agregarPbtn";
            this.agregarPbtn.Size = new System.Drawing.Size(240, 35);
            this.agregarPbtn.TabIndex = 17;
            this.agregarPbtn.Text = "Guardar Cambios";
            this.agregarPbtn.UseVisualStyleBackColor = false;
            this.agregarPbtn.Click += new System.EventHandler(this.agregarPbtn_Click);
            // 
            // duracionPud
            // 
            this.duracionPud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.duracionPud.Location = new System.Drawing.Point(27, 100);
            this.duracionPud.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.duracionPud.Name = "duracionPud";
            this.duracionPud.Size = new System.Drawing.Size(127, 25);
            this.duracionPud.TabIndex = 16;
            // 
            // generoCbx
            // 
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Location = new System.Drawing.Point(27, 61);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(127, 25);
            this.generoCbx.TabIndex = 15;
            // 
            // DuracionP
            // 
            this.DuracionP.AutoSize = true;
            this.DuracionP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DuracionP.ForeColor = System.Drawing.Color.White;
            this.DuracionP.Location = new System.Drawing.Point(170, 103);
            this.DuracionP.Name = "DuracionP";
            this.DuracionP.Size = new System.Drawing.Size(97, 15);
            this.DuracionP.TabIndex = 14;
            this.DuracionP.Text = "Duración (min)";
            // 
            // GeneroP
            // 
            this.GeneroP.AutoSize = true;
            this.GeneroP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GeneroP.ForeColor = System.Drawing.Color.White;
            this.GeneroP.Location = new System.Drawing.Point(170, 64);
            this.GeneroP.Name = "GeneroP";
            this.GeneroP.Size = new System.Drawing.Size(49, 15);
            this.GeneroP.TabIndex = 13;
            this.GeneroP.Text = "Género";
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NombreP.ForeColor = System.Drawing.Color.White;
            this.NombreP.Location = new System.Drawing.Point(170, 26);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(53, 15);
            this.NombreP.TabIndex = 12;
            this.NombreP.Text = "Nombre";
            // 
            // nombrepTxb
            // 
            this.nombrepTxb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nombrepTxb.Location = new System.Drawing.Point(27, 23);
            this.nombrepTxb.Name = "nombrepTxb";
            this.nombrepTxb.Size = new System.Drawing.Size(127, 25);
            this.nombrepTxb.TabIndex = 11;
            // 
            // ModificarPelicula
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.agregarPbtn);
            this.Controls.Add(this.duracionPud);
            this.Controls.Add(this.generoCbx);
            this.Controls.Add(this.DuracionP);
            this.Controls.Add(this.GeneroP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.nombrepTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Película";
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
