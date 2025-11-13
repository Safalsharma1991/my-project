using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGMMVCSP.Controllers
{
    public class EmployeeController : Controller
    {
        EmpRepo.EmpRepo empRepo = new EmpRepo.EmpRepo();
        // GET: Employee
        public ActionResult Index()
        {
            List<Models.Employee> emps = empRepo.GetEmployee(new Models.Employee());
            TempData["emps"] = emps;
            TempData.Keep("emps");
            return View();
        }
    }
}