using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InvertirNum.Models;
using InvertirNum.Reverse;

namespace InvertirNum.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resultado(Datos data)
        {
            //Se crea una instancia de Datos y luego se le manda por parametros el numero a la clase Reverser.
            //Recordar!! Es una variable var, debido a que da error si se pone como INT, no se puede transformar.
            var numInverted = new Datos
            {
                Numero = Reverser.invertirNum(data.Numero)
            };

            return View(numInverted);
        }
    }
}