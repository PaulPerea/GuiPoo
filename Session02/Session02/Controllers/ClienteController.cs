using Session02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session02.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Registro(Cliente obj)
        {
            ViewBag.codigo = obj.codigo;
            ViewBag.nombre = obj.nombre;
            ViewBag.apellido = obj.apellido;
            ViewBag.email = obj.email;


            return View();
        }
    }
}