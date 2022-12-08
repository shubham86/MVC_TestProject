using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_MVC.Models;


namespace TestProject_MVC.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        [Route("validation")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }        

    }
}