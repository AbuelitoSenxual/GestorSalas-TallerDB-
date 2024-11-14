namespace GestorSalas.Vistas
{
    partial class AgregarPelicualas
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
            this.nombrepTxb = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.Label();
            this.GeneroP = new System.Windows.Forms.Label();
            this.DuracionP = new System.Windows.Forms.Label();
            this.generoCbx = new System.Windows.Forms.ComboBox();
            this.duracionPud = new System.Windows.Forms.NumericUpDown();
            this.agregarPbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrepTxb
            // 
            this.nombrepTxb.Location = new System.Drawing.Point(80, 40);
            this.nombrepTxb.Name = "nombrepTxb";
            this.nombrepTxb.Size = new System.Drawing.Size(121, 20);
            this.nombrepTxb.TabIndex = 0;
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Location = new System.Drawing.Point(242, 43);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(44, 13);
            this.NombreP.TabIndex = 1;
            this.NombreP.Text = "Nombre";
            // 
            // GeneroP
            // 
            this.GeneroP.AutoSize = true;
            this.GeneroP.Location = new System.Drawing.Point(242, 81);
            this.GeneroP.Name = "GeneroP";
            this.GeneroP.Size = new System.Drawing.Size(42, 13);
            this.GeneroP.TabIndex = 3;
            this.GeneroP.Text = "Genero";
            // 
            // DuracionP
            // 
            this.DuracionP.AutoSize = true;
            this.DuracionP.Location = new System.Drawing.Point(242, 120);
            this.DuracionP.Name = "DuracionP";
            this.DuracionP.Size = new System.Drawing.Size(89, 13);
            this.DuracionP.TabIndex = 5;
            this.DuracionP.Text = "Duracion minutos";
            // 
            // generoCbx
            // 
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Location = new System.Drawing.Point(80, 81);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(121, 21);
            this.generoCbx.TabIndex = 6;
            // 
            // duracionPud
            // 
            this.duracionPud.Location = new System.Drawing.Point(81, 118);
            this.duracionPud.Name = "duracionPud";
            this.duracionPud.Size = new System.Drawing.Size(120, 20);
            this.duracionPud.TabIndex = 7;
            // 
            // agregarPbtn
            // 
            this.agregarPbtn.Location = new System.Drawing.Point(126, 176);
            this.agregarPbtn.Name = "agregarPbtn";
            this.agregarPbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarPbtn.TabIndex = 8;
            this.agregarPbtn.Text = "Agregar";
            this.agregarPbtn.UseVisualStyleBackColor = true;
            this.agregarPbtn.Click += new System.EventHandler(this.agregarPbtn_Click);
            // 
            // AgregarPelicualas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 256);
            this.Controls.Add(this.agregarPbtn);
            this.Controls.Add(this.duracionPud);
            this.Controls.Add(this.generoCbx);
            this.Controls.Add(this.DuracionP);
            this.Controls.Add(this.GeneroP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.nombrepTxb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarPelicualas";
            this.Text = "AggregarPelicualas";
            this.Load += new System.EventHandler(this.AgregarPelicualas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombrepTxb;
        private System.Windows.Forms.Label NombreP;
        private System.Windows.Forms.Label GeneroP;
        private System.Windows.Forms.Label DuracionP;
        private System.Windows.Forms.ComboBox generoCbx;
        private System.Windows.Forms.NumericUpDown duracionPud;
        private System.Windows.Forms.Button agregarPbtn;
    }
}