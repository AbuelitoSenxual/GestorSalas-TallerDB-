namespace GestorSalas.Vistas
{
    partial class CambioReeicivod
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
            this.label1 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.Label();
            this.montotxt = new System.Windows.Forms.TextBox();
            this.pagarBtn = new System.Windows.Forms.Button();
            this.TpagoCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TipoPago";
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(59, 130);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(44, 16);
            this.Monto.TabIndex = 1;
            this.Monto.Text = "Monto";
            // 
            // montotxt
            // 
            this.montotxt.Location = new System.Drawing.Point(32, 161);
            this.montotxt.Name = "montotxt";
            this.montotxt.Size = new System.Drawing.Size(121, 22);
            this.montotxt.TabIndex = 3;
            // 
            // pagarBtn
            // 
            this.pagarBtn.Location = new System.Drawing.Point(47, 229);
            this.pagarBtn.Name = "pagarBtn";
            this.pagarBtn.Size = new System.Drawing.Size(75, 23);
            this.pagarBtn.TabIndex = 4;
            this.pagarBtn.Text = "Pagar";
            this.pagarBtn.UseVisualStyleBackColor = true;
            this.pagarBtn.Click += new System.EventHandler(this.pagarBtn_Click);
            // 
            // TpagoCbox
            // 
            this.TpagoCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TpagoCbox.FormattingEnabled = true;
            this.TpagoCbox.Location = new System.Drawing.Point(32, 81);
            this.TpagoCbox.Name = "TpagoCbox";
            this.TpagoCbox.Size = new System.Drawing.Size(121, 24);
            this.TpagoCbox.TabIndex = 5;
            // 
            // CambioReeicivod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 365);
            this.Controls.Add(this.TpagoCbox);
            this.Controls.Add(this.pagarBtn);
            this.Controls.Add(this.montotxt);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label1);
            this.Name = "CambioReeicivod";
            this.Text = "CambioReeicivod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Monto;
        private System.Windows.Forms.TextBox montotxt;
        private System.Windows.Forms.Button pagarBtn;
        private System.Windows.Forms.ComboBox TpagoCbox;
    }
}