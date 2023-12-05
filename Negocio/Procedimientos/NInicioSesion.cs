using Datos.Context;
using Dominio.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public class NInicioSesion
    {
        private readonly SeguridadInformaticaContext context;
        public NInicioSesion() { context = new SeguridadInformaticaContext(); }

        public bool Login( Usuario user)
        {
            try
            {
                var usuario = (from u in context.Usuarios
                                     where u.Correo.Equals(user.Correo)
                                     && u.Activo.Equals(true) && u.Bloqueado.Equals(false)
                                     select u).First();
                if (usuario != null)
                {
                    if (Encrypt.EncryptUser(user.Correo).SequenceEqual(Encrypt.EncryptUser(user.Correo)))
                    {
                        var result = (usuario.Password.SequenceEqual(user.Password)) ? true : false;

                        if (!result)
                        { 
                            usuario.Contador += 1;
                            usuario.Bloqueado = (usuario.Contador>2) ? true : false;
                            context.Entry(usuario).State = EntityState.Modified;
                            context.SaveChanges();
                            return result;
                        }
                        return result;
                    }
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
        }
        public Usuario GetUsuario(Usuario user)
        {
            try
            {
                var usuario = (from u in context.Usuarios
                                    where u.Correo.Equals(user.Correo) && u.Activo.Equals(true)
                                    select u).FirstOrDefault();
                var result = (usuario != null) ? usuario : null;
                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

      
    }
}
