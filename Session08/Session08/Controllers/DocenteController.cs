using Session08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session08.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult busqueda(Docente obj)
        {
            ViewBag.filtro = obj.ape;
            DaoDocente dao = new DaoDocente();
            Docente est = dao.buscar(obj);
            if (est != null)
            {
                ViewBag.id = est.idoc;
                ViewBag.nomb = est.nomb;
                ViewBag.ape = est.ape;
                ViewBag.dni = est.dni;
                ViewBag.especie = est.especie;
                ViewBag.sueldo = est.sueldo;
                ViewBag.fin = est.fin;
            }
            return View();
        }
        public ActionResult listado()
        {

            IEnumerable<Docente> lista = new List<Docente>();
            DaoDocente dao = new DaoDocente();
            lista = dao.listado();
            return View(lista);
        }
    }
}