using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home  
        public ActionResult Index()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        [AllowAnonymous]  
        public ActionResult SubmitEmp(Employee emp)
        {
            TempData["Emp"] = emp;

            if (ModelState.IsValid)
            {
                return Redirect("/Home/EmpDetails");

            }
            Console.Write("Errorrrrrrr");
            return View(emp);

        }

        public ActionResult EmpDetails()
        {
            Employee emp = TempData["Emp"] as Employee;
           return View(emp);
        }
    }
}