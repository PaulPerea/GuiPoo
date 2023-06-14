using Session11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session11.Controllers
{
    public class CursoController : Controller
    {
        DaoCurso dao = new DaoCurso();
        public ActionResult Index()
        {
            IEnumerable<Curso> lista = new List<Curso>();
            lista = dao.listado();
            return View(lista);
        }
        public ActionResult Nuevo() { 
            return View();
        }
        public ActionResult insertar(Curso cur) 
        { 
            string msj = dao.guardar(cur);
            if (msj == "exito")
            {
                ViewBag.mensaje = "Transaccion Exitosa";
            }
            return View("Nuevo", cur);
        }
    }
}