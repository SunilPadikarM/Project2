using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class CustomerAccountController : Controller
    {
        // GET: CustomerAccount
        public ActionResult Index()
        {
            using (CustomerData db = new CustomerData())
            {
                return View(db.customeraccount.ToList());
            }
                
        }

        public ActionResult Singup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Singup(CustomerAccount cusAccount)
        {
            if (ModelState.IsValid)
            {
                using (CustomerData db = new CustomerData())
                {
                    db.customeraccount.Add(cusAccount);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = cusAccount.FirstName + " " + cusAccount.LastName + " Successfully Registered";
            }
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(CustomerAccount cusAccount)
        {
            using(CustomerData db = new CustomerData())
            {
                try { 
                var usr = db.customeraccount.FirstOrDefault(u => u.Email == cusAccount.Email && u.Password == cusAccount.Password);
                if(null != usr)
                {
                    Session["UserId"] = usr.ID.ToString();
                    Session["User Name"] = usr.FirstName + " " + usr.LastName;
                    return RedirectToAction("../Reservations/SearchRooms");
                }
                else
                {
                    ModelState.AddModelError("", "User Name or Password is wrong!");
                }
                } catch(Exception ex)
                {
                    ModelState.AddModelError("", "User Name or Password is wrong!");
                    throw ex;
                    
                }
                return View();
            }
        }

        public ActionResult LoggedIn()
        {
            if(Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOff()
        {
            if (Session["UserId"] != null)
            {
                Session.Clear();
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //for displaying the booking list....
        public ActionResult BookingList(){

           

                return View();
            
        }

    }
}