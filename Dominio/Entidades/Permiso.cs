using System;
using System.Collections.Generic;

namespace Dominio.Entidades;

public partial class Permiso
{
    public byte Id { get; set; }

    public string? Permiso1 { get; set; }

    public bool Activo { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? UsuarioActualiza { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
}
