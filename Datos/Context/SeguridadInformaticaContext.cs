using System;
using System.Collections.Generic;
using System.Configuration;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos.Context;

public partial class SeguridadInformaticaContext : DbContext
{
    public SeguridadInformaticaContext()
    {
    }

    public SeguridadInformaticaContext(DbContextOptions<SeguridadInformaticaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Formulario> Formularios { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<RolFormulario> RolFormularios { get; set; }

    public virtual DbSet<RolPermiso> RolPermisos { get; set; }

    public virtual DbSet<RolUsuario> RolUsuarios { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString,b=>b.MigrationsAssembly("Datos"));
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Formulario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formular__3214EC27481572BB");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Formulario1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Formulario");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permisos__3214EC276117E573");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Permiso1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Permiso");
        });

        modelBuilder.Entity<RolFormulario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolFormu__3214EC27322700AE");

            entity.ToTable("RolFormulario");

            entity.HasIndex(e => e.IdFormulario, "IX_RolFormulario_IdFormulario");

            entity.HasIndex(e => e.IdRol, "IX_RolFormulario_IdRol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RolFormularios)
                .HasForeignKey(d => d.IdFormulario)
                .HasConstraintName("FK__RolFormul__IdFor__36B12243");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolFormularios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__RolFormul__IdRol__35BCFE0A");
        });

        modelBuilder.Entity<RolPermiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolPermi__3214EC275B79F6A2");

            entity.ToTable("RolPermiso");

            entity.HasIndex(e => e.IdPermiso, "IX_RolPermiso_IdPermiso");

            entity.HasIndex(e => e.IdRol, "IX_RolPermiso_IdRol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.IdPermisoNavigation).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.IdPermiso)
                .HasConstraintName("FK__RolPermis__IdPer__30F848ED");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__RolPermis__IdRol__300424B4");
        });

        modelBuilder.Entity<RolUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolUsuar__3214EC270437CA4A");

            entity.ToTable("RolUsuario");

            entity.HasIndex(e => e.IdRol, "IX_RolUsuario_IdRol");

            entity.HasIndex(e => e.IdUsuario, "IX_RolUsuario_IdUsuario");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolUsuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__RolUsuari__IdRol__2C3393D0");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RolUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__RolUsuari__IdUsu__2D27B809");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC274944B42F");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC27A61A16C9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CambiarPassword).HasDefaultValueSql("((0))");
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
