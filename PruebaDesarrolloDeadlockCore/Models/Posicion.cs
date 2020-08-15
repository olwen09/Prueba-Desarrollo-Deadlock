using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Models
{
   public class Posicion
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
