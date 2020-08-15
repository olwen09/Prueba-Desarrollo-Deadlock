using Microsoft.EntityFrameworkCore;
using PruebaDesarrolloDeadlockCore.Context;
using PruebaDesarrolloDeadlockCore.Interfaces;
using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Repositorio
{
    public class EmpleadoRepository : IEmpleado
    {
        private readonly PruebaDesarrolloDeadlockContext _pruebaDesarrolloDeadlockContext; 
        public EmpleadoRepository(PruebaDesarrolloDeadlockContext pruebaDesarrolloDeadlockContext)
        {
            _pruebaDesarrolloDeadlockContext = pruebaDesarrolloDeadlockContext;
        }
        public IEnumerable<Empleado> GetAll => _pruebaDesarrolloDeadlockContext.Empleados
            .Include(x => x.Posicion)
            .Include(x => x.Direccion);

        public Empleado GetById(int empleadoId)
        {
            return GetAll.FirstOrDefault(x => x.EmpleadoId == empleadoId);
        }

        public void Save(Empleado model)
        {
            var today = DateTime.Today;

            if(model.EmpleadoId != 0)
            {
                model.Modificacion = today;

                _pruebaDesarrolloDeadlockContext.Empleados.Update(model);

            }
            else
            {
                _pruebaDesarrolloDeadlockContext.Add(model);
            }

            _pruebaDesarrolloDeadlockContext.SaveChanges();
        }
    }
}
