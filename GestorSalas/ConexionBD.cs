using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestorSalas
{
    public class ConexionBD
    {
        // Definir los parámetros de conexión
        private string servidor = "papus2.database.windows.net";
        private string usuario = "Flood";
        private string contraseña = "Martin2003";
        private string bdNombre = "GestionCine";

        // Cadena de conexión
        private string connectionString;

        // Constructor para inicializar la cadena de conexión
        public ConexionBD()
        {
            connectionString = $"Server=tcp:{servidor},1433;Initial Catalog={bdNombre};User ID={usuario};Password={contraseña};Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        }

        // Método para obtener la conexión
        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa.");
                return conexion;
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error al conectar a la base de datos");
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return null;
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}
