using Session04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session04.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Registrar(Docente obj)
        {
            ViewBag.noM = obj.nom;
            ViewBag.ap = obj.ap;
            ViewBag.dni = obj.dni;
            ViewBag.esp = obj.esp;
            ViewBag.sue= obj.sue;
            ViewBag.fin= obj.fin;
            DaoDocente dao = new DaoDocente();
            string rpta = dao.insertar(obj);
            if (rpta == "ok")
            {
                ViewBag.respuesta = "Docente Registrado exitosamente";
            }
            else
            {
                ViewBag.respuesta = "No valida oo no nada";
            }
            return View();
        }
    }
}