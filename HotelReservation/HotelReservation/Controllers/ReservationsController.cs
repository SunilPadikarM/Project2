using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class ReservationsController : Controller
    {
        private Reservation_Room db = new Reservation_Room();

        // GET: Reservations
        public ActionResult Index()
        {
            var reservations = db.Reservations.Include(r => r.Room);
            return View(reservations.ToList());
        }

        public ActionResult bookRoom(Room room)
        {
            return View("CreditCardController");
        }

        public ActionResult SearchRooms(Reservation reservation)
        {
            List<Room> rooms = db.Rooms.ToList();
            List<Reservation> reservations = null;
            //List<Reservation> result = new List<Reservation>();
            if (reservation.CheckInDate != null)
            {
                String date = reservation.CheckOutDate.Value.ToString("yyyy/MM/dd");
                String date1 = reservation.CheckInDate.Value.ToString("yyyy/MM/dd");

                DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime dateTime1 = DateTime.ParseExact(date1, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                //reservations = db.Reservations.Where(u => u.CheckInDate >= dateTime || u.CheckOutDate <= dateTime1 && u.RoomNumber == u.Room.RoomNumber).Distinct().ToList();

                reservations = db.Reservations.Where(u => u.CheckInDate <= dateTime1 || u.CheckOutDate >= dateTime).ToList();
                
                foreach(Reservation res in reservations)
                {
                    foreach(Room rm in rooms.ToList())
                    {
                        if(rm.RoomNumber == res.RoomNumber)
                        {
                            rooms.Remove(rm);
                        }
                    }
                }
                //db.Rooms.Find();
                /*   List<int> roomList = new List<int>();

                   int i = 0;
                   while (i < reservations.Count)
                   {
                       if (!roomList.Contains(reservations.ElementAt(i).RoomNumber))
                       {
                           result.Add(reservations.ElementAt(i));
                           roomList.Add(reservations.ElementAt(i).RoomNumber);

                       }
                       i++;
                   }*/
            }

            TempData["rooms"] = rooms;
            if (reservations != null)
            {
                return View(rooms);
            }
            return View(rooms);
        }
        // GET: Reservations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            ViewBag.RoomNumber = new SelectList(db.Rooms, "RoomNumber", "RoomType");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservationNumber,CheckInDate,CheckOutDate,NoOfGuests,NoOfRooms,ID,RoomNumber")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RoomNumber = new SelectList(db.Rooms, "RoomNumber", "RoomType", reservation.RoomNumber);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoomNumber = new SelectList(db.Rooms, "RoomNumber", "RoomType", reservation.RoomNumber);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservationNumber,CheckInDate,CheckOutDate,NoOfGuests,NoOfRooms,ID,RoomNumber")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoomNumber = new SelectList(db.Rooms, "RoomNumber", "RoomType", reservation.RoomNumber);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            db.Reservations.Remove(reservation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

