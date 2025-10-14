using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGMDFA.Controllers
{
    public class EmployeeController : Controller
    {
        MGMDFA.Models.safaldatabase2025Entities obj = new Models.safaldatabase2025Entities();
        // GET: Employee
        public ActionResult Index()
        {
            TempData["ie"]= obj.Employees.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(MGMDFA.Models.Employee employee)
        {
            obj.Employees.Add(employee);
            obj.SaveChanges();
            return RedirectToAction("Index","Employee");
        }

        public ActionResult Delete(int id)
        {
            MGMDFA.Models.Employee employee =obj.Employees.Find(id);
            obj.Employees.Remove(employee);
            obj.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }
    }
}