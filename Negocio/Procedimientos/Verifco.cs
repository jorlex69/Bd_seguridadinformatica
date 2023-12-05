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
    public class Pass_secure
    {
        public static class ValidadorContraseña
        {
            public static bool AlgoritmoContraseñaSegura(string password)
            {
                bool mayuscula = false, minuscula = false, numero = false, carespecial = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        mayuscula = true;
                    }
                    else if (Char.IsLower(password[i]))
                    {
                        minuscula = true;
                    }
                    else if (Char.IsDigit(password[i]))
                    {
                        numero = true;
                    }
                    else
                    {
                        carespecial = true;
                    }
                }

                return mayuscula && minuscula && numero && carespecial && password.Length >= 8;
            }
        }


    }
}