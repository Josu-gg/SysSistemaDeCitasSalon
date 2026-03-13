using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysSistemaDeCitasSalon.EN
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage ="El nombre de la categoria es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre de la categoría no puede tener más de 100 caracteres.")]
        public string NombreCategoria { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
