namespace GestorSalas.Vistas
{
    partial class Cambio
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
            this.CambioBtn = new System.Windows.Forms.Button();
            this.TipoPagoCb = new System.Windows.Forms.ComboBox();
            this.TipoPago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pagotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CambioBtn
            // 
            this.CambioBtn.Location = new System.Drawing.Point(101, 284);
            this.CambioBtn.Name = "CambioBtn";
            this.CambioBtn.Size = new System.Drawing.Size(75, 23);
            this.CambioBtn.TabIndex = 0;
            this.CambioBtn.Text = "Cobrar";
            this.CambioBtn.UseVisualStyleBackColor = true;
            this.CambioBtn.Click += new System.EventHandler(this.CambioBtn_Click);
            // 
            // TipoPagoCb
            // 
            this.TipoPagoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPagoCb.FormattingEnabled = true;
            this.TipoPagoCb.Location = new System.Drawing.Point(73, 129);
            this.TipoPagoCb.Name = "TipoPagoCb";
            this.TipoPagoCb.Size = new System.Drawing.Size(121, 21);
            this.TipoPagoCb.TabIndex = 1;
            // 
            // TipoPago
            // 
            this.TipoPago.AutoSize = true;
            this.TipoPago.Location = new System.Drawing.Point(115, 92);
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Size = new System.Drawing.Size(53, 13);
            this.TipoPago.TabIndex = 2;
            this.TipoPago.Text = "TipoPago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pago";
            // 
            // Pagotxt
            // 
            this.Pagotxt.Location = new System.Drawing.Point(73, 220);
            this.Pagotxt.Name = "Pagotxt";
            this.Pagotxt.Size = new System.Drawing.Size(121, 20);
            this.Pagotxt.TabIndex = 4;
            // 
            // Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 337);
            this.Controls.Add(this.Pagotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoPago);
            this.Controls.Add(this.TipoPagoCb);
            this.Controls.Add(this.CambioBtn);
            this.Name = "Cambio";
            this.Text = "Cambio";
            this.Load += new System.EventHandler(this.Cambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CambioBtn;
        private System.Windows.Forms.ComboBox TipoPagoCb;
        private System.Windows.Forms.Label TipoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pagotxt;
    }
}