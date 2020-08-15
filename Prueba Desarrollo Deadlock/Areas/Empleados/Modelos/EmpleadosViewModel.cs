using PruebaDesarrolloDeadlockCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Desarrollo_Deadlock.Areas.Empleados.Modelos
{
    public class EmpleadosViewModel
    {
        /// <summary>
        /// Id de la persona este campo es identity
        /// </summary>
        public int EmpleadoId { get; set; }


        /// <summary>
        /// Nombre del Empleado este tiene un limite de 50 caracteres requerido
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string NombreEmpleado { get; set; }


        /// <summary>
        /// Apellido de la persona este tiene un limite de 50 caracteres requerido
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string ApellidoEmpleado { get; set; }


        /// <summary>
        /// Correo electronico del empleado requerido
        /// </summary>
        [Required]
        public string Email { get; set; }


        /// <summary>
        /// Numero de contacto del empleado requerido
        /// </summary>
        [Required]
        public int Telefono1 { get; set; }

        /// <summary>
        /// Un segundo numero de contacto opcional
        /// </summary>
        public int Telefono2 { get; set; }

        /// <summary>
        /// Fecha en la que el empleado fue registrado
        /// </summary>
        public DateTime Creacion { get; set; }


        /// <summary>
        /// Fecha en la que el empleado fue modificado
        /// </summary>
        public DateTime Modificacion { get; set; }


        public int PosicionId { get; set; }


     
        public virtual Posicion Posicion { get; set; }
    }
}
