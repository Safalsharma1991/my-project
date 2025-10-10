using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee emp)
        {
            ViewBag.da = 0.2 * emp.Esal;
            ViewBag.hra = 0.1 * emp.Esal;
            ViewBag.gross = emp.Esal + ViewBag.da + ViewBag.hra;

            return View();
        }
    }
}