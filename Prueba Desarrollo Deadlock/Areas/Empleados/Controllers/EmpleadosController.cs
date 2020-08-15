using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prueba_Desarrollo_Deadlock.Areas.Empleados.Modelos;
using Prueba_Desarrollo_Deadlock.Helpers;
using PruebaDesarrolloDeadlockCore.Interfaces;
using PruebaDesarrolloDeadlockCore.Models;
using PruebaDesarrolloDeadlockCore.Utilidades;

namespace Prueba_Desarrollo_Deadlock.Areas.Empleados.Controllers
{

    [Area("Empleados")]
    public class EmpleadosController : Controller
    {
        private readonly IEmpleado _empleado;
        private readonly IPosicion _posicion;


        public EmpleadosController(IEmpleado empleado, IPosicion posicion)
        {
            _empleado = empleado;
            _posicion = posicion;
        }

        public IActionResult Index()
        {
            var empleadoData = _empleado.GetAll;

            return View(empleadoData);
        }

        public IActionResult Crear()
        {
            var model = new EmpleadosViewModel();

            ViewBag.Posiciones = new SelectList(_posicion.GetAll, "PosicionId", "PosicionName");
            return View(model);
        }

        public IActionResult Editar(int empleadoId)
        {
            var data = _empleado.GetById(empleadoId);

            var model = CopyPropierties.Convert<Empleado, EmpleadosViewModel>(data);


            ViewBag.Posiciones = new SelectList(_posicion.GetAll, "PosicionId", "PosicionName");
            return View("Crear", model);
            
        }

        public IActionResult GuardarEmpleado(EmpleadosViewModel model)
        {
            var empleadoData = _empleado.GetAll;

            if (ModelState.IsValid)
            {
                var data = CopyPropierties.Convert<EmpleadosViewModel,Empleado>(model);


                try
                {
                    _empleado.Save(data);
                }
                catch(Exception e)
                {

                    ViewBag.Posiciones = new SelectList(_posicion.GetAll, "PosicionId", "PosicionName");
                    return View("Crear", model);
                }
            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors).FirstOrDefault(x => x.Count() > 0).First();

                EnviarMensaje.Enviar(TempData, "red", errors.ErrorMessage);

                ViewBag.Posiciones = new SelectList(_posicion.GetAll, "PosicionId", "PosicionName");
                return View("Crear", model);
            }

            return View("Index", empleadoData);

        }
    }
}
