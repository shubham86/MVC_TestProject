using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;

namespace TestProject_MVC.Controllers
{
    public class ViewBagViewDataController : Controller
    {
        // GET: ViewBagViewData
        public ActionResult Index()
        {
            //ViewBag
            ViewBag.Name = "Shubham Dhomse";
            ViewBag.Mylist = new List<string>() { "a", "b", "c", "d" };

            List<Employee> empList = new List<Employee>()
            {
                new Employee(){ EmployeeID = 3634 , EmployeeName = "Shubham", EmployeeAddress = "Kharadi"},
                new Employee(){ EmployeeID = 3631 , EmployeeName = "Sahil", EmployeeAddress = "Kharadi"},
                new Employee(){ EmployeeID = 3514 , EmployeeName = "Prasad", EmployeeAddress = "Hadapsar"}
            };

            ViewBag.EmployeeList = empList;

            //ViewData
            ViewData["Name"] = "Dhomse Shubham";
            ViewData["Mylist"] = new List<string>() { "l", "m", "n", "o" };
            //ViewBag["EmployeeList"] = empList; //not working


            //TempData
            TempData["mobileNo"] = "8369791005";
            

            return View();
        }

        public ActionResult SecondCall()
        {
            //ViewBag.MobileNo = TempData["mobileNo"]; //this line only read tempdata

            //TempData.Keep(); // It store all temp data

            //TempData.Keep("mobileNo"); //// It store spesific key data

            ViewBag.MobileNo = TempData.Peek("mobileNo"); // this read aswel as keep the data

            return View();
        }

        public ActionResult ThirdCall()
        {
            ViewBag.MobileNo = TempData["mobileNo"];
            return View();
        }
    }
}