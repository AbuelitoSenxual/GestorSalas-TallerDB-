namespace GestorSalas.Vistas
{
    partial class AgregarPelicualas
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
            this.components = new System.ComponentModel.Container();
            this.nombrepTxb = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.Label();
            this.DuracionP = new System.Windows.Forms.Label();
            this.duracionPud = new System.Windows.Forms.NumericUpDown();
            this.agregarPbtn = new System.Windows.Forms.Button();
            this.imagenPelBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RutaImagenTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrepTxb
            // 
            this.nombrepTxb.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.nombrepTxb.ForeColor = System.Drawing.Color.White;
            this.nombrepTxb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nombrepTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombrepTxb.Location = new System.Drawing.Point(80, 58);
            this.nombrepTxb.Name = "nombrepTxb";
            this.nombrepTxb.Size = new System.Drawing.Size(140, 25);
            this.nombrepTxb.TabIndex = 0;
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.NombreP.ForeColor = System.Drawing.Color.White;
            this.NombreP.Location = new System.Drawing.Point(242, 61);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(65, 19);
            this.NombreP.TabIndex = 1;
            this.NombreP.Text = "Nombre";
            // 
            // DuracionP
            // 
            this.DuracionP.AutoSize = true;
            this.DuracionP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DuracionP.ForeColor = System.Drawing.Color.White;
            this.DuracionP.Location = new System.Drawing.Point(242, 120);
            this.DuracionP.Name = "DuracionP";
            this.DuracionP.Size = new System.Drawing.Size(120, 19);
            this.DuracionP.TabIndex = 5;
            this.DuracionP.Text = "Duración (minutos)";
            // 
            // duracionPud
            // 
            this.duracionPud.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.duracionPud.ForeColor = System.Drawing.Color.White;
            this.duracionPud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.duracionPud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duracionPud.Location = new System.Drawing.Point(80, 118);
            this.duracionPud.Name = "duracionPud";
            this.duracionPud.Size = new System.Drawing.Size(140, 25);
            this.duracionPud.TabIndex = 7;
            // 
            // agregarPbtn
            // 
            this.agregarPbtn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.agregarPbtn.FlatAppearance.BorderSize = 0;
            this.agregarPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarPbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.agregarPbtn.ForeColor = System.Drawing.Color.White;
            this.agregarPbtn.Location = new System.Drawing.Point(112, 212);
            this.agregarPbtn.Name = "agregarPbtn";
            this.agregarPbtn.Size = new System.Drawing.Size(120, 40);
            this.agregarPbtn.TabIndex = 8;
            this.agregarPbtn.Text = "Agregar";
            this.agregarPbtn.UseVisualStyleBackColor = false;
            this.agregarPbtn.Click += new System.EventHandler(this.agregarPbtn_Click);
            // 
            // imagenPelBtn
            // 
            this.imagenPelBtn.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.imagenPelBtn.FlatAppearance.BorderSize = 0;
            this.imagenPelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagenPelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.imagenPelBtn.ForeColor = System.Drawing.Color.White;
            this.imagenPelBtn.Location = new System.Drawing.Point(225, 168);
            this.imagenPelBtn.Name = "imagenPelBtn";
            this.imagenPelBtn.Size = new System.Drawing.Size(140, 30);
            this.imagenPelBtn.TabIndex = 9;
            this.imagenPelBtn.Text = "Importar imagen";
            this.imagenPelBtn.UseVisualStyleBackColor = false;
            this.imagenPelBtn.Click += new System.EventHandler(this.imagenPelBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RutaImagenTxt
            // 
            this.RutaImagenTxt.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.RutaImagenTxt.ForeColor = System.Drawing.Color.White;
            this.RutaImagenTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RutaImagenTxt.Location = new System.Drawing.Point(80, 168);
            this.RutaImagenTxt.Name = "RutaImagenTxt";
            this.RutaImagenTxt.ReadOnly = true;
            this.RutaImagenTxt.Size = new System.Drawing.Size(140, 25);
            this.RutaImagenTxt.TabIndex = 10;
            // 
            // AgregarPelicualas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(32, 30, 31);
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.RutaImagenTxt);
            this.Controls.Add(this.imagenPelBtn);
            this.Controls.Add(this.agregarPbtn);
            this.Controls.Add(this.duracionPud);
            this.Controls.Add(this.DuracionP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.nombrepTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarPelicualas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Películas";
            this.Activated += new System.EventHandler(this.AgregarPelicualas_Activated);
            this.Load += new System.EventHandler(this.AgregarPelicualas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duracionPud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox nombrepTxb;
        private System.Windows.Forms.Label NombreP;
        private System.Windows.Forms.Label DuracionP;
        private System.Windows.Forms.NumericUpDown duracionPud;
        private System.Windows.Forms.Button agregarPbtn;
        private System.Windows.Forms.Button imagenPelBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox RutaImagenTxt;
    }
}
