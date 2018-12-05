using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreditCardDetails.Models;
namespace CreditCardDetails.Controllers
{
    public class CreditCardController : Controller
    {
        // GET: CreditCard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreditCardInformation()
        {
            return View();
        }

       /* public string CheckRadio(FormCollection f)
        {
            string card = f["CardType"].ToString();
            
        }*/

  
        
      /*  [HttpPost]
        public ActionResult CreditCardInformation(CardDetails cardDetails)
        {
            if (ModelState.IsValid)
            {
               
            }

            return View();
        }
        */
    }
}