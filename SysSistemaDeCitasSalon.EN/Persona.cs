using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysSistemaDeCitasSalon.EN
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "Ingrese un número de teléfono válido.")]
        public string Telefono { get; set; }
        [StringLength(150, ErrorMessage = "La dirección no puede tener más de 150 caracteres.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El DUI es obligatorio.")]
        [StringLength(10, ErrorMessage = "El DUI debe tener máximo 10 caracteres.")]
        public string DUI { get; set; }
    }
}
