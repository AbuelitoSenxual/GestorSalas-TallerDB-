using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorSalas.Modelos;

namespace GestorSalas.Servicios
{
    public class GenerarTicketServicio
    {
       public List<string> asientos = new List<string>();
       public int cantidadAbonada;
       public FuncionesModelo funciones = new FuncionesModelo();

        public string ImprimirTickets()
        {
            // Verificar si no hay asientos seleccionados
            if (asientos.Count == 0)
            {
                return "No hay asientos seleccionados para imprimir el ticket.";
            }

            // Crear un StringBuilder para construir la cadena
            StringBuilder ticket = new StringBuilder();

            // Calcular detalles del costo
            decimal precioPorBoleto = 80.00m; // Precio fijo por boleto
            decimal subtotal = precioPorBoleto * asientos.Count;
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal;

            // Agregar encabezado del ticket
            ticket.AppendLine("===================================");
            ticket.AppendLine("            CINEPLUS               ");
            ticket.AppendLine("         RFC: ABC123456XYZ         ");
            ticket.AppendLine(" Dirección:Avenida insugentes 58   ");
            ticket.AppendLine("===================================");
            ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy}");
            ticket.AppendLine($"Hora: {DateTime.Now:HH:mm:ss}");
            ticket.AppendLine("===================================");

            // Agregar detalles de la función
            ticket.AppendLine("Película:");
            ticket.AppendLine($"  {funciones.pelicula}");
            ticket.AppendLine($"Horario: {funciones.Hora}");
            ticket.AppendLine("===================================");

            // Agregar detalles de los asientos
            ticket.AppendLine("Asientos seleccionados:");
            foreach (var asiento in asientos)
            {
                ticket.AppendLine($"  - Asiento {asiento}");
            }
            ticket.AppendLine("===================================");

            // Agregar detalles de costos
            ticket.AppendLine($"Precio por boleto:  $ {precioPorBoleto:F2}");
            ticket.AppendLine($"Cantidad de boletos: {asientos.Count}");
            ticket.AppendLine($"Subtotal:           $ {subtotal:F2}");
            ticket.AppendLine($"Total:              $ {total:F2}");
            ticket.AppendLine("===================================");

            // Mensaje final
            ticket.AppendLine("   ¡Gracias por su compra!         ");
            ticket.AppendLine("      Disfrute la función          ");
            ticket.AppendLine("===================================");

            // Retornar la cadena completa
            return ticket.ToString();
        }


    }
}
