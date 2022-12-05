using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;

namespace TestProject_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {            
            //fill employee model
            Employee employee = new Employee();
            employee.EmployeeID = 3634;
            employee.EmployeeName = "Shubham Dhomse";
            employee.EmployeeAddress = "Nashik";
            employee.isActive = true;

            return View(employee);
        }

        //Post method   
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }


        [Route("about")]       
        public ActionResult About(string name = null)
        {
            return View();
        }
    }
}