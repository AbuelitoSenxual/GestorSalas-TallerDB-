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
    public partial class Cambio : Form
    {

        public int Compra;
        public int MotoOtorgado;
        public int cambio;
        public string tipoPago;
        public Cambio(int Compra)
        {
            InitializeComponent();
            TipoPagoCb.Items.Add("Efectico");
            TipoPagoCb.Items.Add("Terminal");
            this.Compra = Compra;
        }

        private void CambioBtn_Click(object sender, EventArgs e)
        {
            if (TipoPagoCb.SelectedIndex == -1 || Pagotxt.Text == "")
            {
                MessageBox.Show("Rellene todos lo parametros");

            }
            else {
                if (int.TryParse(Pagotxt.Text, out MotoOtorgado)){ 
                    tipoPago = TipoPagoCb.SelectedItem.ToString();
                    if (MotoOtorgado < Compra)
                    {
                        MessageBox.Show("El monto no cubre la compra");
                    }
                    else {
                        cambio = MotoOtorgado-Compra;
                        MessageBox.Show("su cambio es: "+cambio);
                        this.Close();
                    }
                
                }
                else
                {
                    MessageBox.Show("Parametro no valido");
                    Pagotxt.Text = "";
                }
            
            
            
            }


        }

        private void Cambio_Load(object sender, EventArgs e)
        {

        }
    }
}
