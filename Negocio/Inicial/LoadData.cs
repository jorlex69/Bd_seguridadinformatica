using Datos.Context;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Inicial
{
    public class LoadData
    {
        private readonly SeguridadInformaticaContext context;
        public LoadData()
        {
            context=new SeguridadInformaticaContext();
        }

        public void InsertData()
        {

            if (!context.RolPermisos.Any())
            {
                AddRoles();
                Permiso_();
                RolPermiso_();
            }
        }

        private void AddRoles()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role {
                Rol="Administrador",
                Activo=true,
                UsuarioRegistro=1,
                FechaRegistro=DateTime.Now
            });
            roles.Add(new Role
            {
                Rol = "Supervisor",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            roles.Add(new Role
            {
                Rol = "Cajero",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            roles.Add(new Role
            {
                Rol = "Facturacion",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            roles.Add(new Role
            {
                Rol = "Gerencia General",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            context.AddRange(roles);
            context.SaveChanges();
        }
        private void Permiso_()
        {
            List<Permiso> lpermiso= new List<Permiso>();
            lpermiso.Add(new Permiso
            {
                Permiso1 = "Lectura",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            lpermiso.Add(new Permiso
            {
                Permiso1 = "Escritura",
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            context.AddRange(lpermiso);
            context.SaveChanges();
        }

        private void RolPermiso_()
        {
            List<RolPermiso> rolPermisos= new List<RolPermiso>();
            rolPermisos.Add(new RolPermiso {
                IdRol= 1,
                IdPermiso= 1,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 1,
                IdPermiso = 2,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 2,
                IdPermiso = 1,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 3,
                IdPermiso = 2,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 4,
                IdPermiso = 1,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 5,
                IdPermiso = 1,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            rolPermisos.Add(new RolPermiso
            {
                IdRol = 5,
                IdPermiso = 2,
                Activo = true,
                UsuarioRegistro = 1,
                FechaRegistro = DateTime.Now
            });
            context.AddRange(rolPermisos);
            context.SaveChanges();
        
        }
    }
}
    



