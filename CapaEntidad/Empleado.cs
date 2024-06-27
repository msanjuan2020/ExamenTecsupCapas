using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Empleado
    {
        // Debemos agregar las propiedades deacuerdo a la cantidad de variables de la tabla de la BD
        
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Oficina { get; set; }
        public decimal Salario { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
