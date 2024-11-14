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
        private string cadenaConexion;
        private SqlConnection conexion;
        public baseDatosServicios()
        {
            cadenaConexion = $"Server=DESKTOP-IPBG7ER\\SQLEXPRESS; Database=GestorSalas; User Id={usuario}; Password={contraseña};";
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
