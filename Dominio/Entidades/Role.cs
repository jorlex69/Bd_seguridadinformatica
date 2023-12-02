using System;
using System.Collections.Generic;

namespace Dominio.Entidades;

public partial class Role
{
    public byte Id { get; set; }

    public string Rol { get; set; } = null!;

    public bool Activo { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? UsuarioActualiza { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<RolFormulario> RolFormularios { get; set; } = new List<RolFormulario>();

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();

    public virtual ICollection<RolUsuario> RolUsuarios { get; set; } = new List<RolUsuario>();
}
