using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CafeVN.Models;

namespace CafeVN.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IList<CoffeeBag> coffeeBags = new List<CoffeeBag>();

            coffeeBags.Add(new CoffeeBag() {Id = 1, Name = "VinaCafe", Price = 4.99, Quantity = 20});
            coffeeBags.Add(new CoffeeBag(){Id = 2, Name = "Andy's Coffee", Price = 5.99, Quantity = 15});

            return View(coffeeBags);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
