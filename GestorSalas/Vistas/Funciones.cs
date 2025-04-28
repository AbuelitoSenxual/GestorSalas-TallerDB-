using GestorSalas.Modelos;
using GestorSalas.Servicios;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Funciones : Form
    {
        public string idPelicula;
        public Empleado Empleado;
        public Venta Venta;
        public FuncionesModelo FuncionesModelo = new FuncionesModelo();
        

        public Funciones(string idPelicula, Empleado Empleado, Venta Venta)
        {
            InitializeComponent();
            this.idPelicula = idPelicula;
            this.Empleado = Empleado;
            this.Venta = Venta;
        }

        private void Form3_Activated(object sender, EventArgs e)
        {

            baseDatosServicios baseDatosServicios = new baseDatosServicios();

            DataTable dt = baseDatosServicios.ObtenerTodaInformacionFunciones(idPelicula);
            dgvpelicula.DataSource = dt;



            dgvpelicula.Columns["ID_Funcion"].Visible = false;
            dgvpelicula.Columns["ID_Sala"].Visible = false;
            dgvpelicula.Columns["HoraFin"].Visible = false;
            dgvpelicula.Columns["ID_Pelicula"].Visible = false;


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

                //Rellenamos el objeto FuncionesModelo
                FuncionesModelo.ID_Funcion = Convert.ToInt32(filaSeleccionada.Cells["ID_Funcion"].Value);
                FuncionesModelo.ID_Pelicula = filaSeleccionada.Cells["ID_Pelicula"].Value.ToString();
                FuncionesModelo.ID_Sala = Convert.ToInt32(filaSeleccionada.Cells["ID_Sala"].Value);
                FuncionesModelo.HoraInicio = (TimeSpan)filaSeleccionada.Cells["HoraInicio"].Value;
                FuncionesModelo.HoraFin = (TimeSpan)filaSeleccionada.Cells["HoraFin"].Value;

                FuncionesModelo.costo = Convert.ToInt32(filaSeleccionada.Cells["Costo"].Value);



                // Crea una instancia del siguiente formulario y pasa los objetos
                frmAsientos frmAsientos = new frmAsientos(Empleado, FuncionesModelo, Venta);


                this.Hide();
                frmAsientos.Owner = this;
                frmAsientos.ShowDialog();
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
