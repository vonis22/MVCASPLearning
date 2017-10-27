using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        public ActionResult Details(int id)
        {
            Employee x = db.Employees.Single(emp => emp.EmployeeId == id);

            return View(x);
        }
    }
}