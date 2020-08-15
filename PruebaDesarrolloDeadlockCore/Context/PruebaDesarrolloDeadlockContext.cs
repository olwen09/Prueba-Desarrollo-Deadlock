using Microsoft.EntityFrameworkCore;
using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Context
{
   public class PruebaDesarrolloDeadlockContext : DbContext
    {
    

        public PruebaDesarrolloDeadlockContext(DbContextOptions<PruebaDesarrolloDeadlockContext>options) : base(options)
        {

        }

        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Posicion> Posiciones { get; set; }

    }
}
