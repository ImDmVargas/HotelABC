using HotelABC.Context;
using HotelABC.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelABC.Services
{
    public class Login
    {

        public class AuthService
        {
            private readonly ApplicationDbContext _dbContext;

            public AuthService(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public bool ValidarAcceso(string username, string password)
            {
                var empleado = _dbContext.Empleados.FirstOrDefault(e => e.PkEmpleado == username && e.Password == password);

                if (empleado != null)
                {
                    Console.WriteLine("Acceso correcto");
                    return true;
                }
                else
                {
                    Console.WriteLine("Acceso incorrecto");
                    return false;
                }
            }
        }
    }
}
