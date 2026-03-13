using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysSistemaDeCitasSalon.EN
{
    public class Empleado : Persona
    {
        [Key]
        public int IdEmpleado { get; set; }
        public int IdEstado { get; set; }
    }
}
