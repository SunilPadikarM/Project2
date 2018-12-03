using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "WELCOME TO DAN'S HAPPY HOTEL";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact us here";

            return View();
        }
    }
}