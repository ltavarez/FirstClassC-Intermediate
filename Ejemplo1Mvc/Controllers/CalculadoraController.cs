using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo1Mvc.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(int numero1, int numero2)
        {
            var resultado = numero1 + numero2;

            ViewBag.resultado = resultado;
            return View("Resultado");
        }

        
        public IActionResult Resultado()
        {
            return View();
        }

        public IActionResult TablaGenerada()
        {
            return View();
        }



    }
}