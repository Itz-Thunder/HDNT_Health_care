using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Website.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: Equipment
        public ActionResult Equipmentcatalog()
        {
            return View();
        }
        public ActionResult Searchandfilter()
        {
            return View();
        }
        public ActionResult Productpage()
        {
            return View();
        }

        public ActionResult Shoppingcart()
        {
            return View();
        }
        public ActionResult Checkoutandpayment()
        {
            return View();
        }
        public ActionResult Useraccount()
        {
            return View();
        }
        public ActionResult Ordertracking()
        {
            return View();
        }
        public ActionResult Customersupport() // call the page from customer support from home view...
        {
            return View();
        }
        public ActionResult Ratingandreview()
        {
            return View();
        }
        public ActionResult Deliveryandshipping()
        {
            return View();
        }
        public ActionResult Equipmentrental()
        {
            return View();
        }
        public ActionResult Warrantyandreturns() // only for hospital to see others cannot see this and after buying only the buyers can see for hospitals the table and for buyers the contact info of the hospitals.
        {
            return View();
        }
        public ActionResult Bulkordering() // embedded into the rental page 
        {
            return View();
        }
        public ActionResult Customizationoptions() // embedded into the rental page
        {
            return View();
        }
    }
}