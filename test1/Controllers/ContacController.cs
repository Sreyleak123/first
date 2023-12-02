using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Content
{
    public class ContacController : Controller
    {
        // GET: Contac
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mycontac()
        {
            return View();
        }
        public int add()
        {
            int a = 4;
            int b = 5;
            int s=a+b;
            return s;
        }

    }
}