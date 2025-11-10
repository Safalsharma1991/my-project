using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCapp.Controllers
{
    public class MyGoMindsController : Controller
    {
        // GET: MyGoMinds
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}