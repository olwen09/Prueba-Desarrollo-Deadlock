using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Interfaces
{
   public interface IPosicion
    {


        /// <summary>
        /// Obtener la lista de posiciones
        /// </summary>
        IEnumerable<Posicion> GetAll { get; }

        /// <summary>
        /// Obtener una posicion por su Id
        /// </summary>
        /// <param name="posicionId"></param>
        /// <returns></returns>

        Posicion GetById(int posicionId);


        /// <summary>
        /// Guardar/Actualizar una posicion
        /// </summary>
        /// <param name="model"></param>
        void Save(Posicion model);
    }
}
