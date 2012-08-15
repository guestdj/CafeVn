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

            coffeeBags.Add(new CoffeeBag()
                               {
                                   Id = 1,
                                   Name = "VinaCafe", 
                                   Description = "Vinacafe is great coffee!",
                                   Price = 4.99, 
                               });
            coffeeBags.Add(new CoffeeBag()
                               {
                                   Id = 2, 
                                   Name = "G7", 
                                   Description = "G7 is also very good - not as sweet",
                                   Price = 3.99
                               });

            return View(coffeeBags);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
