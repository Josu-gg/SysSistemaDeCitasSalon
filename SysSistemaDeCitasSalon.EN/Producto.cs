using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } 
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
    }
}
