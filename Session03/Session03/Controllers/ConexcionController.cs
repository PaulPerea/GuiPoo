using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session03.Models;

namespace Session03.Controllers
{
    public class ConexcionController : Controller
    {
        // GET: Conexcion
        public ActionResult Prueba(myConexion obj)
        {
            ViewBag.rpta = obj.ObtenerConexion();
            return View();
        }
    }
}