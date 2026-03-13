using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSistemaDeCitasSalon.EN
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public TimeSpan DuracionMinutos { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
    }
}
