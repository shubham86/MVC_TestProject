using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;


namespace TestProject_MVC.Controllers
{
    public class custValidationController : Controller
    {
        // GET: custValidation
        [Route("customeValidation")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult validate(Department dpt)
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