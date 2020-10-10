using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller

    {
        public IActionResult Index()
        {
            Array array;
            List<AlumnoModel> alumnos=new List<AlumnoModel>();

            alumnos.Add(new AlumnoModel
            {
                NC = "17030084",
                Nombre = "Karla",
                App = "Garcia",
                Apm = "Reza",
                Carrera = "Informatica",
                Semestre = 7,
                Promedio = 9.54,
                FechaIngreso = DateTime.Now
            });

            alumnos.Add(new AlumnoModel
            {
                NC = "17030082",
                Nombre = "Jaqueline",
                App = "Fernnandez",
                Apm = "Maldonado",
                Carrera = "Informatica",
                Semestre = 7,
                Promedio = 9.55,
                FechaIngreso = DateTime.Now
            });

            alumnos.Add(new AlumnoModel
            {
                NC = "17030081",
                Nombre = "Carlos",
                App = "Cordova",
                Apm = "Lechuga",
                Carrera = "Informatica",
                Semestre = 7,
                Promedio = 9.56,
                FechaIngreso = DateTime.Now
            });

            array = alumnos.ToArray();
            ViewBag.datos = array;
                       

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
