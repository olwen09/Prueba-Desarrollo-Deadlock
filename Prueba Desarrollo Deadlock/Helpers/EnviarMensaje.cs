using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Prueba_Desarrollo_Deadlock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Desarrollo_Deadlock.Helpers
{
    public static class EnviarMensaje
    {
        public static void Enviar(this ITempDataDictionary tempData, string tipo, string texto)
        {
            MensajesViewModel mensaje = new MensajesViewModel("", "", "");

            mensaje.Titulo = "Mensaje";
            mensaje.Texto = texto;
            mensaje.Tipo = tipo;

            TempDataExtensions.Put<MensajesViewModel>(tempData, "mensaje", mensaje);

        }
    }
}
