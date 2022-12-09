using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject_MVC.Controllers
{
    public class renderPageController : Controller
    {
        // GET: renderPage
        public ActionResult Index()
        {
            return View();
        }

    }
}