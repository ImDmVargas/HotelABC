using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelABC.Entieties
{
    public class Empleado
    {
        [Key]
        public string PkEmpleado { get; set; }

        public string Rfc { get; set; }

        public string Nombre { get; set; }

       public string ApellidoMat { get; set; }
        public string ApellidoPat { get; set; }
        public double Telefono { get; set; }

        public string Correo { get; set; }

        public string Password { get; set; }

    }
}
