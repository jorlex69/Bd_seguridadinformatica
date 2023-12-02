using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTO
{
    public class PermisosDTO
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public string Rol {  get; set; }
        public string Permisos {  get; set; }
    }
}