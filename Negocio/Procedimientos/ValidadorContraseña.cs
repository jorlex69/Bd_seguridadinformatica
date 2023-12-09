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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
        public static class ValidadorContraseña
        {
            public static bool AlgoritmoContraseñaSegura(string password)
            {
                Regex letras = new(@"[a-zA-z]");
                Regex numeros = new Regex(@"[0-9]");
                Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");
                var result = (letras.IsMatch(password) && numeros.IsMatch(password) &&
                    caracEsp.IsMatch(password) && password.Length > 9) ? true : false;
                return result;
            }
        }
}