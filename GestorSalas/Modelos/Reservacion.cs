using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSalas.Modelos
{
    internal class Reservacion
    {
        public int ID_Reservacion;
        public int ID_Asiento;
        public int ID_Funcion;
        public int ID_Empleado;
        public int ID_Venta;
        public DateTime Fecha_Reservacion;
    }
}
