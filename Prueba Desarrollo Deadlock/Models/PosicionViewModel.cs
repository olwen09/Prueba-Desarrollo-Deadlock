using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Desarrollo_Deadlock.Models
{
    public class PosicionViewModel
    {
        /// <summary>
        /// id de la Posición
        /// </summary>
        public int PosicionId { get; set; }


        /// <summary>
        /// Nombre de la Posición requerido
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string PosicionName { get; set; }

        /// <summary>
        /// Fecha en la que la Posicion fue registrada
        /// </summary>
        public DateTime Creacion { get; set; }


        /// <summary>
        /// Fecha en la que la Posicion fue modificada
        /// </summary>
        public DateTime Modificacion { get; set; }


        public IEnumerable<Empleado> Empleados { get; set; } = new HashSet<Empleado>();
    }
}
