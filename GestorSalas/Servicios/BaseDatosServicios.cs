using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSalas.Servicios
{
    internal class baseDatosServicios
    {
        private  string usuario = "sa";
        private  string contraseña = "1234";
        private string cadenaConexion;
        private SqlConnection conexion;
        public baseDatosServicios() {
            conexion = new SqlConnection(cadenaConexion);
            cadenaConexion = $"Server=localhost; Database=GestorSalas; User Id={usuario}; Password={contraseña};"; 
        }

       public  bool probarConexion()
        {
            
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa.");
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;  
            }
        }

        public static bool verificarUsuario(string usuario,string contraseña) {
            
        }
    }
}
