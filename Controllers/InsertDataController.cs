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
        EmployeeRepository employeeRepository = null;
        public InsertDataController()
        { 
            employeeRepository = new EmployeeRepository();
        }
                
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
                    ViewBag.IsSuccess = "Data Added Emp ID : " + id;

                    return RedirectToAction("getAllEmployees");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult getAllEmployees()
        {
            var result = employeeRepository.getAllEmployee();
            return View(result);
        }

        [HttpGet]
        public ActionResult getEmployeeDetail(int id)
        {
            var result = employeeRepository.getEmployee(id);
            return View(result);
        }


        [HttpGet]
        public ActionResult editEmployee(int id)
        {
            var result = employeeRepository.getEmployee(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult editEmployee(EmploayeeModel model)
        {
            if (ModelState.IsValid)
            {
                bool isEdit = employeeRepository.UpdateEmployee(model.employeeID, model);

                if (isEdit)
                {
                    return RedirectToAction("getAllEmployees");
                }
            }
            return View();
        }

        public ActionResult deleteEmployee(int id)
        {
            bool isDelete = employeeRepository.RemoveEmployee(id);

            if (isDelete)
            {
                return RedirectToAction("getAllEmployees");
            }

            return View();
        }
    }
}