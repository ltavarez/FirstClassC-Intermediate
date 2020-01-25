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

            List<Person> persons = new List<Person>{};


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