using System;
using System.Collections.Generic;

namespace Dominio.Entidades;

public partial class RolUsuario
{
    public short Id { get; set; }

    public byte? IdRol { get; set; }

    public short? IdUsuario { get; set; }

    public bool Activo { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? UsuarioActualiza { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
