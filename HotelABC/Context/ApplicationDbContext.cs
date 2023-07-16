using HotelABC.Entieties;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelABC.Context
{
    public class ApplicationDbContext: DbContext
    {
       
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseMySQL("server=localhost; database=HOTELABC; user=root; password=");
            }
            public DbSet<Empleado> Empleados { get; set; }
            public DbSet<Huesped> Huespedes { get; set; }

       
    }
}
