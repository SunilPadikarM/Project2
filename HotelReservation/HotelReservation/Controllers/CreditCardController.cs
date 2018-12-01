using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreditCardDetails.Models;
using HotelReservation.Models;
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
            Room room = new Room();
            if (Request.Params.Get("RoomNumber") != null) { 
            
            room.RoomNumber = int.Parse(Request.Params.Get("RoomNumber"));
            room.RoomType = Request.Params.Get("RoomType");
            room.Price = int.Parse(Request.Params.Get("Price"));
            }
            return View(room);
        }


        public ActionResult PayAndBook(CardDetails credit)
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