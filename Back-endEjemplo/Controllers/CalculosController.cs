using Back_endEjemplo.Models;
using Back_endEjemplo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) +  Convert.ToInt16(n2);
            ViewBag.res = res;


            return View();
        }

        public ActionResult Operacion()
        {
            OperasBas op = new OperasBas();
            return View(op);

        }
        [HttpPost]

        public ActionResult Operacion(OperasBas op)
        {
            op.Suma();
            return View(op);

        }

        public ActionResult Resta(OperasBas op)
        {
            op.Resta();
            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult MuestraPeliculas2()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

        public /*ContentResult*//*JsonResult*//*ActionResult*//*RedirectResult*/RedirectToRouteResult Temporal()
        {
            //var alumno1 = new Alumno() { Nombre = "Juan", Edad = 20 };
            //return Content("<h1>Hola Mundo Soy Gustavo!</h1>");
            //return Json(alumno1, JsonRequestBehavior.AllowGet);
            //return Redirect("https://Google.com.mx");
            return RedirectToAction("About", "Home");
        }

    }
}