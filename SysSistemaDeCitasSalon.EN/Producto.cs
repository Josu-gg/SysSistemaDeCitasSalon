using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SysSistemaDeCitasSalon.EN
{
    public class Producto
    {
        [Key]
  
        public int IdProducto { get; set; }
        [Required(ErrorMessage = " El Nombre del producto es obligatorio")]
        [StringLength(100, ErrorMessage = " El Nombre del producto no puede tener más de 100 caracteres")]
        public string NombreProducto { get; set; }
        [StringLength(500, ErrorMessage = " La Descripción del producto no puede tener más de 500 caracteres")]
        public string? Descripcion { get; set; }
            [Required(ErrorMessage = " El Precio del producto es obligatorio")]
            [Range(0.01, double.MaxValue, ErrorMessage = " El Precio del producto debe ser un valor positivo")]
        public decimal Precio { get; set; }
            [Required(ErrorMessage = " El Stock del producto es obligatorio")]
            [Range(0, int.MaxValue, ErrorMessage = " El Stock del producto no puede ser negativo")]
        public int Stock { get; set; }

        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
    }
}
