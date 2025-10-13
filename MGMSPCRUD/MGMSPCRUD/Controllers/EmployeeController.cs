using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace MGMSPCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        MGMSPCRUD.EmpRepo.Employee empRepo = new EmpRepo.Employee();
        // GET: Employee
        public ActionResult Index()
        {
            TempData["emps"] = empRepo.GetEmployees();
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee emp, String b1)
        {
            if(b1=="Save")
            {
                empRepo.SaveEmployee(emp);
            }
           else if(b1=="Update")
            {
                empRepo.UpdateEmployee(emp);
            }
                return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(Models.Employee emp)
        {
            empRepo.DeleteEmployee(emp);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
           Models.Employee emp =  empRepo.SearchEmployee(id);
            return View("Index",emp);
        }
    }
}