using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Fam";
        }

        public ActionResult CountryList()
        {

            ViewBag.Countries = new List<string>()
            {
                "Nederland",
                "Belgïe",
                "Gasunie"
            };

            return View();
        }

    }
}