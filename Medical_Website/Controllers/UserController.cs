using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Website.Controllers
{
    public class UserController : Controller
    {      
       
            // GET: User
            public ActionResult Accountsandprofile()
            {
                return View();
            }
            public ActionResult Userforumsandcommunity()
            {
                return View();
            }
            public ActionResult Appointmentsheduling()
            {
                return View();
            }
            public ActionResult Message()
            {
                return View();
            }
            public ActionResult Healthrecord()
            {
                return View();
            }
        public ActionResult Search() // this contains the search option to search doctors and hospitals using each other... 
        {
            return View();
        }
        public ActionResult Logout()
            {
                return View();
            }
            public ActionResult Changepassword()
            {
                return View();
            }
        }
    }