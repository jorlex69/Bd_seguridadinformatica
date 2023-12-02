using System;
using System.Collections.Generic;

namespace Dominio.Entidades;

public partial class Usuario
{
    public short Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Login { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public byte Contador { get; set; }

    public bool Bloqueado { get; set; }

    public bool? CambiarPassword { get; set; }

    public bool Activo { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? UsuarioActualiza { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<RolUsuario> RolUsuarios { get; set; } = new List<RolUsuario>();
}
