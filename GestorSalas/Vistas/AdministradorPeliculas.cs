using GestorSalas.Modelos;
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

namespace GestorSalas.Vistas
{
    public partial class AdministradorPeliculas : Form
    {
        public AdministradorPeliculas()
        {
            InitializeComponent();
        }

        private void gesPeliculaBtn_Click(object sender, EventArgs e)
        {



            AgregarPelicualas agregarPelicualas = new AgregarPelicualas();
            agregarPelicualas.ShowDialog();
        }

        private void AdministradorPeliculas_Activated(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
          

            DataTable dt = baseDatosServicios.peliculasInformacion();
            dgvPelicula.DataSource = dt;

        }

        private void AdministradorPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();

            if (dgvPelicula.SelectedRows.Count > 0)
            {
                // Obtener el valor del "ID_Pelicula" y convertirlo a string
                string IdPelicula = Convert.ToString(dgvPelicula.SelectedRows[0].Cells["ID_Pelicula"].Value);

                // Eliminar la fila del DataGridView
                dgvPelicula.Rows.RemoveAt(dgvPelicula.SelectedRows[0].Index);

                // Eliminar la película de la base de datos
                baseDatosServicios.eliminarPelicula(IdPelicula);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
            if (dgvPelicula.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPelicula.SelectedRows[0];

                Pelicula pelicula = new Pelicula();

                pelicula.ID_Pelicula = selectedRow.Cells["ID_Pelicula"].Value.ToString();

                Console.WriteLine("este el id de la pelicula"+pelicula.ID_Pelicula);
                pelicula.nombre = selectedRow.Cells["Nombre"].Value.ToString();
                pelicula.Duracion = selectedRow.Cells["Duracion"].Value.ToString();
                pelicula.Genero = selectedRow.Cells["Genero"].Value.ToString();

              

                ModificarPelicula modificarPelicula =new ModificarPelicula(pelicula);
                modificarPelicula.ShowDialog();

                baseDatosServicios.ActualizarPelicula(modificarPelicula.Pelicula);
                DataTable dt = baseDatosServicios.peliculasInformacion();
                dgvPelicula.DataSource = dt;



            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }
    }
}
