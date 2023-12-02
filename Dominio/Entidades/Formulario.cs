using System;
using System.Collections.Generic;

namespace Dominio.Entidades;

public partial class Formulario
{
    public byte Id { get; set; }

    public string? Formulario1 { get; set; }

    public bool Activo { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? UsuarioActualiza { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public virtual ICollection<RolFormulario> RolFormularios { get; set; } = new List<RolFormulario>();
}
