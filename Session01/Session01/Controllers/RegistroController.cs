using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session01.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        [HttpGet] //PARA POST solo borra esta linea y moidifica el html Enviar
        public ActionResult Enviar(int id = 0, string nombre = null)
        {
            ViewBag.id = id;
            ViewBag.nombre = nombre;
            return View();
        }
    }
}