using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas.Vistas
{
    public partial class CambioReeicivod : Form
    {
        public int CantidadCobrar;
        public int MontoRecivido;
        public string metodoPago;
        
        public CambioReeicivod(int CantidadCobrar)
        {
            this.CantidadCobrar = CantidadCobrar;
            InitializeComponent();
            TpagoCbox.Items.Add("Efectivo");
            TpagoCbox.Items.Add("Terminal");


        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(montotxt.Text, out MontoRecivido))
            {
                if (TpagoCbox.SelectedIndex != -1 || montotxt.Text != "") {
                    if (MontoRecivido >= CantidadCobrar) {

                        metodoPago = TpagoCbox.Text;
                        MessageBox.Show("Su cambio es " + (MontoRecivido-CantidadCobrar));

                    }
                    else {
                        MessageBox.Show("El Monto no curo la compra "+ CantidadCobrar);

                    }

                }
                else
                {
                    MessageBox.Show("Rellene todos los parametros");

                }
            }
            else {
                MessageBox.Show("Introdusca un parametro validdo");
            
            }
        }
    }
}
