using Microsoft.Reporting.WebForms;
using session13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Microsoft.Reporting;
using ReportViewerForMvc;

namespace session13.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult ReporteEstudiante()
        {
            ReportViewer rp = new ReportViewer();
            rp.ProcessingMode = ProcessingMode.Local;
            rp.SizeToReportContent = true;
            // establecer origen de datos  - del reporte
            DaoEstudiante dao = new DaoEstudiante();
            DataSet ds = dao.informe();
            rp.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reportes\rptEstudiante.rdlc";
            rp.LocalReport.DataSources.Add(new ReportDataSource("dsEstudiante", ds.Tables["estudiante"]));

            //transportar modelo entre la vista
            ViewBag.ReporteViewer = rp;

            return View();
        }
        public ActionResult ReporteDocente()
        {
            ReportViewer rp = new ReportViewer();
            rp.ProcessingMode = ProcessingMode.Local;
            rp.SizeToReportContent = true;
            // establecer origen de datos  - del reporte
            DaoDocente dao = new DaoDocente();
            DataSet ds = dao.informe();
            rp.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reportes\rptDocente.rdlc";
            rp.LocalReport.DataSources.Add(new ReportDataSource("dbCiber", ds.Tables["docente"]));

            //transportar modelo entre la vista
            ViewBag.ReporteViewer = rp;

            return View();
        }
        public ActionResult ReporteCurso()
        {
            ReportViewer rp = new ReportViewer();
            rp.ProcessingMode = ProcessingMode.Local;
            rp.SizeToReportContent = true;
            // establecer origen de datos  - del reporte
            DaoCurso dao = new DaoCurso();
            DataSet ds = dao.informe();
            rp.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reportes\rptCurso.rdlc";
            rp.LocalReport.DataSources.Add(new ReportDataSource("dbCiber", ds.Tables["curso"]));

            //transportar modelo entre la vista
            ViewBag.ReporteViewer = rp;

            return View();
        }
        public ActionResult ReporteCoordinador()
        {
            ReportViewer rp = new ReportViewer();
            rp.ProcessingMode = ProcessingMode.Local;
            rp.SizeToReportContent = true;
            // establecer origen de datos  - del reporte
            DaoCoordinador dao = new DaoCoordinador();
            DataSet ds = dao.informe();
            rp.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reportes\rptCoodinador.rdlc";
            rp.LocalReport.DataSources.Add(new ReportDataSource("dbCiber", ds.Tables["coodinador"]));

            //transportar modelo entre la vista
            ViewBag.ReporteViewer = rp;

            return View();
        }
    }
}