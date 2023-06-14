using Session06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session06.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Busqueda(Estudiante obj)
        {
            ViewBag.filtro = obj.ape;
            DaoEstudiante dao = new DaoEstudiante();
            Estudiante est = dao.buscar(obj);
            if (est != null)
            {
                ViewBag.id = est.idEstud;
                ViewBag.nom = est.nom;
                ViewBag.ape = est.ape;
                ViewBag.tel = est.tel;
                ViewBag.correo = est.correo;
            }

            return View();
        }
    }
}