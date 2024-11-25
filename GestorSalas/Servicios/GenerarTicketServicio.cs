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

            // Agregar detalles del ticket
            ticket.AppendLine("--- Detalles del Ticket ---");
            ticket.AppendLine($"Película: {funciones.pelicula}");
            ticket.AppendLine($"Hora: {funciones.Hora}");

            ticket.AppendLine("Asientos:");
            foreach (var asiento in asientos)
            {
                ticket.AppendLine($"- Asiento: {asiento}");
            }

            ticket.AppendLine("--- Fin del Ticket ---");

            // Retornar la cadena completa
            return ticket.ToString();
        }


    }
}
