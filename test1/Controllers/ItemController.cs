using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {

            ViewBag.shopName = "Computer shop";
            List<Itemlist> itemlist = new List<Itemlist>() {
                new Itemlist{Id="001", Name="Acer",price=500 ,Category="Laptop"},
                new Itemlist{Id="002", Name="Mac",price=1500 ,Category="Laptop"},
                new Itemlist{Id="003", Name="Asus",price=600 ,Category="Laptop"},
                new Itemlist{Id="004", Name="dell",price=580 ,Category="Laptop"}

            };
            itemlist.Add(new Itemlist { Id = "005", Name = "MSI", price = 900, Category = "Laptop" });

            return View(itemlist);
        }
    }
}