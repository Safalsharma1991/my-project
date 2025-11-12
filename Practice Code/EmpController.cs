using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDemo.Controllers
{
    public class EmpController : Controller
    {
        EmpRepo.EmpRepo empRepo = new EmpRepo.EmpRepo();
        // GET: Emp
        public ActionResult Index()
        {
            List<Models.Employee> emp = empRepo.GetEmployees();
            ViewBag.EmployeeList = emp;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee employee)
        {
            int i = empRepo.SaveEmployee(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            int i = empRepo.DeleteEmployee(id);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Models.Employee employee = new Models.Employee();
            employee.Eno = id;
            Models.Employee em = empRepo.SearchEmployee(employee);

            return View("Index",em);
        }

    }
}