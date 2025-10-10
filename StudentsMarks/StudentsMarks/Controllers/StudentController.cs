using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMarks.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Student obj)
        {
            ViewBag.total = obj.Marks1 + obj.Marks2 + obj.Marks3;
            ViewBag.percentage = (obj.Marks1 + obj.Marks2 + obj.Marks3) / 3;
            ViewBag.grade = (ViewBag.percentage >= 60) ? "First" : (ViewBag.percentage >= 50) ? "Second" : (ViewBag.percentage >= 35) ? "Third" : "Fail";
            return View(obj);
        }
    }
}