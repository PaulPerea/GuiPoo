using Session04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session04.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Registrar(Estudiante obj)
        {
            ViewBag.nombre = obj.nombre;
            ViewBag.apellido = obj.apellido;
            ViewBag.telefono = obj.telefono;
            ViewBag.correo = obj.correo;
            DaoEstudiante dao = new DaoEstudiante();
            string rpta = dao.insertar(obj);
            if (rpta == "ok")
            {
                ViewBag.respuesta = "Estudiante Registrado exitosamente";
            }

            return View();
        }
    }
}