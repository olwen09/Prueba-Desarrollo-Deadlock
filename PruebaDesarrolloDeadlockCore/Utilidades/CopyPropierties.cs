﻿using System;
using System.Collections.Generic;
using System.Text;
using PruebaDesarrolloDeadlockCore.Models;
using Newtonsoft.Json;

namespace PruebaDesarrolloDeadlockCore.Utilidades
{
    public class CopyPropierties
    {
        public static TTarget Convert<TSource, TTarget>(TSource sourceItem)
        {
            if (null == sourceItem)
            {
                return default(TTarget);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace, ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore };

            var serializedObject = JsonConvert.SerializeObject(sourceItem, deserializeSettings);

            return JsonConvert.DeserializeObject<TTarget>(serializedObject);
        }

    }
}
