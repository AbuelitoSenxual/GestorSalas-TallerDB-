namespace GestorSalas.Vistas
{
    partial class Cambio
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
            this.CambioBtn = new System.Windows.Forms.Button();
            this.TipoPagoCb = new System.Windows.Forms.ComboBox();
            this.TipoPago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pagotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CambioBtn
            // 
            this.CambioBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.CambioBtn.FlatAppearance.BorderSize = 0;
            this.CambioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambioBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CambioBtn.ForeColor = System.Drawing.Color.White;
            this.CambioBtn.Location = new System.Drawing.Point(80, 219);
            this.CambioBtn.Name = "CambioBtn";
            this.CambioBtn.Size = new System.Drawing.Size(100, 40);
            this.CambioBtn.TabIndex = 0;
            this.CambioBtn.Text = "Cobrar";
            this.CambioBtn.UseVisualStyleBackColor = false;
            this.CambioBtn.Click += new System.EventHandler(this.CambioBtn_Click);
            // 
            // TipoPagoCb
            // 
            this.TipoPagoCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TipoPagoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPagoCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoPagoCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TipoPagoCb.ForeColor = System.Drawing.Color.White;
            this.TipoPagoCb.Location = new System.Drawing.Point(55, 74);
            this.TipoPagoCb.Name = "TipoPagoCb";
            this.TipoPagoCb.Size = new System.Drawing.Size(150, 25);
            this.TipoPagoCb.TabIndex = 1;
            // 
            // TipoPago
            // 
            this.TipoPago.AutoSize = true;
            this.TipoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TipoPago.ForeColor = System.Drawing.Color.White;
            this.TipoPago.Location = new System.Drawing.Point(91, 44);
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Size = new System.Drawing.Size(78, 19);
            this.TipoPago.TabIndex = 2;
            this.TipoPago.Text = "Tipo Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pago";
            // 
            // Pagotxt
            // 
            this.Pagotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Pagotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pagotxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Pagotxt.ForeColor = System.Drawing.Color.White;
            this.Pagotxt.Location = new System.Drawing.Point(55, 159);
            this.Pagotxt.Name = "Pagotxt";
            this.Pagotxt.Size = new System.Drawing.Size(150, 25);
            this.Pagotxt.TabIndex = 4;
            // 
            // Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(248, 296);
            this.Controls.Add(this.Pagotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoPago);
            this.Controls.Add(this.TipoPagoCb);
            this.Controls.Add(this.CambioBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
