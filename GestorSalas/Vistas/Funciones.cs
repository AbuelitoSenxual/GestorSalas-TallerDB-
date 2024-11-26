using GestorSalas.Servicios;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Funciones : Form
    {
        public string idPelicula;
        public GenerarTicketServicio GenerarTicketServicio;

        public Funciones(string idPelicula, GenerarTicketServicio generarTicketServicio)
        {
            InitializeComponent();
            this.idPelicula = idPelicula;
            GenerarTicketServicio = generarTicketServicio;
        }

        private void Form3_Activated(object sender, EventArgs e)
        {

            baseDatosServicios baseDatosServicios = new baseDatosServicios();

            DataTable dt = baseDatosServicios.HorarioPeliocula(idPelicula);
            dgvpelicula.DataSource = dt;



            dgvpelicula.Columns["ID_Funcion"].Visible = false;
        }

      

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarAsiento_Click(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvpelicula.CurrentRow != null)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvpelicula.CurrentRow;

                // Suponiendo que la columna de ID se llama "ID_Pelicula"
                string ID_Funcion = filaSeleccionada.Cells["ID_Funcion"].Value.ToString();
                Console.WriteLine($"ID de la funcion seleccionada: {ID_Funcion}");

                GenerarTicketServicio.funciones.Hora = filaSeleccionada.Cells["Hora"].Value.ToString();




                // Crea una instancia del siguiente formulario y pasa el ID
                btnContinuar funciones = new btnContinuar(ID_Funcion, GenerarTicketServicio);


                this.Hide();
                funciones.Owner = this;
                funciones.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película.");
            }
        }

        private void dgvpelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
