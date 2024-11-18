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
            this.idPelicula = idPelicula;
        }

        private void Form3_Activated(object sender, EventArgs e)
        {

            baseDatosServicios baseDatosServicios = new baseDatosServicios();

            DataTable dt = baseDatosServicios.HorarioPeliocula(idPelicula);
            dgvpelicula.DataSource = dt;
        }

      

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
