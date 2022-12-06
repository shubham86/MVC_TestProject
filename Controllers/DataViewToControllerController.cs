using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return "Data from parameters - ID :" + Request["EmployeeNo"] + ", Name : " + Request["EmployeeName"];
        }
    }
}