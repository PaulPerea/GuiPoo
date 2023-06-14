using Session05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session05.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Insertar(Docente doc)
        {
            ViewBag.nombre = doc.nom;
            ViewBag.ape = doc.ape;
            ViewBag.dni = doc.dni;
            ViewBag.especialidad = doc.esp;
            ViewBag.sue = doc.sue;
            ViewBag.fin = doc.fingDate;
            DaoDocente dao = new DaoDocente();
            string rpta = dao.insertar(doc);
            if(rpta == "exito")
            {
                ViewBag.rpta = "Docente Insertado Satisfactoriamente";
            }
            return View();
        }
    }
}