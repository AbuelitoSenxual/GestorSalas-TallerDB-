using GestorSalas.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas.Servicios
{
    internal class baseDatosServicios
    {
        private string usuario = "sa";
        private string contraseña = "1234";
        private string server = "DESKTOP-L5UGVKJ\\SQLEXPRESS";
        private string cadenaConexion;
        private SqlConnection conexion;
        public baseDatosServicios()
        {
            //4:30
            cadenaConexion = $"Server=DESKTOP-L5UGVKJ\\SQLEXPRESS; Database=GestorSalas; User Id={usuario}; Password={contraseña};";
            //cadenaConexion = $"Server={server}; Database=GestorSalas; User Id={usuario}; Password={contraseña};";
            //usa esta y cambia la contrasena y usuario
            //cadenaConexion = $"Server=localhost; Database=GestorSalas; User Id={usuario}; Password={contraseña}; TrustServerCertificate=True;"; 



        }

        public bool probarConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa.");
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }

        public bool verificarUsuario(string usuario, string contraseña)
        {
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                string consulta = $"SELECT CASE WHEN EXISTS (SELECT 1 FROM Empleados WHERE Usuario = '{usuario}' AND Contraseña = '{contraseña}') THEN 1 ELSE 0 END";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                try
                {

                    conexion.Open();

                    int resultado = (int)comando.ExecuteScalar();

                    return resultado == 1;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        public Empleado inicializarEmpleado(string usuario, string contraseña)
        {
            Empleado empleado = new Empleado();
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                conexion.Open();
                string querry = $"select ID_Empleado,Nombre,Puesto,Usuario,Contraseña from Empleados where Usuario='{usuario}' AND Contraseña = '{contraseña}'";
                using (SqlCommand comando = new SqlCommand(querry, conexion)) {
                    using (SqlDataReader lector = comando.ExecuteReader()) {
                        if (lector.Read())
                        {
                            empleado.id_Empleado = lector.GetInt32(0);
                            empleado.nombre = lector.GetString(1);
                            empleado.puesto = lector.GetString(2);
                            empleado.usuario = lector.GetString(3);
                            empleado.contraseña = lector.GetString(4);


                        }
                    }
                }
                return empleado;
            }

        }

        public DataTable peliculasInformacion() {

            DataTable dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);
            string querry = "SELECT * FROM Peliculas;";
            using (conexion)
            {
                try
                {
                    // Crear un adaptador SQL
                    SqlDataAdapter da = new SqlDataAdapter(querry, conexion);

                    // Llenar el DataTable con los datos de la base de datos
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // En caso de error, mostrar el mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



            
            return dt;
        }
        public DataTable HorarioPeliocula(string id )
        {

            DataTable dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);

            string querry = $"select ID_Funcion,Nombre,Fecha,Hora from funciones,Peliculas where Peliculas.ID_Pelicula={id} and  funciones.ID_Pelicula ={id};";
            using (conexion)
            {
                try
                {
                    // Crear un adaptador SQL
                    SqlDataAdapter da = new SqlDataAdapter(querry, conexion);

                    // Llenar el DataTable con los datos de la base de datos
                    da.Fill(dt);

                    
                }
                catch (Exception ex)
                {
                    // En caso de error, mostrar el mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




            return dt;
        }
        public DataTable empleadoInformacion()
        {

            DataTable dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);
            string querry = "SELECT * FROM Empleados;";
            using (conexion)
            {
                try
                {
                    // Crear un adaptador SQL
                    SqlDataAdapter da = new SqlDataAdapter(querry, conexion);

                    // Llenar el DataTable con los datos de la base de datos
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // En caso de error, mostrar el mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            return dt;
        }

        public void eliminarEmpleado(int idEmpleado)
        {
            conexion = new SqlConnection(cadenaConexion);
            string query = $"DELETE FROM [GestorSalas].[dbo].[Empleados] WHERE ID_Empleado = {idEmpleado}";

            using (conexion)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                }
            }
        }

        public void eliminarPelicula(string Idpelicula)
        {
            conexion = new SqlConnection(cadenaConexion);

            string query = "DELETE FROM Peliculas WHERE ID_Pelicula = @IdPelicula";

            using (conexion)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Añadir el parámetro a la consulta
                    cmd.Parameters.AddWithValue("@IdPelicula", Idpelicula);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Película eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Película: " + ex.Message);
                }
            }
        }


        public void InsertarEmpleado(Empleado empleado)
        {
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO [GestorSalas].[dbo].[Empleados] " +
                                   "([Nombre], [Puesto], [Usuario], [Contraseña]) " +
                                   "VALUES (@Nombre, @Puesto, @Usuario, @Contraseña)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Parametrizar la consulta para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nombre", empleado.nombre);
                        cmd.Parameters.AddWithValue("@Puesto", empleado.puesto);
                        cmd.Parameters.AddWithValue("@Usuario", empleado.usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", empleado.contraseña);

                        // Ejecutar la inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Empleado insertado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el empleado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el empleado: " + ex.Message);
                }
            }
        }


        public void ActualizarEmpleado(Empleado empleado)
        {
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE [GestorSalas].[dbo].[Empleados] SET " +
                                   "[Nombre] = @Nombre, " +
                                   "[Puesto] = @Puesto, " +
                                   "[Usuario] = @Usuario, " +
                                   "[Contraseña] = @Contraseña " +
                                   "WHERE [ID_Empleado] = @ID_Empleado";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Parametrizar la consulta para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nombre", empleado.nombre);
                        cmd.Parameters.AddWithValue("@Puesto", empleado.puesto);
                        cmd.Parameters.AddWithValue("@Usuario", empleado.usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", empleado.contraseña);
                        cmd.Parameters.AddWithValue("@ID_Empleado", empleado.id_Empleado);

                        // Ejecutar la actualización
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Empleado actualizado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el empleado con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                }
            }
        }
        public void ActualizarPelicula(Pelicula pelicula)
        {
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE [GestorSalas].[dbo].[Peliculas] SET " +
                    "[Nombre] = @Nombre, " +
                    "[Duracion] = @Duracion, " +
                    "[Genero] = @Genero " +
                    "WHERE [ID_Pelicula] = @ID_Pelicula";

                  

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Parametrizar la consulta para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nombre", pelicula.nombre);
                        cmd.Parameters.AddWithValue("@Duracion", pelicula.Duracion);
                        cmd.Parameters.AddWithValue("@Genero", pelicula.Genero);
                    
                        // Ejecutar la actualización
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        Console.WriteLine(query);
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Empleado actualizado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el empleado con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                }
            }
        }

        public void InsertarEmpleado(string nombre, string puesto, string usuario, string contraseña)
        {
            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Consulta de inserción
                    string query = "INSERT INTO [GestorSalas].[dbo].[Empleados] " +
                                   "([Nombre], [Puesto], [Usuario], [Contraseña]) " +
                                   "VALUES (@Nombre, @Puesto, @Usuario, @Contraseña)";

                    // Crear el comando SQL con la consulta y la conexión
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        // Parametrizar la consulta para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Puesto", puesto);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        // Ejecutar la inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si la inserción fue exitosa
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Empleado insertado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Error al insertar el empleado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al insertar el empleado: " + ex.Message);
                }
            }
        }



        public bool agregarPelicula(string nombre,string genero,int duracion) {
            string querry = $"INSERT INTO Peliculas (Nombre, Duracion, Genero) VALUES ('{nombre}', {duracion}, '{genero}');";
            conexion = new SqlConnection(cadenaConexion);
            using (conexion) {

                try
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(querry, conexion))
                    {

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Filas insertadas: {rowsAffected}");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }

            }
        
        }
    }
}
