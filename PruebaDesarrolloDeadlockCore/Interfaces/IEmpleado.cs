using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Interfaces
{
   public interface IEmpleado
    {

        /// <summary>
        /// Lista de empleados
        /// </summary>
        IEnumerable<Empleado> GetAll { get; }


        /// <summary>
        /// Obtener un empleado por su Id
        /// </summary>
        /// <param name="empleadoId"></param>
        /// <returns>Empleado</returns>
        Empleado GetById(int empleadoId);


        /// <summary>
        /// Guardar/Actualizar un empleado
        /// </summary>
        /// <param name="model"></param>
        void Save(Empleado model);

    }
}
