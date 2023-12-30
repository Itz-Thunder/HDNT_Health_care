using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical_Website.Controllers
{
    public class MedicalshopController : Controller
    {     
         
            // GET: Medicalshop
            public ActionResult Medicalcatalog()
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
            public ActionResult Prescripionuploading() // from the doctor's module
            {
                return View();
            }
            public ActionResult Shoppingcart()
            {
                return View();
            }
            public ActionResult Checkoutandpayment() // same as of equipment shop
            {
                return View();
            }
            public ActionResult Useraccounts() // from user module -> user account
            {
                return View();
            }
            public ActionResult Ordertracking() // same as of equipment shop
            {
                return View();
            }
            public ActionResult Customersupport() // same as product page 
            {
                return View();
            }
            public ActionResult Medicineinfo() // somehow used to upload the details of the medicines from the merchant end 
            {
                return View();
            }
            public ActionResult Deliveryandshipping() // same as of equipment shop module
            {
                return View();
            }
            public ActionResult Medicinereview() 
            {
                return View();
            }
        }
    }