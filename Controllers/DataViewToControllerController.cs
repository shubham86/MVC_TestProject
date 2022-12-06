using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;

namespace TestProject_MVC.Controllers
{
    public class DataViewToControllerController : Controller
    {
        // GET: DataViewToControlle
        [Route("viewToController")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string UsingParameter(int EmployeeNo, string EmployeeName)
        {
            return "Data from parameters - ID :" + EmployeeNo + ", Name : " + EmployeeName;
        }

        [HttpPost]
        public string UsingRequest()
        {
            return "Data from Request - ID :" + Request["EmployeeNo"] + ", Name : " + Request["EmployeeName"];
        }

        [HttpPost]
        public string UsingFormCollection(FormCollection form)
        {
            return "Data from FormCollection - ID :" + form["EmployeeNo"] + ", Name : " + form["EmployeeName"];
        }

        public string UsingStronglyBinding(Employee emp)
        {
            return "Data from Strongly Binding - ID :" + emp.EmployeeID + ", Name : " + emp.EmployeeName;
        }
    }
}