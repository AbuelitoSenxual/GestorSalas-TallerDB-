using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorSalas.Vistas
{
    public partial class MontoCambio : Form

        
    {
        public int costosTicket;
        public int MontoObtorgado;
        public int Cambio;
        public MontoCambio(int costosTicket)
        {
            this.costosTicket = costosTicket;
            InitializeComponent();

            MetodoPagoCbx.Items.Add("Terminal");
            MetodoPagoCbx.Items.Add("Efectivo");
     


        }

        private void MontoCambio_Load(object sender, EventArgs e)
        {

        }

        private void GenerarCambioBtn_Click(object sender, EventArgs e)
        {

            if (int.TryParse(cantidadPagadaTXT.Text, out MontoObtorgado))
            {
                if (MontoObtorgado < costosTicket)
                {
                    MessageBox.Show("El monto no cubre el cosoto total de la compra :" + costosTicket);

                }
                else
                {
                    if (MontoObtorgado == 0 || MetodoPagoCbx.SelectedIndex == -1)
                    {
                        MessageBox.Show("Porfavor rellene todos los campos");
                    }
                    else
                    {
                        Cambio = MontoObtorgado - costosTicket;
                        MessageBox.Show("Su cambio es " + Cambio);
                        this.Close();

                    }
                }
            }
            else {
                MessageBox.Show("Parametro no valido");
            }



            
            
        }
    }
}
