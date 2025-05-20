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
    public partial class MetodoPago : Form
    {
        public int ImporteCompra;
        public bool MetodoPagos; // true = efectivo, false = tarjeta
        public int MontoIngresado { get; private set; }
        public int Cambio { get; private set; }


        public MetodoPago(int importeCompra)
        {
            InitializeComponent();
            this.ImporteCompra = importeCompra;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MetodoPago_Load(object sender, EventArgs e)
        {
            // Agrega métodos de pago al ComboBox
            MetodoPcbx.Items.Add("Efectivo");
            MetodoPcbx.Items.Add("Tarjeta");
            ImportePagarlbl.Text = $"Importe a pagar: ${ImporteCompra}";
            

            // Configura el NumericUpDown para solo aceptar enteros
            numericUpDown1.DecimalPlaces = 0; // Solo enteros
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100000; // Máximo aceptado en pagos
        }

        private void Pagarbtn_Click(object sender, EventArgs e)
        {
            // Validar que se seleccionó un método de pago
            if (MetodoPcbx.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int montoIngresado = (int)numericUpDown1.Value;

            // Validar que el monto cubre el importe total
            if (montoIngresado < ImporteCompra)
            {
                MessageBox.Show("El monto ingresado no cubre el importe total de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string metodoSeleccionado = MetodoPcbx.SelectedItem.ToString();

            // Guardar el método de pago
            if (metodoSeleccionado == "Efectivo")
            {
                MetodoPagos = true;

                int cambio = montoIngresado - ImporteCompra;
                MessageBox.Show($"Pago en efectivo realizado correctamente.\nCambio: ${cambio}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (metodoSeleccionado == "Tarjeta")
            {
                MetodoPagos = false;
                MessageBox.Show("Pago con tarjeta realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MontoIngresado = montoIngresado;

            if (MetodoPagos) // Efectivo
            {
                Cambio = montoIngresado - ImporteCompra;
            }
            else
            {
                Cambio = 0;
            }


            // Cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MetodoPcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí podrías ajustar comportamiento si cambia el método de pago
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío o agregar validaciones dinámicas si quieres
        }

        private void ImportePagarlbl_Click(object sender, EventArgs e)
        {

        }

        private void MetodoPlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
