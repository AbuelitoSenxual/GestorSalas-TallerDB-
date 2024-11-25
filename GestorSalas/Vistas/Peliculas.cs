using GestorSalas.Modelos;
using GestorSalas.Servicios;
using GestorSalas.Vistas;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Peliculas : Form
    {
        public Empleado empleado;
        public Peliculas(Empleado empleado)
        {
            this.empleado = empleado;
            InitializeComponent();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }






        private void btnBuscarFuncion_Click(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (peliculasDgv.CurrentRow != null)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = peliculasDgv.CurrentRow;

                // Suponiendo que la columna de ID se llama "ID_Pelicula"
                string idPelicula = filaSeleccionada.Cells["ID_Pelicula"].Value.ToString();
                Console.WriteLine($"ID de la película seleccionada: {idPelicula}");

                // Crea una instancia del siguiente formulario y pasa el ID
                Funciones funciones = new Funciones(idPelicula);

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


        private void Peliculas_Load(object sender, EventArgs e)
        {

        }

        private void gestionarBaseBtn_Click(object sender, EventArgs e)
        {
            if (!empleado.puesto.Equals("Gerente"))
            {
                MessageBox.Show("Solo para administradores");
            }
            else
            {

                GestionarBase gestionarBase = new GestionarBase();
                this.Hide();
                gestionarBase.Owner = this;
                gestionarBase.ShowDialog();
                this.Show();


            }
        }

        private void Peliculas_Activated(object sender, EventArgs e)
        {
   

        }


        private void peliculasDgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) // Asegurarte de que no estás seleccionando el encabezado
            //{
            //    DataGridViewRow filaSeleccionada = peliculasDgv.Rows[e.RowIndex];

            //    // Suponiendo que la columna de ID es la primera

            //    string idPelicula = filaSeleccionada.Cells["ID_Pelicula"].Value.ToString();
            //    Console.WriteLine(idPelicula);

            //    // Por ejemplo, pasar los datos al siguiente formulario
            //    Form3 funciones = new Form3(idPelicula);
            //    // Constructor modificado en Form3
            //    this.Hide();
            //    funciones.Owner = this;
            //    funciones.ShowDialog();
            //    this.Show();



        }

        private void Peliculas_Activated_1(object sender, EventArgs e)
        {
            baseDatosServicios baseDatosServicios = new baseDatosServicios();
            DataTable dt = baseDatosServicios.peliculasInformacion();
            peliculasDgv.DataSource = dt;



            peliculasDgv.Columns["ID_Pelicula"].Visible = false;
        }
    }
}
    


