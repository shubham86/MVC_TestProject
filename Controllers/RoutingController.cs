using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;

namespace TestProject_MVC.Controllers
{
    [RoutePrefix("employees")]
    public class RoutingController : Controller
    {
        [Route("")]
        public ActionResult getAllEmployee()
        {
            var emp = employees();
            return View(emp);
        }

        [Route("{id:int:min(0)}")]
        public ActionResult getEmployee(int id)
        {
            var emp = employees().FirstOrDefault(x => x.EmployeeID == id);
            return View(emp);
        }

        [Route("{id:int}/dpt")]
        public ActionResult getEmployeeDepartment(int id)
        {           
            var empDepartment = employees().Where(x => x.EmployeeID == id).Select(x => x.Department).FirstOrDefault();
            
            //another way to write LINQ query - also used for DataTables
            var dpt = from emp in employees() where emp.EmployeeID == id select emp.Department; 
            return View(empDepartment);
        }

        [Route("~/about-us")]
        public string AboutUs()
        {            
            return "This is About Us page.";
        }

        public List<Employee> employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeID = 3634,
                    EmployeeName = "Shubham",
                    EmployeeAddress = "Kharadi",
                    isActive = true,
                    Department = new Department()
                    {
                        DepartmentID = 1,
                        DepartmentName = "R & D"
                    }
                },
                new Employee()
                {
                    EmployeeID = 3635,
                    EmployeeName = "Akash",
                    EmployeeAddress = "Baner",
                    Department = new Department()
                    {
                        DepartmentID = 2,
                        DepartmentName = "Sales"
                    }
                },
                new Employee()
                {
                    EmployeeID = 3636,
                    EmployeeName = "Saurabh",
                    EmployeeAddress = "Hadapsar",
                    Department = new Department()
                    {
                        DepartmentID = 3,
                        DepartmentName = "Account"
                    }
                }
            };
        }
    }
}