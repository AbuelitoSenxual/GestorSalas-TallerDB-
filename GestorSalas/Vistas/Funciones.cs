using GestorSalas.Servicios;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Funciones : Form
    {
        private string idPelicula;

        public Funciones(string idPelicula)
        {
            InitializeComponent();
            this.idPelicula = idPelicula;
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

                // Crea una instancia del siguiente formulario y pasa el ID
                btnContinuar funciones = new btnContinuar(ID_Funcion);

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
    }
}
