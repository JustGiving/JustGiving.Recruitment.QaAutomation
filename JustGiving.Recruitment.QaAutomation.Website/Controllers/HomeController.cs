using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustGiving.Recruitment.QaAutomation.Website.Models;

namespace JustGiving.Recruitment.QaAutomation.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            
            
            return View(new AboutViewModel());
        }

        [HttpPost]
        public ActionResult About(AboutViewModel model)
        {
            return RedirectToAction("AnnounceListSelection", model);
        }

        [HttpGet]
        public ActionResult AnnounceListSelection(AboutViewModel model)
        {
            return View(model);
        }
    }
}
