using Microsoft.AspNetCore.Mvc;

namespace DisplayStudent.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Student student)
        {
            ViewBag.Result = student.Sno + student.Sname + student.Sage;

            return View();
        }
    }
}
