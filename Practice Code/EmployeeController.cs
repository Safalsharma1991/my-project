using MGMMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGMMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        EmpRepo.EmpRepo empRepo = new EmpRepo.EmpRepo();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            empRepo.SaveEmployee(employee);
            return View();
        }
    }
}