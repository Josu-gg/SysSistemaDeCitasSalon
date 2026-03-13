using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysSistemaDeCitasSalon.EN
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "La fecha de la cita es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La hora de la cita es obligatoria.")]
        [DataType(DataType.Time)]
        public TimeSpan Hora { get; set; }
        public int IdEstado { get; set; }
        [StringLength(500, ErrorMessage = "Las observaciones no pueden exceder los 500 caracteres.")]
        public string? Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
