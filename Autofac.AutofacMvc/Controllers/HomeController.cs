using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.AutofacMvc.Dependencies;

namespace Autofac.AutofacMvc.Controllers
{
    public class HomeController : Controller
    {
        public IWebConfiguration InjectedConfiguration { get; set; }
        public HomeController(IWebConfiguration injectedConfiguration)
        {
            InjectedConfiguration = injectedConfiguration;
        }
         
        public ActionResult Index()
        {
            ViewBag.Message = $"The Webserver is in {InjectedConfiguration.WebServer}";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = $"The Webserver is in {InjectedConfiguration.WebServer}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}