using Session11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session11.Controllers
{
    public class CoordinadorController : Controller
    {

        DaoCoordinador dao = new DaoCoordinador();
        public ActionResult Index()
        {
            IEnumerable<Coordinador> lista = new List<Coordinador>();
            lista = dao.listado();
            return View(lista);
        }
        public ActionResult Nuevo()
        {
            return View();
        }
        public ActionResult insertar(Coordinador cur)
        {
            string msj = dao.guardar(cur);
            if (msj == "listo")
            {
                ViewBag.mensaje = "Transaccion Exitosa";
            }
            return View("Nuevo", cur);
        }
    }
}