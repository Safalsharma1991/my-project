using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.EmpRepo
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmpRepo.Employee objempRepo = new Employee();
        public ActionResult Index()
        {
            TempData["empdb"]=objempRepo.getEmps();

       
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee emp)
        {
            objempRepo.SaveEmployee(emp);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Models.Employee emp)
        {
            objempRepo.DeleteEmployee(emp);
            return RedirectToAction("Index");
        }

    }
}