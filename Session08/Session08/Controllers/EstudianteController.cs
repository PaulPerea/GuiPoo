using Session08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session08.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult busqueda(Estudiante obj)
        {
            ViewBag.filtro = obj.ape;
            DaoEstudiante dao = new DaoEstudiante();
            Estudiante est = dao.buscar(obj);
            if (est != null)
            {
                ViewBag.id = est.idestud;
                ViewBag.nomb = est.nomb;
                ViewBag.ape = est.ape;
                ViewBag.tel = est.telefono;
                ViewBag.correo = est.correo;
            }
            return View();
        }
        public ActionResult listado()
        {

            IEnumerable<Estudiante> lista = new List<Estudiante>();
            DaoEstudiante dao = new DaoEstudiante();
            lista = dao.listado();
            return View(lista);
        }
    }
}