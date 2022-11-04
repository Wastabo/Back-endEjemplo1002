using Back_endEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo.Controllers
{
    public class FormulariosController : Controller
    {
        // GET: Formularios
        public ActionResult Index()
        {
            var model = new Pelicula();
            return View();
        }

        public ActionResult Index2()
        {
            var model = new Pelicula();
            return View();
        }
    }
}