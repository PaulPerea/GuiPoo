using Session05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session05.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Insertar(Estudiante es)
        {
            ViewBag.nombre = es.nom;
            ViewBag.ape = es.ape;
            ViewBag.tel = es.tel;
            ViewBag.email = es.email;
            DaoEstudiante dao = new DaoEstudiante();
            string rpta = dao.insertar(es);
            if (rpta == "exito")
            {
                ViewBag.rpta = "Estudiante Insertado Satisfactoriamente";
            }
            return View();
        }
    }
}