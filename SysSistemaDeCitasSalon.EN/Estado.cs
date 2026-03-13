using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        [Required(ErrorMessage = "El nombre del estado es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre del estado no debe superar los 50 caracteres.")]
        public string NombreEstado { get; set; } 
        [Required(ErrorMessage = "El tipo de estado es obligatorio.")]
        [StringLength(50, ErrorMessage = "El tipo de estado no debe superar los 50 caracteres.")]
        public string TipoEstado { get; set; } 
    }
}
