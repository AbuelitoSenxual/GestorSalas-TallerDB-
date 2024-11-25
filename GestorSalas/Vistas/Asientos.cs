using GestorSalas.Servicios;
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
    public partial class btnContinuar : Form
    {
        private List<Button> botonesSeleccionados = new List<Button>();
        private string idfuncion;
        public GenerarTicketServicio GenerarTicketServicio;
        public btnContinuar(string idfuncion, GenerarTicketServicio generarTicketServicio)
        {

            this.idfuncion = idfuncion;
            GenerarTicketServicio = generarTicketServicio;
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += Boton_Click;
                }
            }
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
                    btn.BackColor = Color.LightGray;  // Color original
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

        }

        private void btnBuscarAsiento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Deseas continuar?", // Mensaje
               "Confirmar acción", // Título
               MessageBoxButtons.YesNo, // Botones disponibles
               MessageBoxIcon.Question); // Icono del MessageBox
            GenerarTicketServicio.asientos = ObtenerNombresBotonesSeleccionados();
            
            
            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(GenerarTicketServicio.ImprimirTickets(), "Continuar");
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
