using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Usuario : Persona
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [StringLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres.")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(255, ErrorMessage = "La contraseña no puede tener más de 255 caracteres.")]
        public string Contra { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required]
        public int IdEstado { get; set; }
    }
}
