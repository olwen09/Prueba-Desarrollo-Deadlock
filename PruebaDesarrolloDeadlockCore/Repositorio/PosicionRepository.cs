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
    public class PosicionRepository : IPosicion
    {

        private readonly PruebaDesarrolloDeadlockContext _pruebaDesarrolloDeadlockContext;


        public PosicionRepository(PruebaDesarrolloDeadlockContext pruebaDesarrolloDeadlockContext)
        {
            _pruebaDesarrolloDeadlockContext = pruebaDesarrolloDeadlockContext;
        }

        public IEnumerable<Posicion> GetAll => _pruebaDesarrolloDeadlockContext.Posiciones
            .Include(x => x.Empleados);

        public Posicion GetById(int posicionId)
        {
            return GetAll.FirstOrDefault(x => x.PosicionId == posicionId);
        }

        public void Save(Posicion model)
        {
            var today = DateTime.Today;

            if(model.PosicionId != 0)
            {
                model.Modificacion = today;

                _pruebaDesarrolloDeadlockContext.Posiciones.Update(model);
            }
            else
            {
                model.Creacion = today;
                _pruebaDesarrolloDeadlockContext.Add(model);
            }

            _pruebaDesarrolloDeadlockContext.SaveChanges();
        }
    }
}
