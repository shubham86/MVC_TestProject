using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace TestProject_MVC.Controllers
{
    public class customeValidationController : Controller
    {
        // GET: customeValidation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult validation(Department dpt)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View("Index");
        }
    }    
}