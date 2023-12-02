using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Same name
        public ActionResult Index()
        {
            ViewBag.name = "Show you home Page";
            return View();
        }
        public ActionResult show()
        {
            return View();
        }
        // Different name
        public ActionResult showInfo()
        {
            return View("show");
        }
        // In share Folder
        public ActionResult Detail()
        {
            return View("Details");
        }
        // different control
        public ActionResult showMoreDetail()
        {
            return View("~/views/about/Index.cshtml");
        }

    }
}