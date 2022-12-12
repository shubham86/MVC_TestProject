using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_MVC.Model;
using Test_MVC.db.dbOperations;

namespace TestProject_MVC.Controllers
{
    public class InsertDataController : Controller
    {
        public InsertDataController()
        { 
            
        }


        EmployeeRepository employeeRepository = new EmployeeRepository();
        public ActionResult addEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addEmployee(EmploayeeModel model)
        {
            if (ModelState.IsValid)
            {
                int id = employeeRepository.AddEmployee(model);
                if (id > 0)
                {
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}