using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysSistemaDeCitasSalon.EN
{
    public class Cliente: Persona
    {
        [Key]
        public int IdCliente { get; set; }
        public int IdEstado { get; set; }
    }
}
