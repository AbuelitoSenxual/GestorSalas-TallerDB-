﻿using GestorSalas.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
        private string server = "DESKTOP-IPBG7ER\\SQLEXPRESS";
        private string BasedeDatos = "GestorSalas";
        private string cadenaConexion;
        private SqlConnection conexion;
        public baseDatosServicios()
        {
            //4:30
            //cadenaConexion = $"Server=DESKTOP-L5UGVKJ\\SQLEXPRESS; Database=GestorSalas; User Id={usuario}; Password={contraseña};";
            cadenaConexion = $"Server={server}; Database={BasedeDatos}; User Id={usuario}; Password={contraseña};";
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
                using (SqlCommand comando = new SqlCommand(querry, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
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
        public DataTable ObtenerTodaInformacionFunciones(string ID_Pelicula)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                        f.ID_Funcion, 
                        p.ID_Pelicula,
                        p.Nombre AS NombrePelicula, 
                        f.ID_Sala,
                        f.HoraInicio, 
                        f.HoraFin, 
                        p.Duracion, 
                        f.Costo
                     FROM Funciones f
                     INNER JOIN Peliculas p ON f.ID_Pelicula = p.ID_Pelicula
                     WHERE p.ID_Pelicula = @ID_Pelicula";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ID_Pelicula", ID_Pelicula);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    conexion.Open();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
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
                        cmd.Parameters.AddWithValue("@ID_Pelicula", pelicula.ID_Pelicula);

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



        public bool agregarPelicula(string nombre, int duracion)
        {
            string querry = $"INSERT INTO Peliculas (Nombre, Duracion) VALUES ('{nombre}', {duracion});";
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {

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

        public Venta GenerarVenta(Empleado empleado)
        {
            Venta venta = new Venta();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "INSERT INTO Venta (ID_Empleado, FechaCompra) VALUES (@ID_Empleado, @FechaCompra); SELECT SCOPE_IDENTITY();";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ID_Empleado", empleado.id_Empleado);
                    comando.Parameters.AddWithValue("@FechaCompra", DateTime.Now);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && int.TryParse(resultado.ToString(), out int idVenta))
                    {
                        venta.ID_Venta = idVenta;
                    }
                    else
                    {
                        throw new Exception("No se pudo generar el ID de la venta.");
                    }

                    venta.ID_Empleado = empleado.id_Empleado;
                    venta.FechaCompra = DateTime.Now;
                }
            }

            return venta;
        }




        public List<string> AsientosBloqueados(int IDfuncion)
        {
            List<string> asientos = new List<string>();
            conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                conexion.Open();
                string query = $@"
            SELECT a.Numero
            FROM Asientos a
            INNER JOIN Reservaciones r ON a.id_asiento = r.id_asiento
            WHERE r.id_funcion = {IDfuncion};";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            asientos.Add(reader.GetString(0)); // Agrega el nombre del asiento
                        }
                    }
                }
            }
            return asientos;
        }

        public List<int> ObtenerIdsAsientos(List<string> NumeroAsientos, int idFuncion)
        {
            List<int> idsAsientos = new List<int>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                var parametros = string.Join(", ", NumeroAsientos.Select((_, index) => $"@asiento{index}"));
                string query = $@"
            SELECT a.ID_Asiento
            FROM Asientos a
            INNER JOIN Funciones f ON a.ID_Sala = f.ID_Sala
            WHERE f.ID_Funcion = @idFuncion
            AND a.Numero IN ({parametros});";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idFuncion", idFuncion);

                    for (int i = 0; i < NumeroAsientos.Count; i++)
                    {
                        comando.Parameters.AddWithValue($"@asiento{i}", NumeroAsientos[i]);
                    }

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idsAsientos.Add(reader.GetInt32(0)); // ID_Asiento
                        }
                    }
                }
            }
            return idsAsientos;
        }


        public void InsertarReservaciones(List<Reservacion> listaReservaciones)
        {
            conexion = new SqlConnection(cadenaConexion);

            using (conexion)
            {
                conexion.Open();

                foreach (var reservacion in listaReservaciones)
                {
                    string query = @"
                INSERT INTO Reservaciones (ID_Asiento, ID_Funcion, ID_Empleado, ID_Venta, Fecha_Reservacion)
                VALUES (@idAsiento, @idFuncion, @idEmpleado, @idVenta, @fechaReservacion);";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idAsiento", reservacion.ID_Asiento);
                        comando.Parameters.AddWithValue("@idFuncion", reservacion.ID_Funcion);
                        comando.Parameters.AddWithValue("@idEmpleado", reservacion.ID_Empleado);
                        comando.Parameters.AddWithValue("@idVenta", reservacion.ID_Venta);
                        comando.Parameters.AddWithValue("@fechaReservacion", reservacion.Fecha_Reservacion);

                        comando.ExecuteNonQuery();
                    }
                }
            }
        }

        public string GenerarTicketVenta(int idVenta)
        {
            var VentasPelicula = new List<(string NombrePeli, string NombreSala, string NumeroAsiento, float Costo)>();
            var VentasDulces = new List<(string NombreProducto, int Cantidad, float Costo)>();

            var conexion = new SqlConnection(cadenaConexion);
            using (conexion)
            {
                conexion.Open();

                // Llenar VentasPelicula
                string queryPeliculas = @"
            SELECT p.Nombre AS NombrePeli, s.Nombre AS NombreSala, a.Numero AS NumeroAsiento, f.Costo
            FROM Reservaciones r
            INNER JOIN Funciones f ON r.ID_Funcion = f.ID_Funcion
            INNER JOIN Peliculas p ON f.ID_Pelicula = p.ID_Pelicula
            INNER JOIN Asientos a ON r.ID_Asiento = a.ID_Asiento
            INNER JOIN Salas s ON f.ID_Sala = s.ID_Sala
            WHERE r.ID_Venta = @idVenta";

                using (var comando = new SqlCommand(queryPeliculas, conexion))
                {
                    comando.Parameters.AddWithValue("@idVenta", idVenta);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentasPelicula.Add((
                                reader.GetString(0),         // NombrePeli
                                reader.GetString(1),         // NombreSala
                                reader.GetString(2),         // NumeroAsiento
                                (float)reader.GetDouble(3)   // Costo (convertir a float)
                            ));
                        }
                    }
                }

                // Llenar VentasDulces
                string queryDulces = @"
            SELECT c.Nombre AS NombreProducto, cd.Cantidad, c.Costo
            FROM CompraDulceria cd
            INNER JOIN Consumible c ON cd.ID_Consumible = c.ID_Consumible
            WHERE cd.ID_Venta = @idVenta";

                using (var comando = new SqlCommand(queryDulces, conexion))
                {
                    comando.Parameters.AddWithValue("@idVenta", idVenta);

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentasDulces.Add((
                                reader.GetString(0),  // NombreProducto
                                reader.GetInt32(1),   // Cantidad
                                (float)reader.GetInt32(2) // Costo convertido de int a float
                            ));
                        }

                    }
                }
            }


            foreach (var venta in VentasPelicula)
            {
                Console.WriteLine($"Película: {venta.NombrePeli}, Sala: {venta.NombreSala}, Asiento: {venta.NumeroAsiento}, Costo: {venta.Costo}");
            }

            return ProcesarTicket(VentasPelicula, VentasDulces);
        }

        public string ProcesarTicket(
    List<(string NombrePeli, string NombreSala, string NumeroAsiento, float Costo)> ventasPelicula,
    List<(string NombreProducto, int Cantidad, float Costo)> ventasDulces)
        {
            // Variables para acumular
            float subtotal = 0f;
            float iva = 0f;
            float total = 0f;

            // Armamos el ticket
            var ticket = new System.Text.StringBuilder();

            // Encabezado
            ticket.AppendLine("===================================");
            ticket.AppendLine("             CINE CINEMA           ");
            ticket.AppendLine("         ¡Gracias por tu visita!   ");
            ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            ticket.AppendLine("===================================\n");

            // Sección de Películas
            ticket.AppendLine("Películas:");
            foreach (var venta in ventasPelicula)
            {
                ticket.AppendLine($"- {venta.NombrePeli}");
                ticket.AppendLine($"  Sala: {venta.NombreSala}  Asiento: {venta.NumeroAsiento}");
                ticket.AppendLine($"  Costo: ${venta.Costo:F2}\n");
                subtotal += venta.Costo;
            }

            ticket.AppendLine("-----------------------------------");

            // Sección de Dulcería
            if (ventasDulces.Count > 0)
            {
                ticket.AppendLine("Dulcería:");
                foreach (var dulce in ventasDulces)
                {
                    float costoProducto = dulce.Costo * dulce.Cantidad;
                    ticket.AppendLine($"- {dulce.NombreProducto} x{dulce.Cantidad}");
                    ticket.AppendLine($"  Total: ${costoProducto:F2}\n");
                    subtotal += costoProducto;
                }
            }

            ticket.AppendLine("-----------------------------------");

            // Cálculo de totales
            iva = subtotal * 0.16f;
            total = subtotal + iva;

            ticket.AppendLine($"Subtotal:      ${subtotal:F2}");
            ticket.AppendLine($"IVA (16%):      ${iva:F2}");
            ticket.AppendLine($"Total a pagar:  ${total:F2}");

            // ======= Aquí llamamos al formulario de pago =======
            var formularioPago = new GestorSalas.Vistas.MetodoPago((int)total);
            if (formularioPago.ShowDialog() == DialogResult.OK)
            {
                string metodo = formularioPago.MetodoPagos ? "Efectivo" : "Tarjeta";
                int montoIngresado = formularioPago.MontoIngresado;
                int cambio = formularioPago.Cambio;

                ticket.AppendLine($"Método de pago: {metodo}");
                ticket.AppendLine($"Monto entregado: ${montoIngresado}");
                if (formularioPago.MetodoPagos) // Solo mostrar cambio si es efectivo
                {
                    ticket.AppendLine($"Cambio: ${cambio}");
                }
            }
            else
            {
                ticket.AppendLine("⚠️ Pago cancelado.");
            }

            ticket.AppendLine("\n===================================");
            ticket.AppendLine("     ¡Gracias por su preferencia!  ");
            ticket.AppendLine("           Cine Cinema 🎬🍿         ");
            ticket.AppendLine("===================================");

            return ticket.ToString();
        }



        public List<(string NombreProducto, int Stock, string RutaImagen, decimal Precio)> ObtenerProductosConStock()
        {
            var productos = new List<(string NombreProducto, int Stock, string RutaImagen, decimal Precio)>();
            string query = @"
        SELECT Nombre, Costo, Stock
        FROM Consumible
    ";

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString(0).Trim();
                            decimal precio = (decimal)reader.GetInt32(1);
                            int stock = reader.GetInt32(2);

                            // Buscar imagen con extensiones comunes
                            string nombreBase = Path.Combine("ImagenesProductos", nombre);
                            string[] extensiones = { ".jpg", ".png" };
                            string rutaAbsoluta = null;

                            foreach (var ext in extensiones)
                            {
                                string posibleRuta = Path.Combine(Application.StartupPath, nombreBase + ext);
                                if (File.Exists(posibleRuta))
                                {
                                    rutaAbsoluta = posibleRuta;
                                    break;
                                }
                            }

                            // Si no se encuentra ninguna imagen, dejar la ruta vacía
                            if (rutaAbsoluta == null)
                                rutaAbsoluta = "";

                            productos.Add((nombre, stock, rutaAbsoluta, precio));
                        }
                    }
                }
            }

            return productos;
        }
        public void InsertarProductosComprados(int idVenta, List<(string NombreProducto, int Cantidad)> productosComprados)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                foreach (var producto in productosComprados)
                {
                    string query = @"
                INSERT INTO CompraDulceria (ID_Consumible, ID_Venta, Cantidad)
                VALUES (
                    (SELECT ID_Consumible FROM Consumible WHERE Nombre = @nombreProducto),
                    @idVenta,
                    @cantidad
                );
            ";

                    using (var comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto);
                        comando.Parameters.AddWithValue("@idVenta", idVenta);
                        comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);

                        comando.ExecuteNonQuery();
                    }
                }
            }
        }







    }
}
