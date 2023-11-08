using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;
using Microsoft.AspNet.Identity;

namespace Restaurant.Controllers
{
    public class ReservationsController : Controller
    {
        private FoodDB db = new FoodDB();

        // GET: Reservations
        [Authorize]
        public ActionResult Index()
        {
            var usr_curr = User.Identity.GetUserId();
            var reservations = db.Reservations.Include(r => r.Table).Include(r => r.userr).Where(r=>r.userr.usr==usr_curr);          
            return View(reservations.ToList());
        }

        public ActionResult List()
        {
            var reservations = db.Reservations.Include(r => r.Table).Include(r => r.userr);
            return View(reservations.ToList());
        }



        // GET: Reservations/Details/5
        [Authorize]
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
        [Authorize]
        public ActionResult Create()
        {
            Reservation reservation = new Reservation();
            var usrn = User.Identity.GetUserName();

            Userr userr = new Userr() { UserrId = reservation.ReservationId, usr = User.Identity.GetUserId(), usrnm = usrn };

            reservation.userr = userr;
            reservation.NumberOfPerson = 1;
            reservation.DateTime = DateTime.Today;

            return View(reservation);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservationId, DateTime, Time, TableId, TableNumber, NumberOfPerson, userr")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TableId = new SelectList(db.Tables, "TableId", "TableNumber", reservation.TableId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            ViewBag.TableId = new SelectList(db.Tables, "TableId", "TableNumber", reservation.TableId);

            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservationId,DateTime, Time, TableId, TableNumber")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TableId = new SelectList(db.Tables, "TableId", "TableNumber", reservation.TableId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        [Authorize]
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
