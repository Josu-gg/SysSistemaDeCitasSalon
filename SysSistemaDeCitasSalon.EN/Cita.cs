using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdEstado { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
