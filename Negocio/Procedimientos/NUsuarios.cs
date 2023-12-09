using Datos.Context;
using Dominio.DTO;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public class NUsuarios 
    {
        private readonly SeguridadInformaticaContext context;
        public NUsuarios() { context = new SeguridadInformaticaContext(); }
        //estoy cansajo jefe, cansado
        //profe como hago?, se como declarar variables pero no mi amor por ella :'V
        //pecado dejar que los demas se encarguen de la tarea
        public string Create(Usuario user)
        {
            try
            {
                var userName = context.Usuarios.Find(user.Login);
                if(userName != null) {
                    context.Add(user);
                    var query = context.SaveChanges();
                    var result = (query > 0) ? "Guardado Correctamente" : "No se pudo Guardar";
                    return result;
                }
                return "Un usuario con este Username ya existe \ncon id {userName.Id}";
            }
            //$
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(Usuario user)
        {
            try
            {
                var usuario = context.Usuarios.Find(user.Id);
                if (usuario != null)
                {
                    usuario.Nombre = user.Nombre;
                    usuario.Correo = user.Correo;
                    usuario.Login = user.Login;
                    usuario.Password = user.Password ;
                    usuario.UsuarioActualiza = user.UsuarioActualiza ;
                    usuario.FechaActualizacion = DateTime.Now;
                    context.Entry(usuario).State = EntityState.Modified;
                    var query = context.SaveChanges();
                    var result = (query > 0) ? "Guardado Correctamente" : "No se pudo Guardar";
                    return result;
                }
                return "No se pudo Guardar";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public  string Delete(Usuario user)
        {
            try
            {
                var usuario = context.Usuarios.Find(user.Id);
                if (usuario != null)
                {
                    usuario.Activo = false;
                    usuario.UsuarioActualiza = user.UsuarioActualiza;
                    usuario.FechaActualizacion = user.FechaActualizacion;
                    context.Entry(usuario).State = EntityState.Modified;
                    var query =context.SaveChanges();
                    var result = (query > 0) ? "Eliminado Correctamente" : "No se pudo Eliminar";
                    return result;
                }
                return "No se pudo Eliminar";
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public List<UsuarioDTO> GetListUsuarios()
        {
            try
            {
                var list = (from u in context.Usuarios
                                  where u.Activo.Equals(true)
                                  select new UsuarioDTO
                                  {
                                      Id = u.Id,
                                      Nombre = u.Nombre,
                                      Correo = u.Correo,
                                      Usuario = u.Login,
                                      FechaRegistro = u.FechaRegistro,
                                  }).ToList();
                return list;
            }
            catch
            {
                return null;
            }
        }
        public List<UsuarioDTO> SearchUsuarios(Usuario user)
        {
            try
            {
                var list = (from u in context.Usuarios
                                  where (
                                        u.Id.ToString().Contains(user.Id.ToString())||
                                        u.Nombre.Contains(user.Nombre)||
                                        u.Correo.Contains(user.Correo)||
                                        u.Login.Contains(user.Login)
                                  )&& u.Activo.Equals(true)
                                  select new UsuarioDTO
                                  {
                                      Id = u.Id,
                                      Nombre = u.Nombre,
                                      Correo = u.Correo,
                                      Usuario = u.Login,
                                      FechaRegistro = u.FechaRegistro,
                                  }).ToList();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public Usuario GetUsarioId(Usuario user)
        {
            try
            {
                var usuario =  context.Usuarios.Find(user.Id);
                return usuario;
            }
            catch
            {
                return null;
            }
        }
    }
}