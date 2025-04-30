using GestorSalas.Modelos;
using GestorSalas.Servicios;
using GestorSalas.Vistas;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GestorSalas
{
    public partial class Peliculas : Form
    {
        private Panel panelPeliculas;  
        private baseDatosServicios baseDatosServicios;
        public Empleado empleado;

        public Peliculas(Empleado empleado)
        {
            
            this.empleado = empleado;
            InitializeComponent();
            InitializeComponent();
            baseDatosServicios = new baseDatosServicios();  // Inicializar la clase baseDatosServicios
            panelPeliculas = new Panel(); 
            panelPeliculas.AutoScroll = true; 
            panelPeliculas.Dock = DockStyle.Fill;  
            this.Controls.Add(panelPeliculas);
           
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }






        //private void btnBuscarFuncion_Click(object sender, EventArgs e)
        //{


        //    FuncionesModelo funcionesModelo = new FuncionesModelo();
        //    GenerarTicketServicio ticketServicio = new GenerarTicketServicio();


        //    // Verifica si hay alguna fila seleccionada
        //    if (peliculasDgv.CurrentRow != null)
        //    {
        //        // Obtiene la fila seleccionada
        //        DataGridViewRow filaSeleccionada = peliculasDgv.CurrentRow;

        //        // Suponiendo que la columna de ID se llama "ID_Pelicula"
        //        string idPelicula = filaSeleccionada.Cells["ID_Pelicula"].Value.ToString();
        //        Console.WriteLine($"ID de la película seleccionada: {idPelicula}");

        //        funcionesModelo.pelicula = filaSeleccionada.Cells["Nombre"].Value.ToString();


        //        ticketServicio.funciones = funcionesModelo;
        //        // Crea una instancia del siguiente formulario y pasa el ID
        //        Funciones funciones = new Funciones(idPelicula, ticketServicio);


                
        //        this.Hide();
        //        funciones.Owner = this;
        //        funciones.ShowDialog();
        //        this.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, selecciona una película.");
        //    }
        //}


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

            DataTable dt = baseDatosServicios.peliculasInformacion();

            // Limpieza de PictureBox
            panelPeliculas.Controls.Clear();

            // Configuración para el desplazamiento y disposición
            int yOffset = 10;  // Espacio vertical inicial
            int xOffset = 10;  // Espacio horizontal inicial
            int espacioHorizontal = 10; // Espacio entre columnas
            int espacioVertical = 10; // Espacio entre filas
            int contadorColumnas = 0; // Contador para columnas
            int maxColumnas = 3; // Máximo número de columnas por fila

            // Iteraciones para agregar películas
            foreach (DataRow row in dt.Rows)
            {
                string nombrePelicula = row["Nombre"].ToString();
                string idPelicula = row["ID_Pelicula"].ToString();
                string imagePath = Path.Combine(Application.StartupPath, "Assets", nombrePelicula + ".jpg");

                if (File.Exists(imagePath))
                {
                    // Crear un nuevo PictureBox para cada película
                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 150,
                        Height = 200,
                        Left = xOffset,
                        Top = yOffset,
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.StretchImage // Ajuste de imagen
                    };

                    pictureBox.Tag = new { ID_Pelicula = idPelicula, Nombre = nombrePelicula };
                    pictureBox.Click += new EventHandler(PictureBox_Click);

                    // Agregar el PictureBox al panel
                    panelPeliculas.Controls.Add(pictureBox);

                    // Actualizar posición horizontal para la siguiente imagen
                    xOffset += pictureBox.Width + espacioHorizontal;
                    contadorColumnas++;

                    // Si alcanza el número máximo de columnas, reinicia horizontal y avanza a la siguiente fila
                    if (contadorColumnas >= maxColumnas)
                    {
                        contadorColumnas = 0;
                        xOffset = 10; // Reiniciar posición horizontal
                        yOffset += pictureBox.Height + espacioVertical; // Avanzar en posición vertical
                    }
                }
                else
                {
                    Console.WriteLine($"Imagen no encontrada para la película: {nombrePelicula}");
                }
            }


        }
        private void PictureBox_Click(object sender, EventArgs e)
        {



            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null)
            {
          
                dynamic peliculaData = pictureBox.Tag;
                string idPelicula = peliculaData.ID_Pelicula;
                string nombrePelicula = peliculaData.Nombre;

             
                FuncionesModelo funcionesModelo = new FuncionesModelo();






                
                Funciones funciones = new Funciones(idPelicula,empleado, baseDatosServicios.GenerarVenta(empleado));

              
                this.Hide();
                funciones.Owner = this;
                funciones.ShowDialog();
                this.Show();
            }
        }

        private void Peliculas_Load_1(object sender, EventArgs e)
        {

        }

        private void ComprarDulcesbtn_Click(object sender, EventArgs e)
        {
            VentaDulces ventaDulces = new VentaDulces(baseDatosServicios.GenerarVenta(empleado));
            this.Hide();
            ventaDulces.Owner = this;
            ventaDulces.ShowDialog();
            this.Show();

        }
    }
}
    


