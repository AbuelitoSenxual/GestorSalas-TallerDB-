namespace GestorSalas.Vistas
{
    partial class MetodoPago
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
            this.MetodoPcbx = new System.Windows.Forms.ComboBox();
            this.MetodoPlbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Montolbl = new System.Windows.Forms.Label();
            this.Pagarbtn = new System.Windows.Forms.Button();
            this.ImportePagarlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MetodoPcbx
            // 
            this.MetodoPcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodoPcbx.FormattingEnabled = true;
            this.MetodoPcbx.Location = new System.Drawing.Point(60, 119);
            this.MetodoPcbx.Name = "MetodoPcbx";
            this.MetodoPcbx.Size = new System.Drawing.Size(121, 21);
            this.MetodoPcbx.TabIndex = 0;
            this.MetodoPcbx.SelectedIndexChanged += new System.EventHandler(this.MetodoPcbx_SelectedIndexChanged);
            // 
            // MetodoPlbl
            // 
            this.MetodoPlbl.AutoSize = true;
            this.MetodoPlbl.Location = new System.Drawing.Point(86, 81);
            this.MetodoPlbl.Name = "MetodoPlbl";
            this.MetodoPlbl.Size = new System.Drawing.Size(71, 13);
            this.MetodoPlbl.TabIndex = 1;
            this.MetodoPlbl.Text = "Metodo Pago";
            this.MetodoPlbl.Click += new System.EventHandler(this.MetodoPlbl_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(60, 177);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Montolbl
            // 
            this.Montolbl.AutoSize = true;
            this.Montolbl.Location = new System.Drawing.Point(93, 158);
            this.Montolbl.Name = "Montolbl";
            this.Montolbl.Size = new System.Drawing.Size(37, 13);
            this.Montolbl.TabIndex = 3;
            this.Montolbl.Text = "Monto";
            // 
            // Pagarbtn
            // 
            this.Pagarbtn.Location = new System.Drawing.Point(70, 234);
            this.Pagarbtn.Name = "Pagarbtn";
            this.Pagarbtn.Size = new System.Drawing.Size(75, 23);
            this.Pagarbtn.TabIndex = 4;
            this.Pagarbtn.Text = "Pagar";
            this.Pagarbtn.UseVisualStyleBackColor = true;
            this.Pagarbtn.Click += new System.EventHandler(this.Pagarbtn_Click);
            // 
            // ImportePagarlbl
            // 
            this.ImportePagarlbl.AutoSize = true;
            this.ImportePagarlbl.Location = new System.Drawing.Point(117, 19);
            this.ImportePagarlbl.Name = "ImportePagarlbl";
            this.ImportePagarlbl.Size = new System.Drawing.Size(81, 13);
            this.ImportePagarlbl.TabIndex = 5;
            this.ImportePagarlbl.Text = "Importe a pagar";
            this.ImportePagarlbl.Click += new System.EventHandler(this.ImportePagarlbl_Click);
            // 
            // MetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 304);
            this.Controls.Add(this.ImportePagarlbl);
            this.Controls.Add(this.Pagarbtn);
            this.Controls.Add(this.Montolbl);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.MetodoPlbl);
            this.Controls.Add(this.MetodoPcbx);
            this.Name = "MetodoPago";
            this.Text = "MetodoPago";
            this.Load += new System.EventHandler(this.MetodoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MetodoPcbx;
        private System.Windows.Forms.Label MetodoPlbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Montolbl;
        private System.Windows.Forms.Button Pagarbtn;
        private System.Windows.Forms.Label ImportePagarlbl;
    }
}