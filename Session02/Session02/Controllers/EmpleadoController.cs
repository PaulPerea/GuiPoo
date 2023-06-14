using Session02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Salario(Empleado emp)
        {
            ViewBag.cod = emp.cod;
            ViewBag.nom = emp.nom; 
            ViewBag.ape = emp.ape;
            ViewBag.email = emp.email;
            ViewBag.hora = emp.hora;
            ViewBag.tarifa = emp.tarifa;

            ViewBag.sueldoBruto = emp.sueldoBruto();
            ViewBag.desBruto = emp.descBruto();
            ViewBag.boniFamiliar = emp.boniFamiliar();
            ViewBag.boniEsp = emp.boniEsp();
            ViewBag.salNeto = emp.salNeto();
            return View();
        }
    }
}