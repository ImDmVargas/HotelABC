using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelABC.Entieties
{
    public class Huesped
    {
        [Key]
        public int PKid {  get; set; }
        public string Nombre { get; set; }
        public string ApellidoPat  { get; set; }
        public string ApellidoMat { get; set; }

        public string Correo { get; set; }

        public double Telefono { get; set; }

        public string Password { get; set; }
    }
}
