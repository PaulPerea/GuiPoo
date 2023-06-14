using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session01.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index() //index es el nombre de la vista - misma ves el mismo nombre de la pagina
        {
            ViewBag.mensaje = "Hola mundo";
            return View();
        }
        public ActionResult Listado()
        {
            ViewBag.nombre = "Jean";
            ViewBag.apellido = "Perea";
            ViewBag.edad = 25;
            ViewBag.estatura = 1.8;
            return View();
        }
        public ActionResult Datos() 
        {
            ViewData["id"] = 14832;
            ViewData["nom"] = "Fimon";
            ViewData["fechNac"] = new DateTime(2005, 1, 22);
            return View();
        }
    }
}