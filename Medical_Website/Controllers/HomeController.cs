using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MedicalEncy()
        { // it contains the category section along with the icnos
            return View();
        }

        public ActionResult Emergencies()
        {
            return View();
        }
        public ActionResult Healthtools()
        {
            return View();
        }
        public ActionResult Vaccinationinfo()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Register()
            //should be in pop up window both register and login
        {
            return View();
        }
        public ActionResult Login()
            // in the preloaded pop up window at login page 
        {
            return View();
        }
    }
}