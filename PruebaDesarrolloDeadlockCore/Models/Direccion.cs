using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaDesarrolloDeadlockCore.Models
{
   public class Direccion
    {
        public int DireccionId { get; set; }



        /// <summary>
        /// Direccion del empleado requerido
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Direccion1 { get; set; }

        /// <summary>
        /// Direccion2  del empleado opcional
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Direccion2 { get; set; }

        /// <summary>
        /// Numero de casa del empleado opcional
        /// </summary>
        public int NumeroDeCasa { get; set; }


        /// <summary>
        /// Pais donde reside el empleado requerido
        /// </summary>
        [Required]
        [MaxLength(60)]
        public string Pais { get; set; }


        /// <summary>
        /// Lista de empleados
        /// </summary>
        IEnumerable<Empleado> Empleado { get; set; } = new HashSet<Empleado>();

    }
}
