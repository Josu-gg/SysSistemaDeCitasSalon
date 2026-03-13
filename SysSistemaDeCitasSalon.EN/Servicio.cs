using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        [Required(ErrorMessage = "El nombre del servicio es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del servicio no puede tener más de 100 caracteres.")]
        public string NombreServicio { get; set; }
        [Required(ErrorMessage = "La descripción del servicio es obligatoria.")]
        [StringLength(500, ErrorMessage = "La descripción del servicio no puede tener más de 500 caracteres.")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El precio del servicio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio del servicio debe ser un valor positivo.")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La duración del servicio es obligatoria.")]
     
        public TimeSpan DuracionMinutos { get; set; }
        [Required(ErrorMessage = "La categoría del servicio es obligatoria.")]

        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El estado del servicio es obligatorio.")]
       
        public int IdEstado { get; set; }
    }
}
