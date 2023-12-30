using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Website.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Appointmentmanag()
        {
            return View();
        }
        public ActionResult Patientsrecord()
        {
            return View();
        }
        public ActionResult Prescriptionmanag()
        {
            return View();
        }
        public ActionResult Communicationtools()
        {
            return View();
        }
        public ActionResult Healthrecordint()
        {
            return View();
        }

        public ActionResult Notification()
        {
            return View();
        }
        public ActionResult Profilemanag()
        {
            return View();
        }
        public ActionResult Supportandhelpcenter()  // customer care page from Home view
        { 
            return View();
        }
        public ActionResult Discussionforumsandcommunity()
        {
            return View();
        }
        public ActionResult logout()
        {
            return View();
        }
        public ActionResult Changepassword()
        {
            return View();
        }
    }
}