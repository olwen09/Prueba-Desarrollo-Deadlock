using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prueba_Desarrollo_Deadlock.Helpers;
using Prueba_Desarrollo_Deadlock.Models;
using PruebaDesarrolloDeadlockCore.Interfaces;
using PruebaDesarrolloDeadlockCore.Models;
using PruebaDesarrolloDeadlockCore.Utilidades;

namespace Prueba_Desarrollo_Deadlock.Controllers
{
    public class PosicionController : Controller
    {

        private readonly IPosicion _posicion;

        public PosicionController(IPosicion posicion)
        {
            _posicion = posicion;
        }

        public IActionResult Index()
        {
            var posicionData = _posicion.GetAll;

            return View(posicionData);
        }


        public IActionResult Crear()
        {
            var model = new PosicionViewModel();

            return View(model);
        }

        public IActionResult Editar(int posicionId)
        {


            var data = _posicion.GetById(posicionId);

            var model = CopyPropierties.Convert<Posicion, PosicionViewModel>(data);



            return View("Crear", model);
        }


        [HttpPost]
        public IActionResult GuardarPosicion(PosicionViewModel model)
        {
            var posicionData = _posicion.GetAll;

            if (ModelState.IsValid)
            {

                var data = CopyPropierties.Convert<PosicionViewModel, Posicion>(model);
                try
                {
                    _posicion.Save(data);
                }
                catch(Exception e)
                {

                    EnviarMensaje.Enviar(TempData, "red", "Verifique el formulario");
                    return View("Crear", model);
                }
            }
            else
            {
                EnviarMensaje.Enviar(TempData, "red", "Verifique el formulario");

                return View("Crear", model);
            }


            EnviarMensaje.Enviar(TempData, "green", "La informacion fue guardada");
            return View("Index",posicionData);
        }

    }
}

