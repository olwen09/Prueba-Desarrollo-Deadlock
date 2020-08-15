using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Desarrollo_Deadlock.Areas.Empleados.Modelos
{
    public class EmpleadosIndexViewModel
    {
        IEnumerable<Empleado> ListaDeEmpleados { get; set; }
    }
}
