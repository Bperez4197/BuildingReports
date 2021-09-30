using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildingReports.Models;

namespace BuildingReports.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            ReportModel model = new ReportModel();
            model.PopulateReport();
            return View(model);
        }
    }
}