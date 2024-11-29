using GestorSalas.Servicios;
using GestorSalas.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class AsientosDesign : Form
    {
        private List<Button> botonesSeleccionados = new List<Button>();
        private string idfuncion;
        public GenerarTicketServicio GenerarTicketServicio;
        public static int AcomuladoEnCaja;
        public AsientosDesign(string idfuncion, GenerarTicketServicio generarTicketServicio)
        {
            this.idfuncion = idfuncion;
            GenerarTicketServicio = generarTicketServicio;
            InitializeComponent();

            var asientosOcupados = ConsultarAsientosOcupados(idfuncion);
            MarcarAsientosOcupados(asientosOcupados);

            // Asignar eventos a los botones que representan los asientos
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Text != null) // Los botones deben tener un Tag asignado
                {
                    btn.Click += Boton_Click;
                    btn.BackColor = Color.LightGray; // Asegurarse de que el color inicial sea consistente
                }
            }
        }

        private List<string> ConsultarAsientosOcupados(string idFuncion)
        {
            baseDatosServicios servicioBD = new baseDatosServicios();
            List<string> asientosOcupados = new List<string>();

            try
            {
                DataTable dt = servicioBD.AsientosSeleccionados(idFuncion);

                foreach (DataRow row in dt.Rows)
                {
                    asientosOcupados.Add(row["Numero"].ToString()); // Usar la columna correcta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar asientos ocupados: {ex.Message}");
            }

            return asientosOcupados;
        }



        public List<string> ObtenerNombresBotonesSeleccionados()
        {
            // Devolver los nombres de los botones seleccionados
            return botonesSeleccionados.Select(btn => btn.Name).ToList();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Verificar si el botón ya está seleccionado
                if (botonesSeleccionados.Contains(btn))
                {
                    // Desmarcar el botón (quitar selección)
                    botonesSeleccionados.Remove(btn);
                    btn.BackColor = Color.LightGray;  // Color original (no seleccionado)
                }
                else
                {
                    // Marcar el botón (seleccionado)
                    botonesSeleccionados.Add(btn);
                    btn.BackColor = Color.Green;  // Color cuando está seleccionado
                }
            }
        }


        private void Asientos_Load(object sender, EventArgs e)
        {
            var asientosOcupados = ConsultarAsientosOcupados(idfuncion);
            MarcarAsientosOcupados(asientosOcupados);

        }
        public void MarcarAsientosOcupados(List<string> nombresAsientosOcupados)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && nombresAsientosOcupados.Contains(btn.Name))
                {
                    btn.BackColor = Color.Red;  // Color que indica que el asiento está ocupado
                    btn.Enabled = false;        // Deshabilitar el botón para evitar selección
                }
            }
        }





        private void btnBuscarAsiento_Click(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();

            DialogResult resultado = MessageBox.Show(
                "¿Deseas continuar? Monto de la compra: " + (ObtenerNombresBotonesSeleccionados().Count * 80) + "$",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            GenerarTicketServicio.asientos = ObtenerNombresBotonesSeleccionados();

            if (resultado == DialogResult.Yes)
            {
                // Actualizar el estado de los asientos seleccionados
                baseDatosServicios.ActualizarEstadoAsientos(ObtenerNombresBotonesSeleccionados(), idfuncion);


                baseDatosServicios.ActualizarEstadoAsientos(ObtenerNombresBotonesSeleccionados(), idfuncion);  

                // Llamar al método para marcar los asientos como ocupados
                List<string> asientosOcupados = ConsultarAsientosOcupados(idfuncion);
                MarcarAsientosOcupados(asientosOcupados);

                // Continuar con el flujo de la aplicación
                Cambio cambio = new Cambio(ObtenerNombresBotonesSeleccionados().Count * 80);
                cambio.ShowDialog();
                AcomuladoEnCaja += ObtenerNombresBotonesSeleccionados().Count * 80;
                MessageBox.Show(GenerarTicketServicio.ImprimirTickets(cambio.tipoPago, cambio.MotoOtorgado), "Continuar");
                this.Close();
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("¡Has declinado la acción!", "Declinar");
                this.Close();
            }
        }


    }
}
