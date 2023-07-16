using HotelABC.Context;
using HotelABC.Entieties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelABC.Services
{
    public class CRUDEMPLEADO
    {
        private ApplicationDbContext _dbContext;
        public ObservableCollection<Empleado> Empleados { get; set; }
        public CRUDEMPLEADO(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Empleados = new ObservableCollection<Empleado>();
        }

        public bool AgregarEmpleado(string pkEmpleado, string rfc, string nombre, string apellidoPat, string apellidoMat, double telefono, string correo, string password)
        {
            try
            {

                bool empleadoExistente = _dbContext.Empleados.Any(e => e.Rfc == rfc || e.Nombre == nombre);

                if (empleadoExistente)
                {
                    return false;
                }


                Empleado nuevoEmpleado = new Empleado
                {
                    PkEmpleado = pkEmpleado,
                    Rfc = rfc,
                    Nombre = nombre,
                    ApellidoPat = apellidoPat,
                    ApellidoMat = apellidoMat,
                    Telefono = telefono,
                    Correo = correo,
                    Password = password
                };


                _dbContext.Empleados.Add(nuevoEmpleado);


                _dbContext.SaveChanges();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public void Actualizartabla()
        {
            try
            {
                // Carga nuevamente los empleados desde la base de datos
                var empleados = _dbContext.Empleados.ToList();

                // Actualiza la colección Empleados
                Empleados.Clear();
                foreach (var empleado in empleados)
                {
                    Empleados.Add(empleado);
                }
            }
            catch (System.Exception)
            {
                // Manejo de errores, si es necesario
            }

        }
    }
}
