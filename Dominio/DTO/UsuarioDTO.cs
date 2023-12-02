using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTO
{
    public class UsuarioDTO
    {
        public short Id { get; set; }

        public string Nombre { get; set; } 

        public string Correo { get; set; } 

        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
