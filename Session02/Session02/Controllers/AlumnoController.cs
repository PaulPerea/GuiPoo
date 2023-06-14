using Session02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session02.Controllers
{
    public class AlumnoController : Controller
    {
        public ActionResult Calificaciones(Alumno alu)
        {
            ViewBag.cod = alu.codigo;
            ViewBag.nom = alu.nombre;
            ViewBag.n1 = alu.nt1;
            ViewBag.n2 = alu.nt2;

            ViewBag.prom = alu.Promedio();
            ViewBag.condi = alu.Condicion();

            return View();
        }
    }
}