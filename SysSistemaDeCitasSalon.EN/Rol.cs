using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        [Required(ErrorMessage = "El nombre del rol es requerido")]
        [StringLength(50, ErrorMessage = "El nombre del rol no puede tener más de 50 caracteres")]
        public string NombreRol { get; set; }
        [Required]
        public int IdEstado { get; set; }
    }
}
