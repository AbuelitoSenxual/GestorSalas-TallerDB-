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
            this.components = new System.ComponentModel.Container();
            this.nombrepTxb = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.Label();
            this.GeneroP = new System.Windows.Forms.Label();
            this.DuracionP = new System.Windows.Forms.Label();
            this.generoCbx = new System.Windows.Forms.ComboBox();
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
            this.nombrepTxb.Location = new System.Drawing.Point(107, 49);
            this.nombrepTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombrepTxb.Name = "nombrepTxb";
            this.nombrepTxb.Size = new System.Drawing.Size(160, 22);
            this.nombrepTxb.TabIndex = 0;
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Location = new System.Drawing.Point(323, 53);
            this.NombreP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(56, 16);
            this.NombreP.TabIndex = 1;
            this.NombreP.Text = "Nombre";
            // 
            // GeneroP
            // 
            this.GeneroP.AutoSize = true;
            this.GeneroP.Location = new System.Drawing.Point(323, 100);
            this.GeneroP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneroP.Name = "GeneroP";
            this.GeneroP.Size = new System.Drawing.Size(52, 16);
            this.GeneroP.TabIndex = 3;
            this.GeneroP.Text = "Genero";
            // 
            // DuracionP
            // 
            this.DuracionP.AutoSize = true;
            this.DuracionP.Location = new System.Drawing.Point(323, 148);
            this.DuracionP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DuracionP.Name = "DuracionP";
            this.DuracionP.Size = new System.Drawing.Size(110, 16);
            this.DuracionP.TabIndex = 5;
            this.DuracionP.Text = "Duracion minutos";
            // 
            // generoCbx
            // 
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Location = new System.Drawing.Point(107, 100);
            this.generoCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(160, 24);
            this.generoCbx.TabIndex = 6;
            // 
            // duracionPud
            // 
            this.duracionPud.Location = new System.Drawing.Point(108, 145);
            this.duracionPud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duracionPud.Name = "duracionPud";
            this.duracionPud.Size = new System.Drawing.Size(160, 22);
            this.duracionPud.TabIndex = 7;
            // 
            // agregarPbtn
            // 
            this.agregarPbtn.Location = new System.Drawing.Point(149, 261);
            this.agregarPbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agregarPbtn.Name = "agregarPbtn";
            this.agregarPbtn.Size = new System.Drawing.Size(100, 28);
            this.agregarPbtn.TabIndex = 8;
            this.agregarPbtn.Text = "Agregar";
            this.agregarPbtn.UseVisualStyleBackColor = true;
            this.agregarPbtn.Click += new System.EventHandler(this.agregarPbtn_Click);
            // 
            // imagenPelBtn
            // 
            this.imagenPelBtn.Location = new System.Drawing.Point(300, 207);
            this.imagenPelBtn.Name = "imagenPelBtn";
            this.imagenPelBtn.Size = new System.Drawing.Size(136, 24);
            this.imagenPelBtn.TabIndex = 9;
            this.imagenPelBtn.Text = "Importar imagen";
            this.imagenPelBtn.UseVisualStyleBackColor = true;
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
            this.RutaImagenTxt.Location = new System.Drawing.Point(107, 207);
            this.RutaImagenTxt.Name = "RutaImagenTxt";
            this.RutaImagenTxt.ReadOnly = true;
            this.RutaImagenTxt.Size = new System.Drawing.Size(161, 22);
            this.RutaImagenTxt.TabIndex = 10;
            // 
            // AgregarPelicualas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 315);
            this.Controls.Add(this.RutaImagenTxt);
            this.Controls.Add(this.imagenPelBtn);
            this.Controls.Add(this.agregarPbtn);
            this.Controls.Add(this.duracionPud);
            this.Controls.Add(this.generoCbx);
            this.Controls.Add(this.DuracionP);
            this.Controls.Add(this.GeneroP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.nombrepTxb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button imagenPelBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox RutaImagenTxt;
    }
}