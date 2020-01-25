using Ejemplo1Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;

namespace Ejemplo1Mvc.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {

            List<Person> persons = new List<Person> {new Person()
            {
                Name = "Itla",
                LastName = "C# intermedio",
                IsActive = true
            }, new Person()
                {
                    Name = "Itla 2",
                    LastName = "Pruebas",
                    IsActive = false
                }};


            ViewBag.HaveData = persons.Any();
            ViewBag.PersonList = persons;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }



    }
}